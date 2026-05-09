//using Android.Provider;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trenslite.Class;

public static class translateClass
{
    public static string Translate { get; set; }

    public static void trans (string text, string languageText, string languageTranslate)
    {
        try
        {
            text = rply(text);
           

            string URl = $"https://api.codebazan.ir/translate/?type=json&from={languageText}&to={languageTranslate}&text={text}";

            using (var client = new HttpClient())
            {
                var result = client.GetStringAsync(URl).Result;
                var desryalazResult = JsonConvert.DeserializeObject<Root>(result);
                Translate = desryalazResult.result;
            }
        }
        catch (Exception)
        {
            
        }
    }
        
     
    public static string rply(string text)
    {
        // حذف اینتر ها و جایگزینی با فاصله
        return text.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " ");
    }

}

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class Root
{
    public bool ok { get; set; }
    public string result { get; set; }
}




