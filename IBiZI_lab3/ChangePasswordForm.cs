using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IBiZI_lab3
{
    public partial class ChangePasswordForm : Form
    {
        private string currentUsername;
        private Dictionary<string, List<string>> users;
        public ChangePasswordForm(string currentUsername, Dictionary<string, List<string>> users)
        {
            InitializeComponent();
            this.currentUsername = currentUsername;
            this.users = users;
        }

        private void buttonChangePass_Click(object sender, EventArgs e)
        {
            // Обработка события нажатия на кнопку смены пароля
            string oldPassword = textBoxOldPass.Text;
            string newPassword = textBoxNewPass.Text;
            string confirmNewPassword = textBoxConfirmPass.Text;

            // Проверка совпадения старого пароля
            if (oldPassword != users[currentUsername][0])
            {
                MessageBox.Show("Старый пароль введен неверно!");
                return;
            }

            // Проверка совпадения нового и подтвержденного пароля
            if (newPassword != confirmNewPassword)
            {
                MessageBox.Show("Новый пароль и подтверждение не совпадают.");
                return;
            }

            // Проверка на повторение старого пароля
            if (newPassword == oldPassword)
            {
                MessageBox.Show("Новый пароль не должен повторять старый!");
                return;
            }

            ChangeUserPassword(currentUsername, newPassword);
        }


        // Метод для изменения пароля пользователя
        private void ChangeUserPassword(string username, string newPassword)
        {
            if (!users.ContainsKey(username))
            {
                MessageBox.Show($"Пользователь {username} не найден.");
            }

            // Проверка есть ли цифры в пароле
            if (Boolean.Parse(users[username][2]))
            {
                if (!newPassword.Any(char.IsDigit))
                {
                    MessageBox.Show("Пароль должен содержать цифры");
                    return;
                }
            }

            // Проверка есть ли спецсимволы в пароле
            if (Boolean.Parse(users[username][3]))
            {
                if (!newPassword.Any(char.IsSymbol))
                {
                    MessageBox.Show("Пароль должен содержать специальные символы");
                    return;
                }
            }

            // Проверка есть ли заглавные буквы в пароле
            if (Boolean.Parse(users[username][4]))
            {
                if (!newPassword.Any(char.IsUpper))
                {
                    MessageBox.Show("Пароль должен содержать заглавные буквы");
                    return;
                }
            }

            int passLenght;
            // Проверка длины пароля
            if (Int32.TryParse(users[username][5], out passLenght))
            {
                if (newPassword.Length < passLenght)
                {
                    MessageBox.Show($"Пароль должен быть длины {passLenght}");
                    return;
                }
            }

            users[username][0] = newPassword;
            MessageBox.Show($"Пароль пользователя {username} успешно изменен.");
        }

        private void buttonCalcPassStrength_Click(object sender, EventArgs e)
        {
            CalculatePasswordStrengthForm form = new CalculatePasswordStrengthForm(textBoxNewPass.Text);
            form.Show();
        }
    }
}
