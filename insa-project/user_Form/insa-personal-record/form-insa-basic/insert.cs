using Oracle.ManagedDataAccess.Client;
using System;

namespace insa_project
{
    class insert : OracleDBManager
    {
        /*
         *  인사기본사항
         */
        public int thrm_bas_add(String empno, String resno, String name, String cname, String ename, String fix, String zip, String addr, String residence, String hdpno, String telno, String email, String mil_sta, String mil_mil, String mil_rnk, String mar,
            String acc_bank1, String acc_name1, String acc_no1, String acc_bank2, String acc_name2, String acc_no2, String cont, String intern, int intern_no, String emp_sdate, String emp_edate, String entdate,
            String resdate, String levdate, String reidate, String wsta, String sts, String pos, String dut, String dept, String rmk, String pos_dt, String dut_dt, String dept_dt, String intern_dt, String datasys1, String datasys2, String datasys3)
        {
            int check = 1;
            try
            {
                if (GetConnection() == true)
                {
                    OracleCommand comm = new OracleCommand();
                    comm.Connection = Connection;
                    comm.CommandText = @"INSERT INTO THRM_BAS_HWY values(:empno, :resno, :name, :cname, :ename, :fix, :zip, :addr, :residence, :hdpno, :telno, :email, :mil_sta, :mil_mil, :mil_rnk, :mar, " + // 15
                        ":acc_bank1, :acc_name1, :acc_no1, :acc_bank2, :acc_name2, :acc_no2, :cont, :intern, :intern_no, :emp_sdate, :emp_edate, :entdate, " + // 12
                        ":resdate, :levdate, :reidate, :wsta, :sts, :pos, :dut, :dept, :rmk, :pos_dt, :dut_dt, :dept_dt, :intern_dt, :datasys1, :datasys2, :datasys3)"; // 16

                    comm.Parameters.Add("empno", empno);
                    comm.Parameters.Add("resno", resno);
                    comm.Parameters.Add("name", name);
                    comm.Parameters.Add("cname", cname);
                    comm.Parameters.Add("ename", ename);
                    comm.Parameters.Add("fix", fix);
                    comm.Parameters.Add("zip", zip);
                    comm.Parameters.Add("addr", addr);
                    comm.Parameters.Add("residence", residence);
                    comm.Parameters.Add("hdpno", hdpno);
                    comm.Parameters.Add("telno", telno);
                    comm.Parameters.Add("email", email);
                    comm.Parameters.Add("mil_sta", mil_sta);
                    comm.Parameters.Add("mil_mil", mil_mil);
                    comm.Parameters.Add("mil_rnk", mil_rnk);
                    comm.Parameters.Add("mar", mar);
                    comm.Parameters.Add("acc_bank1", acc_bank1);
                    comm.Parameters.Add("acc_name1", acc_name1);
                    comm.Parameters.Add("acc_no1", acc_no1);
                    comm.Parameters.Add("acc_bank2", acc_bank2);
                    comm.Parameters.Add("acc_name2", acc_name2);
                    comm.Parameters.Add("acc_no2", acc_no2);
                    comm.Parameters.Add("cont", cont);
                    comm.Parameters.Add("intern", intern);
                    comm.Parameters.Add("intern_no", intern_no);
                    comm.Parameters.Add("emp_sdate", emp_sdate);
                    comm.Parameters.Add("emp_edate", emp_edate);
                    comm.Parameters.Add("entdate", entdate);
                    comm.Parameters.Add("resdate", resdate);
                    comm.Parameters.Add("levdate", levdate);
                    comm.Parameters.Add("reidate", reidate);
                    comm.Parameters.Add("wsta", wsta);
                    comm.Parameters.Add("sts", sts);
                    comm.Parameters.Add("pos", pos);
                    comm.Parameters.Add("dut", dut);
                    comm.Parameters.Add("dept", dept);
                    comm.Parameters.Add("rmk", rmk);
                    comm.Parameters.Add("pos_dt", pos_dt);
                    comm.Parameters.Add("dut_dt", dut_dt);
                    comm.Parameters.Add("dept_dt", dept_dt);
                    comm.Parameters.Add("intern_dt", intern_dt);
                    comm.Parameters.Add("datasys1", datasys1);
                    comm.Parameters.Add("datasys2", datasys2);
                    comm.Parameters.Add("datasys3", datasys3);
                    comm.Prepare();
                    comm.ExecuteNonQuery();
                    comm.Cancel();
                    comm.Dispose();
                    check = 0;
                }
            }
            catch (Exception ex)
            {
                check = 1;
                Console.WriteLine(ex);
            }
            return check;
        }
        /// <summary>
        /// 가족사항 데이터베이스 입력
        /// <list type="table">
        /// <item>fam_empno: 사원번호</item>
        /// <item>fam_rel: 관계</item>
        /// <item>fam_name: 이름</item>
        /// <item>fam_bth: 생년월일</item>
        /// <item>fam_ltg: 동거</item>
        /// </list>
        /// </summary>
        public int thrm_fam_add(String fam_empno, String fam_rel, String fam_name, String fam_bth, String fam_ltg, String datasys1, String datasys2, String datasys3)
        {
            int check = 1;
            try
            {
                if (GetConnection() == true)
                {
                    OracleCommand comm = new OracleCommand();
                    comm.Connection = Connection;
                    comm.CommandText = @"INSERT INTO THRM_FAM_HWY values(:empno, :resno, :name, :cname, :ename, :datasys1, :datasys2, :datasys3)";
                    comm.Parameters.Add("empno", fam_empno);
                    comm.Parameters.Add("resno", fam_rel);
                    comm.Parameters.Add("name", fam_name);
                    comm.Parameters.Add("cname", fam_bth);
                    comm.Parameters.Add("ename", fam_ltg);
                    comm.Parameters.Add("datasys1", datasys1);
                    comm.Parameters.Add("datasys2", datasys2);
                    comm.Parameters.Add("datasys3", datasys3);
                    comm.Prepare();
                    comm.ExecuteNonQuery();
                    comm.Cancel();
                    comm.Dispose();
                    check = 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return check;
        }
        /*
         *  학력사항
         */
        public int thrm_edu_add(String edu_empno, String edu_loe, String edu_entdate, String edu_gradate, String edu_schnm, String edu_dept, String edu_degree, int edu_grade, String edu_gra, String edu_last, String datasys1, String datasys2, String datasys3)
        {
            int check = 1;
            try
            {
                if (GetConnection() == true)
                {
                    OracleCommand comm = new OracleCommand();
                    comm.Connection = Connection;
                    comm.CommandText = @"INSERT INTO THRM_EDU_HWY values(:empno, :resno, :name, :cname, :ename, :edu_dept, :edu_degree, :edu_grade, :edu_gra, :edu_last, :datasys1, :datasys2, :datasys3)";
                    comm.Parameters.Add("empno", edu_empno);
                    comm.Parameters.Add("resno", edu_loe);
                    comm.Parameters.Add("name", edu_entdate);
                    comm.Parameters.Add("cname", edu_gradate);
                    comm.Parameters.Add("ename", edu_schnm);
                    comm.Parameters.Add("edu_dept", edu_dept);
                    comm.Parameters.Add("edu_degree", edu_degree);
                    comm.Parameters.Add("edu_grade", edu_grade);
                    comm.Parameters.Add("edu_gra", edu_gra);
                    comm.Parameters.Add("edu_last", edu_last);
                    comm.Parameters.Add("datasys1", datasys1);
                    comm.Parameters.Add("datasys2", datasys2);
                    comm.Parameters.Add("datasys3", datasys3);
                    comm.Prepare();
                    comm.ExecuteNonQuery();
                    comm.Cancel();
                    comm.Dispose();
                    check = 0;
                }
            }
            catch (Exception ex)
            {
                check = 1;
                Console.WriteLine(ex);
            }
            return check;
        }
        /*
         *  상벌이력
         */
        public int thrm_award_add(String award_empno, String award_date, String award_type, String award_no, String award_kind, String award_organ, String award_content, String award_inout, String award_pos, String award_dept, String datasys1, String datasys2, String datasys3)
        {
            int check = 1;
            try
            {
                if (GetConnection() == true)
                {
                    OracleCommand comm = new OracleCommand();
                    comm.Connection = Connection;
                    comm.CommandText = @"INSERT INTO THRM_AWARD_HWY values(:empno, :resno, :name, :cname, :ename, :edu_dept, :edu_degree, :edu_grade, :edu_gra, :edu_last, :datasys1, :datasys2, :datasys3)";
                    comm.Parameters.Add("empno", award_empno);
                    comm.Parameters.Add("resno", award_date);
                    comm.Parameters.Add("name", award_type);
                    comm.Parameters.Add("cname", award_no);
                    comm.Parameters.Add("ename", award_kind);
                    comm.Parameters.Add("edu_dept", award_organ);
                    comm.Parameters.Add("edu_degree", award_content);
                    comm.Parameters.Add("edu_grade", award_inout);
                    comm.Parameters.Add("edu_gra", award_pos);
                    comm.Parameters.Add("edu_last", award_dept);
                    comm.Parameters.Add("datasys1", datasys1);
                    comm.Parameters.Add("datasys2", datasys2);
                    comm.Parameters.Add("datasys3", datasys3);
                    comm.Prepare();
                    comm.ExecuteNonQuery();
                    comm.Cancel();
                    comm.Dispose();
                    check = 0;
                }
            }
            catch (Exception ex)
            {
                check = 1;
                Console.WriteLine(ex);
            }
            return check;
        }
        /*
         *  경력사항
         */
        public int thrm_car_add(String car_empno, String car_com, String car_region, String car_yyyymm_f, String car_yyyymm_t, String car_pos, String car_dept, String car_job, String car_reason, String datasys1, String datasys2, String datasys3)
        {
            int check = 1;
            try
            {
                if (GetConnection() == true)
                {
                    OracleCommand comm = new OracleCommand();
                    comm.Connection = Connection;
                    comm.CommandText = @"INSERT INTO THRM_CAR_HWY values(:empno, :resno, :name, :cname, :ename, :edu_dept, :edu_degree, :edu_grade, :edu_gra, :datasys1, :datasys2, :datasys3)";
                    comm.Parameters.Add("empno", car_empno);
                    comm.Parameters.Add("resno", car_com);
                    comm.Parameters.Add("name", car_region);
                    comm.Parameters.Add("cname", car_yyyymm_f);
                    comm.Parameters.Add("ename", car_yyyymm_t);
                    comm.Parameters.Add("edu_dept", car_pos);
                    comm.Parameters.Add("edu_degree", car_dept);
                    comm.Parameters.Add("edu_grade", car_job);
                    comm.Parameters.Add("edu_gra", car_reason);
                    comm.Parameters.Add("datasys1", datasys1);
                    comm.Parameters.Add("datasys2", datasys2);
                    comm.Parameters.Add("datasys3", datasys3);
                    comm.Prepare();
                    comm.ExecuteNonQuery();
                    comm.Cancel();
                    comm.Dispose();
                    check = 0;
                }
            }
            catch (Exception ex)
            {
                check = 1;
                Console.WriteLine(ex);
            }
            return check;
        }
        /*
         *  자격면허
         */
        public int thrm_lic_add(String lic_empno, String lic_code, String lic_grade, String lic_acqdate, String lic_organ, String datasys1, String datasys2, String datasys3)
        {
            int check = 1;
            try
            {
                if (GetConnection() == true)
                {
                    OracleCommand comm = new OracleCommand();
                    comm.Connection = Connection;
                    comm.CommandText = @"INSERT INTO THRM_LIC_HWY values(:empno, :resno, :name, :cname, :ename, :edu_dept, :edu_degree, :edu_grade, :edu_gra, :datasys1, :datasys2, :datasys3)";
                    comm.Parameters.Add("empno", lic_empno);
                    comm.Parameters.Add("resno", lic_code);
                    comm.Parameters.Add("name", lic_grade);
                    comm.Parameters.Add("cname", lic_acqdate);
                    comm.Parameters.Add("ename", lic_organ);
                    comm.Parameters.Add("datasys1", datasys1);
                    comm.Parameters.Add("datasys2", datasys2);
                    comm.Parameters.Add("datasys3", datasys3);
                    comm.Prepare();
                    comm.ExecuteNonQuery();
                    comm.Cancel();
                    comm.Dispose();
                    check = 0;
                }
            }
            catch (Exception ex)
            {
                check = 1;
                Console.WriteLine(ex);
            }
            return check;
        }
        /*
         *  외국어
         */
        public int thrm_forl_add(String forl_empno, String forl_code, String forl_score, String forl_acqdate, String forl_organ, String datasys1, String datasys2, String datasys3)
        {
            int check = 1;
            try
            {
                if (GetConnection() == true)
                {
                    OracleCommand comm = new OracleCommand();
                    comm.Connection = Connection;
                    comm.CommandText = @"INSERT INTO THRM_FORL_HWY values(:empno, :resno, :name, :cname, :ename, :edu_dept, :edu_degree, :edu_grade, :edu_gra, :datasys1, :datasys2, :datasys3)";
                    comm.Parameters.Add("empno", forl_empno);
                    comm.Parameters.Add("resno", forl_code);
                    comm.Parameters.Add("name", forl_score);
                    comm.Parameters.Add("cname", forl_acqdate);
                    comm.Parameters.Add("ename", forl_organ);
                    comm.Parameters.Add("datasys1", datasys1);
                    comm.Parameters.Add("datasys2", datasys2);
                    comm.Parameters.Add("datasys3", datasys3);
                    comm.Prepare();
                    comm.ExecuteNonQuery();
                    comm.Cancel();
                    comm.Dispose();
                    check = 0;
                }
            }
            catch (Exception ex)
            {
                check = 1;
                Console.WriteLine(ex);
            }
            return check;
        }
    }
}
