using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodingChallengeThird.Models
{
    public class TVChannelModel
    {
        [Display(Name = "TVChannelId")]
        public int TVChannelId { get; set; }

        [Display(Name = "TVChannelName")]
        [Required(ErrorMessage = "Name is required")]

        public string TVChannelName { get; set; }

        [Display(Name = "TVChanneltype")]
        [Required(ErrorMessage = "Type is required")]
        public string TVChanneltype { get; set; }


        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

    }
}