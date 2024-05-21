using Microsoft.Extensions.Logging;
using System.Data;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace Test2WebAPI_Server
{
    public class APITest
    {
        private readonly ILogger<APITest> _logger;
        
        public DataTable GetData()
        {
            string constr = @"Data Source = USER-NB\SQLEXPRESS; Initial Catalog = TestWebAPI; User ID=admin; Password=123456;";

            DataTable dt = new DataTable();
            string sql = "";

            //sql = "select * from Report";     //Sql
            sql = "SP_Report";                  //StoredProcedureName

            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    using (var adapter = new SqlDataAdapter(sql, con))
                    {
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        //adapter.SelectCommand.Parameters.Add("@companyid", SqlDbType.Int).Value = 123;
                        adapter.Fill(dt);
                    };
                }
                catch (Exception ex)
                {
                    _logger.Log(LogLevel.Error, $"{ex.Message}");
                }
                finally {
                    
                    con.Close();
                }
            }

            return dt;
        }
    }
}
