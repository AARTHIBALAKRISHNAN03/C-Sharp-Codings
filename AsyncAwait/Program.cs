using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Start downloading data...");

        
        string data = await DownloadDataAsync();

       
        Console.WriteLine($"Downloaded data: {data}");

        Console.WriteLine("Data processing complete.");
    }

    static async Task<string> DownloadDataAsync()
    {
        
        await Task.Delay(3000); 

        
        return "This is the downloaded data.";
    }
}