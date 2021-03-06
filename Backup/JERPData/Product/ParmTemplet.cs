/*
$Header$
$Author$
$Date$
$Revision$
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections.Generic;
using Microsoft.ApplicationBlocks.Data;
namespace JERPData.Product
{
    /// <描述>
    /// 表[prd.ParmTemplet]数据访问类
    ///</描述> 
    ///<作者> 
    /// 金优富
    ///</作者> 
    ///<时间> 
    /// 2014/3/3 17:30:18
    ///</时间>  
    public class ParmTemplet
    {
        private SqlConnection sqlConn;
        public ParmTemplet()
        {
            this.sqlConn = DBConnection.JSqlDBConn;
        }


        public bool DeleteParmTemplet(ref string ErrorMsg, object TempletID)
        {
            bool flag = false;
            ErrorMsg = string.Empty;
            SqlParameter[] arParams = new SqlParameter[1];
            arParams[0] = new SqlParameter("@TempletID", SqlDbType.Int);
            arParams[0].Value = TempletID;
            SqlTransaction DBTransaction = null;
            try
            {
                if (this.sqlConn.State == System.Data.ConnectionState.Closed) this.sqlConn.Open();
                DBTransaction = this.sqlConn.BeginTransaction();
                SqlHelper.ExecuteNonQuery(DBTransaction, CommandType.StoredProcedure, "prd.DeleteParmTemplet", arParams);
                DBTransaction.Commit();
                flag = true;
            }
            catch (SqlException ex)
            {
                ErrorMsg = ex.Message; //返回错误信息
                flag = false;
                DBTransaction.Rollback();//--回退事务
            }
            finally
            {
                this.sqlConn.Close();
            }
            return flag;
        }
        public DataSet GetDataParmTemplet()
        {
            DataSet ds = null;
            try
            {
                if (this.sqlConn.State == System.Data.ConnectionState.Closed) this.sqlConn.Open();
                ds = SqlHelper.ExecuteDataset(sqlConn, "prd.GetDataParmTemplet");
            }
            catch//(SqlException ex)
            {
                // ex.Message --这里作调试用
            }
            finally
            {
                this.sqlConn.Close();
            }
            return ds;
        }
        public bool InsertParmTemplet(ref string ErrorMsg, ref object TempletID, object TempletName)
        {
            bool flag = false;
            ErrorMsg = string.Empty;
            SqlParameter[] arParams = new SqlParameter[2];
            arParams[0] = new SqlParameter("@TempletID", SqlDbType.Int);
            arParams[0].Direction = ParameterDirection.InputOutput;
            arParams[1] = new SqlParameter("@TempletName", SqlDbType.VarChar);
            arParams[1].Size = 50;
            arParams[1].Value = TempletName;
            SqlTransaction DBTransaction = null;
            try
            {
                if (this.sqlConn.State == System.Data.ConnectionState.Closed) this.sqlConn.Open();
                DBTransaction = this.sqlConn.BeginTransaction();
                SqlHelper.ExecuteNonQuery(DBTransaction, CommandType.StoredProcedure, "prd.InsertParmTemplet", arParams);
                TempletID = arParams[0].Value;
                DBTransaction.Commit();
                flag = true;
            }
            catch (SqlException ex)
            {
                ErrorMsg = ex.Message; //返回错误信息
                flag = false;
                DBTransaction.Rollback();//--回退事务
            }
            finally
            {
                this.sqlConn.Close();
            }
            return flag;
        }
        public bool UpdateParmTemplet(ref string ErrorMsg, object TempletID, object TempletName)
        {
            bool flag = false;
            ErrorMsg = string.Empty;
            SqlParameter[] arParams = new SqlParameter[2];
            arParams[0] = new SqlParameter("@TempletID", SqlDbType.Int);
            arParams[1] = new SqlParameter("@TempletName", SqlDbType.VarChar);
            arParams[1].Size = 50;
            arParams[0].Value = TempletID;
            arParams[1].Value = TempletName;
            SqlTransaction DBTransaction = null;
            try
            {
                if (this.sqlConn.State == System.Data.ConnectionState.Closed) this.sqlConn.Open();
                DBTransaction = this.sqlConn.BeginTransaction();
                SqlHelper.ExecuteNonQuery(DBTransaction, CommandType.StoredProcedure, "prd.UpdateParmTemplet", arParams);
                DBTransaction.Commit();
                flag = true;
            }
            catch (SqlException ex)
            {
                ErrorMsg = ex.Message; //返回错误信息
                flag = false;
                DBTransaction.Rollback();//--回退事务
            }
            finally
            {
                this.sqlConn.Close();
            }
            return flag;
        }



    }
}