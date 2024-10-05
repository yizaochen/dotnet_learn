using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TeaTimeDemo.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "最多30個字")]
        [DisplayName("類別名稱")]
        public string Name { get; set; }

        [DisplayName("顯示順序")]
        [Range(1, 100, ErrorMessage = "請輸入1-100之間的數字")]
        public int DisplayOrder { get; set; }
    }
}