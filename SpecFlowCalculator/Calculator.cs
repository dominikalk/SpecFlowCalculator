namespace SpecFlowCalculator;

public class Calculator
{
    public int FirstNumber { get; set; }
    public int SecondNumber { get; set; }
    public CalculatorSavedValues SavedValues = new CalculatorSavedValues();

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

    public void BulkSetSavedValues(int alpha, int beta)
    {
        SavedValues.Alpha = alpha;
        SavedValues.Beta = beta;
    }

    public void SetAlpha(int alpha)
    {
        SavedValues.Alpha = alpha;
    }

    public void SetBeta(int beta)
    {
        SavedValues.Beta = beta;
    }
}
