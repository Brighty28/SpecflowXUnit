using System;
using Bowling.SpecFlowXUnit.Drivers;
using TechTalk.SpecFlow;

namespace Bowling.SpecFlowXUnit.StepDefinitions
{
    public class BowlingSteps
    {
        private readonly BowlingDriver _driver;

        public BowlingSteps(BowlingDriver driver)
        {
            _driver = driver ?? throw new ArgumentNullException(nameof(driver));
        }

        [Given(@"There is a new bowling game")]
        public void GivenANewBowlingGame()
        {
            _driver.NewGame();
        }

        [When(@"All my balls land in the side gutter")]
        public void WhenAllOfMyBallsAreLandingInTheGutter()
        {
            _driver.Roll(0, 20);
        }

        [When(@"I only throw strikes")]
        public void WhenAllOfMyRollsAreStrikes()
        {
            _driver.Roll(10, 12);
        }

        [Then(@"Should be my (\d+) score")]
        public void ThenMyTotalScoreShouldBe(int score)
        {
            _driver.CheckScore(score);
        }

        [When(@"I (\d+) throw")]
        public void WhenIRoll(int pins)
        {
            _driver.Roll(pins, 1);
        }

        [When(@"I (\d+) and (\d+) throw")]
        public void WhenIRoll(int pins1, int pins2)
        {
            _driver.Roll(pins1, pins2, 1);
        }

        [When(@"I (\d+) times (\d+) and (\d+) throw")]
        public void WhenIRollSeveralTimes2(int rollCount, int pins1, int pins2)
        {
            _driver.Roll(pins1, pins2, rollCount);
        }

        [When(@"I following series throw:(.*)")]
        public void WhenIRollTheFollowingSeries(string series)
        {
            _driver.RollSeries(series);
        }

        [When(@"I throw")]
        public void WhenIRoll(Table rolls)
        {
            _driver.RollSeries(rolls);
        }
    }
}
