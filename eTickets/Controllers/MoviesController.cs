﻿using eTickets.Data;
using eTickets.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMoviesService _service;
        public MoviesController(IMoviesService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allMovies = await _service.GetAllAsync(n => n.Cinema);
            return View(allMovies);
        }

        //Get: Movies/Details/1

        public async Task<IActionResult> Details(int id)
        {
            var movieDetail = await _service.GetMovieByIdAsync(id);
            return View(movieDetail);
        }

        //GET: Movies/Create

        public async Task<IActionResult> Create()
        {
            var movieDropDownData = await _service.GetNewMovieDropDownsValues();

            ViewBag.Cinema = new SelectList(movieDropDownData.Cinemas, "Id", "Name");
            ViewBag.Producer = new SelectList(movieDropDownData.Producers, "Id", "FullName");
            ViewBag.Actor = new SelectList(movieDropDownData.Actors, "Id", "FullName");

            return View();
        }
    }
}
