using System.ComponentModel.DataAnnotations;

namespace BlogLab.Models.Blog
{
    public class BlogCreate
    {
        public int BlogId { get; set; }

        [Required(ErrorMessage ="Title is required.")]
        [MinLength(10, ErrorMessage = "Must be 10-50 characters.")]
        [MaxLength(50, ErrorMessage = "Must be 10-50 characters.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Content is required.")]
        [MinLength(10, ErrorMessage = "Must be 10-240 characters.")]
        [MaxLength(240, ErrorMessage = "Must be 10-240 characters.")]
        public string Content { get; set; }
        public int? PhotoId { get; set; }
    }
}
