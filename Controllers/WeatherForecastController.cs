using carsapi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Headers;

namespace carsapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async void Get()
        {

            
                string token = "";
                long location = 4058526;
                int facelimit = 10;
                int location_facet_limit = 20;
                string platform = "web-desktop";
                string query = "ertiga";
                int page = 0;
                int size = 40;
                int yearmax = 2021;
                int yearmin = 2019;
                string user = "189d4619fghx331e32f";
               string langu = "en-IN";
               HashSet<Datum> carsdatalist = new HashSet<Datum>();
               HashSet<int> adids = new HashSet<int>();


            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://www.olx.in/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/115.0.0.0 Safari/537.36");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                HttpResponseMessage response = new HttpResponseMessage();

                try
                {
                    for (int i = 1; i < 30; i++)
                    {
                        if (page == 0)
                        {
                            response = await client.GetAsync(String.Format("api/relevance/v4/search?facet_limit={0}&location={1}&location_facet_limit={2}&platform={3}&query={4}&user={5}&lang={6}&size={7}&year_max={8}&year_min={9}", facelimit, location, location_facet_limit, platform, query, user, langu, size,yearmax,yearmin));
                            page++;


                        }
                        else
                        {
                            response = await client.GetAsync(String.Format("api/relevance/v4/search?facet_limit={0}&location={1}&location_facet_limit={2}&platform={3}&query={4}&user={5}&lang={6}&size={7}&page={8}&year_max={9}&year_min={10}", facelimit, location, location_facet_limit, platform, query, user, langu, size, page,yearmax,yearmin));
                            page++;
                        }


                        if (response.IsSuccessStatusCode)
                        {
                            string responseData = await response.Content.ReadAsStringAsync();
                            Carsdata myDeserializedClass = JsonConvert.DeserializeObject<Carsdata>(responseData);

                            foreach (var item in myDeserializedClass.data)
                            {
                                adids.Add(int.Parse(item.ad_id));
                                if (carsdatalist.Contains(item))
                                {

                                }
                                else
                                {
                                    carsdatalist.Add(item);
                                }
                               

                            }
                            ///myDeserializedClass.data.id ,ad_id,created_at_first,created_at,user_id
                            //Console.WriteLine(responseData);
                        }
                        else
                        {
                           // Console.WriteLine("Request failed with status code: " + response.StatusCode);
                        }
                    }








                }
                catch (Exception ex)
                {

                }


            }
                try
                {


                  
                    ///logic for checking not a dealer vehicles
                    ///

                    using (HttpClient clients = new HttpClient())
                    {
                        clients.BaseAddress = new Uri("https://www.olx.in/");
                        clients.DefaultRequestHeaders.Accept.Clear();
                        clients.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/115.0.0.0 Safari/537.36");
                        clients.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                        clients.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                        int limit = 10;


                    foreach (var item in carsdatalist)
                    {
                        try
                        {

                       
                             HttpResponseMessage responseowner = new HttpResponseMessage();
                             responseowner = await clients.GetAsync(String.Format("api/v2/users/"+item.user_id+"/items?limit={0}&status={1}&lang={2}",18,true,langu));


                             if (responseowner.IsSuccessStatusCode)
                          {
                            string responseData = await responseowner.Content.ReadAsStringAsync();
                            CarDealerApi carDealerApi = JsonConvert.DeserializeObject<CarDealerApi>(responseData);


                            if(carDealerApi.data.Count <= 2 )
                            {
                                //owner vehicle
                                Console.WriteLine(item.ad_id);
                            }

                            else
                            {

                            }
                           
                            ///myDeserializedClass.data.id ,ad_id,created_at_first,created_at,user_id
                            
                        }
                        else
                        {
                            Console.WriteLine("Request failed with status code: " + item.ad_id);
                        }

                        }
                        catch (Exception ex) { }

                    }

                    }
                    
                }
                catch (Exception ex) { }

            Console.WriteLine("please copy all ad ids ");
            Console.ReadLine();




                   
                }


            
        
    }
}
