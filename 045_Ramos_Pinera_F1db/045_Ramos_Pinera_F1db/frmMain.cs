using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _045_Ramos_Pinera_F1db
{
    public partial class frmMain : Form
    {
        string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Z:/045_Ramos/dbPhone.mdb";
        OleDbConnection conn;
        public frmMain()
        {
            InitializeComponent();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(connStr);
            frmAdd frm = new frmAdd(conn);
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(connStr);
            frmDelete frm = new frmDelete(conn);
            frm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(connStr);
            frmUpdate frm = new frmUpdate(conn);
            frm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(connStr);
            frmSearch frm = new frmSearch(conn);
            frm.ShowDialog();
        }
    }
}
