﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
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
using TheTriviaProject.ViewModel;

namespace TheTriviaProject.View
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {

        private SharedViewModel _sharedViewModel;
        private MediaPlayer mediaPlayer = new MediaPlayer();

        public Login(SharedViewModel sharedViewModel)
        {
            InitializeComponent();
            _sharedViewModel = sharedViewModel;
        }

        private void SignUpBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Register registerPage = new Register(_sharedViewModel);
                NavigationService.Navigate(registerPage);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            UserName.Focus();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string enteredEmail = UserName.Text;
                string enteredPassword = Passwordclass.Password;
                bool isAdmin = false;
                bool userFound = false;

                string connectionString = @"Data Source=C:\Users\User\source\repos\FinalProject\FinalProject\FinalProject.db;Version=3;";

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Users WHERE Email = @Email AND Password = @Password LIMIT 1";
                    using (var command = new SQLiteCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Email", enteredEmail);
                        command.Parameters.AddWithValue("@Password", enteredPassword);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                userFound = true;
                                isAdmin = Convert.ToBoolean(reader["IsAdmin"]);
                            }
                        }
                    }
                }

                if (userFound)
                {
                    if (isAdmin)
                    {
                        Admin adminPage = new Admin();
                        NavigationService.Navigate(adminPage);
                    }
                    else
                    {
                        MainWindow mainPage = new MainWindow();
                        NavigationService.Navigate(mainPage);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid email or password. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }
    }
}
