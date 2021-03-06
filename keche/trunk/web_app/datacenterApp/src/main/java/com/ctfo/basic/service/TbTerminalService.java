package com.ctfo.basic.service;

import com.ctfo.basic.beans.TbTerminal;
import com.ctfo.basic.beans.TbTerminalOem;
import com.ctfo.basic.beans.TbTerminalProtocol;
import com.ctfo.common.local.exception.CtfoAppException;
import com.ctfo.common.local.obj.DynamicSqlParameter;
import com.ctfo.common.local.obj.PaginationResult;

/**
 * 
 * 
 * <p>
 * -----------------------------------------------------------------------------<br>
 * 工程名 ： datacenterApp<br>
 * 功能：终端<br>
 * 描述：终端<br>
 * 授权 : (C) Copyright (c) 2011<br>
 * 公司 : 北京中交慧联信息科技有限公司<br>
 * -----------------------------------------------------------------------------<br>
 * 修改历史<br>
 * <table width="432" border="1">
 * <tr>
 * <td>版本</td>
 * <td>时间</td>
 * <td>作者</td>
 * <td>改变</td>
 * </tr>
 * <tr>
 * <td>1.0</td>
 * <td>2014年5月28日</td>
 * <td>JiTuo</td>
 * <td>创建</td>
 * </tr>
 * </table>
 * <br>
 * <font color="#FF0000">注意: 本内容仅限于[北京中交慧联信息科技有限公司]内部使用，禁止转发</font><br>
 * 
 * @version 1.0
 * 
 * @author JiTuo
 * @since JDK1.6
 */
public interface TbTerminalService {

	/**
	 * 查询终端分页信息
	 * 
	 * @param param
	 * @return
	 * @throws CtfoAppException
	 */
	public PaginationResult<TbTerminal> findTerminalByParamPage(DynamicSqlParameter param) throws CtfoAppException;

	/**
	 * 查询终端厂家list
	 * 
	 * @param param
	 * @return
	 * @throws CtfoAppException
	 */
	public PaginationResult<TbTerminalOem> findOemNames(DynamicSqlParameter param) throws CtfoAppException;

	/**
	 * 查询终端协议名称list
	 * 
	 * @param param
	 * @return
	 * @throws CtfoAppException
	 */
	public PaginationResult<TbTerminalProtocol> findProtocolNames(DynamicSqlParameter param) throws CtfoAppException;
}
