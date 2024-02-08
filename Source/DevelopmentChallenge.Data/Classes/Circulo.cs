using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Circulo : FormaGeometrica
    {
        private readonly decimal _radio;

        public Circulo(decimal radio)
        {
            _radio = radio;
        }

        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * _radio * _radio;
        }

        public override decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * 2 * _radio;
        }

        public override string ObtenerNombre(int cantidad, int idioma)
        {
            switch (idioma)
            {
                case Idioma.Castellano:
                    return cantidad == 1 ? "Círculo" : "Círculos";
                case Idioma.Ingles:
                    return cantidad == 1 ? "Circle" : "Circles";
                case Idioma.Italiano:
                    return cantidad == 1 ? "Cerchio" : "Cerchi";
                default:
                    throw new ArgumentOutOfRangeException(nameof(idioma));
            }
        }
    }

}
