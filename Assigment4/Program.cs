// See https://aka.ms/new-console-template for more information
/// <summary>
/// This Assigment is on Dictionary (using Dictionary to print out ten words and their meaning).
/// </summary>

Dictionary<string,string> wordmeaning = new Dictionary<string,string>();

wordmeaning.Add("specious", "plausible but false");
wordmeaning.Add("obtuse", "lacking in insight");
wordmeaning.Add("Diffidence","lack of self-assurance");
wordmeaning.Add("Fad", "an interest followed with exaggerated zeal");
wordmeaning.Add("Larder", "a small storeroom for storing foods or wines");
wordmeaning.Add("Quip", "make jokes or witty remarks");
wordmeaning.Add("Glower","look angry ");
wordmeaning.Add("Turbid","clouded as with sediment");
wordmeaning.Add("Ensconce","fix firmly");

foreach (var Word in wordmeaning)
{
    Console.WriteLine("WORD----{0}, MEANING----{1}", Word.Key,   Word.Value);

}

Console.WriteLine( "*************************************************");

// Assignment Q---create  two collection of array using string  and use all set operators on it

string[] FruitBoxA =  {"Apple", "Orange", "Mango", "Pear", "Avocado", "Guava", "Melon", "Grape", "Mango" };

string[] FruitBoxB = {"Pineapple", "Orange", "Beetroot", "African-Pear", "cucumber","Orange", "Guava", "Banana","Grape"};

//Using Distinct

var Sdistinct = FruitBoxA.Distinct();

foreach (var result in Sdistinct)
{
    Console.WriteLine(" Distinct ~~" + result);

}

Console.WriteLine("*************************************************");

//Using Except

var SExcept = FruitBoxA.Except(FruitBoxB);

foreach (var result in SExcept)
{
    Console.WriteLine(" Except: " + result);
}


Console.WriteLine("*************************************************");
//Using Intersect
var SIntersect = FruitBoxA.Intersect(FruitBoxB);

foreach (var result in SIntersect)
{
    Console.WriteLine(" Intersect= " + result);
}

Console.WriteLine("*************************************************");

//Using Union

var SUnion = FruitBoxA.Union(FruitBoxB);

foreach (var result in SUnion)
{
    Console.WriteLine(" Union= " + result);
}

Console.ReadKey();

