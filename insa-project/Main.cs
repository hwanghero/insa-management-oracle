using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace insa_project
{
    public partial class Main : Form
    {
        menu menu = new menu();
        ipr_control ipr_control = new ipr_control();
        ipr_main ipr_main;

        bool On;
        Point Pos;

        Form saveform;

        // 폼 여러개 추가
        public void add_form(Form form)
        {
            if (saveform != null)
            {
                saveform.Close();
            }

            form.TopLevel = false;
            form.Parent = this.main_panel;
            form.Show();
            saveform = form;
        }

        // 컨트롤 패널 추가
        public void control_add(Form addform)
        {
            ipr_control.TopLevel = false;
            this.Controls.Add(addform);
            ipr_control.Parent = this.control_panel;
            ipr_control.ControlBox = false;
            ipr_control.Show();
        }

        public Main()
        {
            InitializeComponent();
            MouseDown += (o, e) => { if (e.Button == MouseButtons.Left) { On = true; Pos = e.Location; } };
            MouseMove += (o, e) => { if (On) Location = new Point(Location.X + (e.X - Pos.X), Location.Y + (e.Y - Pos.Y)); };
            MouseUp += (o, e) => { if (e.Button == MouseButtons.Left) { On = false; Pos = e.Location; } };
            ipr_main = new ipr_main(ipr_control);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Login login_form = new Login(this);
            login_form.Show();
            this.Enabled = false;
            this.Opacity = .9;
        }

        public void login_event()
        {
            this.Enabled = true;
            this.Opacity = 1.0;
            menu.get_menu(treeView1);
            menu.child_menu(treeView1, "인사기록관리");
        }

        // 메뉴 체계 수정 다시, 배열로/

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            ipr_main.ipr_setMode(e.Node.Text);
            if (e.Node.Parent != null && e.Node.Parent.GetType() == typeof(TreeNode))
            {
                if (e.Node.Parent.Text.Equals("인사기록관리"))
                {
                    if (!e.Node.Text.Equals("인사기록관리"))
                    {
                        add_form(ipr_main = new ipr_main(ipr_control));
                        if (ipr_main != null)
                        {
                            ipr_main.add_ipr_main(this);
                            control_add(ipr_control);
                            ipr_main.ipr_check();
                            size_update();
                        }
                    }
                }
            }
        }

        public void size_update()
        {
            this.Size = ipr_main.ipr_getsize();
        }
    }
}
