namespace AktifInterview.Questions.Q2
{
    public sealed class Product
    {
        public Guid Id { get; init; } = Guid.NewGuid();
        public string Name { get; set; }
        public float Price { get; set; }

        public Product() { }
        public Product(string name, float price) => (Name, Price) = (name, price);
        public Product(Guid id, string name, float price) => (Id, Name, Price) = (id, name, price);
    }
}
