using MySql.Data.MySqlClient;
using System;
using System.Text;

namespace SadConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Console.WriteLine("Hello World!");
            using (MySqlConnection con = new MySqlConnection("Server=595cdf9db718a.gz.cdb.myqcloud.com;Port=14862;Database=nxpxcx;User ID=cdb_outerroot;Password=lo123yyf@yfd#win;Min Pool Size=10;SslMode=None;Max Pool Size=400;CharSet=utf8;Allow Zero Datetime=true;Allow User Variables=True;persist security info=true;"))
            {
                con.Open();
                string sql = "select * from nxp_wxadmindetail where WxAdId=72";
                using (MySqlCommand com = new MySqlCommand(sql, con))
                {
                    MySqlDataReader dd = com.ExecuteReader();
                    while (dd.Read())
                    {
                        for (int i = 0; i < dd.FieldCount; i++)
                        {
                            Console.Write($"{dd.GetName(i)}:{dd[i]}");
                            Console.WriteLine(" ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine(dd);
                    com.Clone();
                }
                con.Clone();
            }
            Console.ReadLine();
        }
    }
}
