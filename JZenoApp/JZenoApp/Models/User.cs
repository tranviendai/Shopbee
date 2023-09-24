using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace JZenoApp.Models
{
    public class User : IdentityUser
    {
        [StringLength(50)]
        public string? fullName { get; set; }
        public string? image { get; set; }
        public string? address { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/M/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime dateCreated { get; set; }

    }
}
