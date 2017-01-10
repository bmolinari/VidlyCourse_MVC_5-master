﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_Tutorial.Models;
using Vidly_Tutorial.ViewModels;

namespace Vidly_Tutorial.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = GetMovies().SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }

        private IEnumerable<Movie> GetMovies()
        {

            return new List<Movie>
            {
                new Movie { Id = 1, Name = "A Christmas Story" },
                new Movie { Id = 2, Name = "Resovoir Dogs" }
            };
        }

    }
}