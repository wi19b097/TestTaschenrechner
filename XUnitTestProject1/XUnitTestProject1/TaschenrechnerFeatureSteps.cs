using System;
using TechTalk.SpecFlow;
using Xunit;

namespace XUnitTestProject1
{
    [Binding]
    public class TaschenrechnerFeatureSteps
    {
        double p;
        [Given(@"a sinus operator")]
        public void GivenASinusOperator()
        {
            Math.Cos(p);
        }

        [When(@"the object PI")]
        public void WhenTheObjectPI()
        {
            p = Math.PI;
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.Equal(1.0, p0, 5);
        }

        [Given(@"a Cos Function")]
        public void GivenACosFunction()
        {
            Math.Cos(p);
        }
        
        [Given(@"a tangens fucntion")]
        public void GivenATangensFucntion()
        {
            Math.Cos(p);
        }
    }
}
