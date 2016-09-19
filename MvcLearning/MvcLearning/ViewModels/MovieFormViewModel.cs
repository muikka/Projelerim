using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcLearning.Models;

namespace MvcLearning.ViewModels
{
    public class MovieFormViewModel
    {
        public Movie Movies { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}