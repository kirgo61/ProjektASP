using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektASP.Models
{
    public class Person
    {
        [Key]
        public int PersonID { get; set; }
        [Column(TypeName = "text(250)")]
        [Required (ErrorMessage = "This field is required")]
        [DisplayName("Full Name")]
        public string FullName { get; set; }
        [Column(TypeName = "varchar(5)")]
        [DisplayName("Zip Code")]
        [Required(ErrorMessage = "This field is required")]
        public int ZipCode { get; set; }
        [Column(TypeName = "text(250)")]
        [DisplayName("Position")]
        [Required(ErrorMessage = "This field is required")]
        public string Position { get; set; }
        [Column(TypeName = "text(250)")]
        [DisplayName("City")]
        [Required(ErrorMessage = "This field is required")]
        public string City { get; set; }
    }
}
