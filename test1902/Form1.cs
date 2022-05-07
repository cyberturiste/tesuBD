using Apache.NMS;

using Newtonsoft.Json;
using System;
using System.Data;
using System.Data.SQLite;
using System.Windows;
using System.Windows.Forms;


namespace test1902
{
    public partial class Form1 : Form
    {


        private SQLiteConnection m_dbConn;
        private SQLiteCommand m_sqlCmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                m_dbConn = new SQLiteConnection();
                m_sqlCmd = new SQLiteCommand();
                MessageBox.Show(
        "Выберите файл database SQLite",
        "Выбор файла");
                OpenFileDialog OPF = new OpenFileDialog();
                if (OPF.ShowDialog() == DialogResult.OK)
                {




                    m_dbConn = new SQLiteConnection("Data Source=" + OPF.FileName + ";Version=3;");
                    m_dbConn.Open();

                    DataTable dTable = new DataTable();

                    String selecet = " SELECT name FROM sqlite_master WHERE TYPE = 'table'";

                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(selecet, m_dbConn);

                    adapter.Fill(dTable);

                    if (dTable.Rows.Count > 0)
                    {
                        dataGridView2.Rows.Clear();

                        for (int i = 0; i < dTable.Rows.Count; i++)
                        {
                            dataGridView2.Rows.Add(dTable.Rows[i].ItemArray);

                            dbTableName.Items.Add(string.Join(",", dTable.Rows[i].ItemArray));
                            dbTableName2.Items.Add(string.Join(",", dTable.Rows[i].ItemArray));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
        "Логическая ошибка SQL или выбранный файл не найден",
        "Ошибка");
            }

        }







        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                m_sqlCmd.Connection = m_dbConn;

                DataTable dTable = new DataTable();

                m_sqlCmd.CommandText = "INSERT INTO " + dbTableName.Text + " values ('" + insertdbValue1.Text + "','" + insertdbValue2.Text + "','" + insertdbValue3.Text + "')";

                m_sqlCmd.ExecuteNonQuery();

                String sqlQuery = "SELECT * FROM " + dbTableName.Text;

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, m_dbConn);

                adapter.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {
                    dataGridView1.Rows.Clear();

                    for (int i = 0; i < dTable.Rows.Count; i++)
                        dataGridView1.Rows.Add(dTable.Rows[i].ItemArray);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Логическая ошибка SQL,проверьте написание команды",
        "Ошибка");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                m_sqlCmd.Connection = m_dbConn;


                if (checkBox2.Checked == true)
                {
                    m_sqlCmd.CommandText = "CREATE TABLE IF NOT EXISTS " + dbName.Text + " (" + dbColumn1.Text + " " + dataType2.Text + " PRIMARY KEY, " + dbColumn2.Text + " " + dataType2.Text + ", " + dbColumn3.Text + " " + dataType4.Text + ")";
                    m_sqlCmd.ExecuteNonQuery();
                }
                else if (checkBox3.Checked == true)
                {
                    m_sqlCmd.CommandText = "CREATE TABLE IF NOT EXISTS " + dbName.Text + " (" + dbColumn1.Text + " " + dataType2.Text + ", " + dbColumn2.Text + " " + dataType2.Text + " PRIMARY KEY, " + dbColumn3.Text + " " + dataType4.Text + ")";
                    m_sqlCmd.ExecuteNonQuery();
                }
                else if (checkBox4.Checked == true)
                {
                    m_sqlCmd.CommandText = "CREATE TABLE IF NOT EXISTS " + dbName.Text + " (" + dbColumn1.Text + " " + dataType2.Text + " , " + dbColumn2.Text + " " + dataType2.Text + ", " + dbColumn3.Text + " " + dataType4.Text + " PRIMARY KEY)";
                    m_sqlCmd.ExecuteNonQuery();
                }







                MessageBox.Show(
            "Таблица базы данных создана",
            "Успешно");



            }
            catch (Exception ex)
            {
                MessageBox.Show("Логическая ошибка SQL,проверьте написание команды",
       "Ошибка");
            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dbTableName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dTable = new DataTable();

                dataGridView1.Rows.Clear();

                String sqlQuery = "SELECT * FROM " + dbTableName.Text;

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, m_dbConn);

                adapter.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {
                    dataGridView1.Rows.Clear();

                    for (int i = 0; i < dTable.Rows.Count; i++)
                        dataGridView1.Rows.Add(dTable.Rows[i].ItemArray);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Логическая ошибка SQL,проверьте написание команды",
        "Ошибка");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Form1 form = new Form1();
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Логическая ошибка SQL,проверьте написание команды",
        "Ошибка");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            try
            {
                m_sqlCmd.Connection = m_dbConn;
                m_sqlCmd.CommandText = "DROP TABLE IF EXISTS " + dbTableName2.Text + ";";
                m_sqlCmd.ExecuteNonQuery();

            }

            catch (Exception ex)
            {

                MessageBox.Show("Логическая ошибка SQL,проверьте написание команды",
        "Ошибка");
            }
        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dTable3 = new DataTable();
                m_sqlCmd.Connection = m_dbConn;
                m_sqlCmd.CommandText = consoleDb.Text;
                m_sqlCmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Логическая ошибка SQL,проверьте написание команды",
        "Ошибка");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;

            checkBox4.Checked = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;

        }


    }
}

