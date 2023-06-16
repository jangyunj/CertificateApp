namespace EFCrudApp.Models
{
    public class Certificate
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Scope { get; set; }
        public string Language { get; set; }
        public DateTime Date { get; set; }
        public string Website { get; set; }
        public string Authenticity { get; set; }
    }
}
