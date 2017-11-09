using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaLlantasForm
{

    public enum rin { R16, R19, R22 };
    public enum dibujo { Rallado, Zigzag, Triangular };
    public enum velocidad { H90, H120, H150, H180, H220 };

    

    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();

            comboBoxrin.DataSource = Enum.GetValues(typeof(rin));
            comboBoxdibujo.DataSource = Enum.GetValues(typeof(dibujo));
            comboBoxvelocidad.DataSource = Enum.GetValues(typeof(velocidad));

        }
    }
}
