using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JERPApp.Define.Material
{
    public partial class FrmBuyReceiveItemForReconciliation : Form
    {
        public FrmBuyReceiveItemForReconciliation()
        {
            InitializeComponent();
            this.dgrdv.AutoGenerateColumns = false; 
            this.ctrlQFind.SeachGridView = this.dgrdv;
            this.accItems = new JERPData.Material.BuyReceiveItems();
            this.accReconciliation = new JERPData.Material.BuyReconciliations();
            this.ckbFiter.CheckedChanged += new EventHandler(ckbFiter_CheckedChanged);
            this.btnConfirm.Click += new EventHandler(btnConfirm_Click);
        }

     
        private JERPData.Material.BuyReceiveItems accItems;
        private JERPData.Material.BuyReconciliations accReconciliation;
        private long ReconciliationID=-1;
        private DataTable dtblItems;
        public void ReconciliationItem(long ReconciliationID,int Year,int Month)
        {
            this.ReconciliationID = ReconciliationID;
            this.ckbFiter.Checked = false;
            this.dtpDateBegin.Value = new DateTime(Year, Month, 1);
            this.dtpDateEnd.Value = new DateTime(Year, Month, DateTime.DaysInMonth(Year, Month));
            this.LoadData();
           
        }
        private void LoadData()
        {
            this.dtblItems = this.accItems.GetDataBuyReceiveItemsForReconciliation (this.ReconciliationID).Tables[0];
            this.dgrdv.DataSource = this.dtblItems;
        }
        private void FiterData()
        {
            
            DataRow[] drows= this.dtblItems.Select("DateNote<'"+this.dtpDateBegin .Value.ToShortDateString ()+"' or DateNote>'"+this.dtpDateEnd .Value .ToShortDateString ()+"'");
            foreach (DataRow drow in drows)
            {
                this.dtblItems.Rows.Remove(drow);
            }
        }

        void ckbFiter_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFiter.Checked)
            {
                FiterData();
            }
            else
            {
                this.LoadData();
            }
        }

        public delegate void AffterEnterDelegate();
        private AffterEnterDelegate affterEnter;
        public event AffterEnterDelegate AffterEnter
        {
            add
            {
                affterEnter += value;
            }
            remove
            {
                affterEnter -= value;
            }
        }
        void btnConfirm_Click(object sender, EventArgs e)
        {
            string errormsg=string.Empty ;
            bool flag = false;
            foreach (DataRow drow in this.dtblItems.Select("", "", DataViewRowState.CurrentRows))
            {
                flag=this.accItems.UpdateBuyReceiveItemsForReconciliation(ref errormsg,
                    drow["ItemID"], this.ReconciliationID);
                if (!flag)
                {
                    MessageBox.Show(errormsg);
                }
            }
            if (this.affterEnter != null) this.affterEnter();
            this.Close();
        }

    }
}