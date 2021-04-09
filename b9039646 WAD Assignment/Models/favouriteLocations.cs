using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace b9039646_WAD_Assignment.Models
{
    public class FavouriteLocations
    {
        [Key]
        [Column(TypeName = "nvarchar(450)")]
        public string UserID{ get; set; }

        [Column(TypeName = "nvarchar(450)")]
        public string UserIDDuplicate { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string locationCoordinates1 { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string locationCoordinates2 { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string locationCoordinates3 { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string locationCoordinates4 { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string locationCoordinates5 { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string locationCoordinates6 { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string locationCoordinates7 { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string locationCoordinates8 { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string locationCoordinates9 { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string locationCoordinates10 { get; set; }

    }
}
