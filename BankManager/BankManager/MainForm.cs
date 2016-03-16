using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManager
{
    public partial class MainForm : Form
    {
        private string _connectionString;
        private SqlDebitorRepository _debitorRepo;
        private SqlCreditRepositary _creditRepo;

        //Enum which is represent what data is in GridView in current moment (debitors by default)
        private DataInGrid _dataInGrid;

        public MainForm()
        {
            InitializeComponent();

            _connectionString = ConfigurationManager.ConnectionStrings["ConnectionToBank"].ConnectionString;
            _debitorRepo = new SqlDebitorRepository(_connectionString);
            _creditRepo = new SqlCreditRepositary(_connectionString);

            dgv_Data.RowHeadersVisible = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Default table is debitors so we show it when the form loads
            dgv_Data.DataSource = _debitorRepo.GetDebitors();
            _dataInGrid = DataInGrid.Debitors;
            //dgv_Data.DataSource = this._creditRepo.GetCredits();
        
        }

        private void dgv_Data_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Double click on some debitor causes loading all credits fro that debitor
            if (_dataInGrid == DataInGrid.Debitors)
            {
                int debitorId = Convert.ToInt32(dgv_Data.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                dgv_Data.DataSource = _creditRepo.GetCredits(debitorId);
                _dataInGrid = DataInGrid.CreditsForDebitor;
            }
        }

        private void dgv_Data_MouseClick(object sender, MouseEventArgs e)
        {
            //Right click on gridView - and we get the context menu
            if(e.Button == MouseButtons.Right)
            {
                cntxms_GridMenu.Show(dgv_Data, new Point(e.X, e.Y));
            }
        }

        private void showAllDebitorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //If there are debitors in grid view there is no sense to load them again
            if(_dataInGrid == DataInGrid.Debitors)
            {
                return;
            }
            else
            {
                dgv_Data.DataSource = _debitorRepo.GetDebitors();
                _dataInGrid = DataInGrid.Debitors;
            }
        }

        private void showAllCreditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //If there are credits in grid view there is no sense to load them again
            if (_dataInGrid == DataInGrid.AllCredits)
            {
                return;
            }
            else
            {
                dgv_Data.DataSource = _creditRepo.GetCredits();
                _dataInGrid = DataInGrid.AllCredits;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult closeResult = MessageBox.Show("Are you sure want to close te application?", "BankManager", MessageBoxButtons.OKCancel);
            if(closeResult == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addNewDebitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDebitor newDebitor = new NewDebitor();
            if(newDebitor.ShowDialog() == DialogResult.OK)
            {
                dgv_Data.DataSource = _debitorRepo.GetDebitors();
                _dataInGrid = DataInGrid.Debitors;
            }
            else
            {
                MessageBox.Show("New debitor was not added");
            }
        }

        private void openNewCreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenCredit openCredit = new OpenCredit();

            if(openCredit.ShowDialog()== DialogResult.OK)
            {
                dgv_Data.DataSource = _creditRepo.GetCredits();
                _dataInGrid = DataInGrid.AllCredits;
            }
            else
            {
                MessageBox.Show("New credit was not opened");
            }
        }
    }

    public enum DataInGrid
    {
        Debitors,
        AllCredits,
        CreditsForDebitor,
        Payments
    }
}
