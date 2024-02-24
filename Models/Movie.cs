using System.ComponentModel.DataAnnotations.Schema;

namespace TestingGitHub_Podium.Models
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string MovieName { get; set;}
        public string MovieDescription { get; set; }

        public int GenreID { get; set; }
        [ForeignKey("GenreID")]
        public string Genre { get; set; }
    }
}
