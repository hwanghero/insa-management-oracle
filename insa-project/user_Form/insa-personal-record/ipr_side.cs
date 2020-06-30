using Oracle.ManagedDataAccess.Client;
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
    public partial class ipr_side : Form
    {
        public static String ipr_empno { get; set; }
        OracleDBManager dBManager = new OracleDBManager();
        Form get_form;

        select select = new select();

        public ipr_side()
        {
            InitializeComponent();
        }

        public void add_ipr_side(Form b)
        {
            get_form = b;
        }

        public void Setsize(int a)
        {
            this.Size = new Size(261, a);
            dataGridView1.Size = new Size(242, a - 80);
        }

        private void ipr_side_Load(object sender, EventArgs e)
        {
            Gridview_on();
        }

        public void Gridview_on()
        {
            side_list_load();
            dataGridView1.Columns[0].HeaderText = "사원번호";
            dataGridView1.Columns[1].HeaderText = "이름";
        }

        // 어댑터 사용해서 바인딩하기.
        public void side_list_load()
        {
            if (dBManager.GetConnection() == true)
            {
                OracleDataAdapter adapter = new OracleDataAdapter("select bas_empno, bas_name from thrm_bas_hwy", dBManager.Connection);
                DataTable table = new DataTable
                {
                    Locale = CultureInfo.InvariantCulture
                };
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            ipr_empno = textBox2.Text;

            if (ipr_control.get_mode().Equals("update"))
            {
                if (get_form.GetType() == typeof(insa_basic))
                {
                    Console.WriteLine("insa_basic 에서 cell click");
                    (get_form as insa_basic).e_no_box.Text = ipr_empno;
                    Object[] a = select.thrm_bas_select(ipr_empno);

                    (get_form as insa_basic).rrn_box.Text = a[1].ToString();
                    (get_form as insa_basic).kor_name_box.Text = a[2].ToString();
                    (get_form as insa_basic).chn_name_box.Text = a[3].ToString();
                    (get_form as insa_basic).eng_name_box.Text = a[4].ToString();
                    (get_form as insa_basic).sexxbox.Text = a[5].ToString();
                    (get_form as insa_basic).zip_box.Text = a[6].ToString();
                    (get_form as insa_basic).address_box.Text = a[7].ToString();
                    (get_form as insa_basic).residence_box.Text = a[8].ToString();
                    (get_form as insa_basic).phone_box.Text = a[9].ToString();
                    (get_form as insa_basic).home_box.Text = a[10].ToString();
                    (get_form as insa_basic).email1_box.Text = a[11].ToString();
                    (get_form as insa_basic).marry_box.Text = a[15].ToString();
                    select.thrm_bas_select_code("BNK", ipr_empno, (get_form as insa_basic).bank_combox);
                    (get_form as insa_basic).bank_master_box.Text = a[17].ToString();
                    (get_form as insa_basic).bank_number_box.Text = a[18].ToString();
                    select.thrm_bas_select_code("BNK", ipr_empno, (get_form as insa_basic).bank2_combox);
                    (get_form as insa_basic).bank_master_box2.Text = a[20].ToString();
                    (get_form as insa_basic).bank_number_box2.Text = a[21].ToString();
                    (get_form as insa_basic).mil_ok_box.Text = a[12].ToString();
                    (get_form as insa_basic).mil_catagory_box.Text = a[13].ToString();
                    (get_form as insa_basic).mil_rank_box.Text = a[14].ToString();
                    (get_form as insa_basic).note_box.Text = a[36].ToString();
                    (get_form as insa_basic).contract_box.Text = a[22].ToString();
                    (get_form as insa_basic).newbie_check_box.Text = a[23].ToString();
                    (get_form as insa_basic).newbie_month_box.Text = a[24].ToString();
                    (get_form as insa_basic).slave_start.Value = DateTime.ParseExact(a[25].ToString() as String, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    (get_form as insa_basic).slave_end.Value = DateTime.ParseExact(a[26].ToString() as String, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    (get_form as insa_basic).join_box.Value = DateTime.ParseExact(a[27].ToString() as String, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    (get_form as insa_basic).goodbye_box.Value = DateTime.ParseExact(a[28].ToString() as String, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    (get_form as insa_basic).state_box.Text = a[31].ToString();
                    select.thrm_bas_select_code("STS", ipr_empno, (get_form as insa_basic).sts_combox);
                    select.thrm_bas_select_code("POS", ipr_empno, (get_form as insa_basic).rank_combox);
                    select.thrm_bas_select_code("DUT", ipr_empno, (get_form as insa_basic).dut_combox);
                    select.thrm_bas_select_code("DEPT", ipr_empno, (get_form as insa_basic).dept_combox);
                    (get_form as insa_basic).now_rank_box.Value = DateTime.ParseExact(a[37].ToString() as String, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    (get_form as insa_basic).now_spot_box.Value = DateTime.ParseExact(a[38].ToString() as String, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    (get_form as insa_basic).now_department_box.Value = DateTime.ParseExact(a[39].ToString() as String, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    (get_form as insa_basic).now_newbie_box.Value = DateTime.ParseExact(a[40].ToString() as String, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                }
            }
        }
    }
}
