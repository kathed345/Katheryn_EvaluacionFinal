using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Examen_graficas
{
    class colors
    {
        public static Color color1_txt_recibir;
        public static Color color2_txt_recibir;
        public static readonly Color color1_txt_dar = Color.FromArgb(116, 155, 194);
        public static readonly Color color2_txt_dar = Color.FromArgb(255, 164, 27);

        public static void tema_butons( string dato)
        {
            if (dato == "tema")
            {
                color1_txt_recibir = color1_txt_dar;
                color2_txt_recibir = color2_txt_dar;
            }

        }

    }
}
