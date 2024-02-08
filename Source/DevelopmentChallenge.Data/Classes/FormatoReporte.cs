using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class FormatoReporte : ILenguaje
    {
        public string ObtenerCabecera(int idioma)
        {
            return idioma == Idioma.Castellano ? "<h1>Reporte de Formas</h1>" : (idioma == Idioma.Ingles ? "<h1>Shapes report</h1>" : "<h1>Rapporto delle forme</h1>");
        }

        public string Imprimir(List<FormaGeometrica> formas, int idioma)
        {
            var sb = new StringBuilder();
            sb.Append(ObtenerCabecera(idioma));
            sb.Append(GenerarContenido(idioma, formas));
            return sb.ToString();
        }

        private string GenerarContenido(int idioma, List<FormaGeometrica> formas)
        {
            var sb = new StringBuilder();

            if (formas.Count == 0)
            {
                sb.Append(idioma == Idioma.Castellano ? "<h2>Lista vacía de formas!</h2>" : (idioma == Idioma.Ingles ? "<h2>Empty list of shapes!</h2>" : "<h2>Elenco vuoto di forme!</h2>"));
            }
            else
            {
                var totalArea = 0m;
                var totalPerimetro = 0m;

                foreach (var forma in formas)
                {
                    totalArea += forma.CalcularArea();
                    totalPerimetro += forma.CalcularPerimetro();
                    sb.Append(forma.ObtenerNombre(1, idioma) + " | Area " + forma.CalcularArea().ToString("#.##") + " | Perimetro " + forma.CalcularPerimetro().ToString("#.##") + "<br/>");
                }

                sb.Append("TOTAL:<br/>");
                sb.Append(formas.Count + " " + (idioma == Idioma.Castellano ? "formas" : (idioma == Idioma.Ingles ? "shapes" : "forme")) + " ");
                sb.Append((idioma == Idioma.Castellano ? "Perimetro " : (idioma == Idioma.Ingles ? "Perimeter " : "Perimetro ")) + totalPerimetro.ToString("#.##") + " ");
                sb.Append("Area " + totalArea.ToString("#.##"));
            }

            return sb.ToString();
        }
    }

}
