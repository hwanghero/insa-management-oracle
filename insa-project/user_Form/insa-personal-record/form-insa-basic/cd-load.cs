using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insa_project
{
    /*
     * 
     * 데이터베이스 뿌려주는값 코드화값 구별
     * 
     */

    class cd_load : OracleDBManager
    {
        public Dictionary<string, string> insa_basic_code(String cd_grpcd)
        {
            var dict = new Dictionary<string, string>();
            if (GetConnection() == true)
            {
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = Connection;
                    cmd.CommandText = "SELECT * FROM tieas_cd_hwy where CD_GRPCD='" + cd_grpcd+"'";

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dict.Add(reader["cd_codnms"].ToString(), reader["cd_code"].ToString());
                        }
                    }
                }
            }
            return dict;
        }

        public Dictionary<string, string> insa_basic_dept()
        {
            var dict = new Dictionary<string, string>();
            if (GetConnection() == true)
            {
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = Connection;
                    cmd.CommandText = "SELECT * FROM thrm_dept_hwy";

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dict.Add(reader["DEPT_NAME"].ToString(), reader["DEPT_CODE"].ToString());
                        }
                    }
                }
            }
            return dict;
        }
    }
}
