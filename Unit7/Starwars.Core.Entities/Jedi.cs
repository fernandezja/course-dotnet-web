namespace Starwars.Core.Entities
{
    public class Jedi
    {
        public int JediId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        //public int? Height { get; set; }|
        //public DateTime Created { get; set; }
        //public DateTime Edited { get; set; }


        public bool CanEdit
        {
            get {
                return (JediId % 2 == 0);
            }
        }
    }
}
