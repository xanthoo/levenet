using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProP_Restaurant
{
    public class DBHelper
    {
        public static readonly MySqlConnection connection;

        static DBHelper()
        {
            string connectionstring =   "server=studmysql01.fhict.local;" +
                                        "database=dbi410674;" +
                                        "user id=dbi410674;" +
                                        "password=asdqwe123;" +
                                        "connect timeout=60;";

            connection = new MySqlConnection(connectionstring);
        }
    }
}
