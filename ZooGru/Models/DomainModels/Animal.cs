namespace ZooGru.Models.DomainModels
{
    public class Animal
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime LogDate { get; set; }
    }
}
