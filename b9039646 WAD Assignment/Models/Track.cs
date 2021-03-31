using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace b9039646_WAD_Assignment.Models
{
    public class Track
    {
        [Key]
        public int TrackID { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string TrackName { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int TrackLength { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string TrackImage { get; set; }

        public int Rating { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }


    }
}
