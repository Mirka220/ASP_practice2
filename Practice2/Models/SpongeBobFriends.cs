using System.ComponentModel.DataAnnotations.Schema;

namespace Practice2.Models
{
    public class SpongeBobFriends
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Job { get; set; }
        public string JobPlace { get; set; }
        public string SkinCollor { get; set; }
        [ForeignKey("Home_Id")]
        public virtual Home HomeId { get; set; }
    }
}
