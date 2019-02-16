using System.ComponentModel.DataAnnotations;

namespace Ballerz.KnowledgeBase.Models
{
    public class Positions
    {
        [Key]
        public int PositionId { get; set; }
        public string Position { get; set; }
    }
}