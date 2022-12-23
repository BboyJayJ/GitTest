using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeetJob_Rent.Models
{
    public class Movie
    {
        [Display(Name = "編號")]
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        [Display(Name = "電影名稱")]
        public string Title { get; set; } = string.Empty;

        [Display(Name = "出版日期")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "製片公司")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; } = string.Empty;
        [Range(1, 500)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "票價")]
        public decimal Price { get; set; }

        public string Rating { get; set; } = string.Empty;
    }
}
