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
namespace JERPData.Finance
{
    /// <描述>
    /// 表[finance.ExpressReceivableAccount]数据访问类
    ///</描述> 
    ///<作者> 
    /// 金优富
    ///</作者> 
    ///<时间> 
    /// 2014-12-18 14:55:05
    ///</时间>  
    public class ExpressReceivableAccount
    {
        private SqlConnection sqlConn;
        public ExpressReceivableAccount()
        {
            this.sqlConn = DBConnection.JSqlDBConn;
        }
        public DataSet GetDataExpressReceivableAccount()
        {
            DataSet ds = null;
            try
            {
                if (this.sqlConn.State == System.Data.ConnectionState.Closed) this.sqlConn.Open();
                ds = SqlHelper.ExecuteDataset(sqlConn, "finance.GetDataExpressReceivableAccount");
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
        public DataSet GetDataExpressReceivableAccountLastRecord(int CompanyID, int MoneyTypeID, int RecordCount)
        {
            DataSet ds = null;
            SqlParameter[] arParams = new SqlParameter[3];
            arParams[0] = new SqlParameter("@CompanyID", SqlDbType.Int);
            arParams[1] = new SqlParameter("@MoneyTypeID", SqlDbType.Int);
            arParams[2] = new SqlParameter("@RecordCount", SqlDbType.Int);
            arParams[0].Value = CompanyID;
            arParams[1].Value = MoneyTypeID;
            arParams[2].Value = RecordCount;
            try
            {
                if (this.sqlConn.State == System.Data.ConnectionState.Closed) this.sqlConn.Open();
                ds = SqlHelper.ExecuteDataset(sqlConn, CommandType.StoredProcedure, "finance.GetDataExpressReceivableAccountLastRecord", arParams);
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
        public DataSet GetDataExpressReceivableAccountRecord(int CompanyID, int MoneyTypeID, DateTime DateBegin, DateTime DateEnd)
        {
            DataSet ds = null;
            SqlParameter[] arParams = new SqlParameter[4];
            arParams[0] = new SqlParameter("@CompanyID", SqlDbType.Int);
            arParams[1] = new SqlParameter("@MoneyTypeID", SqlDbType.Int);
            arParams[2] = new SqlParameter("@DateBegin", SqlDbType.DateTime);
            arParams[3] = new SqlParameter("@DateEnd", SqlDbType.DateTime);
            arParams[0].Value = CompanyID;
            arParams[1].Value = MoneyTypeID;
            arParams[2].Value = DateBegin;
            arParams[3].Value = DateEnd;
            try
            {
                if (this.sqlConn.State == System.Data.ConnectionState.Closed) this.sqlConn.Open();
                ds = SqlHelper.ExecuteDataset(sqlConn, CommandType.StoredProcedure, "finance.GetDataExpressReceivableAccountRecord", arParams);
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
        public bool GetParmExpressReceivableAccountBalanceAM(int CompanyID, int MoneyTypeID, ref decimal BalanceAMT)
        {
            bool flag = false;
            SqlParameter[] arParams = new SqlParameter[3];
            arParams[0] = new SqlParameter("@CompanyID", SqlDbType.Int);
            arParams[1] = new SqlParameter("@MoneyTypeID", SqlDbType.Int);
            arParams[2] = new SqlParameter("@BalanceAMT", SqlDbType.Money);
            arParams[2].Direction = ParameterDirection.InputOutput;
            arParams[0].Value = CompanyID;
            arParams[1].Value = MoneyTypeID;
            try
            {
                if (this.sqlConn.State == System.Data.ConnectionState.Closed) this.sqlConn.Open();
                SqlHelper.ExecuteNonQuery(this.sqlConn, CommandType.StoredProcedure, "finance.GetParmExpressReceivableAccountBalanceAM", arParams);
                BalanceAMT = (decimal)arParams[2].Value;
                flag = true;
            }
            catch//(SqlException ex)
            {
                flag = false;
            }
            finally
            {
                this.sqlConn.Close();
            }
            return flag;
        }
        public bool InsertExpressReceivableAccountForAdjust(ref string ErrorMsg, object CompanyID, object MoneyTypeID, object BalanceAMT, object RegisterPsnID)
        {
            bool flag = false;
            ErrorMsg = string.Empty;
            SqlParameter[] arParams = new SqlParameter[4];
            arParams[0] = new SqlParameter("@CompanyID", SqlDbType.Int);
            arParams[1] = new SqlParameter("@MoneyTypeID", SqlDbType.Int);
            arParams[2] = new SqlParameter("@BalanceAMT", SqlDbType.Money);
            arParams[3] = new SqlParameter("@RegisterPsnID", SqlDbType.Int);
            arParams[0].Value = CompanyID;
            arParams[1].Value = MoneyTypeID;
            arParams[2].Value = BalanceAMT;
            arParams[3].Value = RegisterPsnID;
            SqlTransaction DBTransaction = null;
            try
            {
                if (this.sqlConn.State == System.Data.ConnectionState.Closed) this.sqlConn.Open();
                DBTransaction = this.sqlConn.BeginTransaction();
                SqlHelper.ExecuteNonQuery(DBTransaction, CommandType.StoredProcedure, "finance.InsertExpressReceivableAccountForAdjust", arParams);
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
        public bool InsertExpressReceivableAccountForCredit(ref string ErrorMsg, object Summary, object CompanyID, object MoneyTypeID, object CreditAMT, object RegisterPsnID)
        {
            bool flag = false;
            ErrorMsg = string.Empty;
            SqlParameter[] arParams = new SqlParameter[5];
            arParams[0] = new SqlParameter("@Summary", SqlDbType.VarChar);
            arParams[0].Size = 100;
            arParams[1] = new SqlParameter("@CompanyID", SqlDbType.Int);
            arParams[2] = new SqlParameter("@MoneyTypeID", SqlDbType.Int);
            arParams[3] = new SqlParameter("@CreditAMT", SqlDbType.Money);
            arParams[4] = new SqlParameter("@RegisterPsnID", SqlDbType.Int);
            arParams[0].Value = Summary;
            arParams[1].Value = CompanyID;
            arParams[2].Value = MoneyTypeID;
            arParams[3].Value = CreditAMT;
            arParams[4].Value = RegisterPsnID;
            SqlTransaction DBTransaction = null;
            try
            {
                if (this.sqlConn.State == System.Data.ConnectionState.Closed) this.sqlConn.Open();
                DBTransaction = this.sqlConn.BeginTransaction();
                SqlHelper.ExecuteNonQuery(DBTransaction, CommandType.StoredProcedure, "finance.InsertExpressReceivableAccountForCredit", arParams);
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
        public bool InsertExpressReceivableAccountForDebit(ref string ErrorMsg, object Summary, object CompanyID, object MoneyTypeID, object DebitAMT, object RegisterPsnID)
        {
            bool flag = false;
            ErrorMsg = string.Empty;
            SqlParameter[] arParams = new SqlParameter[5];
            arParams[0] = new SqlParameter("@Summary", SqlDbType.VarChar);
            arParams[0].Size = 100;
            arParams[1] = new SqlParameter("@CompanyID", SqlDbType.Int);
            arParams[2] = new SqlParameter("@MoneyTypeID", SqlDbType.Int);
            arParams[3] = new SqlParameter("@DebitAMT", SqlDbType.Money);
            arParams[4] = new SqlParameter("@RegisterPsnID", SqlDbType.Int);
            arParams[0].Value = Summary;
            arParams[1].Value = CompanyID;
            arParams[2].Value = MoneyTypeID;
            arParams[3].Value = DebitAMT;
            arParams[4].Value = RegisterPsnID;
            SqlTransaction DBTransaction = null;
            try
            {
                if (this.sqlConn.State == System.Data.ConnectionState.Closed) this.sqlConn.Open();
                DBTransaction = this.sqlConn.BeginTransaction();
                SqlHelper.ExecuteNonQuery(DBTransaction, CommandType.StoredProcedure, "finance.InsertExpressReceivableAccountForDebit", arParams);
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