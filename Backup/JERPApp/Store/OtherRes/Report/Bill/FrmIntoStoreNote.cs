using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JERPApp.Store.OtherRes.Report.Bill
{
    public partial class FrmIntoStoreNote : FrmBizBill 
    {
        public FrmIntoStoreNote()
        {
            InitializeComponent();
            this.dgrdv.AutoGenerateColumns = false;
            this.NoteEntity = new JERPBiz.OtherRes.IntoStoreNoteEntity();
            this.accItems = new JERPData.OtherRes.IntoStoreItems();
            this.btnExplore .Click  +=new EventHandler(btnExplore_Click);
        }
        private JERPBiz.OtherRes.IntoStoreNoteEntity NoteEntity;
        private JERPData.OtherRes.IntoStoreItems accItems;  
     
        private DataTable dtblItems;            
        public override void DetailNote(long NoteID)
        {
            this.NoteEntity.LoadData(NoteID);
            this.txtDateNote.Text = this.NoteEntity.DateNote.ToShortDateString();
            this.txtNoteCode.Text = this.NoteEntity.NoteCode;
            this.txtDeptName.Text = this.NoteEntity.DeptName;
            this.txtMakerPsn.Text = this.NoteEntity.MakerPsn;
            this.rchMemo.Text = this.NoteEntity.Memo;
            this.dtblItems = this.accItems.GetDataIntoStoreItemsByNoteID(NoteID).Tables[0];
            this.dgrdv.DataSource = this.dtblItems;
        }

        void btnExplore_Click(object sender, EventArgs e)
        {
            FrmMsg.Show("正在生成打印文档，请稍候......");
            Office2003Helper.Excel2003 excel = new Office2003Helper.Excel2003();
            excel.NewFromTemp(JERPData.ServerParameter.TempletFolder + @"GeneralShowSheet.xlt");
            excel.SetCellVal("D1", "耗材领用返库单");
            excel.SetCellVal("A2", "领用返库单号:" + this.txtNoteCode.Text +"   制单日期:" + this.txtDateNote.Text + " 制单:" + this.txtMakerPsn.Text);
            int rowIndex = 3;
            int colIndex = 1;
            excel.ImportGridData(dgrdv, ref rowIndex, ref colIndex, true, true);
            excel.SetRangeInnerBorder(3, 1, rowIndex, colIndex);
            FrmMsg.Hide();
            excel.Show();
        }
    }
}