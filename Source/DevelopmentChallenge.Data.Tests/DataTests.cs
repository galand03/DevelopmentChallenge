using System;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void ObtenerReporte_ListaVacia_Castellano()
        {
            // Arrange
            var formas = new List<FormaGeometrica>();

            var formatoReporte = new FormatoReporte();

            // Act
            var reporte = formatoReporte.Imprimir(formas, Idioma.Castellano);

            // Assert
            StringAssert.Contains("<h1>Reporte de Formas</h1>", reporte);
            StringAssert.Contains("<h2>Lista vacía de formas!</h2>", reporte);
        }

        [TestCase]
        public void ObtenerReporte_ListaVacia_Ingles()
        {
            // Arrange
            var formas = new List<FormaGeometrica>();

            var formatoReporte = new FormatoReporte();

            // Act
            var reporte = formatoReporte.Imprimir(formas, Idioma.Ingles);

            // Assert
            StringAssert.Contains("<h1>Shapes report</h1>", reporte);
            StringAssert.Contains("<h2>Empty list of shapes!</h2>", reporte);
        }

        [TestCase]
        public void ObtenerReporte_ListaVacia_Italiano()
        {
            // Arrange
            var formas = new List<FormaGeometrica>();

            var formatoReporte = new FormatoReporte();

            // Act
            var reporte = formatoReporte.Imprimir(formas, Idioma.Italiano);

            // Assert
            StringAssert.Contains("<h1>Rapporto delle forme</h1>", reporte);
            StringAssert.Contains("<h2>Elenco vuoto di forme!</h2>", reporte);
        }

        [TestCase]
        public void ObtenerReporte_Cuadrado_Castellano()
        {
            // Arrange
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(4)
            };

            var formatoReporte = new FormatoReporte();

            // Act
            var reporte = formatoReporte.Imprimir(formas, Idioma.Castellano);

            // Assert
            StringAssert.Contains("<h1>Reporte de Formas</h1>", reporte);
            StringAssert.Contains("Cuadrado | Area 16 | Perimetro 16", reporte);
        }

        [TestCase]
        public void ObtenerReporte_MultiplesCuadrados_Ingles()
        {
            // Arrange
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(4),
                new Cuadrado(5),
                new Cuadrado(6)
            };

            var formatoReporte = new FormatoReporte();

            // Act
            var reporte = formatoReporte.Imprimir(formas, Idioma.Ingles);

            // Assert
            StringAssert.Contains("<h1>Shapes report</h1>", reporte);
        }

        [TestCase]
        public void ObtenerReporte_MultiplesCuadrados_Castellano()
        {
            // Arrange
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(4),
                new Cuadrado(5),
                new Cuadrado(6)
            };

            var formatoReporte = new FormatoReporte();

            // Act
            var reporte = formatoReporte.Imprimir(formas, Idioma.Castellano);

            // Assert
            StringAssert.Contains("<h1>Reporte de Formas</h1>", reporte);
            StringAssert.Contains("Cuadrado | Area 16 | Perimetro 16", reporte);
            StringAssert.Contains("Cuadrado | Area 25 | Perimetro 20", reporte);
            StringAssert.Contains("Cuadrado | Area 36 | Perimetro 24", reporte);
        }

        [TestCase]
        public void ObtenerReporte_MultiplesCuadrados_Italiano()
        {
            // Arrange
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(4),
                new Cuadrado(5),
                new Cuadrado(6)
            };

            var formatoReporte = new FormatoReporte();

            // Act
            var reporte = formatoReporte.Imprimir(formas, Idioma.Italiano);

            // Assert
            StringAssert.Contains("<h1>Rapporto delle forme</h1>", reporte);
            StringAssert.Contains("Quadrato | Area 16 | Perimetro 16", reporte);
            StringAssert.Contains("Quadrato | Area 25 | Perimetro 20", reporte);
            StringAssert.Contains("Quadrato | Area 36 | Perimetro 24", reporte);
        }

        [TestCase]
        public void ObtenerReporte_TodasFormas_Castellano()
        {
            // Arrange
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(4),
                new Circulo(5),
                new TrianguloEquilatero(6),
                new Trapecio(8, 5, 4, 7, 6)
            };

            var formatoReporte = new FormatoReporte();

            // Act
            var reporte = formatoReporte.Imprimir(formas, Idioma.Castellano);

            // Assert
            StringAssert.Contains("<h1>Reporte de Formas</h1>", reporte);
        }

        [TestCase]
        public void ObtenerReporte_TodasFormas_Ingles()
        {
            // Arrange
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(4),
                new Circulo(5),
                new TrianguloEquilatero(6),
                new Trapecio(8, 5, 4, 7, 6)
            };

            var formatoReporte = new FormatoReporte();

            // Act
            var reporte = formatoReporte.Imprimir(formas, Idioma.Ingles);

            // Assert
            StringAssert.Contains("<h1>Shapes report</h1>", reporte);

        }

    }
}
