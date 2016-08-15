using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestApp.Controllers;

namespace TestApp.Tests.Controllers
{
    [TestClass]
    public class UsuariosControllerTest
    {

        [TestMethod]
        public void Get()
        {
            // Arrange
            UsuariosController controller = new UsuariosController();

            // Act
            IEnumerable<string> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(4, result.Count());

        }
    }
}
