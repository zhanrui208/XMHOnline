/*
$Header$
$Author$
$Date$
$Revision$
*/
using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
namespace JERPBiz.Packing
{
    /// <描述>
    /// 表[WorkingSheetFormat]数据实体类
    ///</描述> 
    ///<作者> 
    /// 金优富
    ///</作者> 
    ///<时间> 
    /// 2016/5/23 16:04:22
    ///</时间>  
    public class WorkingSheetFormatEntity
    {
        public WorkingSheetFormatEntity()
        {
            this.accData = new JERPData.Packing.WorkingSheetFormat();
        }
        private JERPData.Packing.WorkingSheetFormat accData;
        public int FormatID = -1;
        public string TmpSheetName = string.Empty;
        public string WorkingSheetCodeCellName = string.Empty;
        public string DateNoteCellName = string.Empty;
        public string CompanyNameCellName = string.Empty;
        public string PrdCodeCellName = string.Empty;
        public string PrdNameCellName = string.Empty;
        public string PrdSpecCellName = string.Empty;
        public string ModelCellName = string.Empty;
        public string QuantityCellName = string.Empty;
        public string UnitNameCellName = string.Empty;
        public string DateTargetCellName = string.Empty;
        public string PackingTypeCellName = string.Empty;
        public string MemoCellName = string.Empty;
        public string MakerPsnCellName = string.Empty;
        public void LoadData(int FormatID)
        {
            this.FormatID = FormatID;
            DataTable dtbl = this.accData.GetDataWorkingSheetFormatByFormatID(FormatID).Tables[0];
            if (dtbl.Rows.Count == 0)
            {
                this.TmpSheetName = string.Empty;
                this.WorkingSheetCodeCellName = string.Empty;
                this.DateNoteCellName = string.Empty;
                this.CompanyNameCellName = string.Empty;
                this.PrdCodeCellName = string.Empty;
                this.PrdNameCellName = string.Empty;
                this.PrdSpecCellName = string.Empty;
                this.ModelCellName = string.Empty;
                this.QuantityCellName = string.Empty;
                this.UnitNameCellName = string.Empty;
                this.DateTargetCellName = string.Empty;
                this.PackingTypeCellName = string.Empty;
                this.MemoCellName = string.Empty;
                this.MakerPsnCellName = string.Empty;
                return;
            }
            DataRow drow = dtbl.Rows[0];
            if (drow["TmpSheetName"] == DBNull.Value)
            {
                this.TmpSheetName = string.Empty;
            }
            else
            {
                this.TmpSheetName = drow["TmpSheetName"].ToString();
            }
            if (drow["WorkingSheetCodeCellName"] == DBNull.Value)
            {
                this.WorkingSheetCodeCellName = string.Empty;
            }
            else
            {
                this.WorkingSheetCodeCellName = drow["WorkingSheetCodeCellName"].ToString();
            }
            if (drow["DateNoteCellName"] == DBNull.Value)
            {
                this.DateNoteCellName = string.Empty;
            }
            else
            {
                this.DateNoteCellName = drow["DateNoteCellName"].ToString();
            }
            if (drow["CompanyNameCellName"] == DBNull.Value)
            {
                this.CompanyNameCellName = string.Empty;
            }
            else
            {
                this.CompanyNameCellName = drow["CompanyNameCellName"].ToString();
            }
            if (drow["PrdCodeCellName"] == DBNull.Value)
            {
                this.PrdCodeCellName = string.Empty;
            }
            else
            {
                this.PrdCodeCellName = drow["PrdCodeCellName"].ToString();
            }
            if (drow["PrdNameCellName"] == DBNull.Value)
            {
                this.PrdNameCellName = string.Empty;
            }
            else
            {
                this.PrdNameCellName = drow["PrdNameCellName"].ToString();
            }
            if (drow["PrdSpecCellName"] == DBNull.Value)
            {
                this.PrdSpecCellName = string.Empty;
            }
            else
            {
                this.PrdSpecCellName = drow["PrdSpecCellName"].ToString();
            }
            if (drow["ModelCellName"] == DBNull.Value)
            {
                this.ModelCellName = string.Empty;
            }
            else
            {
                this.ModelCellName = drow["ModelCellName"].ToString();
            }
            if (drow["QuantityCellName"] == DBNull.Value)
            {
                this.QuantityCellName = string.Empty;
            }
            else
            {
                this.QuantityCellName = drow["QuantityCellName"].ToString();
            }
            if (drow["UnitNameCellName"] == DBNull.Value)
            {
                this.UnitNameCellName = string.Empty;
            }
            else
            {
                this.UnitNameCellName = drow["UnitNameCellName"].ToString();
            }
            if (drow["DateTargetCellName"] == DBNull.Value)
            {
                this.DateTargetCellName = string.Empty;
            }
            else
            {
                this.DateTargetCellName = drow["DateTargetCellName"].ToString();
            }
            if (drow["PackingTypeCellName"] == DBNull.Value)
            {
                this.PackingTypeCellName = string.Empty;
            }
            else
            {
                this.PackingTypeCellName = drow["PackingTypeCellName"].ToString();
            }
            if (drow["MemoCellName"] == DBNull.Value)
            {
                this.MemoCellName = string.Empty;
            }
            else
            {
                this.MemoCellName = drow["MemoCellName"].ToString();
            }
            if (drow["MakerPsnCellName"] == DBNull.Value)
            {
                this.MakerPsnCellName = string.Empty;
            }
            else
            {
                this.MakerPsnCellName = drow["MakerPsnCellName"].ToString();
            }
        }
    }
}