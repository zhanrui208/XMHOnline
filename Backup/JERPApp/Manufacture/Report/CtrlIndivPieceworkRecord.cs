using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace JERPApp.Manufacture.Report
{
    public partial class CtrlIndivPieceworkRecord : UserControl
    {
        public CtrlIndivPieceworkRecord()
        {
            InitializeComponent();
            this.dgrdv.AutoGenerateColumns = false;
            this.ctrlQFind.SeachGridView = this.dgrdv;
            this.accPiecework = new JERPData.Manufacture.IndivPiecework();
            this.dgrdv.ContextMenuStrip = this.cMenu;
            this.mItemRefresh.Click += new EventHandler(mItemRefresh_Click);
            this.btnExport.Click += new EventHandler(btnExport_Click);
        }

     
        private DataTable dtblRecords;
        private JERPData.Manufacture.IndivPiecework accPiecework;
        private int PsnID = -1;
        private string PsnInfor = string.Empty;
        private DateTime DateBegin = DateTime.MinValue;
        private DateTime DateEnd = DateTime.MinValue;
        public void WageRecord(int PsnID, string PsnInfor, DateTime DateBegin, DateTime DateEnd)
        {
            this.PsnID = PsnID;
            this.PsnInfor = PsnInfor;
            this.DateBegin = DateBegin;
            this.DateEnd = DateEnd;
            this.LoadData();
        }
        private void LoadData()
        {
            this.dtblRecords = this.accPiecework.GetDataIndivPieceworkPsnRecord(this.PsnID,
                          this.DateBegin, this.DateEnd).Tables[0];
            DataRow drowNew = this.dtblRecords.NewRow();
            drowNew["DateWage"] = "合计";
            drowNew["LaborWage"] = this.dtblRecords.Compute("SUM(LaborWage)", "");
            this.dtblRecords.Rows.Add(drowNew);
            this.dgrdv.DataSource = this.dtblRecords;
        }
        void mItemRefresh_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }
        void btnExport_Click(object sender, EventArgs e)
        {
            FrmMsg.Show("正在生成打印文档，请稍候......");
            Office2003Helper.Excel2003 excel = new Office2003Helper.Excel2003();
            excel.NewFromTemp(JERPData.ServerParameter.TempletFolder + @"GeneralShowSheet.xlt");
            excel.SetCellVal("C1", this.PsnInfor +"["+this.DateBegin.ToShortDateString ()+"-"+this.DateEnd .ToShortDateString ()+"]计件工资表");
            int rowIndex = 3;
            int colIndex = 1;
            excel.ImportGridData(this.dgrdv, ref rowIndex, ref colIndex, true, true);
            excel.SetRangeInnerBorder(3, 1, rowIndex, colIndex);
            excel.SetRangeAutoFit(3, 1, rowIndex, colIndex, true, false);
            FrmMsg.Hide();
            excel.Show();
        }
    }
}
