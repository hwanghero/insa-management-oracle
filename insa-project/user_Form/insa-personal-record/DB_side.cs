using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insa_project.user_Form.insa_personal_record
{
    class DB_side : OracleDBManager
    {
        /*
         *  side form에 사원번호 불러오기.
         */

        public DataTable side_list_load()
        {
            DataTable date_table = new DataTable
            {
                Locale = CultureInfo.InvariantCulture
            };

            if (GetConnection() == true)
            {
                string query = "SELECT bas_empno, bas_name FROM THRM_BAS_KJH";
                try
                {
                    OracleDataAdapter adapter = new OracleDataAdapter(query, Connection);
                    adapter.Fill(date_table);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            return date_table;
        }
    }
}
