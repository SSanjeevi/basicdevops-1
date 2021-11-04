using BasicWebapiUnitTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProjectBasicApi
{
    [TestClass]
    public class UnitTestWeatherReport
    {
        [TestMethod]
        public void TestWeatherReport()
        {
            WeatherService weatherService = new WeatherService();

            Assert.IsNotNull(weatherService.GetWeather());
        }
    }
}
