using System;
using System.Windows;
using System.Windows.Controls;

namespace PasswordResetApp
{
    public partial class MainWindow : Window
    {
        private string encryptedPassword;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnEncrypt_Click(object sender, RoutedEventArgs e)
        {
            string password = txtPassword.Text;
            string Salt = "zaz"; // Static salt for simplicity
            encryptedPassword = PasswordManager.EncryptPassword(password,Salt);
            txtStoredPassword.Text = encryptedPassword;
        }

        private void BtnBruteForce_Click(object sender, RoutedEventArgs e)
        {
            if (encryptedPassword == null)
            {
                MessageBox.Show("Please encrypt a password first.");
                return;
            }

            if (!int.TryParse(txtNumThreads.Text, out int maxThreads))
            {
                MessageBox.Show("Please enter a valid number of threads.");
                return;
            }

            var (foundPassword, executionTime) = BruteForceAttack.BruteForcePassword(encryptedPassword,txtPassword.Text, maxThreads);

            txtBruteForcedPassword.Text = foundPassword ?? "Not found";
            txtExecutionTime.Text = executionTime.TotalSeconds.ToString("F2") + " seconds";
        }
    }
}
