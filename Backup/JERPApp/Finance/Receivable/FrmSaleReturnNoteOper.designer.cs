﻿namespace JERPApp.Finance.Receivable
{
    partial class FrmSaleReturnNoteOper
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.radPayableFlag = new System.Windows.Forms.RadioButton();
            this.radCashSettleFlag = new System.Windows.Forms.RadioButton();
            this.txtTotalAMT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.rchMemo = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMoneyTypeName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNoteCode = new System.Windows.Forms.TextBox();
            this.txtCompanyAbbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMakerPsn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDateNote = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgrdv = new JCommon.MyDataGridView();
            this.ColumnDeliverNoteCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrdCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrdSpec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnItemAMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMemo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.radPayableFlag);
            this.panel2.Controls.Add(this.radCashSettleFlag);
            this.panel2.Controls.Add(this.txtTotalAMT);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.rchMemo);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 445);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 34);
            this.panel2.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(433, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 147;
            this.label10.Text = "结算方式";
            // 
            // radPayableFlag
            // 
            this.radPayableFlag.AutoSize = true;
            this.radPayableFlag.Checked = true;
            this.radPayableFlag.Location = new System.Drawing.Point(545, 9);
            this.radPayableFlag.Name = "radPayableFlag";
            this.radPayableFlag.Size = new System.Drawing.Size(47, 16);
            this.radPayableFlag.TabIndex = 146;
            this.radPayableFlag.TabStop = true;
            this.radPayableFlag.Text = "月结";
            this.radPayableFlag.UseVisualStyleBackColor = true;
            // 
            // radCashSettleFlag
            // 
            this.radCashSettleFlag.AutoSize = true;
            this.radCashSettleFlag.Location = new System.Drawing.Point(492, 9);
            this.radCashSettleFlag.Name = "radCashSettleFlag";
            this.radCashSettleFlag.Size = new System.Drawing.Size(47, 16);
            this.radCashSettleFlag.TabIndex = 145;
            this.radCashSettleFlag.Text = "现结";
            this.radCashSettleFlag.UseVisualStyleBackColor = true;
            // 
            // txtTotalAMT
            // 
            this.txtTotalAMT.Location = new System.Drawing.Point(335, 8);
            this.txtTotalAMT.Name = "txtTotalAMT";
            this.txtTotalAMT.ReadOnly = true;
            this.txtTotalAMT.Size = new System.Drawing.Size(92, 21);
            this.txtTotalAMT.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(300, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "货款";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(654, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存入账";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // rchMemo
            // 
            this.rchMemo.Location = new System.Drawing.Point(47, 7);
            this.rchMemo.Name = "rchMemo";
            this.rchMemo.ReadOnly = true;
            this.rchMemo.Size = new System.Drawing.Size(239, 24);
            this.rchMemo.TabIndex = 1;
            this.rchMemo.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "备注";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMoneyTypeName);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtNoteCode);
            this.panel1.Controls.Add(this.txtCompanyAbbName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMakerPsn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtDateNote);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 56);
            this.panel1.TabIndex = 5;
            // 
            // txtMoneyTypeName
            // 
            this.txtMoneyTypeName.Location = new System.Drawing.Point(236, 31);
            this.txtMoneyTypeName.Name = "txtMoneyTypeName";
            this.txtMoneyTypeName.ReadOnly = true;
            this.txtMoneyTypeName.Size = new System.Drawing.Size(50, 21);
            this.txtMoneyTypeName.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(200, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "币种";
            // 
            // txtNoteCode
            // 
            this.txtNoteCode.Location = new System.Drawing.Point(64, 6);
            this.txtNoteCode.Name = "txtNoteCode";
            this.txtNoteCode.ReadOnly = true;
            this.txtNoteCode.Size = new System.Drawing.Size(125, 21);
            this.txtNoteCode.TabIndex = 14;
            // 
            // txtCompanyAbbName
            // 
            this.txtCompanyAbbName.Location = new System.Drawing.Point(64, 31);
            this.txtCompanyAbbName.Name = "txtCompanyAbbName";
            this.txtCompanyAbbName.ReadOnly = true;
            this.txtCompanyAbbName.Size = new System.Drawing.Size(125, 21);
            this.txtCompanyAbbName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "客户";
            // 
            // txtMakerPsn
            // 
            this.txtMakerPsn.Location = new System.Drawing.Point(516, 29);
            this.txtMakerPsn.Name = "txtMakerPsn";
            this.txtMakerPsn.ReadOnly = true;
            this.txtMakerPsn.Size = new System.Drawing.Size(114, 21);
            this.txtMakerPsn.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(469, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "制单人";
            // 
            // txtDateNote
            // 
            this.txtDateNote.Location = new System.Drawing.Point(344, 31);
            this.txtDateNote.Name = "txtDateNote";
            this.txtDateNote.ReadOnly = true;
            this.txtDateNote.Size = new System.Drawing.Size(114, 21);
            this.txtDateNote.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "退货日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "退货单号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(332, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "销售退货处理";
            // 
            // dgrdv
            // 
            this.dgrdv.AllowUserToAddRows = false;
            this.dgrdv.AllowUserToDeleteRows = false;
            this.dgrdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDeliverNoteCode,
            this.ColumnPrdCode,
            this.ColumnPrdName,
            this.ColumnPrdSpec,
            this.ColumnModel,
            this.ColumnQuantity,
            this.ColumnUnitName,
            this.ColumnPrice,
            this.ColumnItemAMT,
            this.ColumnMemo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrdv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgrdv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrdv.Location = new System.Drawing.Point(0, 56);
            this.dgrdv.Name = "dgrdv";
            this.dgrdv.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrdv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgrdv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgrdv.RowTemplate.Height = 23;
            this.dgrdv.Size = new System.Drawing.Size(785, 389);
            this.dgrdv.TabIndex = 7;
            // 
            // ColumnDeliverNoteCode
            // 
            this.ColumnDeliverNoteCode.DataPropertyName = "DeliverNoteCode";
            this.ColumnDeliverNoteCode.HeaderText = "送货单号";
            this.ColumnDeliverNoteCode.Name = "ColumnDeliverNoteCode";
            this.ColumnDeliverNoteCode.ReadOnly = true;
            // 
            // ColumnPrdCode
            // 
            this.ColumnPrdCode.DataPropertyName = "PrdCode";
            this.ColumnPrdCode.HeaderText = "产品编号";
            this.ColumnPrdCode.Name = "ColumnPrdCode";
            this.ColumnPrdCode.ReadOnly = true;
            this.ColumnPrdCode.Width = 80;
            // 
            // ColumnPrdName
            // 
            this.ColumnPrdName.DataPropertyName = "PrdName";
            this.ColumnPrdName.HeaderText = "产品名称";
            this.ColumnPrdName.Name = "ColumnPrdName";
            this.ColumnPrdName.ReadOnly = true;
            // 
            // ColumnPrdSpec
            // 
            this.ColumnPrdSpec.DataPropertyName = "PrdSpec";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnPrdSpec.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnPrdSpec.HeaderText = "产品规格";
            this.ColumnPrdSpec.Name = "ColumnPrdSpec";
            this.ColumnPrdSpec.ReadOnly = true;
            // 
            // ColumnModel
            // 
            this.ColumnModel.DataPropertyName = "Model";
            this.ColumnModel.HeaderText = "机型";
            this.ColumnModel.Name = "ColumnModel";
            this.ColumnModel.ReadOnly = true;
            this.ColumnModel.Width = 80;
            // 
            // ColumnQuantity
            // 
            this.ColumnQuantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            this.ColumnQuantity.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnQuantity.HeaderText = "数量";
            this.ColumnQuantity.Name = "ColumnQuantity";
            this.ColumnQuantity.ReadOnly = true;
            this.ColumnQuantity.Width = 66;
            // 
            // ColumnUnitName
            // 
            this.ColumnUnitName.DataPropertyName = "UnitName";
            this.ColumnUnitName.HeaderText = "单位";
            this.ColumnUnitName.Name = "ColumnUnitName";
            this.ColumnUnitName.ReadOnly = true;
            this.ColumnUnitName.Width = 54;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.DataPropertyName = "Price";
            this.ColumnPrice.HeaderText = "单价";
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.ReadOnly = true;
            this.ColumnPrice.Width = 66;
            // 
            // ColumnItemAMT
            // 
            this.ColumnItemAMT.DataPropertyName = "ItemAMT";
            this.ColumnItemAMT.HeaderText = "金额";
            this.ColumnItemAMT.Name = "ColumnItemAMT";
            this.ColumnItemAMT.ReadOnly = true;
            this.ColumnItemAMT.Width = 66;
            // 
            // ColumnMemo
            // 
            this.ColumnMemo.DataPropertyName = "Memo";
            this.ColumnMemo.HeaderText = "备注";
            this.ColumnMemo.Name = "ColumnMemo";
            this.ColumnMemo.ReadOnly = true;
            // 
            // FrmSaleReturnNoteOper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 479);
            this.Controls.Add(this.dgrdv);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSaleReturnNoteOper";
            this.Text = "销售退货处理";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rchMemo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCompanyAbbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMakerPsn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDateNote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private JCommon.MyDataGridView dgrdv;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtTotalAMT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNoteCode;
        private System.Windows.Forms.TextBox txtMoneyTypeName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radPayableFlag;
        private System.Windows.Forms.RadioButton radCashSettleFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDeliverNoteCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrdCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrdSpec;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemAMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMemo;

    }
}