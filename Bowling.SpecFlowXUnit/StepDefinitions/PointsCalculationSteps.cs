using System;
using Bowling.SpecFlowXUnit.Drivers;
using TechTalk.SpecFlow;

namespace Bowling.SpecFlowXUnit.StepDefinitions
{
    [Binding]
    public class PointsCalculationSteps
    {
        private readonly BowlingDriver _driver;

        public PointsCalculationSteps(BowlingDriver driver)
        {
            _driver = driver ?? throw new ArgumentNullException(nameof(driver));
        }

        [Given(@"A new bowling game")]
        public void GivenANewBowlingGame()
        {
            _driver.NewGame();
        }
        
        [When(@"All my balls land in the side gutter")]
        public void WhenAllMyBallsLandInTheSideGutter()
        {
            _driver.Roll(0, 20);
        }
        
        [When(@"I roll (\d+) and (\d+)")]
        public void WhenIRoll(int pins1, int pins2)
        {
            _driver.Roll(pins1, pins2, 1);
        }
        
        [When(@"I roll (\d+) times (\d+) and (\d+)")]
        public void WhenIRollTimesAnd(int rollCount, int pins1, int pins2)
        {
            _driver.Roll(pins1, pins2, rollCount);
        }

        [When(@"All my rolls are strikes")]
        public void WhenAllMyRollsAreStrikes()
        {
            _driver.Roll(10, 12);
        }
        
        [When(@"I roll the following series: (.*)")]
        public void WhenIRollTheFollowingSeries(string series)
        {
            _driver.RollSeries(series);
        }
        
        [When(@"I roll (\d+)")]
        public void WhenIRoll(int pins)
        {
            _driver.Roll(pins, 1);
        }
        
        [Then(@"My total score should be (\d+)")]
        public void ThenMyTotalScoreShouldBe(int score)
        {
            _driver.CheckScore(score);
        }
    }
}
