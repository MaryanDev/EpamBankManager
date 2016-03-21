using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BankManager.Code;

namespace LoanManager
{
    public partial class NewDebitor : Form
    {
        private string _connectionString;
        private SqlDebitorRepository _debitorRepo;

        public NewDebitor()
        {
            InitializeComponent();

            _connectionString = ConfigurationManager.ConnectionStrings["ConnectionToBank"].ConnectionString;
            _debitorRepo = new SqlDebitorRepository(_connectionString);
        }

        private void btn_addNewDebitor_Click(object sender, EventArgs e)
        {
            Debitor newDebitor = new Debitor
            {
                FirstName = txt_FirstName.Text,
                LastName = txt_LastName.Text,
                Address = txtAddress.Text,
                PhoneNumber = txt_PhoneNumber.Text,
                UserId = CurrentUser.Id
            };
            if(_debitorRepo.AddDebitor(newDebitor) != -1)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }
        }
    }
}
