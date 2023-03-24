using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.NetworkInformation;
using static AprendendoWindowsForms.Program;

namespace AprendendoWindowsForms
{
    internal class Cotacoes
    {
        public string name { get; set; }
        public string buy { get; set; }
        public string sell { get; set; }
        public string variation { get; set; }
        




        public  void VerCotacao(string nomeBrl)
        {
            string strURL = "https://economia.awesomeapi.com.br/json/last/USD-BRL,EUR-BRL";
            HttpClient client = new HttpClient();
            try
            {
                var response = client.GetAsync(strURL).Result;
                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync().Result;
                    var market = JsonConvert.DeserializeObject<Market>(result);
                    switch (nomeBrl)
                    {
                        case "Dollar":
                            name = market.Usdbrl.Name;
                            buy = market.Usdbrl.High;

                            break;
                        case "Euro":
                            name = market.Eurbrl.Name;
                            buy = market.Eurbrl.High;

                            break;

                    }
                    if (name == null) { throw new Exception("Você não digitou certo."); }




                    /*
                    buy = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", market.Moeda.Buy);
                    sell = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", market.Moeda.Sell);
                    variation = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:P}", market.Moeda.Variation / 100);*/
                }
                else
                {
                    buy = "-";
                    sell = "-";
                    variation = "-";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
