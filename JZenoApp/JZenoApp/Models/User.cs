using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace JZenoApp.Models
{
    public class User : IdentityUser
    {
        [StringLength(50)]
        public string? FullName { get; set; }
        public string? Image { get; set; }
        public string? Address { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/M/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateCreated { get; set; }

    }
}
