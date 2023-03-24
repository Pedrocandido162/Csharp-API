using Newtonsoft.Json;

namespace AprendendoWindowsForms
{
    internal static partial class Program
    {
        public class Market
        {
            public Market()
            {
                this.Usdbrl = new Brl();
                this.Eurbrl = new Brl();
            }

            [JsonProperty("USDBRL")]
            public Brl Usdbrl { get; set; }

            [JsonProperty("EURBRL")]
            public Brl Eurbrl { get; set; }
        }

    }
}

