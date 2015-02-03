using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WLSXX.Model.Enumerations;
using WLSXX.Model;
using WLSXX.DataAccess;

namespace WLSXX.Helpers
{
    public static class InputHelper
    {
        public const int MAX_ATTRIBUTE = 100;
        public const int MIN_ATTRIBUTE = 0;

        public static string GetString(string text)
        {
            var input = "";
            do
            {
                Console.Write(text);
                input = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(input));

            return input;
        }

        public static int GetIntRating(string text)
        {
            var inputStr = "x";
            int inputInt = -1;

            while (!int.TryParse(inputStr, out inputInt) || (int.TryParse(inputStr, out inputInt) && (int.Parse(inputStr) < MIN_ATTRIBUTE || int.Parse(inputStr) > MAX_ATTRIBUTE)))
            {
                Console.Write(text);
                inputStr = Console.ReadLine();
            }

            int.TryParse(inputStr, out inputInt);

            return inputInt;
        }

        public static GenderEnum GetGender(string text = null)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                text = "Gender (M/F): ";
            }

            var gender = 'x';
            do
            {
                Console.Write(text);
                gender = Console.ReadKey().KeyChar;
            } while (gender != 'f' && gender != 'm');

            if (gender == 'm')
            {
                return GenderEnum.Male;
            }
            else if (gender == 'f')
            {
                return GenderEnum.Female;
            }
            else
            {
                return GenderEnum.Male;
            }
        }

        public static Wrestler SelectWrestlerAll()
        {
            var wrestlers = WrestlerManager.GetWrestlers();

            int i = 1;
            foreach (var wrestler in wrestlers)
            {
                Console.WriteLine(i.ToString() + ". " + wrestler.Name);
                i++;
            }

            Console.WriteLine(i.ToString() + ". Back");

            var choice = Console.ReadKey();

            int intChoice = -1;

            if (int.TryParse(choice.KeyChar.ToString(), out intChoice))
            {
                if (intChoice == i)
                {
                    return null;
                }
                else
                {
                    return wrestlers.ElementAt(intChoice - 1);
                }
            }
            else
            {
                SelectWrestlerAll();
            }

            return null;
        }
    }
}
