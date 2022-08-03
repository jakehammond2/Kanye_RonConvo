using Newtonsoft.Json.Linq;

var client = new HttpClient();

var kanyeURL = "https://api.kanye.rest/";
var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";


for (int i = 0; i < 5; i++)
{
    var kanyeResponse = client.GetStringAsync(kanyeURL).Result; //Json object
    var ronResponse = client.GetStringAsync(ronURL).Result;

    var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();  //parsing kanye response //converting kanye repsonse
    var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[',' ').Replace(']', ' ').Replace('"', ' ').Trim();

    Console.WriteLine($"Kanye: {kanyeQuote}");
    Console.WriteLine($"Ron Swanson: {ronQuote}");
    Console.WriteLine();
}