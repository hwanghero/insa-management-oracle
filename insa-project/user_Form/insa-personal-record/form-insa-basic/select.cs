using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace insa_project
{
    class select : OracleDBManager
    {
        cd_load cd_load = new cd_load();

        public Object[] thrm_bas_select(String emp_no)
        {
            Object[] date = new Object[44];

            try
            {
                if (GetConnection() == true)
                {
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        cmd.Connection = Connection;
                        cmd.CommandText = "select * from thrm_bas_hwy where bas_empno = '" + emp_no + "'";

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                reader.GetValues(date);
                            }
                        }
                    }
                }
            }
            catch
            {

            }
            return date;
        }


        public void thrm_bas_select_code(String grpcd, String emp_no, ComboBox combo)
        {
            String emp_no_reader = "";
            using (OracleCommand cmd = new OracleCommand())
            {
                cmd.Connection = Connection;
                // 사원 어떤 코드인지 불러옴
                cmd.CommandText = "select * from thrm_bas_hwy where bas_empno = '" + emp_no + "'";
                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    // 어떤 코드인지 확인하고 string으로 변환 후 비교해서 값 추출.
                    if (reader.Read())
                    {
                        if (grpcd.Equals("BNK") && combo.Name.Equals("bank_combox"))
                        {
                            emp_no_reader = reader["BAS_ACC_BANK1"].ToString();
                        }
                        else if (grpcd.Equals("BNK") && combo.Name.Equals("bank2_combox"))
                        {
                            emp_no_reader = reader["BAS_ACC_BANK2"].ToString();
                        }
                        else
                        {
                            emp_no_reader = reader["BAS_" + grpcd].ToString();

                        }
                    }
                }
                Dictionary<string, string> store = null;


                if (grpcd.Equals("DEPT"))
                {
                    store = cd_load.insa_basic_dept();
                }
                else
                {
                    store = cd_load.insa_basic_code(grpcd);
                }

                foreach (KeyValuePair<string, string> kvp in store)
                {
                    if (kvp.Value.Equals(emp_no_reader))
                    {
                        combo.Text = kvp.Key;
                        break;
                    }
                }
            }
        }
    
        public DataTable get_Family(String sql)
        {
            if (GetConnection() == true)
            {
                OracleDataAdapter adapter = new OracleDataAdapter(sql, Connection);

                DataTable table = new DataTable { Locale = CultureInfo.InvariantCulture };
                adapter.Fill(table);
                return table;
            }
            return null;
        }
    }
}
