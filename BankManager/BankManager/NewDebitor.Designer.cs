namespace BankManager
{
    partial class NewDebitor
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
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.txt_PhoneNumber = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.btn_addNewDebitor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(143, 26);
            this.txt_FirstName.MaxLength = 50;
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(169, 20);
            this.txt_FirstName.TabIndex = 0;
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.Location = new System.Drawing.Point(143, 106);
            this.txt_PhoneNumber.MaxLength = 12;
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.Size = new System.Drawing.Size(169, 20);
            this.txt_PhoneNumber.TabIndex = 1;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(143, 64);
            this.txt_LastName.MaxLength = 50;
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(169, 20);
            this.txt_LastName.TabIndex = 2;
            // 
            // btn_addNewDebitor
            // 
            this.btn_addNewDebitor.Location = new System.Drawing.Point(237, 140);
            this.btn_addNewDebitor.Name = "btn_addNewDebitor";
            this.btn_addNewDebitor.Size = new System.Drawing.Size(75, 23);
            this.btn_addNewDebitor.TabIndex = 3;
            this.btn_addNewDebitor.Text = "Add Debitor";
            this.btn_addNewDebitor.UseVisualStyleBackColor = true;
            this.btn_addNewDebitor.Click += new System.EventHandler(this.btn_addNewDebitor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Debitors First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Debitors Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Debitors Phone Number";
            // 
            // NewDebitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 172);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_addNewDebitor);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.txt_PhoneNumber);
            this.Controls.Add(this.txt_FirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewDebitor";
            this.Text = "NewDebitor";
            this.Load += new System.EventHandler(this.NewDebitor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.TextBox txt_PhoneNumber;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Button btn_addNewDebitor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}