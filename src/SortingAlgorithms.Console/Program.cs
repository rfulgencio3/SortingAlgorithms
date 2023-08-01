using SortingAlgorithms.Console.Services;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite a cadeia de números separados por espaço:");
        string input = Console.ReadLine();

        int[] arr = Array.ConvertAll(input.Split(' '), int.Parse);

        SortingService sortingService = new SortingService();
        sortingService.PerformSorting(arr);
    }
}