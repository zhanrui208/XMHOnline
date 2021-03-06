﻿/*
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
    /// 表[manuf.ManuProcessNew]数据访问类
    ///</描述> 
    ///<作者> 
    /// 
    ///</作者> 
    ///<时间> 
    /// 2016-08-31 14:48:21
    ///</时间>  
    public class ManuProcessNew
    {
        private SqlConnection sqlConn;
        public ManuProcessNew()
        {
            this.sqlConn = DBConnection.JSqlDBConn;
        }

        //获取数据
        public DataSet GetDataManuProcessNewByPrdID(int PrdID)
        {
            DataSet ds = null;
            SqlParameter[] arParams = new SqlParameter[1];
            arParams[0] = new SqlParameter("@PrdID", SqlDbType.Int);
            arParams[0].Value = PrdID;
            try
            {
                if (this.sqlConn.State == System.Data.ConnectionState.Closed) this.sqlConn.Open();
                ds = SqlHelper.ExecuteDataset(sqlConn, CommandType.StoredProcedure, "manuf.GetDataManuProcessNewByPrdID", arParams);
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

        public DataSet GetDataManuProcessNewByPrdIDUnion(int PrdID)
        {
            DataSet ds = null;
            SqlParameter[] arParams = new SqlParameter[1];
            arParams[0] = new SqlParameter("@PrdID", SqlDbType.Int);
            arParams[0].Value = PrdID;
            try
            {
                if (this.sqlConn.State == System.Data.ConnectionState.Closed) this.sqlConn.Open();
                ds = SqlHelper.ExecuteDataset(sqlConn, CommandType.StoredProcedure, "manuf.GetDataManuProcessNewByPrdIDUnion", arParams);
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


        public bool InsertManuProcessNew(ref string ErrorMsg, ref object ID, object PrdID, object ProcessTempIndex, object ProcessID, object ModeMachineTime, object TimeCost, object TimeTypeID, object MoneyCost, object ConfirmPsnID, object ProcessMemo)
        {
            bool flag = false;
            ErrorMsg = string.Empty;
            SqlParameter[] arParams = new SqlParameter[10];
            arParams[0] = new SqlParameter("@ID", SqlDbType.BigInt);
            arParams[0].Direction = ParameterDirection.InputOutput;
            arParams[1] = new SqlParameter("@PrdID", SqlDbType.Int);
            arParams[2] = new SqlParameter("@ProcessTempIndex", SqlDbType.Int);
            arParams[3] = new SqlParameter("@ProcessID", SqlDbType.Int);
            arParams[4] = new SqlParameter("@ModeMachineTime", SqlDbType.Decimal);
            arParams[4].Precision = 18;
            arParams[4].Scale = 4;
            arParams[5] = new SqlParameter("@TimeCost", SqlDbType.Decimal);
            arParams[5].Precision = 18;
            arParams[5].Scale = 4;
            arParams[6] = new SqlParameter("@TimeTypeID", SqlDbType.Int);
            arParams[7] = new SqlParameter("@MoneyCost", SqlDbType.Decimal);
            arParams[7].Precision = 18;
            arParams[7].Scale = 4;
            arParams[8] = new SqlParameter("@ConfirmPsnID", SqlDbType.Int);
            arParams[9] = new SqlParameter("@ProcessMemo", SqlDbType.VarChar);
            arParams[9].Size = 400;
            arParams[0].Value = ID;
            arParams[1].Value = PrdID;
            arParams[2].Value = ProcessTempIndex;
            arParams[3].Value = ProcessID;
            arParams[4].Value = ModeMachineTime;
            arParams[5].Value = TimeCost;
            arParams[6].Value = TimeTypeID;
            arParams[7].Value = MoneyCost;
            arParams[8].Value = ConfirmPsnID;
            arParams[9].Value = ProcessMemo;
            SqlTransaction DBTransaction = null;
            try
            {
                if (this.sqlConn.State == System.Data.ConnectionState.Closed) this.sqlConn.Open();
                DBTransaction = this.sqlConn.BeginTransaction();
                SqlHelper.ExecuteNonQuery(DBTransaction, CommandType.StoredProcedure, "manuf.InsertManuProcessNew", arParams);
                ID = arParams[0].Value;
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

        public bool UpdateManuProcessNew(ref string ErrorMsg, object ID, object PrdID, object ProcessTempIndex, object ProcessID, object ModeMachineTime, object TimeCost, object TimeTypeID, object MoneyCost, object ConfirmPsnID, object ProcessMemo)
        {
            bool flag = false;
            ErrorMsg = string.Empty;
            SqlParameter[] arParams = new SqlParameter[10];
            arParams[0] = new SqlParameter("@ID", SqlDbType.BigInt);
            arParams[1] = new SqlParameter("@PrdID", SqlDbType.Int);
            arParams[2] = new SqlParameter("@ProcessTempIndex", SqlDbType.Int);
            arParams[3] = new SqlParameter("@ProcessID", SqlDbType.Int);
            arParams[4] = new SqlParameter("@ModeMachineTime", SqlDbType.Decimal);
            arParams[4].Precision = 18;
            arParams[4].Scale = 4;
            arParams[5] = new SqlParameter("@TimeCost", SqlDbType.Decimal);
            arParams[5].Precision = 18;
            arParams[5].Scale = 4;
            arParams[6] = new SqlParameter("@TimeTypeID", SqlDbType.Int);
            arParams[7] = new SqlParameter("@MoneyCost", SqlDbType.Decimal);
            arParams[7].Precision = 18;
            arParams[7].Scale = 4;
            arParams[8] = new SqlParameter("@ConfirmPsnID", SqlDbType.Int);
            arParams[9] = new SqlParameter("@ProcessMemo", SqlDbType.VarChar);
            arParams[9].Size = 400;
            arParams[0].Value = ID;
            arParams[1].Value = PrdID;
            arParams[2].Value = ProcessTempIndex;
            arParams[3].Value = ProcessID;
            arParams[4].Value = ModeMachineTime;
            arParams[5].Value = TimeCost;
            arParams[6].Value = TimeTypeID;
            arParams[7].Value = MoneyCost;
            arParams[8].Value = ConfirmPsnID;
            arParams[9].Value = ProcessMemo;
            SqlTransaction DBTransaction = null;
            try
            {
                if (this.sqlConn.State == System.Data.ConnectionState.Closed) this.sqlConn.Open();
                DBTransaction = this.sqlConn.BeginTransaction();
                SqlHelper.ExecuteNonQuery(DBTransaction, CommandType.StoredProcedure, "manuf.UpdateManuProcessNew", arParams);
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


        //删除数据
        public bool DeleteManuProcessNew(ref string ErrorMsg, object ID, object PrdID)
        {
            bool flag = false;
            ErrorMsg = string.Empty;
            SqlParameter[] arParams = new SqlParameter[2];
            arParams[0] = new SqlParameter("@ID", SqlDbType.BigInt);
            arParams[1] = new SqlParameter("@PrdID", SqlDbType.Int);
            arParams[0].Value = ID;
            arParams[1].Value = PrdID;
            SqlTransaction DBTransaction = null;
            try
            {
                if (this.sqlConn.State == System.Data.ConnectionState.Closed) this.sqlConn.Open();
                DBTransaction = this.sqlConn.BeginTransaction();
                SqlHelper.ExecuteNonQuery(DBTransaction, CommandType.StoredProcedure, "manuf.DeleteManuProcessNew", arParams);
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