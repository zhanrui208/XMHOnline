﻿namespace JERPApp.Manufacture.SemiPrd.Report.Bill
{
    partial class FrmStoreCheckNote
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDateNote = new System.Windows.Forms.TextBox();
            this.txtCheckPersons = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNoteCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rchMemo = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExplore = new System.Windows.Forms.Button();
            this.ctrlQFind = new JCommon.CtrlGridQuickFind();
            this.dgrdv = new JCommon.MyDataGridView();
            this.ColumnPrdCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrdSpec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrdStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCheckQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInventoryQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInitQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSurplusQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLostQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDateNote);
            this.panel1.Controls.Add(this.txtCheckPersons);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNoteCode);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 62);
            this.panel1.TabIndex = 1;
            // 
            // txtDateNote
            // 
            this.txtDateNote.Location = new System.Drawing.Point(225, 33);
            this.txtDateNote.Name = "txtDateNote";
            this.txtDateNote.ReadOnly = true;
            this.txtDateNote.Size = new System.Drawing.Size(100, 21);
            this.txtDateNote.TabIndex = 21;
            // 
            // txtCheckPersons
            // 
            this.txtCheckPersons.Location = new System.Drawing.Point(392, 33);
            this.txtCheckPersons.Name = "txtCheckPersons";
            this.txtCheckPersons.ReadOnly = true;
            this.txtCheckPersons.Size = new System.Drawing.Size(264, 21);
            this.txtCheckPersons.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "盘点人员";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "制单日期";
            // 
            // txtNoteCode
            // 
            this.txtNoteCode.Location = new System.Drawing.Point(60, 33);
            this.txtNoteCode.Name = "txtNoteCode";
            this.txtNoteCode.ReadOnly = true;
            this.txtNoteCode.Size = new System.Drawing.Size(100, 21);
            this.txtNoteCode.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "盘点单号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(436, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "半成品盘点单";
            // 
            // rchMemo
            // 
            this.rchMemo.Location = new System.Drawing.Point(290, 1);
            this.rchMemo.Name = "rchMemo";
            this.rchMemo.ReadOnly = true;
            this.rchMemo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rchMemo.Size = new System.Drawing.Size(422, 25);
            this.rchMemo.TabIndex = 20;
            this.rchMemo.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "备注";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExplore);
            this.panel2.Controls.Add(this.rchMemo);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.ctrlQFind);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 543);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(923, 29);
            this.panel2.TabIndex = 2;
            // 
            // btnExplore
            // 
            this.btnExplore.Location = new System.Drawing.Point(737, 1);
            this.btnExplore.Name = "btnExplore";
            this.btnExplore.Size = new System.Drawing.Size(77, 25);
            this.btnExplore.TabIndex = 5;
            this.btnExplore.Text = "输出打印";
            this.btnExplore.UseVisualStyleBackColor = true;
            // 
            // ctrlQFind
            // 
            this.ctrlQFind.Location = new System.Drawing.Point(3, 3);
            this.ctrlQFind.Name = "ctrlQFind";
            this.ctrlQFind.SeachGridView = null;
            this.ctrlQFind.Size = new System.Drawing.Size(250, 21);
            this.ctrlQFind.TabIndex = 1;
            // 
            // dgrdv
            // 
            this.dgrdv.AllowUserToAddRows = false;
            this.dgrdv.AllowUserToDeleteRows = false;
            this.dgrdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPrdCode,
            this.ColumnPrdName,
            this.ColumnPrdSpec,
            this.ColumnModel,
            this.ColumnPrdStatus,
            this.ColumnCheckQty,
            this.ColumnInventoryQty,
            this.ColumnInitQty,
            this.ColumnSurplusQty,
            this.ColumnLostQty});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrdv.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgrdv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrdv.Location = new System.Drawing.Point(0, 62);
            this.dgrdv.Name = "dgrdv";
            this.dgrdv.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrdv.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgrdv.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgrdv.RowTemplate.Height = 23;
            this.dgrdv.Size = new System.Drawing.Size(923, 481);
            this.dgrdv.TabIndex = 3;
            // 
            // ColumnPrdCode
            // 
            this.ColumnPrdCode.DataPropertyName = "PrdCode";
            this.ColumnPrdCode.HeaderText = "产品编号";
            this.ColumnPrdCode.Name = "ColumnPrdCode";
            this.ColumnPrdCode.ReadOnly = true;
            this.ColumnPrdCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnPrdName
            // 
            this.ColumnPrdName.DataPropertyName = "PrdName";
            this.ColumnPrdName.HeaderText = "产品名称";
            this.ColumnPrdName.Name = "ColumnPrdName";
            this.ColumnPrdName.ReadOnly = true;
            this.ColumnPrdName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnPrdSpec
            // 
            this.ColumnPrdSpec.DataPropertyName = "PrdSpec";
            this.ColumnPrdSpec.HeaderText = "产品规格";
            this.ColumnPrdSpec.Name = "ColumnPrdSpec";
            this.ColumnPrdSpec.ReadOnly = true;
            this.ColumnPrdSpec.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnModel
            // 
            this.ColumnModel.DataPropertyName = "Model";
            this.ColumnModel.HeaderText = "机型";
            this.ColumnModel.Name = "ColumnModel";
            this.ColumnModel.ReadOnly = true;
            this.ColumnModel.Width = 80;
            // 
            // ColumnPrdStatus
            // 
            this.ColumnPrdStatus.DataPropertyName = "PrdStatus";
            this.ColumnPrdStatus.HeaderText = "工序";
            this.ColumnPrdStatus.Name = "ColumnPrdStatus";
            this.ColumnPrdStatus.ReadOnly = true;
            this.ColumnPrdStatus.Width = 66;
            // 
            // ColumnCheckQty
            // 
            this.ColumnCheckQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnCheckQty.DataPropertyName = "CheckQty";
            dataGridViewCellStyle5.Format = "#,##0.####";
            this.ColumnCheckQty.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnCheckQty.HeaderText = "实盘数";
            this.ColumnCheckQty.Name = "ColumnCheckQty";
            this.ColumnCheckQty.ReadOnly = true;
            this.ColumnCheckQty.Width = 80;
            // 
            // ColumnInventoryQty
            // 
            this.ColumnInventoryQty.DataPropertyName = "InventoryQty";
            this.ColumnInventoryQty.HeaderText = "账目数";
            this.ColumnInventoryQty.Name = "ColumnInventoryQty";
            this.ColumnInventoryQty.ReadOnly = true;
            this.ColumnInventoryQty.Width = 66;
            // 
            // ColumnInitQty
            // 
            this.ColumnInitQty.DataPropertyName = "InitQty";
            this.ColumnInitQty.HeaderText = "初始化";
            this.ColumnInitQty.Name = "ColumnInitQty";
            this.ColumnInitQty.ReadOnly = true;
            this.ColumnInitQty.Width = 66;
            // 
            // ColumnSurplusQty
            // 
            this.ColumnSurplusQty.DataPropertyName = "SurplusQty";
            this.ColumnSurplusQty.HeaderText = "盘盈";
            this.ColumnSurplusQty.Name = "ColumnSurplusQty";
            this.ColumnSurplusQty.ReadOnly = true;
            this.ColumnSurplusQty.Width = 66;
            // 
            // ColumnLostQty
            // 
            this.ColumnLostQty.DataPropertyName = "LostQty";
            this.ColumnLostQty.HeaderText = "盘亏";
            this.ColumnLostQty.Name = "ColumnLostQty";
            this.ColumnLostQty.ReadOnly = true;
            this.ColumnLostQty.Width = 66;
            // 
            // FrmStoreCheckNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 572);
            this.Controls.Add(this.dgrdv);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmStoreCheckNote";
            this.Text = "半成品盘点单";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private JCommon.MyDataGridView dgrdv;
        private JCommon.CtrlGridQuickFind ctrlQFind;
        private System.Windows.Forms.RichTextBox rchMemo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCheckPersons;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNoteCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDateNote;
        private System.Windows.Forms.Button btnExplore;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrdCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrdSpec;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrdStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCheckQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInventoryQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInitQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSurplusQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLostQty;
    }
}