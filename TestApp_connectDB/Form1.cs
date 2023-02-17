using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp_connectDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen; //プログラムを実行したときのFORMの初期位置を中央
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var builder = new SqlConnectionStringBuilder();
            builder.DataSource = "TAKAHIRA";                           //DBサーバー名を入れる
            builder.InitialCatalog = "Test";                           //DB名を入れる
            builder.IntegratedSecurity = false;                        //認証方式：trueはwindows認証　falseはsql認証
            builder.UserID = "sa";                                     //sql認証のID
            builder.Password = "6918";                                 //sql認証のパスワード
            var connectionString = builder.ToString();                 //上記の入力文字列にて接続文字列の生成(と代入)      

            var sql = @"select * from Product";

            DataTable dt = new DataTable();

            //usingで囲うことでコネクションを切る動作を省略できる
            using (var connection = new SqlConnection(connectionString))      //４行↑の接続文字列を使ってSQLSERVER DBに接続するオブジェクトを生成
            using (var adapter = new SqlDataAdapter(sql, connection))         //Sqlを実行
            {
                
                connection.Open();                                            //SQLserverに接続
                adapter.Fill(dt);                                             //dtにsql結果を格納する
            }

            dataGridView1.DataSource= dt;                                     //dataGridView1にdtを格納
        }

        private void ReaderReadbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
