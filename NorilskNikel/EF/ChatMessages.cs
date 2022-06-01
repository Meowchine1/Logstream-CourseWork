using System.ComponentModel.DataAnnotations;

namespace NorilskNikel.EF
{
    public class ChatMessages
    {
       
    public int Id{ get; set; }
    public int? IdCategory{ get; set; }
        public string? Name{ get; set; }
        public string Text{ get; set; }
        public DateTime dateTime{ get; set; }
    }
}
