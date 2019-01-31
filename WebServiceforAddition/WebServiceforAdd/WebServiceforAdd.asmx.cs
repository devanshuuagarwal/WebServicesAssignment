using System;
using System.Web.Services;

namespace WebServiceforAdd
{
    /// <summary>
    /// Summary description for WebServiceforAdd
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceforAdd : System.Web.Services.WebService
    {

        //Constructor for making the object
        public WebServiceforAdd()
        {

        }

    
        [WebMethod]
        public object Add(string numbers)
        {
            int sumOfNumbers = 0;
            string[] arrayOfNumbers = numbers.Split(',');
            

            for(int i=0;i<arrayOfNumbers.Length;i++)
            {
                sumOfNumbers += Convert.ToInt16(arrayOfNumbers[i]);
            }

            return sumOfNumbers;
        }
    }
}
