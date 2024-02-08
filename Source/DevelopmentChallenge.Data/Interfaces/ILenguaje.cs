using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public interface ILenguaje
    {
        string ObtenerCabecera(int idioma);
        string Imprimir(List<FormaGeometrica> formas, int idioma);
    }

}
