﻿namespace JERPApp.Define.Product
{
    partial class CtrlDPTypeTreePro
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mItemRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemDefine = new System.Windows.Forms.ToolStripMenuItem();
            this.treePrdType = new System.Windows.Forms.TreeView();
            this.cMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cMenu
            // 
            this.cMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemRefresh,
            this.mItemDefine});
            this.cMenu.Name = "cMenu";
            this.cMenu.Size = new System.Drawing.Size(153, 70);
            // 
            // mItemRefresh
            // 
            this.mItemRefresh.Name = "mItemRefresh";
            this.mItemRefresh.Size = new System.Drawing.Size(152, 22);
            this.mItemRefresh.Text = "刷新";
            // 
            // mItemDefine
            // 
            this.mItemDefine.Name = "mItemDefine";
            this.mItemDefine.Size = new System.Drawing.Size(152, 22);
            this.mItemDefine.Text = "设置";
            // 
            // treePrdType
            // 
            this.treePrdType.BackColor = System.Drawing.Color.White;
            this.treePrdType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treePrdType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treePrdType.ForeColor = System.Drawing.Color.Black;
            this.treePrdType.HideSelection = false;
            this.treePrdType.LineColor = System.Drawing.Color.Silver;
            this.treePrdType.Location = new System.Drawing.Point(0, 0);
            this.treePrdType.Margin = new System.Windows.Forms.Padding(0);
            this.treePrdType.Name = "treePrdType";
            this.treePrdType.Size = new System.Drawing.Size(150, 150);
            this.treePrdType.TabIndex = 18;
            // 
            // CtrlDPTypeTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treePrdType);
            this.Name = "CtrlDPTypeTree";
            this.cMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cMenu;
        private System.Windows.Forms.ToolStripMenuItem mItemRefresh;
        private System.Windows.Forms.ToolStripMenuItem mItemDefine;
        private System.Windows.Forms.TreeView treePrdType;
    }
}
