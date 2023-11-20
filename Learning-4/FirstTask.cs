namespace Learning_4;

public class FirstTask
{
    private int[] number = new int [10];

    public void ArrayPrint()
    {
        for (int i = 0; i < number.Length; i++)
        {
            Console.WriteLine(i);
            number[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        Console.WriteLine(" Element in array are : ");
        
        for (int i = 0; i < number.Length; i++)
        {
            Console.WriteLine(number[i]);
        }
    }
}