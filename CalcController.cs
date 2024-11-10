using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcPropeller
{
    public class CalcController
    {
        public static double Diameter;
        public static double Step;
        private readonly Result result = new Result();
        public CalcController()
        {

        }
        public bool Start (double step, double diameter)
        {
            Step = step;
            Diameter = diameter;
            if(CheckFields(step,diameter) == true)
            {
                result.GetResult();
                return true;
            }
            return false;
        }
        //установить ограничения для входных параметров
        private bool CheckFields(double step,double diameter)
        {
            
            if(step > 0 && diameter > 0)
            {
                return true;
            }
            else
            {
                ShowMessage("Неверно введен шаг или диаметр!");
            }
            return false;
        }
        internal void ShowMessage(string message)
        {
            MessageBox.Show(
                message,
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
        }

        private static bool IsDigitInput (string value)
        {
            double num;
            bool isDigit = double.TryParse(value, out num);
            return isDigit;
        }
    }
}
