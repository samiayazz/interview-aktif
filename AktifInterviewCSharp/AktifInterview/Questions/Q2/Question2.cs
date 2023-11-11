namespace AktifInterview.Questions.Q2
{
    public class Question2
    {
        public List<Product> FilterProductsWherePriceGreaterThan100(List<Product> products)
            => products is null
            ? throw new ArgumentNullException(nameof(products))
            : products.Where(x => x.Price > 100).ToList();
    }
}
