using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace b9039646_WAD_Assignment.Models
{
    public class locationForm
    {
        
        public string Name { get; set; }

        public string NameF { get; set; }

        public string Description { get; set; }

        public string DescriptionF { get; set; }

        public string Justification { get; set; }

        public string JustificationF { get; set; }

        public DateTime Date { get; set; }

        public string Danger { get; set; }

        public float Longitude { get; set; }

        public float Latitude { get; set; }

        public float Area { get; set; }

        public string Category { get; set; }

        public string Country { get; set; }

        public string CountryF { get; set; }

        public string Continent { get; set; }

        public string ContinentF { get; set; }

        [Key]
        public string GeographicalCoordinates { get; set; }
        
        //public int Rating { get; set; }




    }
}
