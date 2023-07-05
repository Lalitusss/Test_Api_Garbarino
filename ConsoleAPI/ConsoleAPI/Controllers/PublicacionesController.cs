using Api.Util;
using ConsoleAPI.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace ConsoleAPI.Controllers
{
    public class PublicacionesController : ApiController
    {
        public Publication Get(int? id)
        {
            Publication ret = new Publication();
            try
            {
                ret = new JavaScriptSerializer().Deserialize<Publication>(Metodos.MetodoGet(Urls.PUBLICACIONES + id, Metodos.UsuarioGet()));
            }
            catch
            { }
            return ret;
        }

        public Publications Get()
        {
            Publications ret = new Publications();
            try
            {
                ret = new JavaScriptSerializer().Deserialize<Publications>(Metodos.MetodoGet(Urls.PUBLICACIONES, Metodos.UsuarioGet()));
            }
            catch
            { }
            return ret;
        }

        public Publications Get(int page, int size, string status, string sort, string paused, int brand_id, string search, int? category_id)
        {
            Publications ret = new Publications();
            try
            {
                List<Parametro> parametros = new List<Parametro>();

                parametros.Add(new Parametro { nombre = "page=", dato = page.ToString() });
                parametros.Add(new Parametro { nombre = "size=", dato = size.ToString() });
                parametros.Add(new Parametro { nombre = "status=", dato = status });
                parametros.Add(new Parametro { nombre = "sort=", dato = sort });
                parametros.Add(new Parametro { nombre = "paused=", dato = paused });
                parametros.Add(new Parametro { nombre = "brand_id=", dato = brand_id.ToString() });
                parametros.Add(new Parametro { nombre = "search=", dato = search });
                parametros.Add(new Parametro { nombre = "category_id=", dato = category_id.ToString() });

                ret = new JavaScriptSerializer().Deserialize<Publications>(Metodos.MetodoGet(Urls.PUBLICACIONES, Metodos.UsuarioGet(), parametros));
            }
            catch
            { }
            return ret;
        }

        //[HttpGet]
        public Publications Get(int page, int size, string status, string sort, string paused, int brand_id)
        {
            return Get(page, size, status, sort, paused, brand_id, string.Empty, null);
        }

        public List<Price> Post(int id, string page, double sale_price, double list_price)
        {
            List<Price> ret = new List<Price>();

            try
            {
                PriceR body = new PriceR { sale_price = sale_price, list_price = list_price };

                string UrlAdd = id.ToString() + "/" + page + "/";

                ret = new JavaScriptSerializer().Deserialize<List<Price>>(Metodos.MetodoPost(Urls.PUBLICACIONES + UrlAdd, Metodos.UsuarioGet(), body));
            }
            catch
            { }
            return ret;
        }

        public StockR Post(int id, string page, int quantity)
        {
            StockR ret = new StockR();

            try
            {
                Quantity body = new Quantity { quantity = quantity };

                string UrlAdd = id.ToString() + "/" + page;

                ret = new JavaScriptSerializer().Deserialize<StockR>(Metodos.MetodoPost(Urls.PUBLICACIONES + UrlAdd, Metodos.UsuarioGet(), body));
            }
            catch
            { }
            return ret;
        }
    }
}

