using System;
using System.Drawing;
using System.Windows.Forms;

namespace insa_project
{
    public partial class ipr_main : Form
    {
        static String mode;

        // 사이즈 부분
        int a, b; // 사이즈 get, set
        int treeview_width = 150 + 16; // +16
        int side_width = 261;
        int control_height = 55 + 40; // +40
        int form_width;
        int form_height;

        // side는 여기서 선언
        ipr_control ipr_control;
        ipr_side ipr_side = new ipr_side();
        Form saveform;

        // main form 사이즈 조절을 위해 불러와야함.
        Main main2;

        // control 객체를 생성을 Main에서 했으니까 참조 받아야함.
        public ipr_main(ipr_control a)
        {
            InitializeComponent();
            ipr_control = a;
        }

        public void add_ipr_main(Main a)
        {
            main2 = a;
        }

        public void add_form(Form form)
        {
            if (saveform != null)
            {
                saveform.Close();
            }
            ipr_control.add_ipr_main(this);
            ipr_control.add_ipr_control(form);
            ipr_control.add_ipr_side(ipr_side);
            ipr_side.add_ipr_side(form);
            form.TopLevel = false;
            form.Parent = this.main;
            form.Show();
            saveform = form;
            
        }

        private void ipr_main_Load(object sender, EventArgs e)
        {

        }

        public void ipr_check()
        {
            if (ipr_getMode() != null)
            {
                // 이건 배열 사용해서 알아서 찾게끔 해야함.
                // 쌉노가다 수정해야하긴하는데;

                if (ipr_getMode().Equals("인사기본사항"))
                {
                    SetForm("insa_basic");
                }
                else if (ipr_getMode().Equals("가족사항"))
                {
                    SetForm("family_education");
                }
                else if (ipr_getMode().Equals("학력사항"))
                {
                    SetForm("form_career");
                }
                else if (ipr_getMode().Equals("상벌사항"))
                {
                    SetForm("form_point");
                }
                else if (ipr_getMode().Equals("경력사항"))
                {
                    SetForm("form_realcareer");
                }
                else if (ipr_getMode().Equals("외국어"))
                {
                    SetForm("form_language");
                }
                else if (ipr_getMode().Equals("자격면허"))
                {
                    SetForm("form_certificate");
                }
                else // 기본값
                {
                    form_width = 1000;
                    form_height = 800;
                }
                setFormsize();
                side_add();
            }
        }

        // 사이즈 부분
        public void form_size_load(Form form)
        {
            form_width = form.Width;
            form_height = form.Height;
        }

        public void setFormsize()
        {
            main.Size = new Size(form_width, form_height); // 메인 패널
            side.Size = new Size(261, form_height);

            this.Size = new Size(form_width + side_width, form_height); // 메인 폼 

            ipr_setsize(form_width + side_width + treeview_width, form_height + control_height); // 전체폼 사이즈 설정

            Point curLoc = side.Location, mainLoc = main.Location; ; // 사이드 패널 위치, 메인 패널 위치
            curLoc.X = mainLoc.X + form_width; // 사이드패널 = 메인폼 + 폼넓이
            this.side.Location = curLoc; // 이동

            main2.size_update();
        }

        // 사이드 사이즈
        public void side_add()
        {
            ipr_side.Setsize(form_height); // 사이드 높이 설정
            ipr_side.TopLevel = false;
            this.Controls.Add(ipr_side);
            ipr_side.Parent = this.side;
            ipr_side.ControlBox = false;
            ipr_side.Show();
        }

        public void ipr_setsize(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public Size ipr_getsize()
        {
            return new Size(a, b);
        }

        static public void ipr_setMode(String set_mode)
        {
            mode = set_mode;
        }

        static public String ipr_getMode()
        {
            return mode;
        }

        private Form GetAssemblyForm(string strFormName)
        {
            Form f = null;
            foreach (Type t in System.Reflection.Assembly.GetExecutingAssembly().GetTypes())
            {
                if (t.Name == strFormName)
                {
                    object o = Activator.CreateInstance(t);
                    f = o as Form;
                }
            }
            return f;
        }

        // 폼 띄우기.
        public void SetForm(String formname)
        {
            Form form = GetAssemblyForm(formname);
            form_size_load(form);
            add_form(form);

            // 여기에서 바로 쿼리값 불러오게해야함
            if (ipr_side.ipr_empno != null)
            {
                Console.WriteLine("not null");
            }
            else
            {
                Console.WriteLine("null");
            }
        }
    }
}
