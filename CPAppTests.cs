using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Vision.QA.Automation.PlanPages;

namespace Vision.FuncTests.CPApp 
{
    [TestFixture]
    class CPAppTests : VisionTestBase
    {
        [Test]
        public void createScenario()
        {
            ChannelPlanningPage cPPage = new ChannelPlanningPage();
            var originalName = "Auto plan " + DateTime.Now;
            ChannelPlanningPage.AddChannelPlanning(originalName).Execute();
        }
    }
}
