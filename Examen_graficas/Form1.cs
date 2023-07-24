using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Examen_graficas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grafica_barras.Titles.Add("Datos grafica de Pastel");
            colors.tema_butons("tema");
            {
                btn_graficar.BackColor = colors.color1_txt_recibir;
                btn_limpiar.BackColor = colors.color2_txt_recibir;
            }
        }

        private void icon_actualizar_Click(object sender, EventArgs e)
        {

        }

        private void icon_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_graficar_Click(object sender, EventArgs e)
        {

        }

        private void btn_graficar_Click_1(object sender, EventArgs e)
        {
            string serietxt = txt_serie.Text;


            if (!string.IsNullOrEmpty(txt_datos.Text) && !string.IsNullOrEmpty(txt_serie.Text))
            {
                int datos = Convert.ToInt32(txt_datos.Text);
                if (datos > 0)
                {
                    Series serie = new Series();
                    serie.ChartType = SeriesChartType.Column;
                    grafica_barras.Series[0].Points.AddXY(serietxt, datos);
                    grafica_barras.Update();

                }
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_datos.Text = "";
            txt_serie.Text = "";
            grafica_barras.Series.Clear();
        }
    }
}
