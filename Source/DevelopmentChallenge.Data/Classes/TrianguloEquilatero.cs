using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class TrianguloEquilatero : FormaGeometrica
    {
        private readonly decimal _lado;

        public TrianguloEquilatero(decimal lado)
        {
            _lado = lado;
        }

        public override decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado * 3;
        }

        public override string ObtenerNombre(int cantidad, int idioma)
        {
            switch (idioma)
            {
                case Idioma.Castellano:
                    return cantidad == 1 ? "Triángulo Equilátero" : "Triángulos Equiláteros";
                case Idioma.Ingles:
                    return cantidad == 1 ? "Equilateral Triangle" : "Equilateral Triangles";
                case Idioma.Italiano:
                    return cantidad == 1 ? "Triangolo Equilatero" : "Triangoli Equilateri";
                default:
                    throw new ArgumentOutOfRangeException(nameof(idioma));
            }
        }
    }

}
