package com.alipay.dw.jstorm.example.sequence.bolt;

import java.util.Map;
import java.util.concurrent.atomic.AtomicLong;

import backtype.storm.task.TopologyContext;
import backtype.storm.topology.BasicOutputCollector;
import backtype.storm.topology.IBasicBolt;
import backtype.storm.topology.OutputFieldsDeclarer;
import backtype.storm.tuple.Fields;
import backtype.storm.tuple.Tuple;
import backtype.storm.tuple.Values;

import com.alipay.dw.jstorm.example.TpsCounter;
import com.alipay.dw.jstorm.example.sequence.bean.Pair;


public class PairCount implements IBasicBolt {
	/**
     * 
     */
    private static final long serialVersionUID = 7346295981904929419L;


	private AtomicLong  sum = new AtomicLong(0);
	
	private TpsCounter          tpsCounter;

	@SuppressWarnings("rawtypes")
	public void prepare(Map conf, TopologyContext context) {
	    tpsCounter = new TpsCounter(context.getThisComponentId() + 
                ":" + context.getThisTaskId());
		
	    System.err.println("Successfully do parepare " + context.getThisComponentId());
	}

	public void execute(Tuple tuple, BasicOutputCollector collector) {
	    tpsCounter.count();
	    
		Long tupleId = tuple.getLong(0);
		Pair pair = (Pair)tuple.getValue(1);
        
        sum.addAndGet(pair.getValue());
        
        collector.emit(new Values(tupleId, pair));

	}

	public void cleanup() {
	    tpsCounter.cleanup();
	    System.err.println("Total receive value :" + sum);
	}

	public void declareOutputFields(OutputFieldsDeclarer declarer) {
		declarer.declare(new Fields("ID", "PAIR"));
	}

	public Map<String, Object> getComponentConfiguration() {
	    return null;
	}
}