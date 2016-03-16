namespace BankManager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grbx_Data = new System.Windows.Forms.GroupBox();
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.cntxms_GridMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showAllDebitorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllCreditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllPaymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debitorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDebitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openNewCreditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passNewPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbx_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            this.cntxms_GridMenu.SuspendLayout();
            this.ms_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbx_Data
            // 
            this.grbx_Data.Controls.Add(this.dgv_Data);
            this.grbx_Data.Location = new System.Drawing.Point(12, 68);
            this.grbx_Data.Name = "grbx_Data";
            this.grbx_Data.Size = new System.Drawing.Size(750, 380);
            this.grbx_Data.TabIndex = 0;
            this.grbx_Data.TabStop = false;
            this.grbx_Data.Text = "Data";
            // 
            // dgv_Data
            // 
            this.dgv_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Data.Location = new System.Drawing.Point(3, 16);
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.Size = new System.Drawing.Size(744, 361);
            this.dgv_Data.TabIndex = 0;
            this.dgv_Data.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Data_CellDoubleClick);
            this.dgv_Data.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_Data_MouseClick);
            // 
            // cntxms_GridMenu
            // 
            this.cntxms_GridMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllDebitorsToolStripMenuItem,
            this.showAllCreditsToolStripMenuItem,
            this.showAllPaymentsToolStripMenuItem});
            this.cntxms_GridMenu.Name = "cntxms_GridMenu";
            this.cntxms_GridMenu.Size = new System.Drawing.Size(174, 70);
            // 
            // showAllDebitorsToolStripMenuItem
            // 
            this.showAllDebitorsToolStripMenuItem.Name = "showAllDebitorsToolStripMenuItem";
            this.showAllDebitorsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.showAllDebitorsToolStripMenuItem.Text = "Show all debitors";
            this.showAllDebitorsToolStripMenuItem.Click += new System.EventHandler(this.showAllDebitorsToolStripMenuItem_Click);
            // 
            // showAllCreditsToolStripMenuItem
            // 
            this.showAllCreditsToolStripMenuItem.Name = "showAllCreditsToolStripMenuItem";
            this.showAllCreditsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.showAllCreditsToolStripMenuItem.Text = "Show all credits";
            this.showAllCreditsToolStripMenuItem.Click += new System.EventHandler(this.showAllCreditsToolStripMenuItem_Click);
            // 
            // showAllPaymentsToolStripMenuItem
            // 
            this.showAllPaymentsToolStripMenuItem.Name = "showAllPaymentsToolStripMenuItem";
            this.showAllPaymentsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.showAllPaymentsToolStripMenuItem.Text = "Show all payments";
            // 
            // ms_main
            // 
            this.ms_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.debitorsToolStripMenuItem,
            this.creditsToolStripMenuItem,
            this.paymentsToolStripMenuItem});
            this.ms_main.Location = new System.Drawing.Point(0, 0);
            this.ms_main.Name = "ms_main";
            this.ms_main.Size = new System.Drawing.Size(884, 24);
            this.ms_main.TabIndex = 1;
            this.ms_main.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // debitorsToolStripMenuItem
            // 
            this.debitorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDebitorToolStripMenuItem});
            this.debitorsToolStripMenuItem.Name = "debitorsToolStripMenuItem";
            this.debitorsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.debitorsToolStripMenuItem.Text = "Debitors";
            // 
            // addNewDebitorToolStripMenuItem
            // 
            this.addNewDebitorToolStripMenuItem.Name = "addNewDebitorToolStripMenuItem";
            this.addNewDebitorToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addNewDebitorToolStripMenuItem.Text = "Add new debitor";
            this.addNewDebitorToolStripMenuItem.Click += new System.EventHandler(this.addNewDebitorToolStripMenuItem_Click);
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openNewCreditToolStripMenuItem});
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.creditsToolStripMenuItem.Text = "Credits";
            // 
            // openNewCreditToolStripMenuItem
            // 
            this.openNewCreditToolStripMenuItem.Name = "openNewCreditToolStripMenuItem";
            this.openNewCreditToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.openNewCreditToolStripMenuItem.Text = "Open new credit";
            this.openNewCreditToolStripMenuItem.Click += new System.EventHandler(this.openNewCreditToolStripMenuItem_Click);
            // 
            // paymentsToolStripMenuItem
            // 
            this.paymentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passNewPaymentToolStripMenuItem});
            this.paymentsToolStripMenuItem.Name = "paymentsToolStripMenuItem";
            this.paymentsToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.paymentsToolStripMenuItem.Text = "Payments";
            // 
            // passNewPaymentToolStripMenuItem
            // 
            this.passNewPaymentToolStripMenuItem.Name = "passNewPaymentToolStripMenuItem";
            this.passNewPaymentToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.passNewPaymentToolStripMenuItem.Text = "Pass new payment";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 462);
            this.Controls.Add(this.ms_main);
            this.Controls.Add(this.grbx_Data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.ms_main;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Bank Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grbx_Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            this.cntxms_GridMenu.ResumeLayout(false);
            this.ms_main.ResumeLayout(false);
            this.ms_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_Data;
        private System.Windows.Forms.DataGridView dgv_Data;
        private System.Windows.Forms.ContextMenuStrip cntxms_GridMenu;
        private System.Windows.Forms.ToolStripMenuItem showAllDebitorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllCreditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllPaymentsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip ms_main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debitorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewDebitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openNewCreditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passNewPaymentToolStripMenuItem;
    }
}

