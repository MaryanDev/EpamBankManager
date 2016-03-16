namespace BankManager
{
    partial class OpenCredit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDebitors = new System.Windows.Forms.DataGridView();
            this.dtpCreditOpenDate = new System.Windows.Forms.DateTimePicker();
            this.txtCreditAmount = new System.Windows.Forms.TextBox();
            this.txtCreditBalance = new System.Windows.Forms.TextBox();
            this.txtCreditState = new System.Windows.Forms.TextBox();
            this.btnOpenNewCredit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebitors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Debitors";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "OpenDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "State";
            // 
            // dgvDebitors
            // 
            this.dgvDebitors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDebitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDebitors.Location = new System.Drawing.Point(125, 12);
            this.dgvDebitors.Name = "dgvDebitors";
            this.dgvDebitors.Size = new System.Drawing.Size(406, 113);
            this.dgvDebitors.TabIndex = 5;
            this.dgvDebitors.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDebitors_CellEnter);
            // 
            // dtpCreditOpenDate
            // 
            this.dtpCreditOpenDate.Location = new System.Drawing.Point(125, 143);
            this.dtpCreditOpenDate.Name = "dtpCreditOpenDate";
            this.dtpCreditOpenDate.Size = new System.Drawing.Size(200, 20);
            this.dtpCreditOpenDate.TabIndex = 6;
            // 
            // txtCreditAmount
            // 
            this.txtCreditAmount.Location = new System.Drawing.Point(125, 180);
            this.txtCreditAmount.MaxLength = 12;
            this.txtCreditAmount.Name = "txtCreditAmount";
            this.txtCreditAmount.Size = new System.Drawing.Size(147, 20);
            this.txtCreditAmount.TabIndex = 7;
            // 
            // txtCreditBalance
            // 
            this.txtCreditBalance.Location = new System.Drawing.Point(125, 215);
            this.txtCreditBalance.Name = "txtCreditBalance";
            this.txtCreditBalance.ReadOnly = true;
            this.txtCreditBalance.Size = new System.Drawing.Size(147, 20);
            this.txtCreditBalance.TabIndex = 8;
            // 
            // txtCreditState
            // 
            this.txtCreditState.Location = new System.Drawing.Point(125, 250);
            this.txtCreditState.Name = "txtCreditState";
            this.txtCreditState.ReadOnly = true;
            this.txtCreditState.Size = new System.Drawing.Size(147, 20);
            this.txtCreditState.TabIndex = 9;
            // 
            // btnOpenNewCredit
            // 
            this.btnOpenNewCredit.Location = new System.Drawing.Point(431, 270);
            this.btnOpenNewCredit.Name = "btnOpenNewCredit";
            this.btnOpenNewCredit.Size = new System.Drawing.Size(100, 27);
            this.btnOpenNewCredit.TabIndex = 10;
            this.btnOpenNewCredit.Text = "Open Credit";
            this.btnOpenNewCredit.UseVisualStyleBackColor = true;
            this.btnOpenNewCredit.Click += new System.EventHandler(this.btnOpenNewCredit_Click);
            // 
            // OpenCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 309);
            this.Controls.Add(this.btnOpenNewCredit);
            this.Controls.Add(this.txtCreditState);
            this.Controls.Add(this.txtCreditBalance);
            this.Controls.Add(this.txtCreditAmount);
            this.Controls.Add(this.dtpCreditOpenDate);
            this.Controls.Add(this.dgvDebitors);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OpenCredit";
            this.Text = "OpenCredit";
            this.Load += new System.EventHandler(this.OpenCredit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebitors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDebitors;
        private System.Windows.Forms.DateTimePicker dtpCreditOpenDate;
        private System.Windows.Forms.TextBox txtCreditAmount;
        private System.Windows.Forms.TextBox txtCreditBalance;
        private System.Windows.Forms.TextBox txtCreditState;
        private System.Windows.Forms.Button btnOpenNewCredit;
    }
}