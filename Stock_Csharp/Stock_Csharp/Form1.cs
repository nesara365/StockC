using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Stock_Csharp
{
    public partial class Form1 : Form
    {
        private SqlConnection con;

        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=DESKTOP-5US1PT5;Initial Catalog=stockSystem;Integrated Security=True");
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                Stock stock = new Stock(textBox1.Text, textBox2.Text, Int32.Parse(textBox3.Text));

                SqlCommand checkCodeCommand = new SqlCommand("SELECT COUNT(*) FROM stockTable WHERE StockCode = @stockCode", con);
                checkCodeCommand.Parameters.AddWithValue("@stockCode", stock.GetStockCode());

                int codeItemCount = (int)checkCodeCommand.ExecuteScalar();

                SqlCommand checkNameCommand = new SqlCommand("SELECT COUNT(*) FROM stockTable WHERE StockName = @stockName", con);
                checkNameCommand.Parameters.AddWithValue("@stockName", stock.GetStockName());

                int nameItemCount = (int)checkNameCommand.ExecuteScalar();

                if (codeItemCount > 0 && nameItemCount > 0)
                {
                    MessageBox.Show("Same Name and Code exists.");
                }
                else if (codeItemCount > 0)
                {
                    MessageBox.Show("Stock Code already exists.");
                }
                else if (nameItemCount > 0)
                {
                    MessageBox.Show("Name already exists.");
                }
                else
                {
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO stockTable (StockCode, StockName, StockQuantity, StockDate) VALUES (@stockCode, @stockName, @stockQuantity, @stockDate)", con);
                    insertCommand.Parameters.AddWithValue("@stockCode", stock.GetStockCode());
                    insertCommand.Parameters.AddWithValue("@stockName", stock.GetStockName());
                    insertCommand.Parameters.AddWithValue("@stockQuantity", stock.GetStockQuantity());
                    insertCommand.Parameters.AddWithValue("@stockDate", stock.GetStockDate());

                    insertCommand.ExecuteNonQuery();
                    MessageBox.Show("Successfully Added");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

            private void button2_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT StockCode, StockName, StockQuantity, StockDate FROM stockTable", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                sd.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    if (row["StockDate"] != DBNull.Value && row["StockDate"] is DateTime)
                    {
                        DateTime stockDate = (DateTime)row["StockDate"];
                        row["StockDate"] = stockDate.ToString("yyyy-MM-dd HH:mm:ss");
                    }
                }


                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
    }
}

