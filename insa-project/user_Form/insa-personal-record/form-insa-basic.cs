using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace insa_project
{
    public partial class insa_basic : Form
    {
        String nowtime = DateTime.Now.ToString("yyyyMMdd");
        insert insa_basic_insert = new insert();
        update insa_basic_update = new update();
        delete insa_basic_delete = new delete();
        form_control from_control = new form_control();

        Dictionary<ComboBox, string> code_control = new Dictionary<ComboBox, string>();
        cd_load cd_load = new cd_load();

        public insa_basic()
        {
            InitializeComponent();
        }

        private void insa_basic_Load(object sender, EventArgs es)
        {
            // 여기서 폼 설정 (현재 폼, 전체를 불러오는지, enable만 불러오는지)
            from_control.get_control(this, true);
            // enabled
            from_control.control_enabled(false);

            if (ipr_side.ipr_empno != null)
            {
                // 선택한 사원이 있을경우.
            }

            // 컨트롤 넣어줌,
            code_control.Add(rank_combox, "POS");
            code_control.Add(sts_combox, "STS");
            code_control.Add(dut_combox, "DUT");
            code_control.Add(mil_catagory_box, "MIL");
            code_control.Add(bank_combox, "BNK");
            code_control.Add(bank2_combox, "BNK");

            // 직급
            foreach (String a in cd_load.insa_basic_code("POS").Keys) rank_combox.Items.Add(a);
            // 직위
            foreach (String a in cd_load.insa_basic_code("DUT").Keys) dut_combox.Items.Add(a);
            // 부서
            foreach (String a in cd_load.insa_basic_dept().Keys) dept_combox.Items.Add(a);
            // 신분
            foreach (String a in cd_load.insa_basic_code("STS").Keys) sts_combox.Items.Add(a);
            // 군별
            foreach (String a in cd_load.insa_basic_code("MIL").Keys) mil_catagory_box.Items.Add(a);
            // 은행1,2
            foreach (String a in cd_load.insa_basic_code("BNK").Keys) { bank_combox.Items.Add(a); bank2_combox.Items.Add(a); }
        }

        List<String> save_keys = new List<String>();
        string dept_keys = string.Empty;
        public void get_keys()
        {
            // 코드를 쿼리에 넣어야함
            foreach (KeyValuePair<ComboBox, string> a in code_control)
            {
                if (cd_load.insa_basic_code(a.Value).TryGetValue(a.Key.Text, out string values))
                {
                    Console.WriteLine("save_keys add : " + a.Value + ": " + values);
                    save_keys.Add(values);
                }
                else
                {
                    save_keys.Add("null");
                }
            }

            foreach (KeyValuePair<string, string> a in cd_load.insa_basic_dept())
            {
                if (cd_load.insa_basic_dept().TryGetValue(dept_combox.Text, out string values))
                {
                    dept_keys = values;
                    break;
                }
            }
        }
        

        public void insert()
        {
            // 코드를 쿼리에 넣어야함
            get_keys();

            /*
             * 코드화 시킨 배열 인덱스
             *  POS 0
             *  STS 1
             *  DUT 2
             *  MIL 3
             *  BNK 4
             *  BNK 5
             */
            try
            {
                int nmbox = Convert.ToInt32(newbie_month_box.Text);
                if (insa_basic_insert.thrm_bas_add(e_no_box.Text, rrn_box.Text, kor_name_box.Text, chn_name_box.Text, eng_name_box.Text,
                    sexxbox.Text, zip_box.Text, address_box.Text, residence_box.Text, phone_box.Text, home_box.Text, email1_box.Text,
                    mil_ok_box.Text, save_keys[3], mil_rank_box.Text, marry_box.Text, save_keys[4], bank_master_box.Text,
                    bank_number_box.Text, save_keys[5], bank_master_box2.Text, bank_number_box2.Text, contract_box.Text,
                    newbie_check_box.Text, nmbox, slave_start.Value.ToString("yyyyMMdd"), slave_end.Value.ToString("yyyyMMdd"),
                    join_box.Value.ToString("yyyyMMdd"), goodbye_box.Value.ToString("yyyyMMdd"), "", "", state_box.Text, save_keys[1], save_keys[0], save_keys[2],
                    dept_keys, note_box.Text, now_rank_box.Value.ToString("yyyyMMdd"), now_spot_box.Value.ToString("yyyyMMdd"), now_department_box.Value.ToString("yyyyMMdd"),
                    now_newbie_box.Value.ToString("yyyyMMdd"), nowtime, "A", "userid") == 0)
                {
                    MessageBox.Show("입력이 완료되었습니다.");
                    from_control.get_control(this, false);
                    from_control.control_reset();
                }
            }

            catch (Exception a)
            {
                MessageBox.Show("입력에 실패하였습니다.\n\n" + a);
            }
        }

        public void update()
        {
            // 코드를 쿼리에 넣어야함
            get_keys();
            try
            {
                int nmbox = Convert.ToInt32(newbie_month_box.Text);
                if (insa_basic_update.thrm_bas_update(e_no_box.Text, rrn_box.Text, kor_name_box.Text, chn_name_box.Text, eng_name_box.Text,
                    sexxbox.Text, zip_box.Text, address_box.Text, residence_box.Text, phone_box.Text, home_box.Text, email1_box.Text,
                    mil_ok_box.Text, save_keys[3], mil_rank_box.Text, marry_box.Text, save_keys[4], bank_master_box.Text,
                    bank_number_box.Text, save_keys[5], bank_master_box2.Text, bank_number_box2.Text, contract_box.Text,
                    newbie_check_box.Text, nmbox, slave_start.Value.ToString("yyyyMMdd"), slave_end.Value.ToString("yyyyMMdd"),
                    join_box.Value.ToString("yyyyMMdd"), goodbye_box.Value.ToString("yyyyMMdd"), "", "", state_box.Text, save_keys[1], save_keys[0], save_keys[2],
                    dept_keys, note_box.Text, now_rank_box.Value.ToString("yyyyMMdd"), now_spot_box.Value.ToString("yyyyMMdd"), now_department_box.Value.ToString("yyyyMMdd"),
                    now_newbie_box.Value.ToString("yyyyMMdd"), nowtime, "A", "userid") == 0)
                {
                    MessageBox.Show("수정이 완료되었습니다.");
                    from_control.get_control(this, false);
                    from_control.control_reset();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("입력에 실패하였습니다.\n\n" + a);
            }
        }

        public void delete()
        {
            try
            {
                insa_basic_delete.thrm_bas_delete(e_no_box.Text);
            }
            catch (Exception a)
            {
                MessageBox.Show("삭제에 실패하였습니다.\n\n" + a);
            }
        }
        // 우편번호 찾기 누를경우
        private void button1_Click(object sender, EventArgs e)
        {
            form_insa_basic_address form_address = new form_insa_basic_address(this);
            form_address.Show();
        }

        private void dept_search_Click(object sender, EventArgs e)
        {
            form_search form_search = new form_search(this);
            form_search.Show();
        }

        private void sexxbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sexxbox.Text.Equals("여"))
            {
                mil_group.Enabled = false;
            }
            else
            {
                mil_group.Enabled = true;
            }
        }

        /*
         *  신규사원 일경우 불필요한 정보 비활성화
         */
        public void insert_button_false()
        {
            goodtime_box.Enabled = false;
            badtime_box.Enabled = false;
            goodbye_box.Enabled = false;
            slave_end.Enabled = false;
            mil_group.Enabled = false;
        }
    }
}