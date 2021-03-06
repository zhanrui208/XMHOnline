using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JERPApp.Manufacture.Templet
{
    public partial class FrmPackingSheetFormatCopy : Form
    {
        public FrmPackingSheetFormatCopy()
        {
            InitializeComponent();
            this.accFormat = new JERPData.Packing .WorkingSheetFormat();
            this.btnCopy.Click += new EventHandler(btnCopy_Click);
        }
        JERPData.Packing.WorkingSheetFormat accFormat;
        public delegate void AffterSaveDelegate();
        private AffterSaveDelegate affterSave;
        public event AffterSaveDelegate AffterSave
        {
            add
            {
                affterSave += value;
            }
            remove
            {
                affterSave -= value;
            }
        }
        private int OldFormatID = -1;
        public void NewFromCopy(int OldFormatID)
        {
            this.OldFormatID = OldFormatID;
        }
        void btnCopy_Click(object sender, EventArgs e)
        {
            DialogResult rul = MessageBox.Show("您将通过复制新增一种格式，请确认！", "新增确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rul == DialogResult.No) return;
            bool flag = false;
            string errormsg = string.Empty;
            flag = this.accFormat.InsertWorkingSheetFormatFromCopy(ref errormsg, this.OldFormatID, 
                this.txtTmpSheetName.Text);
            if (flag)
            {
                MessageBox.Show("成功复制了当前格式！");
            }
            else
            {
                MessageBox.Show(errormsg);
            }
            if (this.affterSave != null) this.affterSave();
            this.Close();
        }
    }
}