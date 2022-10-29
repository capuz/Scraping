using HtmlAgilityPack;
using ScrapySharp.Extensions;


internal class Program
{
    private static void Main(string[] args)
    {

        var url = "https://visualstudio.microsoft.com/es/";
        HtmlWeb html = new();
        HtmlDocument doc = html.Load(url);

        var node = doc.DocumentNode.CssSelect(".hero-grid-text").Select(x => x.InnerText);
       
        foreach (var item in node) {
            Console.WriteLine(item);
        }
      
        Console.ReadKey();
    }
}