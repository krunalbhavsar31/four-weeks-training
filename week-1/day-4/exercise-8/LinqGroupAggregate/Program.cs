namespace LinqGroupAggregate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of Product objects
            List<Product> products = new List<Product>
        {
            new Product { Name = "Laptop", Category = "Electronics", Price = 1200.00M },
            new Product { Name = "Smartphone", Category = "Electronics", Price = 800.00M },
            new Product { Name = "Headphones", Category = "Electronics", Price = 200.00M },
            new Product { Name = "Shirt", Category = "Clothing", Price = 30.00M },
            new Product { Name = "Jeans", Category = "Clothing", Price = 60.00M },
            new Product { Name = "Sneakers", Category = "Footwear", Price = 100.00M }
        };

            // Use LINQ to perform the following operations:
            // 1. Group products by category
            // 2. Count the number of products in each category
            // 3. Calculate the total price of products in each category
            // 4. Find the most expensive product in each category


            // 1. Group products by category
            // Group products by category
            var groups = products.GroupBy(p => p.Category);

            // Print out each group and its products
            foreach (var group in groups)
            {
                Console.WriteLine("Category: {0}", group.Key);
                foreach (var product in group)
                {
                   Console.WriteLine("- {0} (${1})", product.Name, product.Price);
                }
            }

            // 2. Count the number of products in each category
            // Group products by category and count the number of products in each group
            var counts = products.GroupBy(p => p.Category)
                                 .Select(g => new { Category = g.Key, Count = g.Count() });

            // Print out the counts for each category
            foreach (var count in counts)
            {
                Console.WriteLine("Category: {0}, Count: {1}", count.Category, count.Count);
            }

            // 3. Calculate the total price of products in each category
            // Group products by category and calculate the total price of products in each group
            var totals = products.GroupBy(p => p.Category)
                                 .Select(g => new { Category = g.Key, Total = g.Sum(p => p.Price) });

            // Print out the total prices for each category
            foreach (var total in totals)
            {
                Console.WriteLine("Category: {0}, Total Price: ${1}", total.Category, total.Total);
            }

            // 4. Find the most expensive product in each category
            // Group products by category and find the most expensive product in each group
            var maxPrices = products.GroupBy(p => p.Category)
                                    .Select(g => new { Category = g.Key, MaxPrice = g.Max(p => p.Price) });

            // Print out the most expensive product in each category
            foreach (var maxPrice in maxPrices)
            {
                Console.WriteLine("Category: {0}, Most Expensive Product Price: ${1}", maxPrice.Category, maxPrice.MaxPrice);
            }
        }
    }
}