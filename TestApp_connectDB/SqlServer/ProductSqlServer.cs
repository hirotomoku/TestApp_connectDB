using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp_connectDB.SqlServer
{
    public static class ProductSqlServer
    {
        private static string _connectionString;
        static ProductSqlServer()
        {
            var builder = new SqlConnectionStringBuilder();
            builder.DataSource = "TAKAHIRA";                           //DBサーバー名を入れる
            builder.InitialCatalog = "Test";                           //DB名を入れる
            builder.IntegratedSecurity = false;                        //認証方式：trueはwindows認証　falseはsql認証
            builder.UserID = "sa";                                     //sql認証のID
            builder.Password = "6918";                                 //sql認証のパスワード
            _connectionString = builder.ToString();                    //上記の入力文字列にて接続文字列の生成(と代入)    
        }

        public static DataTable GetDataTable() 
        {
            var sql = @"select * from Product";

            DataTable dt = new DataTable();

            //usingで囲うことでコネクションを切る動作を省略できる
            using (var connection = new SqlConnection(_connectionString))      //４行↑の接続文字列を使ってSQLSERVER DBに接続するオブジェクトを生成
            using (var adapter = new SqlDataAdapter(sql, connection))         //Sqlを実行
            {

                connection.Open();                                            //SQLserverに接続
                adapter.Fill(dt);                                             //dtにsql結果を格納する
            }

            return dt;
        }
    }
}
