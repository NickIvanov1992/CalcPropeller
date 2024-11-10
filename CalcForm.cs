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
        public CalcForm()
        {
            InitializeComponent();
            label3.Text = "Воздушный винт c шагом:" + CalcController.Step +"мм"+ "\n"+
                           "Диаметр:" + CalcController.Diameter + "мм";  
        }
    }
}
