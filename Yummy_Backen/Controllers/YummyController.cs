using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yummy_Backen.DAL;
using Yummy_Backen.Models;
using Yummy_Backen.ViewModels;

namespace Yummy_Backen.Controllers
{
    public class YummyController : Controller
    {
        private readonly AppDbContext context;

        public YummyController(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult> Index()
        {
            YummyVM model = new YummyVM
            {
                Hero = await context.Heroes.FirstOrDefaultAsync(),
                About = await context.Abouts.FirstOrDefaultAsync(),
                Chooses = await context.Chooses.ToListAsync(),
                Meals = await context.Meals.ToListAsync(),
                TypesofFoods = await context.TypesofFoods.ToListAsync()
            };
            
            return View(model);
        }
    }
}
