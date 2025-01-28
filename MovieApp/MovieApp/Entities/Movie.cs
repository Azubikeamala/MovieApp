using System.ComponentModel.DataAnnotations;

namespace MovieApp.Entities
{
    public class Movie
    {
        public int MovieId { get; set; }

        [Required(ErrorMessage = "Movie Name is Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Movie Year is Required")]
        [Range(1830,int.MaxValue, ErrorMessage = "Year cannot be less than 1830")]
        public string Year { get; set; }

        [Required(ErrorMessage = "Movie Rating is Required")]
        [Range(1,5, ErrorMessage = "Rating should be between 1 and 5")]
        public int Rating { get; set; }

    }
}
