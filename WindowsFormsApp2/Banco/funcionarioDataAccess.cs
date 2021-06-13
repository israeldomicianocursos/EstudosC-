using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp2.Banco
{
    public class funcionarioDataAccess
    {
    
        private static SqlConnection con = new SqlConnection(@"Integrated Security = SSPI; Persist Security Info=False;Initial Catalog = CRUD; Data Source = desktop - vhtio37\sqlexpress");
        public static DataTable PegarFuncionarios()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Funcionarios", con);
            DataSet ds = new DataSet();

            da.Fill(ds);

            return ds.Tables[0];
        }
       
    }

}
