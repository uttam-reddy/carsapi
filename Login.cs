using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System;
using System.Text;

namespace carsapi
{


    public class Login
    {

        public async Task<string> GetLoginPasswordToken(string token)
        {

            using (HttpClient client = new HttpClient())
            {

                client.BaseAddress = new Uri("https://www.olx.in/");
                Loginobj loginobj = new Loginobj();
                loginobj.grantType = "password";
                loginobj.email = "uttamreddy73@gmail.com";
                loginobj.password = "Uttam@1234";
                loginobj.language = "en-IN";
                Metadatalogin metadatalogin = new Metadatalogin();
                metadatalogin.deviceInfo = " ";
                loginobj.metadata = metadatalogin;




                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/115.0.0.0 Safari/537.36");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                HttpResponseMessage response = new HttpResponseMessage();

                try
                {

                     HttpContent content = new StringContent(loginobj.ToString(), Encoding.UTF8, "application/json");
                     string reuesturl = String.Format("api/auth/authenticate/login?lang={0}", "en-IN");

                      response = await client.PostAsync(reuesturl,content);
                    ///response = await client.GetAsync("api/relevance/v4/search?facet_limit="+facelimit+"&location="+location+"&location_facet_limit="+location_facet_limit+"&platform="+platform+"&query="+query+ "+&relaxedFilters=true"+"&spellcheck=true+"+"&user="+user"+"&lang="+langu");


                }
                catch (Exception ex)
                {

                }

                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                   // AfterloginToken myDeserializedClass = JsonConvert.DeserializeObject<AfterloginToken>(responseData);

                    ///myDeserializedClass.data.id ,ad_id,created_at_first,created_at,user_id
                    Console.WriteLine(responseData);
                }
                else
                {
                    Console.WriteLine("Request failed with status code: " + response.StatusCode);
                }
            }

                return "";

        }


       
    }

    public class EmailTokenForAPI
    {
        public async Task<string> GetLoginEmailToken()
        {
            EmailTokenResponse myDeserializedClass = new EmailTokenResponse();
            using (HttpClient client = new HttpClient())
            {

                client.BaseAddress = new Uri("https://www.olx.in/");
                EmailToken loginobj = new EmailToken();
                loginobj.grantType = "email";
                loginobj.email = "uttamreddy73@gmail.com";
                loginobj.stopOtpOnEmail = true;
                loginobj.language = "en-IN";





                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/115.0.0.0 Safari/537.36");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                HttpResponseMessage response = new HttpResponseMessage();

                try
                {

                    HttpContent content = new StringContent(loginobj.ToString(), Encoding.UTF8, "application/json");
                    string reuesturl = String.Format("api/auth/authenticate?lang={0}", "en-IN");

                    response = await client.PostAsync(reuesturl, content);
                    ///response = await client.GetAsync("api/relevance/v4/search?facet_limit="+facelimit+"&location="+location+"&location_facet_limit="+location_facet_limit+"&platform="+platform+"&query="+query+ "+&relaxedFilters=true"+"&spellcheck=true+"+"&user="+user"+"&lang="+langu");


                }
                catch (Exception ex)
                {

                }
                
                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                     myDeserializedClass = JsonConvert.DeserializeObject<EmailTokenResponse>(responseData);

                    ///myDeserializedClass.data.id ,ad_id,created_at_first,created_at,user_id
                    Console.WriteLine(responseData);
                }
                else
                {
                    Console.WriteLine("Request failed with status code: " + response.StatusCode);
                }
            }

            return myDeserializedClass.token;

        }


    }

    public class EmailTokenResponse
    {
        public string status { get; set; }
        public string token { get; set; }
       // public bool stopOtpOnEmail { get; set; }
        public string nextAction { get; set; }
    }

    public class EmailToken
    {
        public string grantType { get; set; }
        public string email { get; set; }
        public bool stopOtpOnEmail { get; set; }
        public string language { get; set; }
    }
}

    

