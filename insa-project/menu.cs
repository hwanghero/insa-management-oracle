using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insa_project
{
    class menu : OracleDBManager
    {
        /*
         * 
         *  --menu_rank 값이 없어서 저렇게 한건데 추가하고 되면 빼야함--
         *  menu_rank에 값이 지정이 안됨 그래서 null이 떴던거고
         *  수정 할려고하니까 오라클 서버가 안받아주네.
         * 
         */
        public void get_menu(TreeView treeview)
        {
            if (GetConnection() == true)
            {
                using (OracleCommand cmd = new OracleCommand())
                {
                    // 부모 따로, 자식 따로 불러와서 값 넣기
                    cmd.Connection = Connection;
                    cmd.CommandText = "select * from menu_hwy where menu_parent='root'";
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        Console.WriteLine("---parent node ---");
                        while (reader.Read())
                        {
                            Console.WriteLine(reader["menu_name"].ToString() + " : " + reader["menu_parent"]);

                            treeview.Nodes.Add(reader["menu_key"] as string, reader["menu_name"] as string);
                        }
                    }
                }
            }
        }

        public void child_menu(TreeView treeview, String parent)
        {
            if (GetConnection() == true)
            {
                using (OracleCommand cmd = new OracleCommand())
                {
                    // 부모 따로, 자식 따로 불러와서 값 넣기
                    cmd.Connection = Connection;
                    cmd.CommandText = "select * from menu_hwy where menu_parent='"+parent+"' order by menu_rank";

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        Console.WriteLine("---child node ---");
                        while (reader.Read())
                        {
                            Console.WriteLine(reader["menu_name"].ToString() + " : " + reader["menu_parent"]);

                            treeview.Nodes.Find(parent, true)[0].Nodes.Add(reader["menu_key"] as string, reader["menu_name"] as string);
                        }
                    }
                }
            }
        }
    }
}
