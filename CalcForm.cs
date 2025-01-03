﻿using CalcPropeller.Propeller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
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
        Pen pen = new Pen(Color.Black, 3f);
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
            AddDataOnTables(a, TableA);
            AddDataOnTables(b, TableB);
            AddDataOnTables(c, TableC);
            AddDataOnTables(d, TableD);
            AddDataOnTables(e, TableE);
            AddDataOnTables(f, TableF);
            pictureBox1.Paint += CalcFormChart_Load;
        }
        public void AddDataOnTables(Section section, DataGridView table)
        {
            for (int i = 0; i < section.points.Count; i++)
            {
                CreateTables(table, section.points[i]);
            }
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

        private void CalcFormChart_Load(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;
            GetCurrentPoints();
            Point[] points = GetCurrentPoints();
            graphics.DrawLines(pen, points);
        }
        private Point[] GetCurrentPoints()
        {
            Point[] point = new Point[12];
            if (tabControl1.SelectedTab == tabControl1.TabPages[0])
            {
                point = new Point[4 + 1];
                return SetPointsValue(point, a);
            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages[1])
            {
                point = new Point[22 + 1];
                return SetPointsValue(point, b);
            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages[2])
            {
                point = new Point[12 + 1];
                return SetPointsValue(point, c);
            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages[3])
            {
                point = new Point[12 + 1];
                return SetPointsValue(point, d);
            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages[4])
            {
                point = new Point[12 + 1];
                return SetPointsValue(point, e);
            }
            else
                return SetPointsValue(point, f);
        }
        private Point[] SetPointsValue(Point[] p, Section s)
        {
            for (int i = 0; i < p.Length - 1; i++)
            {
                p[i].X = Convert.ToInt32((s.points[i][0] * 100 / 8) + 150);
                p[i].Y = Convert.ToInt32((-s.points[i][1] * 100 / 8) + 150);
            }
            p[p.Length - 1].X = p[0].X;
            p[p.Length - 1].Y = p[0].Y;
            return p;
        }
        private void CalcForm_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            ReloadPicture();
        }
        private void ReloadPicture()
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            GetCurrentPoints();
            Point[] points = GetCurrentPoints();
            graphics.DrawLines(pen, points);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateHtmlPage();
        }
        private void CreateHtmlPage()
        {
            var html = new StringBuilder(); // Тут будет наш html
            html.AppendLine("<table>"); // Начало таблицы
                                        // Сначала делаем заголовки
            html.AppendLine("<tr>"); // Начало строки
            foreach (DataGridViewTextBoxColumn column in TableA.Columns)
            {
                html.AppendLine(string.Format("<td>{0}</td>", column.Name));
            }
            html.AppendLine("</tr>"); // Конец строки
                                      // Теперь сами данные
            foreach (DataGridViewRow row in TableA.Rows)
            {
                html.AppendLine("<tr>"); // Начало строки
                foreach (DataGridViewTextBoxColumn column in TableA.Columns)
                {
                    // html.AppendLine(string.Format("<td>{0}</td>", row[column]));
                }
                html.AppendLine("</tr>"); // Конец строки
            }
            html.AppendLine("</table>");
        }
    }
}
