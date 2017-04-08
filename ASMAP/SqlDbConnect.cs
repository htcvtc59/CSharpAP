using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ASMAP
{
    class SqlDbConnect
    {
        private SqlConnection _con;
        public SqlCommand Cmd;
        private SqlDataAdapter _da;
        private DataTable _dt;
        private DataSet _ds;
        public BindingSource _bs;
        public SqlDataReader SqlReader;

        public SqlDbConnect()
        {
            _con = new SqlConnection("Data Source=localhost;Initial Catalog=Quiz;Integrated Security=True");
            _con.Open();
        }

        public void SqlQuery(string queryText)
        {
            Cmd = new SqlCommand(queryText, _con);
        }
        public DataTable QueryEx()
        {
            _da = new SqlDataAdapter(Cmd);
            _dt = new DataTable();
            _da.Fill(_dt);
            return _dt;
        }
        public void NonQueryEx()
        {
            Cmd.ExecuteNonQuery();
        }
        public void QueryBS() {
            _da = new SqlDataAdapter(Cmd);
            _ds = new DataSet();
            _bs = new BindingSource();
            _ds.Clear();
            _da.Fill(_ds);
            _bs.DataSource = _ds.Tables[0];
        }
        
    }
}
