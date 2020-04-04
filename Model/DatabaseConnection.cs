using System;
using System.Data;
using System.Data.SqlClient;

namespace MyPhotos
{
    public class DatabaseConnection
    {
      public void Connect()
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=WINDOWS-G851JRV\SQLEXPRESS;Initial Catalog=MyPhotos;Integrated Security=True");
        }
    }
}
