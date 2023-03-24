using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PZ3_3
{
    internal class Program
    {
        class SQLCommand
        {
            private string _commandtext;
            public string CommandText
            {
                get
                {
                    return _commandtext;
                }
                private set
                {
                    _commandtext = UpperCommandTextOperators(value);
                }
            }
            private string UpperCommandTextOperators(string commandText)
            {
                string[] operators = { "select", "alter", "drop", "create", "insert", "update", "delete", "in", "grant", "revoke", "from", "where", "not", "or", "and", "table", "like", "between", "order by", "asc", "desc", "group by", "having", "use", "not null", "default", "unique", "primary key", "foreign key", "check", "index", "join", "on", "truncate", "add", "modify", "values", "set", "exists", "commit", "rollback", "all", "any", "is null", "as", "database", "min", "sum", "avg", "max", "count", "union"};
                for (int i = 0; i < operators.Length; i++)
                {
                    commandText = commandText.Replace(operators[i], operators[i].ToUpper());
                }
                return commandText;
            }
            public SQLCommand(string commandText)
            {
                CommandText = commandText;
            }
        }
        static void Main(string[] args)
        {
            string conn_string = @"Data Source=computer1\sqlexpress;Initial Catalog=deliveryGoods;Integrated Security=True";
            SqlConnection sql_conn = new SqlConnection(conn_string);
            SQLCommand cmd = new SQLCommand("select name_customer from Orders where id_good = 2");
            SqlCommand sql_comm = new SqlCommand(cmd.CommandText, sql_conn);
            sql_conn.Open();
            Console.WriteLine(sql_comm.ExecuteScalar());
            sql_conn.Close();
            Console.ReadKey(true);
        }
    }
}
