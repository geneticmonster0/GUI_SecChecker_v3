using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace GUI_SecChecker_v3.DataBases
{
    static class SQL_Executor
    {
        static public void Exec_SPU_With_Multple_Parameters(string connString, string spuName, params string[] paramsAndValue)
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(spuName, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    for (int i = 0; i<paramsAndValue.Length-1; i=i+2)
                    {
                        cmd.Parameters.Add(paramsAndValue[i], SqlDbType.NVarChar).Value = paramsAndValue[i+1];
                    }

                    

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
