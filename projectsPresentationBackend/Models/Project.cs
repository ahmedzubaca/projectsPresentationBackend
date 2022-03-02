using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArchitecturalProjectsBackend.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string ProjectCategory { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string ProjectTitle { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        public string ImageCategory { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string ImageTitle { get; set; }

        [Column(TypeName = "nvarchar(300)")]
        public string Url { get; set; }
    }
}
