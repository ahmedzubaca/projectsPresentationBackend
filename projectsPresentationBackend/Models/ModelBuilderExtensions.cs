using ArchitecturalProjectsBackend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectsPresentationBackend.Models
{
    public static class ModelBuilderExtensions
    {
        public static void PopulateTable(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 1,
                    ProjectCategory = "interior-design",
                    ProjectTitle = "First Project",
                    ImageCategory = "Cover Photo",
                    ImageTitle = "Cover Image",
                    Url = "/projects-images/interior-design/2103202036162_a.jpg"
                },
                new Project
                {
                    Id = 2,
                    ProjectCategory = "interior-design",
                    ProjectTitle = "First Project",
                    ImageCategory = "Project Content",
                    ImageTitle = "Content First",
                    Url = "/projects-images/interior-design/2103202040106_2.jpg"
                },
                new Project
                {
                    Id = 3,
                    ProjectCategory = "interior-design",
                    ProjectTitle = "First Project",
                    ImageCategory = "Project Content",
                    ImageTitle = "Content Second",
                    Url = "/projects-images/academic-projects/2103202051284_renderiic 3.jpg"
                },
                 new Project
                 {
                     Id = 4,
                     ProjectCategory = "interior-design",
                     ProjectTitle = "First Project",
                     ImageCategory = "Project Content",
                     ImageTitle = "Content Third",
                     Url = "/projects-images/interior-design/2103202043431_Screenshot_2.jpg"
                 },
                 new Project
                 {
                     Id = 5,
                     ProjectCategory = "interior-design",
                     ProjectTitle = "Second Project",
                     ImageCategory = "Cover Photo",
                     ImageTitle = "Cover Image",
                     Url = "/projects-images/interior-design/2103202044194_Screenshot_3.jpg"
                 },
                 new Project
                 {
                     Id = 6,
                     ProjectCategory = "interior-design",
                     ProjectTitle = "Second Project",
                     ImageCategory = "Project Content",
                     ImageTitle = "Content First",
                     Url = "/projects-images/interior-design/2103202045201_Screenshot_6.jpg"
                 },
                 new Project
                 {
                     Id = 7,
                     ProjectCategory = "interior-design",
                     ProjectTitle = "Second Project",
                     ImageCategory = "Project Content",
                     ImageTitle = "Content Second",
                     Url = "/projects-images/interior-design/2103202046339_Screenshot_8.jpg"
                 },
                 new Project
                 {
                     Id = 8,
                     ProjectCategory = "interior-design",
                     ProjectTitle = "Second Project",
                     ImageCategory = "Project Content",
                     ImageTitle = "Content Third",
                     Url = "/projects-images/interior-design/2103202047179_Screenshot_14.jpg"
                 },
                 new Project
                 {
                     Id = 9,
                     ProjectCategory = "academic-projects",
                     ProjectTitle = "First Project",
                     ImageCategory = "Cover Photo",
                     ImageTitle = "Cover Image",
                     Url = "/projects-images/academic-projects/2103202050430_rendi.jpg"
                 },
                 new Project
                 {
                     Id = 10 ,
                     ProjectCategory = "academic-projects",
                     ProjectTitle = "First Project",
                     ImageCategory = "Project Content",
                     ImageTitle = "Content First",
                     Url = "/projects-images/academic-projects/2103202051284_renderiic 3.jpg"
                 },
                 new Project
                 {
                     Id = 11,
                     ProjectCategory = "academic-projects",
                     ProjectTitle = "First Project",
                     ImageCategory = "Project Content",
                     ImageTitle = "Content Second",
                     Url = "/projects-images/academic-projects/2103202052295_Screenshot_11.jpg"
                 },
                 new Project
                 {
                     Id = 12,
                     ProjectCategory = "academic-projects",
                     ProjectTitle = "First Project",
                     ImageCategory = "Project Content",
                     ImageTitle = "Content Third",
                     Url = "/projects-images/academic-projects/2103202054014_1a.jpg"
                 },
                 new Project
                 {
                     Id = 13,
                     ProjectCategory = "academic-projects",
                     ProjectTitle = "Second Project",
                     ImageCategory = "Cover Photo",
                     ImageTitle = "Cover Image",
                     Url = "/projects-images/academic-projects/2103202055190_Screenshot_8.jpg"
                 },
                  new Project
                  {
                      Id = 14,
                      ProjectCategory = "academic-projects",
                      ProjectTitle = "Second Project",
                      ImageCategory = "Project Content",
                      ImageTitle = "Content First",
                      Url = "/projects-images/academic-projects/2103202056427_1.jpg"
                  },
                  new Project
                  {
                      Id = 15,
                      ProjectCategory = "academic-projects",
                      ProjectTitle = "Second Project",
                      ImageCategory = "Project Content",
                      ImageTitle = "Content Second",
                      Url = "/projects-images/academic-projects/2103202058026_2103101824567_D1.jpg"
                  },
                  new Project
                  {
                      Id = 16,
                      ProjectCategory = "academic-projects",
                      ProjectTitle = "Second Project",
                      ImageCategory = "Project Content",
                      ImageTitle = "Content Third",
                      Url = "/projects-images/academic-projects/2103202058482_3.jpg"
                  },
                  new Project
                  {
                      Id = 17,
                      ProjectCategory = "competitions-projects",
                      ProjectTitle = "First Project",
                      ImageCategory = "Cover Photo",
                      ImageTitle = "Cover Image",
                      Url = "/projects-images/competitions-projects/2103202059304_3.jpg"
                  },
                  new Project
                  {
                      Id = 18,
                      ProjectCategory = "competitions-projects",
                      ProjectTitle = "First Project",
                      ImageCategory = "Project Content",
                      ImageTitle = "Content First",
                      Url = "/projects-images/competitions-projects/2103202100328_4.jpg"
                  },
                  new Project
                  {
                      Id = 19,
                      ProjectCategory = "competitions-projects",
                      ProjectTitle = "First Project",
                      ImageCategory = "Project Content",
                      ImageTitle = "Content Second",
                      Url = "/projects-images/competitions-projects/2103202101210_1b.jpg"
                  },
                  new Project
                  {
                      Id = 20,
                      ProjectCategory = "competitions-projects",
                      ProjectTitle = "First Project",
                      ImageCategory = "Project Content",
                      ImageTitle = "Content Third",
                      Url = "/projects-images/competitions-projects/2103202101540_1a.jpg"
                  },
                  new Project
                  {
                      Id = 21,
                      ProjectCategory = "competitions-projects",
                      ProjectTitle = "Second Project",
                      ImageCategory = "Cover Photo",
                      ImageTitle = "Cover Image",
                      Url = "/projects-images/competitions-projects/2103202103222_Screenshot_11.jpg"
                  },
                  new Project
                  {
                      Id = 22,
                      ProjectCategory = "competitions-projects",
                      ProjectTitle = "Second Project",
                      ImageCategory = "Project Content",
                      ImageTitle = "Content First",
                      Url = "/projects-images/competitions-projects/2103202104007_3.jpg"
                  },
                  new Project
                  {
                      Id = 23,
                      ProjectCategory = "competitions-projects",
                      ProjectTitle = "Second Project",
                      ImageCategory = "Project Content",
                      ImageTitle = "Content Second",
                      Url = "/projects-images/competitions-projects/2103202104554_renderiic 3.jpg"
                  },
                  new Project
                  {
                      Id = 24,
                      ProjectCategory = "competitions-projects",
                      ProjectTitle = "Second Project",
                      ImageCategory = "Project Content",
                      ImageTitle = "Content Third",
                      Url = "/projects-images/competitions-projects/2103202105591_2103012150286_Screenshot_2.jpg"
                  }
           );
        }
    }
}
