using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace b9039646_WAD_Assignment.Models
{
    public class FavouriteLocations
    {
        [Required]
        public string UserID{ get; set; }

        public string locationCoordinates1 { get; set; }

        public string locationCoordinates2 { get; set; }

        public string locationCoordinates3 { get; set; }

        public string locationCoordinates4 { get; set; }

        public string locationCoordinates5 { get; set; }

        public string locationCoordinates6 { get; set; }

        public string locationCoordinates7 { get; set; }

        public string locationCoordinates8 { get; set; }

        public string locationCoordinates9 { get; set; }

        public string locationCoordinates10 { get; set; }

    }
}
