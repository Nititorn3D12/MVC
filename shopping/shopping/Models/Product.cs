using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace shopping.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public string description { get; set; }
        public int stock { get; set; }

    }
}
