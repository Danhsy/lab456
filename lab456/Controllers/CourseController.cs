﻿using lab456.Models;
using lab456.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab456.Controllers
{

    public class CourseController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public CourseController()
        {
           _dbContext = new ApplicationDbContext();
        }
        // GET: Course
        [Authorize]
        [HttpPost]
        //public ActionResult Create()
        //{
        //    var viewModel = new CourseViewModel
        //    {
        //        Categories = _dbContext.Categories.ToList()
        //    };
        //    return View(viewModel);
        //}
        public ActionResult Create(CourseViewModel viewModel)
        {
            var course = new Course
            {
                LecturerId = User.Identity.GetUserId(),
                DateTime = viewModel.GetDateTime(),
                CategoryId = viewModel.Category,
                Place = viewModel.Place
            };
            _dbContext.Courses.Add(course);
            _dbContext.SaveChanges();
        }
        
    }
} gs