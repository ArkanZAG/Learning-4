namespace Learning_4;

public class FourthTask
{
    private int[] inputNumber;
    private int totalData;

    public void UniqueNumberCheck()
    {
        Console.WriteLine("Please input the total of data you want to assign : ");
        totalData = int.Parse(Console.ReadLine());
        inputNumber = new int [totalData];

        for (int i = 0; i < totalData; i++)
        {
            Console.WriteLine("Please type ini the number you want to shown : ");
            inputNumber[i] = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine("The duplicate number are : ");

        for (int i = 0; i < totalData; i++)
        {
            for (int j = i + 1; j < totalData; j++)
            {
                if (inputNumber[j] == inputNumber[i])
                {
                    Console.WriteLine(inputNumber[i]);
                }
            }
        }
        
        
    }
}