using Oracle.ManagedDataAccess.Client;
using System;

namespace insa_project
{
    class update : OracleDBManager
    {
        public int thrm_bas_update(String empno, String resno, String name, String cname, String ename, String fix, String zip, String addr, String residence, String hdpno, String telno, String email, String mil_sta, String mil_mil, String mil_rnk, String mar,
            String acc_bank1, String acc_name1, String acc_no1, String acc_bank2, String acc_name2, String acc_no2, String cont, String intern, int intern_no, String emp_sdate, String emp_edate, String entdate,
            String resdate, String levdate, String reidate, String wsta, String sts, String pos, String dut, String dept, String rmk, String pos_dt, String dut_dt, String dept_dt, String intern_dt, String datasys1, String datasys2, String datasys3)
        {
            int check = 1;
            try
            {
                if (GetConnection() == true)
                {
                    using (OracleCommand comm = new OracleCommand())
                    {
                        comm.Connection = Connection;
                        comm.CommandText = @"update thrm_bas_hwy set 
                                                bas_resno='" + resno +
                                                "',bas_name='" + name +
                                                "',bas_cname='" + cname +
                                                 "',bas_ename='" + ename +
                                                  "',bas_fix='" + fix +
                                                   "',bas_zip='" + zip +
                                                    "',bas_addr='" + addr +
                                                     "',bas_residence='" + residence +
                                                      "',bas_hdpno='" + hdpno +
                                                       "',bas_telno='" + telno +
                                                        "',bas_email='" + email +
                                                         "',bas_mil_sta='" + mil_sta +
                                                          "',bas_mil_mil='" + mil_mil +
                                                           "',bas_mil_rnk='" + mil_rnk +
                                                            "',bas_mar='" + mar +
                                                             "',bas_acc_bank1='" + acc_bank1 +
                                                              "',bas_acc_name1='" + acc_name1 +
                                                               "',bas_acc_no1='" + acc_no1 +
                                                                "',bas_acc_bank2='" + acc_bank2 +
                                                                 "',bas_acc_name2='" + acc_name2 +
                                                                  "',bas_acc_no2='" + acc_no2 +
                                                                   "',bas_cont='" + cont +
                                                                    "',bas_intern='" + intern +
                                                                     "',bas_intern_no='" + intern_no +
                                                                      "',bas_emp_sdate='" + emp_sdate +
                                                                       "',bas_emp_edate='" + emp_edate +
                                                                        "',bas_entdate='" + entdate +
                                                                         "',bas_resdate='" + resdate +
                                                                          "',bas_levdate='" + levdate +
                                                                           "',bas_reidate='" + reidate +
                                                                            "',bas_wsta='" + wsta +
                                                                             "',bas_sts='" + sts +
                                                                             "',bas_pos='" + pos +
                                                                              "',bas_dut='" + dut +
                                                                               "',bas_dept='" + dept +
                                                                                "',bas_rmk='" + rmk +
                                                                                 "',bas_pos_dt='" + pos_dt +
                                                                                  "',bas_dut_dt='" + dut_dt +
                                                                                   "',bas_dept_dt='" + dept_dt +
                                                                                    "',bas_intern_dt='" + intern_dt +
                                                                                     "' where bas_empno='" + empno + "'";
                        var a = comm.ExecuteNonQuery();
                        check = 0;
                        Console.WriteLine(comm.CommandText);
                        Console.WriteLine(a + " row updateds");
                    }
                }
            }
            catch (Exception a)
            {
                Console.WriteLine(a);
            }
            return check;
        }

        public int thrm_fam_update(String empno, String fam_rel, String fam_name, String fam_bth, String fam_itg)
        {
            int check = 1;
            try
            {
                if (GetConnection() == true)
                {
                    using (OracleCommand comm = new OracleCommand())
                    {
                        comm.Connection = Connection;
                        comm.CommandText = @"update thrm_fam_hwy set fam_rel='"+fam_rel+"', fam_name='"+fam_name+"', fam_bth='"+fam_bth+"', fam_itg='"+fam_itg+"' where fam_empno='"+empno+"'";
                        var a = comm.ExecuteNonQuery();
                        check = 0;
                        Console.WriteLine(comm.CommandText);
                        Console.WriteLine(a + " row updateds");
                    }
                }
            }
            catch (Exception a)
            {
                Console.WriteLine(a);
            }
            return check;
        }

        //public int thrm_fam_update(String name)
        //{
        //    int check = 1;
        //    try
        //    {
        //        if (GetConnection() == true)
        //        {
        //            using (OracleCommand comm = new OracleCommand())
        //            {
        //                comm.Connection = Connection;
        //                comm.CommandText = @"update thrm_fam_hwy set fam_name='" + name + "' where fam_empno=1";
        //                var a = comm.ExecuteNonQuery();
        //                check = 0;
        //                Console.WriteLine(comm.CommandText);
        //                Console.WriteLine(a + " row updateds");
        //            }
        //        }
        //    }
        //    catch (Exception a)
        //    {
        //        Console.WriteLine(a);
        //    }
        //    return check;
        //}
    }
}
