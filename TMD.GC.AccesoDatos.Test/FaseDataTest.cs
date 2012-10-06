using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TMD.CF.Entidades;
using TMD.CF.AccesoDatos.Implementacion;
using TMD.CF.AccesoDatos.Contrato;

namespace TMD.CF.AccesoDatos.Test
{
    [TestClass]
    public class FaseDataTest
    {
        static IFaseData _faseData;

        [ClassInitialize]
        public static void Init(TestContext context)
        {
            _faseData = new FaseData("BDGestConfig");
        }

        [TestMethod]
        public void ListarPorProyecto()
        {
            //ARRANGE  

            //ACT
            var lista = _faseData.ListarPorProyecto(new Proyecto { Id = 1 });

            //ASSERT
            Assert.IsNotNull(lista);
            Assert.AreNotEqual(0, lista.Count);
        }
    }
}
