using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace insa_project
{
    public partial class ipr_control : Form
    {
        static String mode = "";
        Form get_form;
        ipr_main ipr_main;
        ipr_side ipr_side;
        form_control from_control = new form_control();

        public ipr_control()
        {
            InitializeComponent();
        }

        // 모드 확인
        static public string get_mode()
        {
            return mode;
        }

        // 컨트롤을 사용할 폼들을 넣어주는곳
        public void add_ipr_control(Form b)
        {
            get_form = b;
        }

        // 메인에도 컨트롤을 보내줌
        public void add_ipr_main(ipr_main b)
        {
            ipr_main = b;
        }

        // 사이드에 컨트롤을 보내줌
        public void add_ipr_side(ipr_side b)
        {
            ipr_side = b;
        }

        private void Contorl_Load(object sender, EventArgs e)
        {
            choice_enable(false);
        }

        /// 컨트롤 버튼 입력을 누를 경우
        private void insert_button_Click_1(object sender, EventArgs e)
        {
            button_setting("insert");

            switch (ipr_main.ipr_getMode())
            {
                case "인사기본사항":
                    form_control_enabled((get_form as insa_basic), true);
                    // insert에 불필요한 정보 비활성화
                    (get_form as insa_basic).insert_button_false();
                    form_reset(get_form as insa_basic, true);
                    break;
                case "가족사항":
                    Console.WriteLine("insert");
                    break;
            }
        }

        /// 컨트롤 버튼 수정을 누를경우
        private void update_button_Click_1(object sender, EventArgs e)
        {
            button_setting("update");

            switch (ipr_main.ipr_getMode())
            {
                case "인사기본사항":
                    form_control_enabled((get_form as insa_basic), true);
                    break;
                case "가족사항":

                    break;
            }
        }

        /// 컨트롤 버튼 삭제를 누를경우
        private void delete_button_Click_1(object sender, EventArgs e)
        {
            button_setting("delete");

            switch (ipr_main.ipr_getMode())
            {
                case "인사기본사항":
                    form_control_enabled((get_form as insa_basic), false);
                    break;
            }
        }

        /// 컨트롤 적용 버튼을 누를경우
        private void apply_button_Click(object sender, EventArgs e)
        {
            Console.WriteLine(mode);
            switch (ipr_main.ipr_getMode())
            {
                case "인사기본사항":
                    switch (mode)
                    {
                        case "insert":
                            if (form_null_check(get_form as insa_basic)) (get_form as insa_basic).insert();
                            break;
                        case "update":
                            if (form_null_check(get_form as insa_basic)) (get_form as insa_basic).update();
                            break;
                        case "delete":
                            if (form_null_check(get_form as insa_basic)) (get_form as insa_basic).delete();
                            break;
                    }
                    break;
                case "가족사항":
                    switch (mode)
                    {
                        case "insert":
                            (get_form as family_education).gird_data_binding();
                            break;
                        case "update":
                            (get_form as family_education).gird_data_binding();
                            break;
                    }
                    break;
            }
            // 버튼 제어
            choice_enable(false);
            button_enable(true);
            // 사이드 업데이트 해주기
            ipr_side.side_list_load();
        }

        /// <summary>
        /// 폼안의 컨트롤 Enabled 수정하기
        /// <param name="form"></param>
        /// <param name="check"></param>
        /// <list type="number">
        /// <item><description><para><em>
        /// 사용할 폼
        /// </em></para></description></item>       
        /// <item><description><para><em>
        /// 전체 컨트롤 불러올지(false)
        /// 텍스트 컨트롤만 불러올지(true)
        /// </em></para></description></item>
        /// </list>
        /// </summary>
        public void form_control_enabled(Form form, Boolean check)
        {
            // 여기서 폼 설정 (전체 다 불러오는지, 텍스트박스만 불러오는지)
            from_control.get_control(form, true);
            // enabled
            from_control.control_enabled(check);
        }

        /// <summary>
        /// form 안의 컨트롤에 null값이 있는지 확인하는 함수
        /// </summary>
        /// <param name="from"></param>
        /// <returns></returns>
        public Boolean form_null_check(Form from)
        {
            from_control.get_control(from, false);
            if (from_control.control_nullcheck() != true)
            {
                from_control.get_control(from, true);
                from_control.control_enabled(false);
                button_enable(true);
                choice_enable(false);
                return true;
            }
            return false;
        }

        /// <summary>
        /// 컨트롤 입력, 수정, 삭제 제어 함수
        /// </summary>
        /// <param name="check"></param>
        public void button_enable(Boolean check)
        {
            insert_button.Enabled = check;
            update_button.Enabled = check;
            delete_button.Enabled = check;
        }

        /// <summary>
        /// 컨트롤 완료 취소 제어 함수
        /// </summary>
        /// <param name="check"></param>
        public void choice_enable(Boolean check)
        {
            apply_button.Enabled = check;
            cancel_button.Enabled = check;
        }

        /// <summary>
        /// 버튼의 상태를 설정해주는 함수 (입력, 수정, 삭제)
        /// </summary>
        /// <param name="click_mode"></param>
        public void button_setting(string click_mode)
        {
            mode = click_mode;
            button_enable(false);
            choice_enable(true);
        }

        private void insert_button_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "도움말";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(apply_button, "선택한 모드를 실행합니다.");
            this.toolTip1.SetToolTip(cancel_button, "선택한 모드를 취소합니다.");
            this.toolTip1.SetToolTip(this.insert_button, "입력모드로 변경합니다.");
            this.toolTip1.SetToolTip(this.update_button, "업데이트모드로 변경합니다.");
            this.toolTip1.SetToolTip(this.delete_button, "삭제모드로 변경합니다.");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(comboBox1.Text);
            switch (comboBox1.Text)
            {
                case "인사기본사항":
                    ipr_main.SetForm("insa_basic");
                    ipr_main.setFormsize();
                    break;
                case "가족사항":
                    ipr_main.SetForm("family_education");
                    ipr_main.setFormsize();
                    break;
                case "학력사항":
                    ipr_main.SetForm("form_career");
                    ipr_main.setFormsize();
                    break;
                case "상벌사항":
                    ipr_main.SetForm("form_point");
                    ipr_main.setFormsize();
                    break;
                case "경력사항":
                    ipr_main.SetForm("form_realcareer");
                    ipr_main.setFormsize();
                    break;
                case "자격면허":
                    ipr_main.SetForm("form_certificate");
                    ipr_main.setFormsize();
                    break;
                case "외국어":
                    ipr_main.SetForm("form_language");
                    ipr_main.setFormsize();
                    break;

            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            button_enable(true);
            choice_enable(false);

            switch (ipr_main.ipr_getMode())
            {
                case "인사기본사항":
                    form_reset(get_form as insa_basic, false);
                    break;
            }
        }
        /// <summary>
        /// 폼 안의 컨트롤을 전부다 null값으로 만드는 함수
        /// </summary>
        /// <param name="form"></param>
        /// <param name="enabled"></param>
        public void form_reset(Form form, Boolean enabled)
        {
            from_control.get_control(form, true);
            from_control.control_enabled(enabled);
            from_control.get_control(form, false);
            from_control.control_reset();
        }
    }
}
