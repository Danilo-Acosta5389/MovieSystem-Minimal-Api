namespace MovieSystem_Minimal_Api.Models
{
    public class LikedGenre
    {
        public int Id { get; set; }

        public Genre Genre { get; set; }

        public Person Person { get; set; }
    }
}
