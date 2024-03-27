using System.ComponentModel.DataAnnotations;

namespace BlogLab.Models.BlogComment
{
    public class BlogCommentCreate
    {
        public int BlogCommentId { get; set; }
        public int? ParentBlogCommentId { get; set; }
        public int BlogId { get; set; }

        [Required(ErrorMessage = "Content is required.")]
        [MinLength(10, ErrorMessage = "Must be 10-240 characters.")]
        [MaxLength(240, ErrorMessage = "Must be 10-240 characters.")]
        public int Content { get; set; }
    }
}
