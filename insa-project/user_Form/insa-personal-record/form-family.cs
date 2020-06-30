 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insa_project
{
    public partial class family_education : Form
    {
        cd_load cd_load = new cd_load();
        insert insert = new insert();
        select select = new select();
        update update = new update();
        DataTable dataTable = new DataTable();


        public family_education()
        {
            InitializeComponent();

        }


        private void family_education_Load(object sender, EventArgs e)
        {
            dataTable = select.get_Family("select FAM_REL, FAM_NAME, FAM_BTH, FAM_ITG from thrm_fam_hwy");
            dataTable.Columns.Add("CHECK", typeof(string));
            dataGridView2.DataSource = dataTable.DefaultView;
        }

        /// <summary>
        /// 이게 insert인지 update인지 delete인지 확인 하고 데이터베이스에 넣어주자고
        /// </summary>
        public void gird_data_binding()
        {
            foreach (DataRow dtRow in dataTable.Rows)
            {
                String rel = dtRow["FAM_REL"].ToString();
                String name = dtRow["FAM_NAME"].ToString();
                String bth = dtRow["FAM_BTH"].ToString();
                String itg = dtRow["FAM_ITG"].ToString();

                if (dtRow["CHECK"].ToString().Equals("Insert"))
                {
                    insert.thrm_fam_add("1", rel, name, bth, itg, "20200624", "1", "2");
                    Console.WriteLine("insert");
                }

                if (dtRow["CHECK"].ToString().Equals("Update"))
                {
                    update.thrm_fam_update("1", rel, name, bth, itg);
                    MessageBox.Show("update");
                }
            }
        }

        // 셀 값이 바뀌면 update 넣어줌.
        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
            if (!row.Cells["CHECK"].Value.Equals("Insert"))
            {
                row.Cells["CHECK"].Value = "Update";
                row.DefaultCellStyle.BackColor = Color.Aqua;
            }
        }

        // 추가되면 insert 해준다 ( index를 -1을 해주는 이유는 생성 후의 셀에 값을 넣더라고 )
        private void dataGridView2_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            DataGridViewRow row = dataGridView2.Rows[e.Row.Index - 1];
            row.Cells["CHECK"].Value = "Insert";
            row.DefaultCellStyle.BackColor = Color.Green;
        }
    }
}
