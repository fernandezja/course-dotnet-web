namespace Starwars.Core.Entities
{
    public class Jedi
    {
        public int JediId { get; set; }
        public string Name { get; set; }

        public string ToHtml
        {
            get {
                return $"<strong>{Name}</strong>";
            }
        }
    }
}
