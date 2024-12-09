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
    public partial class frmAdd : Form
    {
        OleDbConnection _conn;
        public frmAdd(OleDbConnection conn)
        {
            InitializeComponent();
            _conn = conn;
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            string query = "select * from brand";
            DataTable dt = new DataTable();

            _conn.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, _conn);
            adapter.Fill(dt);
            _conn.Close();


            string getValue;
            cbobrand.DataSource = dt;
            cbobrand.DisplayMember = "brand";
            cbobrand.ValueMember = "brandid";

            getValue = cbobrand.SelectedValue.ToString();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "INSERT into model(model_desc, price, brandid) values(@model, @price, @brandid)";
            _conn.Open();
            OleDbCommand cmd = new OleDbCommand(query, _conn);

            cmd.Parameters.AddWithValue("@model", txtmodel.Text);
            cmd.Parameters.AddWithValue("@price", txtprice.Text);
            cmd.Parameters.AddWithValue("@brandid", cbobrand.SelectedIndex + 1);
            cmd.ExecuteNonQuery();
            _conn.Close();

            MessageBox.Show("INPUT ADDED");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtmodel.Clear();
            txtprice.Clear();
            cbobrand.SelectedIndex = -1;
           
        }
    }
}
