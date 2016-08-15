using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestApp.Controllers;

namespace TestApp.Tests.Controllers
{
    [TestClass]
    public class CotizacionControllerTest
    {

        [TestMethod]
        public void GetPesoCotizacion()
        {
            CotizacionController controller = new CotizacionController();
            try
            {
                var result = controller.Get("Peso").Result;
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is Exception);
            }
           
        }
        [TestMethod]
        public void GetDolarCotizacion()
        {
            CotizacionController controller = new CotizacionController();
            try
            {
                var result = controller.Get("Dolar").Result;
                Assert.IsNotNull(result);
            }
            catch (Exception)
            {
                Assert.Fail("exception thrown");
            }

        }
        [TestMethod]
        public void GetRealCotizacion()
        {
            CotizacionController controller = new CotizacionController();
            try
            {
                var result = controller.Get("Real").Result;
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is Exception);
            }

        }
    }
}
