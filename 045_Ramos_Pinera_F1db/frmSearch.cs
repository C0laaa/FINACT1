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
    public partial class frmSearch : Form
    {
        OleDbConnection _conn;
        public frmSearch(OleDbConnection conn)
        {
            InitializeComponent();
            _conn = conn;
        }

        private void frmSearch_Load(object sender, EventArgs e)
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
            cboBrand.ValueMember = "brandid";
            cboBrand.SelectedIndex = -1;
            

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtModel.Text.Length > 0)
            {
                DataTable dt = new DataTable();
                string query = "SELECT model_desc as MODEL, price as PRICE from model where model_desc like '%" + txtModel.Text + "%'";
                _conn.Open();
                OleDbDataAdapter adpater = new OleDbDataAdapter(query, _conn);
                adpater.Fill(dt);
                _conn.Close();

                grdResult.DataSource = dt;
            }
            if (txtLowPrice.Text.Length > 0)
            {
                int lowPrice = int.Parse(txtLowPrice.Text);
                int highPrice = int.Parse(txtHighPrice.Text);
                DataTable dt = new DataTable();
                string query = "SELECT model_desc as [MODEL], price as [PRICE] FROM model WHERE price BETWEEN @low AND @high";
                _conn.Open();
                OleDbCommand cmd = new OleDbCommand(query, _conn);
                cmd.Parameters.AddWithValue("@low", lowPrice);
                cmd.Parameters.AddWithValue("@", highPrice);
                OleDbDataAdapter adpater = new OleDbDataAdapter(cmd);
                adpater.Fill(dt);
                _conn.Close();

                grdResult.DataSource = dt;
            }
            if (cboBrand.SelectedIndex >= 0)
            {
                DataTable dt = new DataTable();
                string query = "SELECT model_desc as MODEL, price as PRICE from model where model.brandid = " + Convert.ToInt32(cboBrand.SelectedValue.ToString());
                _conn.Open();
                OleDbDataAdapter adpater = new OleDbDataAdapter(query, _conn);
                adpater.Fill(dt);
                _conn.Close();

                grdResult.DataSource = dt;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtModel.Clear();
            txtLowPrice.Clear();
            txtHighPrice.Clear();
            cboBrand.SelectedIndex = -1;
            DataTable dt = new DataTable();

            grdResult.DataSource = dt;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string query = "select * from model";
            DataTable dt = new DataTable();

            _conn.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, _conn);
            adapter.Fill(dt);
            _conn.Close();

            grdResult.DataSource= dt;
        }
    }
}
