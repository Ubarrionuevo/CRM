using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebadmiClient.Controllers;
using WebadmiClient.Models;


namespace FirsTest
{
    public class Tests
    {
        private Clientes1Controller _controller;

        [SetUp]
        public void Setup()
        {
            // Aquí instancias el controlador y le pasas el contexto de la base de datos simulado
            _controller = new Clientes1Controller();
        }

        [Test]
        public void Index_ReturnsViewWithClientes()
        {
            // Act
            var result = _controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            var model = result.Model as IEnumerable<Clientes>;
            Assert.IsNotNull(model);
            Assert.AreEqual(0, model.Count()); // Verifica que no haya clientes en la vista por defecto
        }
    }
}