using Starwars.Core.Entities;

namespace Starwars.Apps.WebAppMvc.Models
{
    public class ResultadoPaginadoViewModel<TEntity>
    {
        public string Titulo { get; set; }
        public IEnumerable<TEntity> Items { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
            
    }
}
