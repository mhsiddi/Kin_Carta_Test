using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Kin_Carta_Automation.Steps
{
    [Binding]
    public class BaseAPIStep
    {
        protected const string Url = @"https://data.cityofchicago.org";
        public BaseAPIStep()
        {

        }
    }
}
