using SQL_DB_APP.DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace SQL_DB_APP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public UsersTableAdapter uta = new UsersTableAdapter();
        public DataSet ds = new DataSet();

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            uta.Fill(ds.Users);
            DataContext = ds.Users.DefaultView;
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {

            var query = from user in ds.Users
                        where (user.Name == txtName.Text)
                        where (user.Password == txtPassword.Text)
                        select user;

            if (query.Any())
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
            }
            else
            {
                MessageBox.Show("User does not exist!");
                txtName.Clear();
                txtPassword.Clear();
            }
        }

        public void RegisterButton_Click(object sender, EventArgs e)
        {
            var query = from user in ds.Users
                        select user;

            DataSet.UsersRow row = (DataSet.UsersRow) ds.Users.NewRow();
            row.Name = txtName.Text;
            row.Password = txtPassword.Text;
            ds.Users.AddUsersRow(row);
            uta.Update(ds);
            MessageBox.Show("User Registered!");
            txtName.Clear();
            txtPassword.Clear();
        }
    }
}