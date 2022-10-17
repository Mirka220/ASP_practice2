namespace Practice2.Models
{
    public class Home
    {
        public virtual Guid Id { get; set; }
        public string HomeType { get; set; }
        public bool IsNeighbour { get; set; }
    }
}
