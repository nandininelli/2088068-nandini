using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp_UsingMvc.Models
{
    public class MovieList
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string BoxOffice { get; set; }
        [Required]
        public bool ActiveStatus { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DateOfLaunch { get; set; }
        [Required]
        public string SelectGenere { get; set; }
        [Required]
        public Genere MovieGenere { get; set; }
        [Required]
        public bool hasTeaser { get; set; }
    }
    public enum Genere
    {
        Fiction,
        Superhero,
        Romance,
        Comedy,
        Adventure,
        Thriller
    }
}
