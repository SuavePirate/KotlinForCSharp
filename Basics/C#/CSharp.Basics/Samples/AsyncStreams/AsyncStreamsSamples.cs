namespace CSharp.Basics.Samples.AsyncStreams
{
    public class AsyncStreamsSample
    {
        // commented for C# 7
        // private async IAsyncEnumberable<string> GetNamesAsync(List<Dog> dogs)
        // {
        //     foreach(var dog in dogs)
        //     {
        //         await Task.Delay(200);
        //         yield return dog.Name;
        //     }
        // }

        // public async Task RunAsync(List<Dog> dogs)
        // {
        //     foreach(var name in GetNamesAsync(dogs))
        //     {
        //         System.Console.WriteLine(name);
        //     }
        // }
    }
}