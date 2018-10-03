using sonar.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ApiTest.Controllers
{
    public class ValuesControllerTest
    {
        [Fact]
        public void GetValue_GivenID()
        {
            ValuesController controller = new ValuesController();
            var result = controller.Get(1);

            Assert.Equal("value", result.Value);
        }
    }
}
