﻿using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace QL_Thue_Xe_Dap.Repository
{
    public class NhomNguoiDungRepository
    {
        private SqlConnection connection;

        public NhomNguoiDungRepository()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStrings"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }
        
        // Phương thức mở kết nối
        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        // Phương thức đóng kết nối
        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        
        
    }
}