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
        public CalcForm(Section a,Section b, Section c, Section d, Section e, Section f)
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
        }

        public void CreateTables(DataGridView table, double[]point)
        {
            int rowX = TableA.Rows.Add();
            int rowY = TableA.Rows.Add();
            table.Rows[0].Cells[0].Value = "X";
            table.Rows[1].Cells[0].Value = "Y";

            for(int i = 1; i < table.Columns.Count; i++ )
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
