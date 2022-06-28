using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Classes.Shapes;
using CodingChallenge.Data.Classes.Translation;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVaciaSpanish()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                GenerateReport.Print(new List<GeometricShape>(), Languages.Spanish));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnglish()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                GenerateReport.Print(new List<GeometricShape>(), Languages.English));
        }

        [TestCase]
        public void TestResumenListaConUnCuadradoSpanish()
        {
            var cuadrados = ShapeMother.GetOneSquare();

            var resumen = GenerateReport.Print(cuadrados, Languages.Spanish);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 forma | Perimetro 20 | Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadradosEnglish()
        {
            var cuadrados = ShapeMother.GetAssortedSquareList();

            var resumen = GenerateReport.Print(cuadrados, Languages.English);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes | Perimeter 36 | Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnglish()
        {
            var formas = ShapeMother.GetAssortedList();
            
            var resumen = GenerateReport.Print(formas, Languages.English);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13.01 | Perimeter 18.06 <br/>3 Equilateral Triangles | Area 49.64 | Perimeter 51.6 <br/>TOTAL:<br/>7 shapes | Perimeter 97.66 | Area 91.65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposSpanish()
        {
            var formas = ShapeMother.GetAssortedList();

            var resumen = GenerateReport.Print(formas, Languages.Spanish);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos Equiláteros | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas | Perimetro 97,66 | Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecioFrench()
        {
            var trapecio = ShapeMother.GetOneTrapeze();

            var resumen = GenerateReport.Print(trapecio, Languages.French);

            Assert.AreEqual("<h1>Poste de formes</h1>1 Trapèze | Aire 276 | Périmètre 74 <br/>TOTAL:<br/>1 forme | Périmètre 74 | Aire 276", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposFrench()
        {
            var formas = ShapeMother.GetAssortedList();

            var resumen = GenerateReport.Print(formas, Languages.French);

            Assert.AreEqual(
                "<h1>Poste de formes</h1>2 Carrés | Aire 29 | Périmètre 28 <br/>2 Cercles | Aire 13,01 | Périmètre 18,06 <br/>3 Triangles Équilatéraux | Aire 49,64 | Périmètre 51,6 <br/>TOTAL:<br/>7 formes | Périmètre 97,66 | Aire 91,65",
                resumen);
        }

        [TestCase]
        public void TestLanzarExcepcionConFormaDesconocida()
        {
            var formaDesconocida = ShapeMother.GetUnknonwShape();

            Assert.Throws<ArgumentException>(() => GenerateReport.Print(formaDesconocida));
        }

        [TestCase]
        public void TestIdiomaDefaultEnglish() => 
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                GenerateReport.Print(new List<GeometricShape>()));

        [TestCase]
        public void TestIdiomaDefaultConIdiomaDesconocido() =>
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                GenerateReport.Print(new List<GeometricShape>(), Languages.German));
    }
}
