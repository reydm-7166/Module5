using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Module1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadGrid();
        }

        public void clearData()
        {
            txtbox_Name.Clear();
            txtbox_Age.Clear();
            txtbox_Salary.Clear();
            txtbox_Phone.Clear();
        }
        public void LoadGrid()
        {
            string connectionString = "SERVER=localhost;DATABASE=mod4;UID=root;PASSWORD=admin;";

            MySqlConnection connection = new MySqlConnection(connectionString);

            MySqlCommand cmd = new MySqlCommand("select * from emptable", connection);
            connection.Open();

            DataTable dta = new DataTable();
            dta.Load(cmd.ExecuteReader());
            connection.Close();

            dtGridAccounts.DataContext = dta;
        }

        private void button_Clear_Click(object sender, RoutedEventArgs e)
        {
            clearData();
        }

        public bool isValid()
        {
            if (txtbox_Name.Text == String.Empty)
            {
                MessageBox.Show("Name is Empty!", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (txtbox_Age.Text == String.Empty)
            {
                MessageBox.Show("Age is Empty!", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (txtbox_Salary.Text == String.Empty)
            {
                MessageBox.Show("Salary is Empty!", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (txtbox_Phone.Text == String.Empty)
            {
                MessageBox.Show("Phone is Empty!", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }

        private void button_Insert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (isValid())
                {
                    DateTime aDate = DateTime.Now;

                    string connectionString = "SERVER=localhost;DATABASE=mod4;UID=root;PASSWORD=admin;";

                    MySqlConnection conn = new MySqlConnection(connectionString);

                    string query = "INSERT INTO mod4.emptable(emp_name, emp_age, emp_salary, join_date, phone) VALUES('" + txtbox_Name.Text + "','" + int.Parse(txtbox_Age.Text) + "','" + int.Parse(txtbox_Salary.Text) + "','" + aDate.ToString("yyyy-MM-dd HH:mm:ss") + "','" + txtbox_Phone.Text + "')";

                    MySqlCommand command = new MySqlCommand(query, conn);
                    conn.Open();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        LoadGrid();
                        MessageBox.Show("Inserted Successfully", "Saved", MessageBoxButton.OK,
                        MessageBoxImage.Information);

                        clearData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtGridAccounts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid row = (DataGrid)sender;
            DataRowView row_select = row.SelectedItem as DataRowView;

            if (row_select != null)
            {
                string connectionString = "SERVER=localhost;DATABASE=mod4;UID=root;PASSWORD=admin;";

                MySqlConnection connection = new MySqlConnection(connectionString);

                dataHolder.ID = row_select["id"].ToString();

                connection.Open();

            }
        }
        public static class dataHolder
        {
            public static string ID { get; set; }
        }

        private void button_Delete_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(dataHolder.ID))
            {
                string connectionString = "SERVER=localhost;DATABASE=mod4;UID=root;PASSWORD=admin;";

                MySqlConnection connection = new MySqlConnection(connectionString);

                MySqlCommand cmd = new MySqlCommand("DELETE FROM emptable WHERE id='" + dataHolder.ID + "';", connection);

                connection.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    LoadGrid();
                    MessageBox.Show("DELETED SUCCESSFULLY");
                }
                else
                {
                    MessageBox.Show("SOMETHING WENT WRONG");

                }
                connection.Close();
            }
        }

        private void button_Update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (isValid())
                {
                    DateTime aDate = DateTime.Now;

                    int value = int.Parse(txtbox_ID.Text);

                    string connectionString = "SERVER=localhost;DATABASE=mod4;UID=root;PASSWORD=admin;";

                    MySqlConnection conn = new MySqlConnection(connectionString);

                    int userVal = int.Parse(txtbox_ID.Text);

                    string query = "UPDATE emptable SET id='" + int.Parse(this.txtbox_ID.Text) + "', emp_name='" + this.txtbox_Name.Text + "', emp_age='" + int.Parse(this.txtbox_Age.Text) + "', emp_salary='" + int.Parse(this.txtbox_Salary.Text) + "',join_date='" + aDate.ToString("yyyy-MM-dd HH:mm:ss") + "', phone='" + this.txtbox_Phone.Text + "' where id='" + int.Parse(this.txtbox_ID.Text) + "' ";

                    MySqlCommand command = new MySqlCommand(query, conn);
                    conn.Open();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        LoadGrid();
                        MessageBox.Show("Updated Successfully!", "Saved", MessageBoxButton.OK, MessageBoxImage.Information);

                        clearData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
