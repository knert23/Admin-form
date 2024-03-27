using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using AuthorizationForm;

namespace IBiZI_lab3
{
    public class PasswordSearch
    {
        string dictionaryPath = @"C:\Users\pc\source\repos\IBiZI_lab3\IBiZI_lab3\словарь.txt";
        private static char[] lowerCaseLettersAndDigits = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()№;:?-=+".ToCharArray();
        private LoginForm loginForm;

        public string FoundPassword { get; set; }

        public PasswordSearch(LoginForm loginForm)
        {
            this.loginForm = loginForm;
        }


        private string TranslateToRussian(string pass)
        {
            string rusPass = "";
            foreach (char ch in pass)
            {
                char rusCh = ReplaceEnglishLetterToRussian(ch);
                rusPass += rusCh;
            }

            return rusPass;
        }

         private string TranslateToEnglish(string pass)
        {
            string engPass = "";
            foreach (char ch in pass)
            {
                char engCh = ReplaceRussianLetterToEnglish(ch);
                engPass += engCh;
            }

            return engPass;
        }

        public double AnalyzeDictionaryAttack()
        {
            Stopwatch stopwatch = new Stopwatch();
            // Количество попыток
            int attempts = 0;

            // Подбор пароля с помощью словаря
            stopwatch.Start();

            using (StreamReader reader = new StreamReader(dictionaryPath))
            {
                string engPass = "";
                attempts++;
                while (!reader.EndOfStream)
                {
                    attempts++;
                    string word = reader.ReadLine();
                    engPass = TranslateToEnglish(word);
                    loginForm.Controls.Find("textBoxPass", false)[0].Text = engPass;
                    (loginForm.Controls.Find("buttonLogin", false)[0] as Button).PerformClick();
                    if (loginForm.OpenformType != null)
                    {
                        break;
                    }
                }
                FoundPassword = engPass;
            }
            stopwatch.Stop();

            return attempts / stopwatch.Elapsed.TotalSeconds;
        }



        public double AnalyzeBruteForceAttack(int maxLength)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            // Количество попыток
            int attempts = 0;
            StartBruteForce(maxLength, ref attempts);
            stopwatch.Stop();

            return attempts / stopwatch.Elapsed.TotalSeconds;
        }

        private void StartBruteForce(int maxLength, ref int attempts, string result = "")
        {
            loginForm.Controls.Find("textBoxPass", false)[0].Text = result;
            (loginForm.Controls.Find("buttonLogin", false)[0] as Button).PerformClick();
            FoundPassword = result;
            if (result.Length == maxLength) {
                FoundPassword = result;
            }
            else
            {
                for (int i = 0; i < lowerCaseLettersAndDigits.Length; i++)
                {
                    attempts++;
                    StartBruteForce(maxLength, ref attempts, result + lowerCaseLettersAndDigits[i]);
                }
            }
        }


        private char ReplaceEnglishLetterToRussian(char letter)
        {
            switch (letter)
            {
                case 'q':
                case 'Q':
                    return 'й';
                case 'w':
                case 'W':
                    return 'ц';
                case 'e':
                case 'E':
                    return 'у';
                case 'r':
                case 'R':
                    return 'к';
                case 't':
                case 'T':
                    return 'е';
                case 'y':
                case 'Y':
                    return 'н';
                case 'u':
                case 'U':
                    return 'г';
                case 'i':
                case 'I':
                    return 'ш';
                case 'o':
                case 'O':
                    return 'щ';
                case 'p':
                case 'P':
                    return 'з';
                case '[':
                case '{':
                    return 'х';
                case ']':
                case '}':
                    return 'ъ';
                case 'a':
                case 'A':
                    return 'ф';
                case 's':
                case 'S':
                    return 'ы';
                case 'd':
                case 'D':
                    return 'в';
                case 'f':
                case 'F':
                    return 'а';
                case 'g':
                case 'G':
                    return 'п';
                case 'h':
                case 'H':
                    return 'р';
                case 'j':
                case 'J':
                    return 'о';
                case 'k':
                case 'K':
                    return 'л';
                case 'l':
                case 'L':
                    return 'д';
                case ';':
                case ':':
                    return 'ж';
                case '\'':
                case '\"':
                    return 'э';
                case 'z':
                case 'Z':
                    return 'я';
                case 'x':
                case 'X':
                    return 'ч';
                case 'c':
                case 'C':
                    return 'с';
                case 'v':
                case 'V':
                    return 'м';
                case 'b':
                case 'B':
                    return 'и';
                case 'n':
                case 'N':
                    return 'т';
                case 'm':
                case 'M':
                    return 'ь';
                case ',':
                case '<':
                    return 'б';
                case '.':
                case '>':
                    return 'ю';
                case '/':
                case '?':
                    return '.';
                default:
                    return letter;
            }
        }
        private char ReplaceRussianLetterToEnglish(char letter)
        {
            switch (letter)
            {
                case 'й':
                case 'Й':
                    return 'q';
                case 'ц':
                case 'Ц':
                    return 'w';
                case 'у':
                case 'У':
                    return 'e';
                case 'к':
                case 'К':
                    return 'r';
                case 'е':
                case 'Е':
                    return 't';
                case 'н':
                case 'Н':
                    return 'y';
                case 'г':
                case 'Г':
                    return 'u';
                case 'ш':
                case 'Ш':
                    return 'i';
                case 'щ':
                case 'Щ':
                    return 'o';
                case 'з':
                case 'З':
                    return 'p';
                case 'х':
                case 'Х':
                    return '[';
                case 'ъ':
                case 'Ъ':
                    return ']';
                case 'ф':
                case 'Ф':
                    return 'a';
                case 'ы':
                case 'Ы':
                    return 's';
                case 'в':
                case 'В':
                    return 'd';
                case 'а':
                case 'А':
                    return 'f';
                case 'п':
                case 'П':
                    return 'g';
                case 'р':
                case 'Р':
                    return 'h';
                case 'о':
                case 'О':
                    return 'j';
                case 'л':
                case 'Л':
                    return 'k';
                case 'д':
                case 'Д':
                    return 'l';
                case 'ж':
                case 'Ж':
                    return ';';
                case 'э':
                case 'Э':
                    return '\'';
                case 'я':
                case 'Я':
                    return 'z';
                case 'ч':
                case 'Ч':
                    return 'x';
                case 'с':
                case 'С':
                    return 'c';
                case 'м':
                case 'М':
                    return 'v';
                case 'и':
                case 'И':
                    return 'b';
                case 'т':
                case 'Т':
                    return 'n';
                case 'ь':
                case 'Ь':
                    return 'm';
                case 'б':
                case 'Б':
                    return ',';
                case 'ю':
                case 'Ю':
                    return '.';
                case '.':
                case ',':
                    return '/';
                default:
                    return letter;
            }
        }

    }
}
