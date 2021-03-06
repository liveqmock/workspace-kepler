package com.caits.analysisserver.quartz.state.jobs;


import java.util.Date;

import org.quartz.JobExecutionContext;
import org.quartz.JobExecutionException;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import com.caits.analysisserver.quartz.MyJob;
import com.caits.analysisserver.quartz.state.jobs.impl.StatStateDaysJobdetail;
import com.caits.analysisserver.utils.CDate;

/**
 * 告警按企业告警类别日统计
 * 运行频率：每日5点00分
 * @author yujch
 */
public class StatStateDaysJob extends MyJob {

	@SuppressWarnings("unused")
	private static Logger logger = LoggerFactory.getLogger(StatStateDaysJob.class);
	
	private String jobName = "StatStateDaysJob";
	
	@Override
	public String getJobName() {
		// TODO Auto-generated method stub
		return this.jobName;
	}
	
/*	@Override
	public int executePrev() {
		// TODO Auto-generated method stub
		return JobMonitor.getInstance().queryJobDependStatus("OrgAlarmDaystatJob");
	}*/

	/*
	 * 每日统计前一日数据
	 * 
	 * @see org.quartz.Job#execute(org.quartz.JobExecutionContext)
	 */
	@Override
	public int executeJob(JobExecutionContext arg0) throws JobExecutionException {
		// TODO Auto-generated method stub
		long yesterdayNoon = CDate.getYesDayYearMonthDay()+1000*60*60*12;//昨天中午日期时间
		Date dt = new Date();
		dt.setTime(yesterdayNoon);
		
		StatStateDaysJobdetail vodJobDetail = new StatStateDaysJobdetail(dt);
		
		return vodJobDetail.executeStatRecorder();
	}

	
/*
	@Override
	public int executeEnd(int execFlag) {
		// TODO Auto-generated method stub
		return JobMonitor.getInstance().updateJobRunningMonitor("OrgAlarmDaystatJob", ""+execFlag, new Date());
	}*/
}


