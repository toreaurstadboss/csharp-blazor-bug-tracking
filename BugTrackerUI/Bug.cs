using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackerUI
{
    public class Bug
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [MinLength(10)]
        public string Description { get; set; }

        [Required]
        [Range(1, 5, ErrorMessage = "Oppgi et tall 1-5 silly")]
        public int Priority { get; set; }
    }
}
