using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OnlineShopping.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required (ErrorMessage ="Title is required")]
        [StringLength(maximumLength:20, ErrorMessage ="Character cannot be greater than 20")]
        [RegularExpression(@"^[a-zA-Z]+$")]
        public string Title { get; set; }

        [DataType(DataType.Currency)]
        public int Price { get; set; }
        public string Description { get; set; }
        
     
        [DisplayName("Category Name")]
        public int CategoryId { get; set; }
        public virtual Category? Categories { get; set; }

            

    }
}
