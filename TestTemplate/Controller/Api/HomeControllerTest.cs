using sonarproj.Controllers.Api;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestTemplate.Controller.Api
{
    public class HomeControllerTest
    {
        [Fact]
        public void Search()
        {
            var controller = new HomeController();
            var result =  controller.Search();

            Assert.Equal(2, result);
        }
    }
}
