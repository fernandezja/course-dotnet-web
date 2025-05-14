using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars.Core.Negocio.Tests
{
    public class JediHelperTest
    {
        [Fact]
        public void ObtenerNombreJedi_ReturnsCorrectName()
        {

            int testId = 1;
            string expectedName = "Jedi con ID 10";


            string actualName = JediHelper.ObtenerNombreJedi(testId);


            Assert.Equal(expectedName, actualName);
        }
    }
}
