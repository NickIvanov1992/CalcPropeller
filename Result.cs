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
            CalcForm calcForm = new(sectionA,sectionB,sectionC,sectionD,sectionE,sectionF);
            calcForm.Show();
           // calcForm.CreateChart();
        }

        public void CreateSections()
        {
            //create A section 14,7% R
            xCenterChord = Math.Round(13.4 / 2,2);
            sectionA.angle = CalcAngle(14.7);
            sectionA.pointA = WriteCordinates(-xCenterChord, 0);
            sectionA.pointB = WriteCordinates(0, 5.5 / 2);
            sectionA.pointC = WriteCordinates(xCenterChord, 0);
            sectionA.pointD = WriteCordinates(0, -(5.5 / 2));

            //create B section 30% R
            xCenterChord = Math.Round(13.5 / 2,2);
            sectionB.angle = CalcAngle(30);
            sectionB.pointA = WriteCordinates(-xCenterChord, 0);
            sectionB.pointB = WriteCordinates(-xCenterChord+ 1.35, 0.850);
            sectionB.pointC = WriteCordinates(-xCenterChord + 1.35*2, 1.324);
            sectionB.pointD = WriteCordinates(-xCenterChord + 1.35 * 3, 1.740);
            sectionB.pointE = WriteCordinates(-xCenterChord + 1.35 * 4, 2.120);
            sectionB.pointF = WriteCordinates(-xCenterChord + 1.35 * 5, 2.416);
            sectionB.pointG = WriteCordinates(-xCenterChord + 1.35 * 6, 2.604);
            sectionB.pointH = WriteCordinates(-xCenterChord + 1.35 * 7, 2.622);
            sectionB.pointI = WriteCordinates(-xCenterChord + 1.35 * 8, 2.422);
            sectionB.pointJ = WriteCordinates(-xCenterChord + 1.35 * 9, 1.944);
            sectionB.pointK = WriteCordinates(-xCenterChord + 1.35 * 9 + 0.574, 1.308);
            sectionB.pointL = WriteCordinates(-xCenterChord + 1.35 * 10, 0);
            sectionB.pointM = WriteCordinates(-xCenterChord + 1.35 * 9 + 0.574, -0.1);
            sectionB.pointN = WriteCordinates(-xCenterChord + 1.35 * 9, -0.932);
            sectionB.pointO = WriteCordinates(-xCenterChord + 1.35 * 8, -1.052);
            sectionB.pointP = WriteCordinates(-xCenterChord + 1.35 * 7, -1.092);
            sectionB.pointQ = WriteCordinates(-xCenterChord + 1.35 * 6, -1.080);
            sectionB.pointR = WriteCordinates(-xCenterChord + 1.35 * 5, -1.030);
            sectionB.pointS = WriteCordinates(-xCenterChord + 1.35 * 4, -0.874);
            sectionB.pointT = WriteCordinates(-xCenterChord + 1.35 * 3, -0.828);
            sectionB.pointU = WriteCordinates(-xCenterChord + 1.35 * 2, -0.728);
            sectionB.pointV = WriteCordinates(-xCenterChord + 1.35, -0.594);

            //create C section 45% R
            xCenterChord = Math.Round(16.3 / 2, 2);
            sectionC.angle = CalcAngle(45);
            sectionC.pointA = WriteCordinates(-xCenterChord, 0);
            sectionC.pointB = WriteCordinates(-xCenterChord + 1.626, 1.056);
            sectionC.pointC = WriteCordinates(-xCenterChord + 1.626 * 2, 1.576);
            sectionC.pointD = WriteCordinates(-xCenterChord + 1.626 * 3, 2.016);
            sectionC.pointE = WriteCordinates(-xCenterChord + 1.626 * 4, 2.358);
            sectionC.pointF = WriteCordinates(-xCenterChord + 1.626 * 5, 2.568);
            sectionC.pointG = WriteCordinates(-xCenterChord + 1.626 * 6, 2.700);
            sectionC.pointH = WriteCordinates(-xCenterChord + 1.626 * 7, 2.730);
            sectionC.pointI = WriteCordinates(-xCenterChord + 1.626 * 8, 2.600);
            sectionC.pointJ = WriteCordinates(-xCenterChord + 1.626 * 9, 2.096);
            sectionC.pointK = WriteCordinates(-xCenterChord + 1.626 * 9 + 0.810, 1.610);
            sectionC.pointL = WriteCordinates(-xCenterChord + 1.626 * 10, 0);

            //create D section 60% R
            xCenterChord = Math.Round(16.4 / 2, 2);
            sectionD.angle = CalcAngle(60);
            sectionD.pointA = WriteCordinates(-xCenterChord, 0);
            sectionD.pointB = WriteCordinates(-xCenterChord + 1.64, 0.770);
            sectionD.pointC = WriteCordinates(-xCenterChord + 1.64 * 2, 1.012);
            sectionD.pointD = WriteCordinates(-xCenterChord + 1.64 * 3, 1.572);
            sectionD.pointE = WriteCordinates(-xCenterChord + 1.64 * 4, 1.838);
            sectionD.pointF = WriteCordinates(-xCenterChord + 1.64*5, 2.000);
            sectionD.pointG = WriteCordinates(-xCenterChord + 1.64 * 6, 2.080);
            sectionD.pointH = WriteCordinates(-xCenterChord + 1.64 * 7, 2.114);
            sectionD.pointI = WriteCordinates(-xCenterChord + 1.64 * 8, 2.046);
            sectionD.pointJ = WriteCordinates(-xCenterChord + 1.64 * 9, 1.690);
            sectionD.pointK = WriteCordinates(-xCenterChord + 1.64 * 9 + 0.820, 1.278);
            sectionD.pointL = WriteCordinates(-xCenterChord + 1.64 * 10, 0);

            //create E section 75% R
            xCenterChord = Math.Round(14.5 / 2, 2);
            sectionE.angle = CalcAngle(75);
            sectionE.pointA = WriteCordinates(-xCenterChord, 0);
            sectionE.pointB = WriteCordinates(-xCenterChord + 1.45, 0.548);
            sectionE.pointC = WriteCordinates(-xCenterChord + 1.45 * 2, 0.852);
            sectionE.pointD = WriteCordinates(-xCenterChord + 1.45 * 3, 1.128);
            sectionE.pointE = WriteCordinates(-xCenterChord + 1.45 * 4, 1.320);
            sectionE.pointF = WriteCordinates(-xCenterChord + 1.45 * 5, 1.450);
            sectionE.pointG = WriteCordinates(-xCenterChord + 1.45 * 6, 1.494);
            sectionE.pointH = WriteCordinates(-xCenterChord + 1.45 * 7, 1.510);
            sectionE.pointI = WriteCordinates(-xCenterChord + 1.45 * 8, 1.430);
            sectionE.pointJ = WriteCordinates(-xCenterChord + 1.45 * 9, 1.170);
            sectionE.pointK = WriteCordinates(-xCenterChord + 1.45 * 9 + 0.782, 0.882);
            sectionE.pointL = WriteCordinates(-xCenterChord + 1.45 * 10, 0);

            //create F section 90% R
            xCenterChord = Math.Round(10.16 / 2, 2);
            sectionF.angle = CalcAngle(90);
            sectionF.pointA = WriteCordinates(-xCenterChord, 0);
            sectionF.pointB = WriteCordinates(-xCenterChord + 1.02, 0.366);
            sectionF.pointC = WriteCordinates(-xCenterChord + 1.02*2, 0.528);
            sectionF.pointD = WriteCordinates(-xCenterChord + 1.02 * 3, 0.660);
            sectionF.pointE = WriteCordinates(-xCenterChord + 1.02 * 4, 0.762);
            sectionF.pointF = WriteCordinates(-xCenterChord + 1.02 * 5, 0.882);
            sectionF.pointG = WriteCordinates(-xCenterChord + 1.02 * 6, 0.862);
            sectionF.pointH = WriteCordinates(-xCenterChord + 1.02 * 7, 0.872);
            sectionF.pointI = WriteCordinates(-xCenterChord + 1.02 * 8, 0.832);
            sectionF.pointJ = WriteCordinates(-xCenterChord + 1.02 * 9, 0.700);
            sectionF.pointK = WriteCordinates(-xCenterChord + 1.02 * 9 + 0.508, 0.518);
            sectionF.pointL = WriteCordinates(-xCenterChord + 1.02 * 10, 0);
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
