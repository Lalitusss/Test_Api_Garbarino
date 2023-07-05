using Api.Util;
using ConsoleAPI.Models;
using System;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace ConsoleAPI.Controllers
{
    public class EnviosController : ApiController
    {
        public Shippings Get()
        {
            Shippings ret = new Shippings();
            try
            {
                ret = new JavaScriptSerializer().Deserialize<Shippings>(Metodos.MetodoGet(Urls.ENVIO, Metodos.UsuarioGet()));
            }
            catch
            { }
            return ret;
        }


        public Shipping Get(string ids, string name)
        {
            Shipping ret = new Shipping();
            try
            {
                var param = @"labels?ids=" + ids + "&name=" + name;
                ret = new JavaScriptSerializer().Deserialize<Shipping>(Metodos.MetodoGet(Urls.ENVIO + param, Metodos.UsuarioGet()));
            }
            catch
            { }
            return ret;
        }
    }
}

