using TechTalk.SpecFlow.Assist;

namespace SpecFlowCalculator.Specs.StepDefinitions;

[Binding]
public sealed class CalculatorSavedValuesStepDefinitions
{
    private readonly Calculator _calculator = new Calculator();

    [Given(@"the saved values are")]
    public void GivenTheSavedValuesAre(Table table)
    {
        _calculator.SavedValues = table.CreateInstance<CalculatorSavedValues>();
    }

    [When(@"the user bulk saves (.*) and (.*)")]
    public void WhenTheUserBulkSavesAnd(int alpha, int beta)
    {
        _calculator.BulkSetSavedValues(alpha, beta);
    }

    [When(@"the user updates alpha to (.*)")]
    public void WhenTheUserUpdatesAlphaTo(int alpha)
    {
        _calculator.SetAlpha(alpha);
    }

    [Then(@"the saved values should be")]
    public void ThenTheSavedValuesShouldBe(Table table)
    {
        table.CompareToInstance(_calculator.SavedValues);
    }
}
