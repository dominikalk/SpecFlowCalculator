namespace SpecFlowCalculator.Specs.StepDefinitions;

[Binding]
public sealed class CalculatorStepDefinitions
{
    // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

    private readonly Calculator _calculator = new Calculator();
    private int _result;

    [Given("the first number is (.*)")]
    public void GivenTheFirstNumberIs(int number)
    {
        _calculator.FirstNumber = number;
    }

    [Given("the second number is (.*)")]
    public void GivenTheSecondNumberIs(int number)
    {
        _calculator.SecondNumber = number;
    }

    [When("the two numbers are added")]
    public void WhenTheTwoNumbersAreAdded()
    {
        _result = _calculator.Add();
    }

    [When(@"the two numbers are subtracted")]
    public void WhenTheTwoNumbersAreSubtracted()
    {
        _result = _calculator.Subtract();
    }

    [When(@"the numbers (.*) are multiplied")]
    public void WhenTheNumbersAreMultiplied(List<int> numbers)
    {
        _result = _calculator.Multiply(numbers);
    }

    [Then("the result should be (.*)")]
    public void ThenTheResultShouldBe(int result)
    {
        _result.Should().Be(result);
    }

    [StepArgumentTransformation]
    public List<int> TransformToListOfIntegers(string commaSeparatedList)
    {
        return commaSeparatedList.Split(",").Select(number =>
        {
            if (int.TryParse(number, out int result))
            {
                return result;
            }

            throw new InvalidCastException();
        }).ToList();
    }
}
