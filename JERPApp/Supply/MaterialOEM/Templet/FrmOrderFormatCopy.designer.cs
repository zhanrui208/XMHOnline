﻿namespace JERPApp.Supply.MaterialOEM.Templet
{
    partial class FrmOrderFormatCopy
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtTmpSheetName = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 40;
            this.label2.Text = "模版名称栏";
            // 
            // txtTmpSheetName
            // 
            this.txtTmpSheetName.Location = new System.Drawing.Point(90, 12);
            this.txtTmpSheetName.Name = "txtTmpSheetName";
            this.txtTmpSheetName.Size = new System.Drawing.Size(167, 21);
            this.txtTmpSheetName.TabIndex = 41;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(90, 39);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 44;
            this.btnCopy.Text = "复制新增";
            this.btnCopy.UseVisualStyleBackColor = true;
            // 
            // FrmOEMOrderFormatCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 66);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTmpSheetName);
            this.Name = "FrmOEMOrderFormatCopy";
            this.Text = "通过复制新增";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTmpSheetName;
        private System.Windows.Forms.Button btnCopy;
    }
}