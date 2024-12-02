using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _045_Ramos_Pinera_F1db
{
    public partial class frmDelete : Form
    {
        OleDbConnection _conn;
        public frmDelete(OleDbConnection conn)
        {
            InitializeComponent();
            _conn = conn;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE from model where model_desc = @model";
           
            _conn.Open();
            OleDbCommand cmd = new OleDbCommand(query, _conn);
            cmd.Parameters.AddWithValue("@model", txtModel.Text);
            cmd.ExecuteNonQuery();
            _conn.Close();

            MessageBox.Show("DELETED");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtModel.Clear();
        }
    }
}
