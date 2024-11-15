using CalcPropeller.Propeller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcPropeller
{
    public partial class CalcForm : Form
    {
        private readonly Section a = new Section();
        private readonly Section b = new Section();
        private readonly Section c = new Section();
        private readonly Section d = new Section();
        private readonly Section e = new Section();
        private readonly Section f = new Section();
        public CalcForm(Section a, Section b, Section c, Section d, Section e, Section f)
        {
            InitializeComponent();
            label3.Text = "Воздушный винт c шагом:" + CalcController.Step + "мм" + "\n" +
                           "Диаметр:" + CalcController.Diameter + "мм";
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
            this.f = f;
            AddDataOnTables();
        }
        public void AddDataOnTables()
        {
            CreateTables(TableA, a.pointA);
            CreateTables(TableA, a.pointB);
            CreateTables(TableA, a.pointC);
            CreateTables(TableA, a.pointD);

            CreateTables(TableB, b.pointA);
            CreateTables(TableB, b.pointB);
            CreateTables(TableB, b.pointC);
            CreateTables(TableB, b.pointD);
            CreateTables(TableB, b.pointE);
            CreateTables(TableB, b.pointF);
            CreateTables(TableB, b.pointG);
            CreateTables(TableB, b.pointH);
            CreateTables(TableB, b.pointI);
            CreateTables(TableB, b.pointJ);
            CreateTables(TableB, b.pointK);
            CreateTables(TableB, b.pointL);
            CreateTables(TableB, b.pointM);
            CreateTables(TableB, b.pointN);
            CreateTables(TableB, b.pointO);
            CreateTables(TableB, b.pointP);
            CreateTables(TableB, b.pointQ);
            CreateTables(TableB, b.pointR);
            CreateTables(TableB, b.pointS);
            CreateTables(TableB, b.pointT);
            CreateTables(TableB, b.pointU);
            CreateTables(TableB, b.pointV);

            CreateTables(TableC, c.pointA);
            CreateTables(TableC, c.pointB);
            CreateTables(TableC, c.pointC);
            CreateTables(TableC, c.pointD);
            CreateTables(TableC, c.pointE);
            CreateTables(TableC, c.pointF);
            CreateTables(TableC, c.pointG);
            CreateTables(TableC, c.pointH);
            CreateTables(TableC, c.pointI);
            CreateTables(TableC, c.pointJ);
            CreateTables(TableC, c.pointK);
            CreateTables(TableC, c.pointL);

            CreateTables(TableD, d.pointA);
            CreateTables(TableD, d.pointB);
            CreateTables(TableD, d.pointC);
            CreateTables(TableD, d.pointD);
            CreateTables(TableD, d.pointE);
            CreateTables(TableD, d.pointF);
            CreateTables(TableD, d.pointG);
            CreateTables(TableD, d.pointH);
            CreateTables(TableD, d.pointI);
            CreateTables(TableD, d.pointJ);
            CreateTables(TableD, d.pointK);
            CreateTables(TableD, d.pointL);

            CreateTables(TableE, e.pointA);
            CreateTables(TableE, e.pointB);
            CreateTables(TableE, e.pointC);
            CreateTables(TableE, e.pointD);
            CreateTables(TableE, e.pointE);
            CreateTables(TableE, e.pointF);
            CreateTables(TableE, e.pointG);
            CreateTables(TableE, e.pointH);
            CreateTables(TableE, e.pointI);
            CreateTables(TableE, e.pointJ);
            CreateTables(TableE, e.pointK);
            CreateTables(TableE, e.pointL);

            CreateTables(TableF, f.pointA);
            CreateTables(TableF, f.pointB);
            CreateTables(TableF, f.pointC);
            CreateTables(TableF, f.pointD);
            CreateTables(TableF, f.pointE);
            CreateTables(TableF, f.pointF);
            CreateTables(TableF, f.pointG);
            CreateTables(TableF, f.pointH);
            CreateTables(TableF, f.pointI);
            CreateTables(TableF, f.pointJ);
            CreateTables(TableF, f.pointK);
            CreateTables(TableF, f.pointL);
        }

        public void CreateTables(DataGridView table, double[] point)
        {
            if (table.Rows.Count < 2)
            {
                int rowX = table.Rows.Add();
                int rowY = table.Rows.Add();
                table.Rows[0].Cells[0].Value = "X";
                table.Rows[1].Cells[0].Value = "Y";
            }


            for (int i = 1; i < table.Columns.Count; i++)
            {
                if (table.Rows[0].Cells[i].Value == null)
                {
                    table.Rows[0].Cells[i].Value = point[0];
                    table.Rows[1].Cells[i].Value = point[1];
                    break;
                }
            }

        }
    }
}
