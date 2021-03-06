package com.caits.analysisserver.quartz.service.jobs.impl;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.SQLException;
import java.sql.Types;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import com.caits.analysisserver.database.OracleConnectionPool;
import com.caits.analysisserver.database.SQLPool;
import com.caits.analysisserver.utils.CDate;

/**
 * 
 * <p>
 * -----------------------------------------------------------------------------
 * <br>
 * 工程名 ： StatisticAnalysisServer <br>
 * 功能： <br>
 * 描述： <br>
 * 授权 : (C) Copyright (c) 2011 <br>
 * 公司 : 北京中交兴路信息科技有限公司 <br>
 * -----------------------------------------------------------------------------
 * <br>
 * 修改历史 <br>
 * <table width="432" border="1">
 * <tr>
 * <td>版本</td>
 * <td>时间</td>
 * <td>作者</td>
 * <td>改变</td>
 * </tr>
 * <tr>
 * <td>1.0</td>
 * <td>2013-01-16</td>
 * <td>yujch</td>
 * <td>创建</td>
 * </tr>
 * </table>
 * <br>
 * <font color="#FF0000>注意: 本内容仅限于[北京中交兴路信息科技有限公司]内部使用，禁止转发</font> <br>
 * 
 * @version 1.0
 * 
 * @author yujch
 * @since JDK1.6
 */
public class StatMobileClientMonthsJobdetail {

	private static final Logger logger = LoggerFactory
			.getLogger(StatMobileClientMonthsJobdetail.class);

	// ------获得xml拼接的Sql语句
	private String statMobileClientMonthsStatSql;// 访问记录按小时分析

//	private int count = 0;// 计数器

//	private long statDate;
	private long beginTime;
	private long endTime;
	
	private int year;
	private int month;

	/**
	 * 初始化统计周期：传入日期
	 * 
	 * @param statDate
	 *            当日12点日期时间
	 */
	public StatMobileClientMonthsJobdetail(int year,int month) {
		this.year = year;
		this.month = month;
		this.beginTime = CDate.getFirstDayOfMonth(year,month).getTime();//当月第一天零点
		this.endTime = CDate.getDateFromParam(CDate.getFirstDayOfMonth(year,month),0,1,1,0,0,0,0).getTime();//下月第一天零点

		this.initAnalyser();
	}

	// 初始化方法
	public void initAnalyser() {
		// 企业按告警类别统计
		statMobileClientMonthsStatSql = SQLPool.getinstance().getSql(
				"sql_procStatMobileClientMonths");
	}

	/**
	 * 手机客户端引用月数据生成
	 * 
	 * @param
	 * @return int 0:执行失败, 1执行成功
	 */
	public int executeStatRecorder() {
		CallableStatement dbPstmt0 = null;
		Connection dbConnection = null;

		// 成功标志位 0:执行失败, >=1执行成功,成功解析个数
		int flag = 0;
		try {
			// 获得Connection对象
			dbConnection = OracleConnectionPool.getConnection();
			if (dbConnection != null) {

				// 按企业告警级别统计
				dbPstmt0 = dbConnection.prepareCall(statMobileClientMonthsStatSql);
				dbPstmt0.setLong(1, beginTime);
				dbPstmt0.setLong(2, endTime);
				dbPstmt0.registerOutParameter(3, Types.INTEGER);
				dbPstmt0.execute();

				int successtag = dbPstmt0.getInt(3);
				
				if (successtag == 1) {
					logger.debug(year+"/"+month + " 手机客户端引用月数据分析成功！");
				}else{
					logger.error(year+"/"+month + " 手机客户端引用月数据分析出错！错误码："+successtag);
				}

				flag = 1;
			} else {
				logger.debug("获取数据库链接失败");
			}
		} catch (Exception e) {
			logger.error("手机客户端引用月数据分析出错：", e);
			flag = 0;
		} finally {
			try {
				if (dbPstmt0 != null) {
					dbPstmt0.close();
				}
				if (dbConnection != null) {
					dbConnection.close();
				}
			} catch (SQLException e) {
				logger.error("连接放回连接池出错.", e);
			}
		}
		return flag;
	}

	/**
	 * 将空值转换为空字符串
	 * 
	 * @param str
	 *            字符串
	 * @return String 返回处理后的字符串
	 */
	public static String nullToStr(String str) {
		return str == null || str.equals("null") ? "" : str.trim();
	}

}
