using Demo.Models;
using static Demo.DataSources.Source;
using System.Linq;
namespace Demo;

internal class Program
{
    private static void Main(string[] args)
    {
        //Q1
        var Expensive = ProductList.OrderByDescending(p => p.UnitPrice)
            .Take(3);
        foreach (var item in Expensive)
        {
            Console.WriteLine(item);
        }


        //Q2
        int PageSize = 5, PageNumber = 2;
        var Pajenation = ProductList.Skip((PageNumber - 1) * PageSize)
            .Take(PageSize);
        foreach (var item in Pajenation)
        {
            Console.WriteLine(item);
        }


        //Q3
        var result = ProductList.OrderBy(p => p.UnitPrice)
            .TakeWhile(p => p.UnitPrice < 25);
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }

        //Q4
        Console.WriteLine(ProductList.All(p => p.Category == "Seafood"));

        //Q5
        int[] ids = { 3, 9, 13, 18 };
        Console.WriteLine(ids.Contains(9));


        //Q6
        var ProductByCat = ProductList.GroupBy(p => p.Category);

        foreach (var group in ProductByCat)
        {
            Console.WriteLine($"{group.Key} - Count: {group.Count()}");
        }


        //Q7
        var Group = ProductList.GroupBy(p => p.Category, p => p.ProductName);
        foreach (var group in Group)
        {
            Console.WriteLine(group.Key);

            foreach (var name in group)
            {
                Console.WriteLine(name);
            }
        }


        //Q8
        var Categories = ProductList.GroupBy(x => x.Category)
            .Where(g => g.Count() > 3)
            .Select(g => new
            {
                Category = g.Key,
                Count = g.Count()
            });
        foreach (var item in Categories)
        {
            Console.WriteLine(item);
        }


        //Q9
        var Query = from C in CustomerList
                    group C by C.Country
                    into c
                    select new
                    {
                        Country = c.Key,
                        Count = c.Count(),
                        TotalOrders = c.Sum(o => o.Orders.Sum(s => s.Total))

                    };
        foreach (var item in Query)
        {
            Console.WriteLine(item);
        }

        //Q10
        var AllProducts = ProductList.Sum(p => p.UnitsInStock);
        Console.WriteLine(AllProducts);


        //Q11
        Console.WriteLine(ProductList.MinBy(p => p.UnitPrice));
        Console.WriteLine(ProductList.MaxBy(p => p.UnitPrice));

        //Q12
        var Dis = ProductList.Select(p => p.Category)
            .Distinct();
        foreach (var item in Dis)
        {
            Console.WriteLine(item);
        }

        //Q13
        int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
        int[] setB = { 3, 6, 9, 12, 15, 13 };
        var Ex = setA.Except(setB);

        foreach (var item in Ex)
        {
            Console.WriteLine(item);
        }

        //Q14
        string[] list1 = { "Germany", "France", "UK", "Spain" };
        string[] list2 = { "france", "SPAIN", "Italy" };
        var ex = list1.Except(list2);
        foreach (var item in ex)
        {
            Console.WriteLine(item);
        }

        //Q15
        var Dic = ProductList.ToDictionary(p => p.ProductID);
        Console.WriteLine(Dic[18]);

        //Q16
        var First = ProductList.First(p => p.UnitPrice > 50);
        Console.WriteLine(First);

        //Q17
        var Fir = ProductList.FirstOrDefault(p => p.UnitPrice > 500);
        Console.WriteLine(Fir);

        //Q18
        var Multi = Enumerable.Range(1, 12)
            .Select(i => 7 * i);
        foreach (var i in Multi)
        {
            Console.WriteLine(i);
        }

        //Q19
        var Even = Enumerable.Range(1, 30)
            .Where(i => i % 2 == 0);
        foreach (var i in Even)
        {
            Console.WriteLine(i);
        }

        //Q20
        var P = ProductList.Select(p => p.ProductName).Take(3)
            .Concat(CustomerList.Select(c => c.CompanyName).Take(3));
        foreach (var item in P)
        {
            Console.WriteLine(item);
        }

        //Q21
        var mix = ProductList.Select(p => p.ProductName)
            .Zip(CustomerList.Select(c => c.CompanyName),
            (product, customer) => $"{product} Sold To {customer}");
        foreach (var item in mix) 
        {
            Console.WriteLine(item);
        }

    }
}
