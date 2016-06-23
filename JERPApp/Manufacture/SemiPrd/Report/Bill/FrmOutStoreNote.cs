using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JERPApp.Manufacture.SemiPrd.Report.Bill
{
    public partial class FrmOutStoreNote : Form  
    {
        public FrmOutStoreNote()
        {
            InitializeComponent();
            this.dgrdv.AutoGenerateColumns = false;
            this.NoteEntity = new JERPBiz.SemiPrd .OutStoreNoteEntity();
            this.accItems = new JERPData.SemiPrd .OutStoreItems();
            this.btnExplore .Click  +=new EventHandler(btnExplore_Click);
        }
        private JERPBiz.SemiPrd .OutStoreNoteEntity NoteEntity;
        private JERPData.SemiPrd .OutStoreItems accItems;
        private DataTable dtblItems;
     
        public  void DetailNote(long NoteID)
        {
            this.NoteEntity.LoadData(NoteID);
            this.txtDateNote.Text = this.NoteEntity.DateNote.ToShortDateString();
            this.txtNoteCode.Text = this.NoteEntity.NoteCode;
            this.txtMakerPsn.Text = this.NoteEntity.MakerPsn;
            this.rchMemo.Text = this.NoteEntity.Memo;
            this.dtblItems = this.accItems.GetDataOutStoreItemsByNoteID(NoteID).Tables[0];
            this.dgrdv.DataSource = this.dtblItems;
        }

        void btnExplore_Click(object sender, EventArgs e)
        {

            FrmMsg.Show("正在生成打印文档，请稍候......");
            Office2003Helper.Excel2003 excel = new Office2003Helper.Excel2003();
            excel.NewFromTemp(JERPData.ServerParameter.TempletFolder + @"GeneralShowSheet.xlt");
            excel.SetCellVal("D1", "半成品转出单");
            excel.SetCellVal("A2", "转出单号:" + this.txtNoteCode.Text + "   制单日期:" + this.txtDateNote.Text + " 制单:" + this.txtMakerPsn.Text);
            int rowIndex = 3;
            int colIndex = 1;
            excel.ImportGridData(dgrdv, ref rowIndex, ref colIndex, true, true);
            excel.SetRangeInnerBorder(3, 1, rowIndex, colIndex);
            FrmMsg.Hide();
            excel.Show();
           
        }
    }
}