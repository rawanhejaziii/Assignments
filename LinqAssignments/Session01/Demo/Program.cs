using static Demo.DataSources.Source;
namespace Demo;

internal class Program
{
    private static void Main(string[] args)
    {
        //Q1 
        var result = ProductList.Where(p => p.Category == "Seafood")
            .Select(p => new { Name = p.ProductName, Price = p.UnitPrice });
        result.Print();
        Console.WriteLine("--------");


        //Q2
        var ProductNames = ProductList.Select(p => p.ProductName).ToList();
        ProductNames.Print();
        Console.WriteLine("--------");


        //Q3
        var SortProduct = ProductList.Select(p => new { Name = p.ProductName, Price = p.UnitPrice })
            .OrderBy(p => p.Price);
        SortProduct.Print();
        Console.WriteLine("--------");

        //Q4
        var AllProductRange = ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30)
            .Select(p => p.ProductName);
        AllProductRange.Print();
        Console.WriteLine("--------");


        //Q5
        var InStock = ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");
        InStock.Print();
        Console.WriteLine("--------");


        //Q6
        var NewProduct = ProductList
        .Select(p => new
        {
            Name = p.ProductName,
            Price = p.UnitPrice,
            StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
        });
        NewProduct.Print();
        Console.WriteLine("--------");


        //Q7
        var ProductPosition = ProductList.Select((p, i) => new { Index = i, Name = p.ProductName });
        ProductPosition.Print();
        Console.WriteLine("--------");


        //Q8
        var Sort = ProductList.OrderBy(p => p.Category)
                   .ThenByDescending(p => p.UnitPrice);
        Sort.Print();
        Console.WriteLine("--------");


        //Q9
        var AllP = ProductList.Where(p => p.Category == "Beverages")
        .OrderByDescending(p => p.UnitsInStock)
        .Select(p => new { p.ProductName, p.UnitsInStock });
        AllP.Print();
        Console.WriteLine("--------");


        //Q10


        //Q11
        var Position = ProductList.Select((p, i) => new { Position = i, p.ProductName });
        Position.Print();
        Console.WriteLine("--------");


        //Q12
        string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
        var A = Arr.OrderBy(w => w.Length)
            .ThenBy(w => w.ToLower());
        A.Print();
        Console.WriteLine("--------");


        //Q13
        string[] words = { "india", "iron", "apple", "ink", "idea" };
        var W = words
            .Where(w => w.StartsWith("i"))
            .Reverse();
        W.Print();

    }
}
public static class Extensions
{
    public static void Print<T>(this IEnumerable<T> values)
    {
        foreach (var item in values)
        {
            Console.WriteLine(item);
        }
    }
}

public class CustomStringComparer : IComparer<string>
{
    public int Compare(string? x, string? y)
    {
        throw new NotImplementedException();
    }
}