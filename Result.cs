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
        public double xCenterChord;
        Section sectionA = new Section();
        Section sectionB = new();
        Section sectionC = new();
        Section sectionD = new();
        Section sectionE = new();
        Section sectionF = new();

        public void GetResult()
        {
            CreateSections();
            Show();      
        }
        public void Show()
        {
            CalcForm calcForm = new(sectionA, sectionB, sectionC, sectionD, sectionE, sectionF);
            calcForm.Show();
        }
        public void CreateSections()
        {
            //create A section 14,7% R
            xCenterChord = Math.Round(13.4 / 2,2);
            sectionA.angle = CalcAngle(14.7);
            sectionA.points[0] = WriteCordinates(-xCenterChord, 0);
            sectionA.points[1] = WriteCordinates(0, 5.5 / 2);
            sectionA.points[2] = WriteCordinates(xCenterChord, 0);
            sectionA.points[3] = WriteCordinates(0, -(5.5 / 2));
            
            //create B section 30% R
            xCenterChord = Math.Round(13.5 / 2,2);
            sectionB.angle = CalcAngle(30);
            sectionB.points[0] = WriteCordinates(-xCenterChord, 0);
            sectionB.points[1] = WriteCordinates(-xCenterChord+ 1.35, 0.850);
            sectionB.points[2] = WriteCordinates(-xCenterChord + 1.35*2, 1.324);
            sectionB.points[3] = WriteCordinates(-xCenterChord + 1.35 * 3, 1.740);
            sectionB.points[4] = WriteCordinates(-xCenterChord + 1.35 * 4, 2.120);
            sectionB.points[5] = WriteCordinates(-xCenterChord + 1.35 * 5, 2.416);
            sectionB.points[6] = WriteCordinates(-xCenterChord + 1.35 * 6, 2.604);
            sectionB.points[7] = WriteCordinates(-xCenterChord + 1.35 * 7, 2.622);
            sectionB.points[8] = WriteCordinates(-xCenterChord + 1.35 * 8, 2.422);
            sectionB.points[9] = WriteCordinates(-xCenterChord + 1.35 * 9, 1.944);
            sectionB.points[10] = WriteCordinates(-xCenterChord + 1.35 * 9 + 0.574, 1.308);
            sectionB.points[11] = WriteCordinates(-xCenterChord + 1.35 * 10, 0);
            sectionB.points[12] = WriteCordinates(-xCenterChord + 1.35 * 9 + 0.574, -0.1);
            sectionB.points[13] = WriteCordinates(-xCenterChord + 1.35 * 9, -0.932);
            sectionB.points[14] = WriteCordinates(-xCenterChord + 1.35 * 8, -1.052);
            sectionB.points[15] = WriteCordinates(-xCenterChord + 1.35 * 7, -1.092);
            sectionB.points[16] = WriteCordinates(-xCenterChord + 1.35 * 6, -1.080);
            sectionB.points[17] = WriteCordinates(-xCenterChord + 1.35 * 5, -1.030);
            sectionB.points[18] = WriteCordinates(-xCenterChord + 1.35 * 4, -0.874);
            sectionB.points[19] = WriteCordinates(-xCenterChord + 1.35 * 3, -0.828);
            sectionB.points[20] = WriteCordinates(-xCenterChord + 1.35 * 2, -0.728);
            sectionB.points[21] = WriteCordinates(-xCenterChord + 1.35, -0.594);

            //create C section 45% R
            xCenterChord = Math.Round(16.3 / 2, 2);
            sectionC.angle = CalcAngle(45);
            sectionC.points[0] = WriteCordinates(-xCenterChord, 0);
            sectionC.points[1] = WriteCordinates(-xCenterChord + 1.626, 1.056);
            sectionC.points[2] = WriteCordinates(-xCenterChord + 1.626 * 2, 1.576);
            sectionC.points[3] = WriteCordinates(-xCenterChord + 1.626 * 3, 2.016);
            sectionC.points[4] = WriteCordinates(-xCenterChord + 1.626 * 4, 2.358);
            sectionC.points[5] = WriteCordinates(-xCenterChord + 1.626 * 5, 2.568);
            sectionC.points[6] = WriteCordinates(-xCenterChord + 1.626 * 6, 2.700);
            sectionC.points[7] = WriteCordinates(-xCenterChord + 1.626 * 7, 2.730);
            sectionC.points[8] = WriteCordinates(-xCenterChord + 1.626 * 8, 2.600);
            sectionC.points[9] = WriteCordinates(-xCenterChord + 1.626 * 9, 2.096);
            sectionC.points[10] = WriteCordinates(-xCenterChord + 1.626 * 9 + 0.810, 1.610);
            sectionC.points[11] = WriteCordinates(-xCenterChord + 1.626 * 10, 0);

            //create D section 60% R
            xCenterChord = Math.Round(16.4 / 2, 2);
            sectionD.angle = CalcAngle(60);
            sectionD.points[0] = WriteCordinates(-xCenterChord, 0);
            sectionD.points[1] = WriteCordinates(-xCenterChord + 1.64, 0.770);
            sectionD.points[2] = WriteCordinates(-xCenterChord + 1.64 * 2, 1.012);
            sectionD.points[3] = WriteCordinates(-xCenterChord + 1.64 * 3, 1.572);
            sectionD.points[4] = WriteCordinates(-xCenterChord + 1.64 * 4, 1.838);
            sectionD.points[5] = WriteCordinates(-xCenterChord + 1.64*5, 2.000);
            sectionD.points[6] = WriteCordinates(-xCenterChord + 1.64 * 6, 2.080);
            sectionD.points[7] = WriteCordinates(-xCenterChord + 1.64 * 7, 2.114);
            sectionD.points[8] = WriteCordinates(-xCenterChord + 1.64 * 8, 2.046);
            sectionD.points[9] = WriteCordinates(-xCenterChord + 1.64 * 9, 1.690);
            sectionD.points[10] = WriteCordinates(-xCenterChord + 1.64 * 9 + 0.820, 1.278);
            sectionD.points[11] = WriteCordinates(-xCenterChord + 1.64 * 10, 0);

            //create E section 75% R
            xCenterChord = Math.Round(14.5 / 2, 2);
            sectionE.angle = CalcAngle(75);
            sectionE.points[0] = WriteCordinates(-xCenterChord, 0);
            sectionE.points[1] = WriteCordinates(-xCenterChord + 1.45, 0.548);
            sectionE.points[2] = WriteCordinates(-xCenterChord + 1.45 * 2, 0.852);
            sectionE.points[3] = WriteCordinates(-xCenterChord + 1.45 * 3, 1.128);
            sectionE.points[4] = WriteCordinates(-xCenterChord + 1.45 * 4, 1.320);
            sectionE.points[5] = WriteCordinates(-xCenterChord + 1.45 * 5, 1.450);
            sectionE.points[6] = WriteCordinates(-xCenterChord + 1.45 * 6, 1.494);
            sectionE.points[7] = WriteCordinates(-xCenterChord + 1.45 * 7, 1.510);
            sectionE.points[8] = WriteCordinates(-xCenterChord + 1.45 * 8, 1.430);
            sectionE.points[9] = WriteCordinates(-xCenterChord + 1.45 * 9, 1.170);
            sectionE.points[10] = WriteCordinates(-xCenterChord + 1.45 * 9 + 0.782, 0.882);
            sectionE.points[11] = WriteCordinates(-xCenterChord + 1.45 * 10, 0);

            //create F section 90% R
            xCenterChord = Math.Round(10.16 / 2, 2);
            sectionF.angle = CalcAngle(90);
            sectionF.points[0] = WriteCordinates(-xCenterChord, 0);
            sectionF.points[1] = WriteCordinates(-xCenterChord + 1.02, 0.366);
            sectionF.points[2] = WriteCordinates(-xCenterChord + 1.02*2, 0.528);
            sectionF.points[3] = WriteCordinates(-xCenterChord + 1.02 * 3, 0.660);
            sectionF.points[4] = WriteCordinates(-xCenterChord + 1.02 * 4, 0.762);
            sectionF.points[5] = WriteCordinates(-xCenterChord + 1.02 * 5, 0.882);
            sectionF.points[6] = WriteCordinates(-xCenterChord + 1.02 * 6, 0.862);
            sectionF.points[7] = WriteCordinates(-xCenterChord + 1.02 * 7, 0.872);
            sectionF.points[8] = WriteCordinates(-xCenterChord + 1.02 * 8, 0.832);
            sectionF.points[9] = WriteCordinates(-xCenterChord + 1.02 * 9, 0.700);
            sectionF.points[10] = WriteCordinates(-xCenterChord + 1.02 * 9 + 0.508, 0.518);
            sectionF.points[11] = WriteCordinates(-xCenterChord + 1.02 * 10, 0);
        }
        private double CalcAngle(double percent) =>
                    (Math.Atan((CalcController.Step / (2 * Math.PI)) / (CalcController.Diameter / 2 / 100 * percent))) / (Math.PI/180);
        private double CalcValue(double percent) =>
            Math.Round(percent * (CalcController.Diameter / 2/100),2);
        private double[] WriteCordinates(double X,double Y)
        {
             double[] cordinates = new double[2];
             cordinates[0] = CalcValue(X);
             cordinates[1] = CalcValue(Y);
             return cordinates;
        }
    }
}
