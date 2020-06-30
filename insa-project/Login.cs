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
    public partial class Login : Form
    {
        Main main;
        public Login()
        {
            InitializeComponent();
        }

        public Login(Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //OracleDBManager dbManager = new OracleDBManager();

            //Console.WriteLine("데이터 베이스 연결 중...");

            //if (dbManager.GetConnection() == false)
            //{
            //    Console.WriteLine("데이터 베이스 접속 연결 실패!!!!!");
            //    return;
            //}
            //Console.WriteLine("데이터 베이스 접속 성공!!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //성공
            main.login_event();
            this.Close();
            this.Dispose();
        }
    }
}
