using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TMD.CF.AccesoDatos.Contrato;
using TMD.CF.AccesoDatos.Implementacion;
using TMD.CF.Entidades;

namespace TMD.CF.AccesoDatos.Test
{
    [TestClass]
    public class LineaBaseDataTest
    {
        static ILineaBaseData _lineaBaseData;

        [ClassInitialize]
        public static void Init(TestContext context)
        {
            _lineaBaseData = new LineaBaseData("BDGestConfig");
        }

        [TestMethod]
        public void ListarPorProyectoFase()
        {
            //ARRANGE  

            //ACT
            var lista = _lineaBaseData.ListarPorProyecto(new Proyecto { Id = 1 });

            //ASSERT
            Assert.IsNotNull(lista);
            Assert.AreNotEqual(0, lista.Count);
        }
    }
}
