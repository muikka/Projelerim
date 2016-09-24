using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcLearning.Models;
using System.ComponentModel.DataAnnotations;

namespace MvcLearning.ViewModels
{
    public class MovieFormViewModel
    {

        public int? Id { get; set; }//after variable type the label ? means that this variable can be null.

        [Required]
        [Display(Name = "Film İsmi")]
        public string Name { get; set; }//it is not necessary to add ? mark bcs string already can be null

        [Required]
        [Display(Name = "Film Çıkış Tarihi")]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Kategori Id")]
        public byte? GenreId { get; set; }

        [Required]
        [Range(1, 20)]
        [Display(Name = "Kalan Stok")]
        public int? NumberInStok { get; set; }


        public IEnumerable<Genre> Genres { get; set; }



        public string Title => (Id != 0) ? "Filmi Güncelle" : "Yeni Film";

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStok = movie.NumberInStok;
            GenreId = movie.GenreId;
        }

        public MovieFormViewModel()
        {
            Id = 0;//Default Constructure Sayesinde Yeni Oluşturulacak Nesnenin Id si Otomatikman 0 Olmuş Olur
        }
    }
}