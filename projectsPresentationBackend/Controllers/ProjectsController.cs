using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SendGrid;
using SendGrid.Helpers.Mail;
using ArchitecturalProjectsBackend.Models;
using ArchitecturalProjectsBackend.Interfaces;

namespace ArchitecturalProjectsBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly ProjectsDbContext _context;        

        public ProjectsController(ProjectsDbContext context, IMailer mailer)
        {
            _context = context;            
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Project>>> GetAllProjects()
        {
            var projects = await _context.ProjectsDb.ToListAsync();
            return projects;
        }

        [HttpGet("home")]
        public async Task<IEnumerable<string>> GetHomepageImages()
        {
            return await Task.Run(() =>
            {
                var homepageImages = from project in _context.ProjectsDb
                                     where project.ImageCategory == "Cover Photo"
                                     select project.Url;
                return homepageImages.ToList();
            });
        }

        [HttpGet("{category}")]
        public async Task<ActionResult<IEnumerable<Project>>> GetProjectsCategoryCoverPhotos(string category)
        {
            return await Task.Run(() =>
            {
                var projectsCategoryCoverPhotos = 
                    from project in _context.ProjectsDb
                    where project.ProjectCategory == category
                    where project.ImageCategory == "Cover Photo"
                    select project;

                return projectsCategoryCoverPhotos.ToList();
            });            
        }

        [HttpGet("{category}/{content}")]
        public async Task<ActionResult<IEnumerable<Project>>> GetProjectsContentPhotos(string category, string content)
        {
            content = content.Replace("-", " ");
            return await Task.Run(() =>
            {
                var projectContentPhotos =
                    from project in _context.ProjectsDb
                    where project.ProjectCategory == category
                    && project.ProjectTitle == content
                    && project.ImageCategory == "Project Content"
                    select project;

                return projectContentPhotos.ToList();
            });                        
        }

        [HttpGet("{category}/{content}/{imgTitle}")]
        public async Task<ActionResult<IEnumerable<Project>>> GetSingleImage(string category, string content, string imgTitle )
        {
            
            content = content.Replace("-", " ");
            imgTitle = imgTitle.Replace("-", " ");

            return await Task.Run(() =>
            {
                var singleImage =
                    from project in _context.ProjectsDb
                    where project.ProjectCategory == category
                    && project.ProjectTitle == content
                    && project.ImageTitle == imgTitle
                    select project;

                return singleImage.ToList();
            });                        
        }
    }
}
