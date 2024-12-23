using Starwars.Core.Negocio.Comun;

namespace Starwars.Core.Negocio.Tests
{
    public class JediMetodosTest
    {
        [Fact]
        public void FormatearNombreAMayusculas_Test()
        {
            var nombre = "Luke Skywalker";
            var resultado = JediMetodos.FormatearNombreAMayusculas(nombre);

            Assert.Equal("LUKE SKYWALKER", resultado);
        }
    }
}
