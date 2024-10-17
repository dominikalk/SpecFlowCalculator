namespace SpecFlowCalculator;

public class CalculatorSavedValues
{
    public int? Alpha { get; internal set; }
    public int? Beta { get; internal set; }

    public CalculatorSavedValues() { }

    public CalculatorSavedValues(int alpha, int beta)
    {
        Alpha = alpha;
        Beta = beta;
    }
}
