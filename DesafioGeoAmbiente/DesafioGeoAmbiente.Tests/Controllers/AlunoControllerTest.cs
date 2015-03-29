using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using DesafioGeoAmbiente.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesafioGeoAmbiente.Tests.Controllers
{
    [TestClass]
    public class AlunoControllerTest
    {
        [TestMethod]
        public void Pesquisar()
        {
            // Arrange
            AlunoController controller = new AlunoController();


            // Act
            ViewResult result = controller.Pesquisar("1") as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
