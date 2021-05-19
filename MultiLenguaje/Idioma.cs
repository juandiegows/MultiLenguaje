using MultiLenguaje.Lenguajes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiLenguaje
{
   public class Idioma
    {
        public String Nombre { get; set; }
        public String Abreviacion{ get; set; }
        public String Pais { get; set; }
        public String AbreviacionPais{ get; set; }

        public String NombrePais
        {
            get
            {
                return Nombre + "(" + Pais + ")";

            }
        }
        public String CultureInfo
        {
            get
            {
                return Abreviacion + "-" + AbreviacionPais;
            }
        }

        public static List<Idioma> ObtenerIdiomas()
        {
            return new List<Idioma> {
                new Idioma
                {
                    Nombre = "Español",
                    Abreviacion = "es",
                    Pais = "Colombia",
                    AbreviacionPais = "CO"
                },
                 new Idioma
                {
                    Nombre = "English",
                    Abreviacion = "en",
                    Pais = "Estados Unidos",
                    AbreviacionPais = "US"
                },
                  new Idioma
                {
                    Nombre = "português",
                    Abreviacion = "pt",
                    Pais = "Brazil",
                    AbreviacionPais = "BR"
                }
            };
        }

        public static void CambiarTexto(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                if(c is Panel)
                {
                    CambiarTexto(c.Controls);
                }
                else
                {
                    String text = Strings.ResourceManager.GetString(c.Name);
                    if (text != null)
                    {
                        c.Text = text;
                    }
                }
               
            }
        }

    }
}
