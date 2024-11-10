using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcPropeller.Propeller;

namespace CalcPropeller
{
    public class Result
    {
        //CalcForm calcForm = new CalcForm();
        Propeller.Propeller propeller = new Propeller.Propeller();

        public void GetResult()
        {
            Show();
        }
        public void Show()
        {
            CalcForm calcForm = new();
            calcForm.Show();
        }
    }
}
