﻿using JikanDotNet;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace JikanApi.Controllers
{
    public class AnimeController : Controller
    {

        IJikan jikan = new Jikan();

        public async Task<IActionResult> Search(string searchQuery)
        {
            var buscaAnime = await jikan.SearchAnimeAsync(searchQuery);

            return View("Search", buscaAnime.Data);
        }
    }
}