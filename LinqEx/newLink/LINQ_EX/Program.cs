using System.Collections.Concurrent;
using Microsoft.VisualBasic;

namespace LINQ_EX;

enum LifeExpectancyType {AtBirth, At60}
enum DataGender { Male, Female, Both}
class Data
{
    public Data(LifeExpectancyType leType, int year, string territory, string country, DataGender dg, double value)
    {
        LEType = leType;
        Year = year;
        Territory = territory;
        Country = country;
        DataGender = dg;
        Value = value;
    }

    public LifeExpectancyType LEType {get; }
    public int Year {get; }
    public string Terrirtory {get;}
    public string Country {get;}
    public DataGender DataGender {get;}
    public double Value {get;}
    public string Territory { get; }

    public override string ToString() =>
        $"{Country},{Year},{LEType},{DataGender},{Value}";

    public static Data Parse(string line)
    {
        var toks = line.Split(',').Select(t => t.Trim('"')).ToArray();        
        LifeExpectancyType leType = toks[0].Contains("60") ? 
                LifeExpectancyType.At60 :
                LifeExpectancyType.AtBirth;
        int year = int.Parse(toks[1]);
        string territory = toks[2].ToLower();
        string country = toks[3].ToLower();
        DataGender dg = toks[4].Contains("Both") ?
            DataGender.Both :
            (
                toks[4].Contains("Male") ? 
                    DataGender.Male :
                    DataGender.Female
            );
        double value = double.Parse(toks[5]);
        return new Data(leType, year, territory, country, dg, value);
    }
}

class Program
{
    static void Main(string[] args)
    {
        var data=File.ReadAllLines("data.csv")
            .Skip(1);
        var SaveData=data.Select(l=>(Data.Parse(l)));
       
   
       
        // //Query 1
        Console.WriteLine("Query 1");
        var result=SaveData
            .Where(l=>(l.Country.Contains("iran"))&&(l.LEType==LifeExpectancyType.AtBirth)&&(l.DataGender==DataGender.Both))
            .OrderBy(c=>c.Value).ToList();

        foreach(var item in result){
            System.Console.WriteLine(item);
           
        }


        Console.WriteLine();

        //Query 2
        Console.WriteLine("Query 2");
        
        var max=result.Max(l=>l.Value);
        var min=result.Min(l=>l.Value);
        var diff=(double)max-(double)min;
        System.Console.WriteLine($"{diff}");

        Console.WriteLine();

        //Query 3
        Console.WriteLine("Query 3");
        var result3=SaveData.Where(l=>l.DataGender==DataGender.Both && l.LEType==LifeExpectancyType.AtBirth)
        .GroupBy(l=>l.Country).Select(l=>{
            double Max=l.Max(l=>l.Value);
            double Min=l.Min(l=>l.Value);
            double Diff=Max-Min;
            var year=l.MinBy(l=>l.Value).Year;
            return(country:l.Key , max:Max , min:Min , diff:Diff , Year:year);
            
        }).OrderByDescending(t=>t.diff).ToList();
        int rank=0;
        foreach(var item in result3){
            rank+=1;
            System.Console.WriteLine($"#{rank}--{item}");
        }
        Console.WriteLine();

        //Query 4
        Console.WriteLine("Query 4");
       
        var MaleData=SaveData.Where(l=>l.DataGender==DataGender.Male&&l.LEType==LifeExpectancyType.AtBirth);
        var FemaleData=SaveData.Where(l=>l.DataGender==DataGender.Female&&l.LEType==LifeExpectancyType.AtBirth);
        var result4=MaleData.Join(FemaleData,
        (m1)=>(m1.Country ,m1.Year),
        (m2)=>(m2.Country ,m2.Year),
        (m1,m2)=>(Country:m1.Country, Year:m1.Year,MaleHealth:m1.Value,FemaleHealth:m2.Value,Diffrence:m1.Value-m2.Value)
        ).GroupBy(g=>g.Country).Select(g => g.OrderByDescending(x => x.Diffrence).First()) 
        .OrderByDescending(x => x.Diffrence).ToList();
           foreach(var item in result4){
            rank+=1;
            System.Console.WriteLine($"#{rank}--{item}");
        }
        Console.WriteLine();

    }
}
