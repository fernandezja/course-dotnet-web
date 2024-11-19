using Starwars.Core.Entities;

namespace Starwars.Apps.WebAppMvc.Models
{
    public class ResultadoPaginadoViewModel<T>
    {
        public string Titulo { get; set; }
        public IEnumerable<T> Items { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
            
    }
}
