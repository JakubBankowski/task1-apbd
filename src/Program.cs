namespace DefaultNamespace;

public class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("Jakub", 21);
        
    }
    
    public int CalculateAverage(int[] values)
    {
        return values.Sum() / values.Length;
    }
}