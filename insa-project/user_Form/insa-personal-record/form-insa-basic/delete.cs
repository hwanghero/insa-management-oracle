using Oracle.ManagedDataAccess.Client;
using System;

namespace insa_project
{
    class delete : OracleDBManager
    {
        public int thrm_bas_delete(String empno)
        {
            int check = 1;
            try
            {
                if (GetConnection() == true)
                {
                    using (OracleCommand comm = new OracleCommand())
                    {
                        comm.Connection = Connection;
                        comm.CommandText = @"delete from thrm_bas_hwy where bas_empno='" + empno + "'";
                        var a = comm.ExecuteNonQuery();
                        check = 0;
                        Console.WriteLine(comm.CommandText);
                        Console.WriteLine(a + " row deleted");
                    }
                }
            }
            catch (Exception a)
            {
                Console.WriteLine(a);
            }
            return check;
        }
    }
}
