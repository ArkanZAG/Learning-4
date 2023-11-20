using System.Runtime.InteropServices.JavaScript;

namespace Learning_4;

public class SecondTask
{
    private int totalData = 0;
    private int[] inputNumber;

    public void ArrayInput()
    {
        Console.WriteLine("Please type in how many number you want to input : ");
        totalData = int.Parse(Console.ReadLine());
        inputNumber = new int [totalData];
        
        for (int i = 0; i < totalData; i++)
        {
            Console.WriteLine("Angka index ke " + i);
            inputNumber[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        
        Array.Sort(inputNumber);
        foreach (var number in inputNumber)
        {
            Console.Write(number + " ");
        }
        
        Console.WriteLine(" ");
        
        Array.Reverse(inputNumber);
        foreach (var number in inputNumber)
        {
            Console.Write(number + " ");
        }
    }
}