using Starwars.Core.Entities;

namespace Starwars.Apps.WebAppMvc.Models
{
    public class JediPageViewModel
    {
        public Jedi Jedi { get; set; }
        public string Title { get; set; }

        public JediPageViewModel()
        {

        }
    }
}
