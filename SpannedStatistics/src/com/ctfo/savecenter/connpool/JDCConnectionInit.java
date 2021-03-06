package com.ctfo.savecenter.connpool;

import java.sql.SQLException;

import com.lingtu.xmlconf.XmlConf;

public class JDCConnectionInit {
	XmlConf config;
	public JDCConnectionInit(XmlConf config){
		this.config=config;
	}

	public  void init() throws ClassNotFoundException,
			InstantiationException, IllegalAccessException, SQLException {

		//String oracledbDriver = config.getStringValue("database|JDBCDriver");// mysql数据库驱动
		String oracledbConString = config.getStringValue("database|JDBCUrl");// mysql数据库连接字
		String oracledbUserName = config.getStringValue("database|JDBCUser");// mysql数据库用户名
		String oracledbPassword = config
				.getStringValue("database|JDBCPassword");// mysql数据库密码
		
		int timeout = config.getIntValue("database|DBReconnectWait");// 设置连接超时时间
		int maxLimit = config.getIntValue("database|connectionPoolSize");// 连接池中至多能建立的连接对象数目，即连接池的上限
		int minLimit = config.getIntValue("database|minLimit");// 连接池中最小连接数
		int InitialLimit = config.getIntValue("database|InitialLimit");// 连接池中初始化连接数
		
		String abandonedConnectionTimeout = config.getStringValue("database|abandonedConnectionTimeout");
		String propertyCheckInterval = config.getStringValue("database|propertyCheckInterval");
		String inactivityTimeout= config.getStringValue("database|inactivityTimeout");
		
		// 初始ORACLE连接池
		OracleConnectionPool.initConnection(oracledbConString, oracledbUserName, oracledbPassword, minLimit + "", maxLimit + "", InitialLimit + "", timeout + "",inactivityTimeout,abandonedConnectionTimeout,propertyCheckInterval);

		
	}

}
