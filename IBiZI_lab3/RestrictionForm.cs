using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IBiZI_lab3
{
    public partial class RestrictionForm : Form
    {
        private Dictionary<string, List<string>> users;

        public RestrictionForm(Dictionary<string, List<string>> users)
        {
            InitializeComponent();

            this.users = users;
        }

        private void RestrictionChange(int restrictionIndex)
        {
            string username = textBoxUsername.Text;
            if (username == "")
            {
                MessageBox.Show("Имя пользователя не указано!");
                return;
            }

            if (checkBoxDigits.Checked)
            {
                users[username][restrictionIndex] = "True";
            }
            else
            {
                users[username][restrictionIndex] = "False";
            }
        }

        private void checkBoxDigits_CheckedChanged(object sender, EventArgs e)
        {
            // restrictionIndex == 2 - цифры
            RestrictionChange(2);
        }

        private void checkBoxSymbols_CheckedChanged(object sender, EventArgs e)
        {
            // restrictionIndex == 3 - символы
            RestrictionChange(3);
        }

        private void checkBoxUpperCase_CheckedChanged(object sender, EventArgs e)
        {
            // restrictionIndex == 4 - заглавыне буквы
            RestrictionChange(4);
        }

        private void textBoxLenght_TextChanged(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string passLength = textBoxLenght.Text;
            users[username][5] = passLength;
        }
    }
}
