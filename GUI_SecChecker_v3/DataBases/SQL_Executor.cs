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
        static public void Exec_SPU_With_Multple_Parameters_NoReturn(string connString, string spuName, params string[] paramsAndValue)
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(spuName, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 0;

                    for (int i = 0; i<paramsAndValue.Length-1; i=i+2)
                    {
                        cmd.Parameters.Add(paramsAndValue[i], SqlDbType.NVarChar).Value = paramsAndValue[i+1];
                    }

                    

                    con.Open();
                    //for (int i = 0; i < 10; i++)
                    //{
                    bool isError = true;
                    int counter = 0;
                    while (isError!=false || counter == 10)
                    {
                        try
                        {
                            cmd.ExecuteNonQuery();
                            isError = false;
                        }
                        catch { }
                        counter++;


                    }
                        
                    //}
                    
                    
                }
            }
        }

        static public DataSet Exec_SPU_With_Multple_Parameters_Return_DS(string connString, string spuName, params string[] paramsAndValue)
        {
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(spuName, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 0;
                    for (int i = 0; i < paramsAndValue.Length - 1; i = i + 2)
                    {
                        cmd.Parameters.Add(paramsAndValue[i], SqlDbType.NVarChar).Value = paramsAndValue[i + 1];
                    }

                    SqlDataAdapter da = new SqlDataAdapter();
                    

                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds);

                    con.Close();
                }
            }

            return ds;
        }
    }
}
