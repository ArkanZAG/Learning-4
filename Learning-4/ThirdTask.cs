namespace Learning_4;

public class ThirdTask
{
    private int[] inputNumber;
    private int totalData;
    private int totalNumber;

    public void TotalNumber()
    {
        Console.WriteLine("Please input the total of data you want to assign : ");
        totalData = int.Parse(Console.ReadLine());
        inputNumber = new int [totalData];
        
        for (int i = 0; i < totalData; i++)
        {
            Console.WriteLine("Please input the number you want to sum");
            inputNumber[i] = int.Parse(Console.ReadLine());
            totalNumber = totalNumber + inputNumber[i];
        }
        
        Console.WriteLine(totalNumber);
    }
}