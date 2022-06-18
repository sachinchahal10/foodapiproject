using System.ComponentModel.DataAnnotations.Schema;

namespace FoodAPI.Models
{
    public class Food
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
        public string itemname { get; set; }
        public int itemprice { get; set; }
        public string foodtype { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public int rating { get; set; }
    }

}
