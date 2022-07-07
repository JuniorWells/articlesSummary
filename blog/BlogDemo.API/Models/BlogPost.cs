using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogDemo.API.Models
{

    [Table("Posts")]
    public class BlogPost
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Category { get; set; }
        public string? SubCategory { get; set; }
        public string? Description { get; set; }
        public string? AuthorName{ get; set; }
        public string? CreatedAt { get; set; }
        public string? Cover { get; set; }
    }
}