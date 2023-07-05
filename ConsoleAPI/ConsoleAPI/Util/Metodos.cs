using ConsoleAPI.Models;
using ConsoleAPI.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace Api.Util
{
    public class Metodos
    {
        static public string MetodoPostRequest(string URL, Token T, object body)
        {
            byte[] dataStream = Encoding.UTF8.GetBytes(Newtonsoft.Json.JsonConvert.SerializeObject(body));
            WebRequest request = WebRequest.Create(URL);
            request.Method = "POST";
            request.ContentType = "application/json";
            if (T != null)
                request.Headers.Add("Authorization", T.token_type + " " + T.access_token);
            request.ContentLength = dataStream.Length;
            Stream newStream = request.GetRequestStream();
            newStream.Write(dataStream, 0, dataStream.Length);
            newStream.Close();
            WebResponse webResponse = request.GetResponse();
            Stream webStream = webResponse.GetResponseStream();
            StreamReader responseReader = new StreamReader(webStream);
            string response = responseReader.ReadToEnd();
            responseReader.Close();
            return response;
        }

        static public Token UsuarioGet()
        {
            Usuario u = new Usuario();

            Token T = new JavaScriptSerializer().Deserialize<Token>(MetodoPostRequest(Urls.LOGIN, null, u));

            return T;
        }

        static public string MetodoPost(string URL, Token T, object body)
        {
            return MetodoPostRequest(URL, T, body);
        }

        static public string MetodoGet(string URL, Token T, List<Parametro> Parametros = null)
        {
            if (Parametros != null)
                if (Parametros.Count != 0)
                    URL += Funciones.ArmarParametros(Parametros);

            HttpWebRequest request = WebRequest.Create(URL) as HttpWebRequest;
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Headers.Add("Authorization", T.token_type + " " + T.access_token);

            var resp = string.Empty;
            try
            {
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                StreamReader reader = new StreamReader(response.GetResponseStream());
                resp = reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }

            return resp;
        }

        //HttpClient PUT
        static public async Task<string> PutAsync(string URL, Token T, string dato, List<Parametro> Parametros = null)
        {
            try
            {
                var res = string.Empty;
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/plain"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", T.access_token);

                    using (var content = new StringContent(dato))
                    {
                        var result = await client.PutAsync(URL, content);
                        res = await result.Content.ReadAsStringAsync();
                    }
                }
                return res;
            }
            catch
            {
                throw;
            }
        }

        //HttpClient GET
        static public async Task<string> GetAsync(string URL, Token T, List<Parametro> Parametros = null)
        {
            try
            {
                var ret = string.Empty;
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(URL);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", T.access_token);

                    client.Timeout = TimeSpan.FromMinutes(10);
                    client.Timeout = new TimeSpan(0, 0, 0, 0, -1);

                    HttpResponseMessage response = await client.GetAsync(URL);
                    if (response.IsSuccessStatusCode)
                    {
                        ret = await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        ret = response.ToString();
                    }
                }
                return ret;
            }
            catch
            {
                throw;
            }
        }

    }
}