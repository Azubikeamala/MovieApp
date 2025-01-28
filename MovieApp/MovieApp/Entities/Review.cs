using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace MovieApp.Entities
{
    public class Review
    {
        public int ReviewId { get; set; }

        public string ReviewName { get; set; }

        public string ReviewDescription { get; set; }
    }
}
