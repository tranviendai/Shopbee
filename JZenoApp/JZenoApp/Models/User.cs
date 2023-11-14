using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JZenoApp.Models
{
    [Index(nameof(PhoneNumber), IsUnique = true)]
    public class User : IdentityUser
    {
        [StringLength(50)]
        public string? fullName { get; set; }
        public string? image { get; set; }
        public string? address { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/M/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime dateCreated { get; set; }

        public string? partnerId { get; set; }
        [ForeignKey("partnerId")]
        public Partner? Partner { get; set; }
    }
}
