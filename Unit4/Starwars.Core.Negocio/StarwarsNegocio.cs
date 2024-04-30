using System;
using System.Collections.Generic;

namespace Starwars.Core.Negocio
{
    public class StarwarsNegocio
    {
        public string Saludar(string name) {
            return $"Hola {name}!";
        }

        public List<Producto> GetAll() {
            var productos = new List<Producto>();
            for (int i = 0; i < 50; i++)
            {
                productos.Add(new Producto()
                {
                    ProductoId = i,
                    Nombre = $"Producto {i}"
                });
            }

            return productos;
        }
    }
}
