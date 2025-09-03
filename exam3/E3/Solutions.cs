using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace E3;

public class Animal
{
    public virtual string MakeSound() {
        return "Some generic animal sound";
    }
}
public class Dog : Animal
{
    public override string MakeSound()
    {
        return "Woof";
    }
}

public class MyPointType1
{
    public int X;
    public int Y;
}

public struct MyPointType2
{
    public int X;
    public int Y;
}

// public class Comparer<T>
// {
//     public int keep;
//     public string keep2;
//     public T v1;
//     public T v2;

//     public Comparer(T v1, T v2)
//     {
//         this.v1 = v1;
//         this.v2 = v2;
//     }

//     public int CompareTo(T? other)
//     {
//         if (other is Comparer<int> m)
//         {
//             if (m.v1.CompareTo(m.v2) > 0)
//             {
//                 keep = m.v1;
//             }
//             else
//             {
//                 keep = m.v2;
//             }
//             return m.v1.CompareTo(m.v2);
            
//         }
//         if (other is Comparer<string> s)
//         {
//             if (s.v1.Length.CompareTo(s.v2.Length) > 0)
//             {
//                 keep2 = s.v1;
//             }
//             else
//             {
//                 keep2 = s.v2;
//             }
//             return s.v1.Length.CompareTo(s.v2.Length);
//         }
//         if (other is Comparer<Product> p)
//         {
//             if (p.v1.Name.Length.CompareTo(p.v2.Name.Length) > 0)
//             {
//                 keep2 = p.v1.Name;
//             }
//             else
//             {
//                 keep2 = p.v2.Name;
//             }
//             return p.v1.Name.Length.CompareTo(p.v2.Name.Length);
//         }
//         else
//         {
//             return 0;
//         }
       
//     }

//     public T GetLarger()
//     {

        

//     }
// }
public class Product
{
    public string Name { get; set; }
    public int Price { get; set; }
}

public class ResourceManager : IDisposable
{
    public bool IsDisposed { get; set; } = false;

    public void Dispose()
    {
        IsDisposed = true;
    }

}

public static class LinqProblems
{
    public static List<int> FilterAndDouble(List<int> numbers)
    {
        var expected = new List<int>();
        var m = numbers.Where(s => s > 5).Select(s => isEven(s)).ToList();
        var c = m.Select(s => s).Where(s => s != 0).ToList();

        expected = c.Select(s => zarbDo(s)).ToList();
        return expected;
    }

    public static Dictionary<string, int> GetTotalAmountByCategory(List<Sale> sales)
    {
        var expected = sales.GroupBy(s => s.Category).Select(s =>
       {
           return (s.Key, s.Sum(t => t.Amount));

       }).ToDictionary();
        return expected;
    }

    public static int isEven(int n)
    {
        if (n % 2 == 0)
        {
            return n;
        }
        return 0;

    }
    public static int zarbDo(int n)
    {
        return n * 2;
    }
}

public class Sale
{
    public string Category { get; set; }
    public int Amount { get; set; }
}
public class Money : IEquatable<Money>
{
    public int Amount;
    public string v2;

    public Money(int Amount, string v2)
    {
        this.Amount = Amount;
        this.v2 = v2;
    }

    public bool Equals(Money? other)
    {
        return this.Amount == other.Amount && this.v2 == other.v2;
    }

    public static Money operator +(Money a, Money b)
    {
        return new Money(a.Amount + b.Amount, a.v2);
    }
    public static bool operator ==(Money a, Money b)
    {
        return a.Equals(b);
    }
    public static bool operator !=(Money a, Money b)
    {
        return !a.Equals(b);
    }

}

public class DelegateProblems
{
    public static string ToUpper(string s)
    {
        return s.ToUpper();
    }
    public static string ToLower(string s)
    {
        return s.ToLower();
    }

    public delegate string StringOperation(string s);

    public static string ProcessString(string input, StringOperation op)
    {
        return op(input);

    }



}

public class LambdaProblems
{

    public static Func<string, int> GetStringLengthCalculator() => (s) => s.Length;

}

public class Publisher
{
    public delegate string myevent();
    public event myevent ev;
    public void RaiseEvent(string v)
    {
      
    }
}
public class Subscriber
{
    public Publisher publisher;

    public Subscriber(Publisher publisher)
    {
        this.publisher = publisher;
    }

    public object ReceivedMessages { get; set; }

    public void Unsubscribe()
    {
        
    }
}

public class Closures
{
       public static Func<int> CreateCounter()
    {
        int count = 1;
        return () => count++;
    }
}
public class SafeCounter
{
    object obj = new object();

    public int Count { get; set; }

    public void Increment()
    {
        lock (obj)
        {
            Count++;
        }
    }
}

public class DataService
{
    public async Task<string?> FetchDataAsync(string v)
    {
        Task.Delay(2000);
        return $"Data for {v}";
    }
}

// public class Repository<T> where T : IEntity<T>
// {

// }


// // public interface IEntity<T>
// {
//     public T CreateNew();        

// }

// public class Customer
// {
//     public Guid Id { get; set; }
// }

// public class Order
// {

// }   

