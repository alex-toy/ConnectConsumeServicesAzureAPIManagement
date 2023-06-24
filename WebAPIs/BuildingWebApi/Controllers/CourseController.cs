﻿using BuildingWebApi.Models;
using BuildingWebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BuildingWebApi.Controllers
{
    [ApiController]
    [Route("/api/Course")]
    public class CourseController : ControllerBase
    {
        private readonly CourseService courseservice;
        public CourseController(CourseService _svc)
        {
            courseservice = _svc;
        }

        [HttpGet]
        public IActionResult GetCourses()
        {
            return Ok(courseservice.GetCourses());
        }

        [HttpGet("{id}")]
        public IActionResult GetCourse(string id)
        {
            return Ok(courseservice.GetCourse(id));
        }

        [HttpPost]
        public IActionResult AddCourse(Course course)
        {
            courseservice.AddCourse(course);
            return Ok("Added");
        }
    }
}
