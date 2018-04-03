using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowVSMac
{
    [Binding]
    public class TestSteps
    {
        private List<int> _numbers = new List<int>();
        private int _sum;

        [Given("I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredSomethingIntoTheCalculator(int number)
        {
            _numbers.Add(number);
        }

        [When("I press add")]
        public void WhenIPressAdd()
        {
            _sum = _numbers.Sum();
        }

        [Then("the result should be (.*) on the screen")]
        public void ThenTheResultShouldBe(int result)
        {
            Assert.AreEqual(result, _sum);
        }
    }
}
