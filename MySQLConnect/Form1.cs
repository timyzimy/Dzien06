using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQLConnect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String connectionString = "";
        bool isOpen = false;
        MySqlConnection conn = null;

        private void btnConnect_Click(object sender, EventArgs e)
        {
            connectionString = String.Format("server={0};userid={1};password={2};database={3};port={4}",
                                   tbHost.Text, tbUser.Text, tbPass.Text, tbDBName.Text, tbPort.Text );
            try
            {
                if (isOpen)
                {
                    conn.Close();
                    conn.Dispose(); // GOOD PRACTICE!
                    btnConnect.Text = "Połącz";
                    isOpen = false;
                } else
                {
                    conn = new MySqlConnection(connectionString);
                    conn.Open();
                    btnConnect.Text = "Rozłącz";
                    isOpen = true;
                }
            } catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnRunSQL_Click(object sender, EventArgs e)
        {
            String sql = tbSQL.Text;
            try
            {
                lvGrid.Items.Clear();
                lvGrid.Columns.Clear();

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (MySqlDataReader rdr = cmd.ExecuteReader())  // good practice
                {
                    for (int i = 0; i < rdr.FieldCount; i++)
                    {
                        lvGrid.Columns.Add(rdr.GetName(i), 150);
                    }

                    while (rdr.Read())
                    {
                        string[] arr = new string[rdr.FieldCount];
                        for (int i = 0; i < rdr.FieldCount; i++)
                        {
                            if (rdr.IsDBNull(i))
                            {
                                arr[i] = "(NULL)";
                            }
                            else
                            {
                                arr[i] = rdr.GetString(i);
                                //rdr.GetInt32(2)
                            }
                        }
                        lvGrid.Items.Add(new ListViewItem(arr));
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
