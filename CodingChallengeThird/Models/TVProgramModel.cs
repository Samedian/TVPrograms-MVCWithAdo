using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodingChallengeThird.Models
{
    public class TVProgramModel
    {
        [Display(Name = "TVProgramId")]
        public int TVProgramId { get; set; }

        [Display(Name = "TVProgramName")]
        [Required(ErrorMessage ="Name is required")]
        public string TVProgramName { get; set; }


        [Display(Name = "TVProgramCategory")]
        [Required(ErrorMessage = "Category is required")]
        public string TVProgramCategory { get; set; }


        [Display(Name = "TVProgramChannelName")]
        [Required(ErrorMessage = "Channel Name is required")]
        public string TVProgramChannelName { get; set; }


        [Display(Name = "TVProgramDesc")]
        [Required(ErrorMessage = "Description is required")]
        public string TVProgramDesc { get; set; }


        [Display(Name = "TVProgramDuration")]
        [Required(ErrorMessage = "Duration is required")]
        public string TVProgramDuration { get; set; }

    }
}