using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insa_project
{
    public partial class form_search : Form
    {
        insa_basic insa_basic;
        OracleDBManager dBManager = new OracleDBManager();

        public form_search(insa_basic a)
        {
            InitializeComponent();
            insa_basic = a;
        }

        private void form_search_Load(object sender, EventArgs e)
        {
            dept_list_load();
            dataGridView1.Columns[0].HeaderText = "부서이름";
        }

        public void dept_list_load()
        {
            if (dBManager.GetConnection() == true)
            {
                OracleDataAdapter adapter = new OracleDataAdapter("select DEPT_NAME from thrm_dept_hwy", dBManager.Connection);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset, "list");
                DataTable dt = dataset.Tables["list"];
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            insa_basic.dept_combox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.Close();
        }
    }
}
