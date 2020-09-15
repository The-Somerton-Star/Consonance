using System;
using System.Net.Http;
using Geoff.Control_Blank_Protocol.Functions.Algorithm_Batch_Core;
using Newtonsoft.Json.Linq;

namespace Geoff.Control_Blank_Protocol.Logic.Stage3.Phase2
{
    public class Idiosyncrasy
    {
        public Idiosyncrasy()
        {

        }

        public static async void GetExchange()
        {
            var baseUrl =
                "https://heartart735801119:quaa06al321a0pm5b97glo3qfu@xecdapi.xe.com/v1/convert_to.json/?to=EUR&from=SEK&amount=1.00";
            try
            {
                using (var client = new HttpClient())
                {
                    using (var response = await client.GetAsync(baseUrl))
                    {
                        using (var content = response.Content)
                        {
                            var data = await content.ReadAsStringAsync();
                            if (data != null)
                            {
                                var dataObject = JObject.Parse(data);
                       //         var change =
                       //             new GoodOmen(
                       //                 Convert.ToInt16($"{dataObject["mid"]}") * 10000);
                            }
                            else
                            {
                       //         var change =
                       //             new GoodOmen(10000);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

    }
}
