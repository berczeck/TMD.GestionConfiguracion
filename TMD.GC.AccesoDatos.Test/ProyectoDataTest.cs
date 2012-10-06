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
    public class ProyectoDataTest
    {
        static IProyectoData _proyectoData;

        [ClassInitialize]
        public static void Init(TestContext context)
        {
            _proyectoData = new ProyectoData("BDGestConfig");
        }

        [TestMethod]
        public void ListarPorUsuario()
        {
            //ARRANGE

            //ACT
            var lista = _proyectoData.ListarPorUsuario(new Usuario { Id = 1 });

            //ASSERT
            Assert.IsNotNull(lista);
            Assert.AreNotEqual(0, lista.Count);
        }
    }
}
