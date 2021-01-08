using Kin_Carta_Automation.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Kin_Carta_Automation.Steps
{
    [Binding]
    public class DistrictSteps : BaseAPIStep
    {
        public RestClient client;
        public RestRequest request;
        public IRestResponse response;


        #region "Constructor"

        public DistrictSteps() : base()
        {
            
        }

        #endregion

        #region "Steps" 

        [Given(@"beach weather station sensor on '(.*)'")]
        public void GivenBeachWeatherStationSensorOakStreet(string station)
        {
            client = new RestClient(Url);
            request = new RestRequest("resource/k7hf-8y75.json", Method.GET);
            request.AddQueryParameter("station_name", station);

        }

        [When(@"the user requests station data")]
        public void WhenTheUserRequestsStationData()
        {
            response = client.Execute(request);
        }

        [Then(@"all data measurements correspond to only that station")]
        public void ThenAllDataMeasuremeantsCorrespondToOnlyThatStation()
        {
            var content = response.Content;
            var districts = JsonConvert.DeserializeObject<List<District>>(content);
            var filtered = districts.Where(w => w.StationName == "Oak Street Weather Station").ToList();

            Assert.AreEqual(districts.Count, filtered.Count);
         
        }

        [Given(@"data is from '(.*)'")]
        public void GivenDataIsFrom(int year)
        {
            string query = $"date_extract_y(measurement_timestamp)={year}";
            request.AddQueryParameter("$where", query);

        }

        [When(@"the user requests data for the first (.*) measurements")]
        public void WhenTheUserRequestsDataForTheFirstMeasurements(int measurement)
        {
            request.AddQueryParameter("$offset", measurement.ToString());
            
        }

        [When(@"the second page of (.*) measurements")]
        public void WhenTheSecondPageOfMeasurements(int measurement)
        {
            request.AddQueryParameter("$limit", "20");
        }

        [Then(@"the returned measurements of both pages should not repeat")]
        public void ThenTheReturnedMeasurementsOfBothPagesShouldNotRepeat()
        {
            response = client.Execute(request);
            var content = response.Content;

            var districts = JsonConvert.DeserializeObject<List<District>>(content);

            int initalCount = districts.Count;
            int uniqueCount = districts.Distinct().ToList().Count;

            Assert.AreEqual(uniqueCount, initalCount);
        }


        #endregion
    }
}
