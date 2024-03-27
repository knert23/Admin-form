using System;

namespace IBiZI_lab3
{
    class PasswordAnalyzer
    {
        public static int? AlphabetStrength { get; set; }

        private static int CalculateAlphabetStrength(string password)
        {
            bool lowerCase = false;
            bool upperCase = false;
            bool digits = false;
            bool symbols = false;

            foreach (char ch in password)
            {
                if (char.IsLower(ch))
                {
                    lowerCase = true;
                }
                else if (char.IsUpper(ch))
                {
                    upperCase = true;
                }
                else if (char.IsDigit(ch))
                {
                    digits = true;
                }
                else
                {
                    symbols = true;
                }
            }

            int alphabetStrength = 0;
            if (lowerCase)
            {
                alphabetStrength += 26;
            }
            if (upperCase)
            {
                alphabetStrength += 26;
            }
            if (digits)
            {
                alphabetStrength += 10;
            }
            if (symbols)
            {
                alphabetStrength += 33;
            }

            return alphabetStrength;
        }

        public static Tuple<int, int, int, int, int, int> CalculateSearchTime(string password, float speed, int attemptsThreshold, int delaySeconds)
        {
            if (AlphabetStrength == null)
            {
                AlphabetStrength = CalculateAlphabetStrength(password);
            }

            double possiblePasswordsCount = Math.Pow((double) AlphabetStrength, password.Length);
            int tryCount = (int)(possiblePasswordsCount / attemptsThreshold);
            if (possiblePasswordsCount % attemptsThreshold == 0)
            {
                tryCount--;
            }
            int delayTime = tryCount * delaySeconds;

            double time = possiblePasswordsCount / speed + delayTime;

            int minute = 60;
            int hour = 60 * minute;
            int day = 24 * hour;
            int month = 30 * day;
            int year = 365 * day;

            int yearResult = (int)(time / year);
            int monthResult = (int)((time - year * yearResult) / month);
            int dayResult = (int)((time - year * yearResult - monthResult * month) / day);
            int hourResult = (int)((time - year * yearResult - monthResult * month - dayResult * day) / hour);
            int minuteResult = (int)((time - year * yearResult - monthResult * month - dayResult * day - hourResult * hour) / minute);
            int secondResult = (int)(time - year * yearResult - monthResult * month - dayResult * day - hourResult * hour - minuteResult * minute);

            return Tuple.Create(yearResult, monthResult, dayResult, hourResult, minuteResult, secondResult);
        }
    }
}
