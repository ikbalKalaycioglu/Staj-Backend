using Business;
using DataAccess;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;

namespace StajAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentController : ControllerBase
    {
        IContentService _contentService;

        public ContentController(IContentService contentService)
        {
            _contentService = contentService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _contentService.GetContent();
            return Ok(result);
        }

        [HttpGet("Title")]
        public IActionResult GetContentByTitle(string title)
        {
            var result = _contentService.GetContentByTitle(title);
            return Ok(result);
        }

        [HttpGet("Category")]
        public IActionResult GetContentByCategoryBase(string baseCategory,string secondCategory)
        {
            var result = _contentService.GetContentByCategory(baseCategory,secondCategory);
            return Ok(result);
        }
    }
}   
