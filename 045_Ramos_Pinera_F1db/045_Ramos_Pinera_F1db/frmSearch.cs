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

            getValue = cboBrand.SelectedValue.ToString();

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
            else if (txtPrice1.Text.Length > 0)
            {
                DataTable dt = new DataTable();
                string query = "SELECT model_desc as MODEL, price as PRICE FROM model WHERE price BETWEEN '"+double.Parse(txtPrice1.Text)+"' AND '"+ double.Parse(txtPrice2.Text) + "' ";
                _conn.Open();
                OleDbDataAdapter adpater = new OleDbDataAdapter(query, _conn);
                adpater.Fill(dt);
                _conn.Close();

                grdResult.DataSource = dt;
            }
            else if (cboBrand.SelectedIndex > 0)
            {
                DataTable dt = new DataTable();
                string query = "SELECT model_desc as MODEL, price as PRICE from model where brandid like '%" + cboBrand.SelectedValue + "%'";
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
            txtPrice1.Clear();
            cboBrand.SelectedIndex = -1;
            DataTable dt = new DataTable();

            grdResult.DataSource = dt;
        }
    }
}
