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
        //Section SectionA = new Section();
        //Section SectionB = new Section();
        //Coordinates coordinates = new Coordinates();
        public double[] cordinate = new double[2];
        Section sectionA = new Section();

        public void GetResult()
        {
            CreateSections();
            Show();
        }
        public void Show()
        {
            CalcForm calcForm = new();
            calcForm.Show();
        }

        public void CreateSections()
        {
            sectionA.angle = 16;
            //create A section 14,7% R
            cordinate[1] = 1.5;
            cordinate[2] = CalcController.Step*0.5;
            sectionA.pointA = cordinate;
        }
    }
}
