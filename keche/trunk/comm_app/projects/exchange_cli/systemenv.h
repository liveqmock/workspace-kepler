/**********************************************
 * systemenv.h
 *
 *  Created on: 2011-07-24
 *      Author: humingqing
 *       Email: qshuihu@gmail.com
 *    Comments: ���������࣬��Ҫ������Ҫ�����Ķ��󣬶�������󽻻�֮����н磬
 *    �������κ���������֮��Ľ���������ͨ���������������ʵ��ֱ�ӽ�����ʹ������֮��͸������
 *    Ҳʹ�ýṹ������������ÿһ������ʵ�֣�������ʵ��Init Start Stop����������Ҫʵ��ϵͳ
 *    ֮���ͳһ�淶��������
 *********************************************/
#ifndef __SYSTEMENV_H__
#define __SYSTEMENV_H__

#include "interface.h"

class CCConfig ;
class CSystemEnv : public ISystemEnv
{
public:
	CSystemEnv() ;
	~CSystemEnv() ;

	// ��ʼ��ϵͳ
	bool Init( const char *file , const char *logpath , const char *userfile  , const char *logname ) ;

	// ��ʼϵͳ
	bool Start( void ) ;

	// ֹͣϵͳ
	void Stop( void ) ;

	// ȡ������ֵ
	bool GetInteger( const char *key , int &value ) ;
	// ȡ���ַ���ֵ
	bool GetString( const char *key , char *value ) ;
	// ȡ���û�����λ��
	const char * GetUserPath( void )  { return _user_file_path.c_str(); }
	// ȡ��MSG�����ݶ���
	IMsgClient *  GetMsgClient( void )  { return _msgclient; }
	//
	IExchClient *  GetExchClient( void )  { return _exchclient; }
	//
	IProtParse * GetProtParse(void) { return _protparse;}
	// ȡ��RedisCache
	IRedisCache * GetRedisCache( void ) { return _rediscache; }
private:
	// ��ʼ����־ϵͳ
	bool InitLog( const char *logpath , const char *logname ) ;

private:
	// �����ļ���
	CCConfig		  *_config ;
	// �û��ļ�·��
	std::string 	   _user_file_path ;
	// �Ƿ��ʼ��
	bool 			   _initialed ;
	//
	IAmqClient        *_amqclient;
	// MSGClient����
	IMsgClient 		  *_msgclient;
	//
	IExchClient       *_exchclient;
	//
	IProtParse        *_protparse;
	//
	IRedisCache       *_rediscache;
};

#endif