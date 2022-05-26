using System.ComponentModel.DataAnnotations;

namespace norilskyNikel1.EF
{
    public class Brilliant
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int ProductCategoryId { get; set; }
    }
}
