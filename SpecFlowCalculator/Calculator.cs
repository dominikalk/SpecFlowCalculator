namespace SpecFlowCalculator;

public class Calculator
{
    public int FirstNumber { get; set; }
    public int SecondNumber { get; set; }

    public int Add()
    {
        return FirstNumber + SecondNumber;
    }

    public int Subtract()
    {
        return FirstNumber - SecondNumber;  
    }

    public int Multiply(IEnumerable<int> numbers) 
    {
        return numbers.Aggregate(1, (a, b) => a * b);
    }
}
