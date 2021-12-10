using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MattiasÖvning3
{
    public static class Util
    {
        public static string AskForString(string prompt, IUI ui)
        {
            bool nice = false;
            string answer;

            do
            {
                ui.PrintString($"{prompt}: ");
                answer = ui.GetStringInput();

                if (string.IsNullOrEmpty(answer))
                {
                    ui.PrintString($"You must enter a {prompt}");
                }
                else
                {
                    nice = true;
                }
            } while (!nice);
            return answer;
        }

        public static int AskForUInt(string prompt, IUI ui)
        {
            do
            {
                string input = AskForString(prompt, ui);
                if (int.TryParse(input, out int answer)) return answer;
            } while (true);
        }

        public static double AskForDouble(string prompt, IUI ui)
        {
            do
            {
                string input = AskForString(prompt, ui);
                if (double.TryParse(input, out double answer)) return answer;
            } while (true);
        }
    }
}
