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
    public partial class frmUpdate : Form
    {
        OleDbConnection _conn;
        public frmUpdate(OleDbConnection conn)
        {
            InitializeComponent();
            _conn = conn;
        }

        private void frmUpdate_Load(object sender, EventArgs e)
        {
            string query = "select * from brand";
            DataTable dt = new DataTable();
       
            _conn.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, _conn);
            adapter.Fill(dt);
            _conn.Close();

            string getValue;
            cboBrand.DataSource = dt;
            cboBrand.DisplayMember = "brand";
            getValue = cboBrand.SelectedIndex.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE model set model_desc = @model_desc, price = @price, brandid = @brand where model_desc = '" + txtModel.Text + "'";
          
            _conn.Open();
            OleDbCommand cmd = new OleDbCommand(query, _conn);
            cmd.Parameters.AddWithValue("@model_desc", txtNewModel.Text);
            cmd.Parameters.AddWithValue("@price", txtPrice.Text);
            cmd.Parameters.AddWithValue("brand", cboBrand.SelectedIndex.ToString());
            cmd.ExecuteNonQuery();
            _conn.Close();

            MessageBox.Show("MODEL UPDATED");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtModel.Clear();
            txtPrice.Clear();
            cboBrand.SelectedIndex = -1;
        }
    }
}
