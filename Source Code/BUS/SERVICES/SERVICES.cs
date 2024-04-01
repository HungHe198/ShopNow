using Microsoft.Data.SqlClient;
using ShopNow.Models;
using ShopNow.Source.DAL.Models;
using ShopNow.Source_Code.DAL.REPOSITORIES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNow.Source_Code.BUS.SERVICES
{
    class SERVICES
    {
        string connectionstring;
        Repo repos = new Repo();
        public SERVICES()
        {
            connectionstring = @"Data Source=SherryLap;Initial Catalog=PRO131_EF;Integrated Security=True";
        }
        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            DataTable data = new DataTable();
            SqlConnection con = new SqlConnection(connectionstring);
            try
            {
                con.Open();
                string query = "select * from Product";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
            finally { con.Close(); }
            foreach (DataRow row in data.Rows)
            {
                Product product = new Product();
                {
                    ProductName = row["Name"].ToString();

                }
            }
            return repos.GetAllProducts();
        }

    }
}
