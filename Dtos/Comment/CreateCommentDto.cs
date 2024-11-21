using System.ComponentModel.DataAnnotations;

namespace api1.Dtos.Comment
{
    public class CreateCommentDto
    {
        [Required]
        [MinLength(5, ErrorMessage =  "Title must be 5 characters")]
        [MaxLength(280, ErrorMessage = "Title cannot be over 200 characters")]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MinLength(5, ErrorMessage = "Context must be 5 characters")]
        [MaxLength(280, ErrorMessage = "Context cannot be over 200 characters")]
        public string Context { get; set; } = string.Empty;
    }
}
