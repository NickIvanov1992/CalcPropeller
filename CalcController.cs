using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcPropeller
{
    public class CalcController
    {
        public double Diameter { get; set; }
        public double Step { get; set; }
        public CalcController()
        {
                
        }
        public bool Start (double step, double diameter)
        {
            if(CheckFields(step,diameter) == true)
            {
                return true;
            }
            return false;
        }
        private bool CheckFields(double step,double diameter)
        {
            
            if(step > 0)
            {
                return true;
            }
            else
            {
                ShowMessage("Неверно введен шаг или диаметр!");
            }
            return false;
        }
        private void ShowMessage(string message)
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
