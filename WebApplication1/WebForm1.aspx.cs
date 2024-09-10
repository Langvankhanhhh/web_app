using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using libHinhthang;
namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.HttpMethod == "POST")
            {
                bool themdoa;
                try
                {
                    string jsonString = new System.IO.StreamReader(Request.InputStream).ReadToEnd();

                    var data = JsonConvert.DeserializeObject<Dictionary<string, double>>(jsonString);

                    double daynho = data["daynho"];
                    double daylon = data["daylon"];
                    double chieucao = data["chieucao"];
                    double result = dientichthang.dientich(daynho, daylon, chieucao);
                    Response.ContentType = "application/json";
                    Response.Write(JsonConvert.SerializeObject(result));
                }
                catch (Exception ex)
                {
                    Response.Write("Lỗi: " + ex.Message);
                }
            }
        }
    }
}