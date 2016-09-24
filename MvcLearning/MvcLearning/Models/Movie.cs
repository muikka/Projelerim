using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Profile;

namespace MvcLearning.Models
{
    public class Movie
    {
        public int?  Id { get; set; }
        [Required]
        [Display(Name = "Film İsmi")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Film Çıkış Tarihi")]
        public DateTime? ReleaseDate { get; set; }
        [Required]
        [Display(Name = "Sisteme Eklenme Tarihi")]
        public DateTime? DateAdded { get; set; }
        [Display(Name = "Kategori")]
        public Genre Genre { get; set; }
        [Required]
        [Display(Name = "Kategori Id")]
        public byte? GenreId { get; set; }

        [Required]
        [Range(1, 20)]
        [Display(Name = "Kalan Stok")]
        public int? NumberInStok {  get; set;}


    }
}