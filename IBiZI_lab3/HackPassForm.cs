using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AuthorizationForm;

namespace IBiZI_lab3
{
    public partial class HackPassForm : Form
    {
        private LoginForm loginForm;
        public HackPassForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
        }

        private void buttonDictHack_Click(object sender, EventArgs e)
        {
            PasswordSearch passwordSearch = new PasswordSearch(loginForm);
            double time = passwordSearch.AnalyzeDictionaryAttack();
            textBoxPass.Text = passwordSearch.FoundPassword;
            MessageBox.Show($"Среднее время перебора паролей в секунду: {time}");
        }

        private void buttonBruteForceHack_Click(object sender, EventArgs e)
        {
            PasswordSearch passwordSearch = new PasswordSearch(loginForm);
            double time = passwordSearch.AnalyzeBruteForceAttack(6);
            textBoxPass.Text = passwordSearch.FoundPassword;
            MessageBox.Show($"Среднее время перебора паролей в секунду: {time}");
        }

        private void HackPassForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Чтобы форма закрывалась, когда пароль введен и нажата кнопка входа
            loginForm.IsHackFormOpened = false;
        }
    }
}
