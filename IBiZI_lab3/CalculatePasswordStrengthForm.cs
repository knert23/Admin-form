using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBiZI_lab3
{
    public partial class CalculatePasswordStrengthForm : Form
    {
        string NewPassword { get; set; }
        public CalculatePasswordStrengthForm(string newPass)
        {
            InitializeComponent();
            NewPassword = newPass;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int speed = Int32.Parse(textBoxSpeed.Text);
            int atteattemptsThreshold = Int32.Parse(textBoxAttemptsThreshold.Text);
            int delay = Int32.Parse(textBoxDelay.Text);
            Tuple<int, int, int, int, int, int> time;

            time = PasswordAnalyzer.CalculateSearchTime(NewPassword, speed, atteattemptsThreshold, delay);

            MessageBox.Show($"{time.Item1} лет {time.Item2} месяцев {time.Item3} дней {time.Item4} часов {time.Item5} минут {time.Item6} секунд");
        }
    }
}
