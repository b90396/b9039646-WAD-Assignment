using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace b9039646_WAD_Assignment.Models
{
    public class Location
    {
        
        [Column(TypeName = "varchar(200)")]
        public string Name { get; set; }

        
        [Column(TypeName = "varchar(200)")]
        public string NameF { get; set; }


        [Column(TypeName = "varchar(500)")]
        public string Description { get; set; }

        [Column(TypeName = "varchar(500)")]
        public string DescriptionF { get; set; }


        [Column(TypeName = "varchar(1000)")]
        public string Justification { get; set; }

        [Column(TypeName = "varchar(1000)")]
        public string JustificationF { get; set; }


        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string Danger { get; set; }

        [Column(TypeName = "float(25)")]
        public float Longitude { get; set; }

        [Column(TypeName = "float(25)")]
        public float Latitude { get; set; }

        [Column(TypeName = "float(25)")]
        public float Area { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string Category { get; set; }


        [Column(TypeName = "varchar(200)")]
        public string Country { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string CountryF { get; set; }


        [Column(TypeName = "varchar(200)")]
        public string Continent { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string ContinentF { get; set; }

        [Key]
        [Column(TypeName = "varchar(200)")]
        public string GeographicalCoordinates { get; set; }
        
        //public int Rating { get; set; }




    }
}
