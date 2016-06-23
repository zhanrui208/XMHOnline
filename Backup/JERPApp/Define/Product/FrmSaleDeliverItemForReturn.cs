using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JERPApp.Define.Product
{
    public partial class FrmSaleDeliverItemForReturn : Form
    {
        public FrmSaleDeliverItemForReturn()
        {
            InitializeComponent();
            this.dgrdv.AutoGenerateColumns = false;
            this.ctrlQFind.SeachGridView = this.dgrdv;
            this.ctrlBetweenDate.DateBegin = DateTime.Now.AddDays(-30).Date;
            this.ctrlBetweenDate.DateEnd = DateTime.Now.AddDays(1).Date;
            this.accDeliverItem = new JERPData.Product.SaleDeliverItems();
            this.ctrlBetweenDate.AffterEnter += this.LoadData;
            this.dgrdv .CellContentClick +=new DataGridViewCellEventHandler(dgrdv_CellContentClick);
            
        }
        private JERPData.Product.SaleDeliverItems accDeliverItem;
        private DataTable dtblItems;
        private int CompanyID = -1;
        private int MoneyTypeID = -1;
        public void SaleDeliverForReturn(int CompanyID,int MoneyTypeID)
        {
            this.CompanyID = CompanyID;
            this.MoneyTypeID = MoneyTypeID;
            this.LoadData();
        }
        private void LoadData()
        {
            this.dtblItems = this.accDeliverItem.GetDataSaleDeliverItemsForReturn (this.CompanyID,this.MoneyTypeID ,this.ctrlBetweenDate.DateBegin.Date,
               this.ctrlBetweenDate.DateEnd.Date).Tables[0];
            this.dgrdv.DataSource = this.dtblItems;
        }
        public delegate void AffterSelectDelegate(DataRow drow);
        private AffterSelectDelegate affterSelect;
        public event AffterSelectDelegate AffterSelect
        {
            add
            {
                affterSelect += value;
            }
            remove
            {
                affterSelect -= value;
            }
        }
        void dgrdv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int irow = e.RowIndex;
            int icol = e.ColumnIndex;
            if ((irow == -1) || (icol == -1)) return;
            if (this.dgrdv.Columns[icol].Name == this.ColumnbtnSelect.Name)
            {
                if (this.affterSelect != null) this.affterSelect(this.dtblItems.DefaultView[irow].Row);
            
            }
        }
    }
}