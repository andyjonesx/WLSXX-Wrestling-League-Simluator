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

        public static string GetString(string text = null)
        {
            var input = "";
            do
            {
                if (!string.IsNullOrWhiteSpace(text))
                {
                    Console.Write(text);
                }
                input = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(input));

            return input;
        }

        public static string GetCharacter(string text = null)
        {
            var inputStr = "";

            while (inputStr.Length != 1)
            {
                if (!string.IsNullOrWhiteSpace(text))
                {
                    Console.Write(text);
                }
                inputStr = Console.ReadLine();
            }

            return inputStr;
        }

        public static int GetIntCharacter(string text = null)
        {
            var inputStr = "x";
            int inputInt = -1;

            while (!int.TryParse(inputStr, out inputInt) || (int.TryParse(inputStr, out inputInt)))
            {
                if (!string.IsNullOrWhiteSpace(text))
                {
                    Console.Write(text);
                }
                inputStr = Console.ReadLine();
            }

            return inputInt;
        }

        public static int GetIntCharacter(int min, int max, string text = null)
        {
            var inputStr = "-1";
            int inputInt = -1;

            while (!int.TryParse(inputStr, out inputInt) || (int.TryParse(inputStr, out inputInt) && (int.Parse(inputStr) < min || int.Parse(inputStr) > max)))
            {
                if (inputInt != -1)
                { 
                    DisplayHelper.ClearLastConsoleLine();
                }

                if (!string.IsNullOrWhiteSpace(text))
                {
                    Console.Write(text);    
                }

                inputStr = Console.ReadLine();
            }

            int.TryParse(inputStr, out inputInt);

            return inputInt;
        }

        public static int GetIntRating(string text = null)
        {
            var inputStr = "x";
            int inputInt = -1;

            while (!int.TryParse(inputStr, out inputInt) || (int.TryParse(inputStr, out inputInt) && (int.Parse(inputStr) < MIN_ATTRIBUTE || int.Parse(inputStr) > MAX_ATTRIBUTE)))
            {
                if (!string.IsNullOrWhiteSpace(text))
                {
                    Console.Write(text);
                }
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
                if (!string.IsNullOrWhiteSpace(text))
                {
                    Console.Write(text);
                }
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

        public static Promotion SelectPromotionAll()
        {
            DisplayHelper.ClearScreen();

            var options = new Dictionary<int, Promotion>();
            var promotions = PromotionManager.GetList();
            int i = 1;
            foreach (var promotion in promotions)
            {
                options.Add(i, promotion);
                i++;
            }

            Console.WriteLine("Select Promotion");
            foreach (var option in options)
            {
                Console.WriteLine(option.Key.ToString() + ". " + option.Value.Name);
            }

            Console.WriteLine("0. Back");

            var choice = InputHelper.GetIntCharacter(0, options.Count);

            if (choice == 0)
            {
                return null;
            }
            else
            {
                return options[choice];
            }
        }

        public static Wrestler SelectWrestlerAll(Guid promotionId)
        {
            var options = new Dictionary<int, Wrestler>();

            var wrestlers = WrestlerManager.GetList(promotionId);

            int i = 1;
            foreach (var wrestler in wrestlers)
            {
                options.Add(i, wrestler);
                i++;
            }

            foreach(var option in options)
            {
                Console.WriteLine(option.Key.ToString() + ". " + option.Value.Name);
            }

            Console.WriteLine("0. Back");

            var choice = InputHelper.GetIntCharacter(0, options.Count);

            if (choice == 0)
            {
                return null;
            }
            else
            {
                return options[choice];
            }
        }
    }
}
