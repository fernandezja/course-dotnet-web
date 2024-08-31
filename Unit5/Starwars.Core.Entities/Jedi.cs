namespace Starwars.Core.Entities
{
    public class Jedi
    {
        public int JediId { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int? Height { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
    }
}
