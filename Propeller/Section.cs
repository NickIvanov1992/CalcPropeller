using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CalcPropeller.Propeller
{
    //public class Section
    //{
    //    public List<Coordinates> point = new List<Coordinates>();
    //}
    //public struct Coordinates
    //{
    //    public double x, y;
    //}
    public class Section
    {
        public double[] cordinates;
        public double X;
        public double Y;


        public double[]? pointA { get; set; }
        public double[]? pointB { get; set; }
        public double[]? pointC { get; set; }
        public double[]? pointD { get; set; }
        public double[]? pointE { get; set; }
        public double[]? pointF { get; set; }
        public double[]? pointG { get; set; }
        public double[]? pointH { get; set; }
        public double[]? pointI { get; set; }
        public double[]? pointJ { get; set; }
        public double[]? pointK { get; set; }
        public double[]? pointL { get; set; }
        public double[]? pointM { get; set; }
        public double[]? pointN { get; set; }
        public double[]? pointO { get; set; }
        public double[]? pointP { get; set; }
        public double[]? pointQ { get; set; }
        public double[]? pointR { get; set; }
        public double[]? pointS { get; set; }
        public double[]? pointT { get; set; }
        public double[]? pointU { get; set; }
        public double[]? pointV { get; set; }
        public double angle { get; set; }

        public List<double[]> points = new List<double[]>();
        public Section()
        {
            points.Add(pointA);
            points.Add(pointB);
            points.Add(pointC);
            points.Add(pointD);
            points.Add(pointE);
            points.Add(pointF);
            points.Add(pointG);
            points.Add(pointH);
            points.Add(pointI);
            points.Add(pointJ);
            points.Add(pointK);
            points.Add(pointL);
            points.Add(pointM);
            points.Add(pointN);
            points.Add(pointO);
            points.Add(pointP);
            points.Add(pointQ);
            points.Add(pointR);
            points.Add(pointS);
            points.Add(pointT);
            points.Add(pointU);
            points.Add(pointV);
        }

    }
}
