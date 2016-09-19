using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using Microsoft.Owin.Security.DataHandler;
using MvcLearning.Models;

namespace MvcLearning.ViewModels
{
    public class RandomMovieViewModel
    {
         public Models.Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }

    }
}