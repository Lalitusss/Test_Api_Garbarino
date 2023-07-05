using Api.Util;
using ConsoleAPI.Models;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace ConsoleAPI.Controllers
{
    public class VentasController : ApiController
    {
        public Sales Get()
        {
            Sales ret = new Sales();
            try
            {
                ret = new JavaScriptSerializer().Deserialize<Sales>(Metodos.MetodoGet(Urls.VENTAS, Metodos.UsuarioGet()));
            }
            catch
            { }
            return ret;
        }

        public Sales Get(int page, int size, string sort, string status, int cart_id, int company_id, string search, string from, string to)
        {
            Sales ret = new Sales();
            try
            {
                List<Parametro> parametros = new List<Parametro>();

                parametros.Add(new Parametro { nombre = "page=", dato = page.ToString() });
                parametros.Add(new Parametro { nombre = "size=", dato = size.ToString() });
                parametros.Add(new Parametro { nombre = "sort=", dato = sort });
                parametros.Add(new Parametro { nombre = "status=", dato = status });
                parametros.Add(new Parametro { nombre = "cart_id=", dato = cart_id.ToString() });
                parametros.Add(new Parametro { nombre = "company_id=", dato = company_id.ToString() });
                parametros.Add(new Parametro { nombre = "search=", dato = search });
                parametros.Add(new Parametro { nombre = "from=", dato = from.ToString() });
                parametros.Add(new Parametro { nombre = "to=", dato = to.ToString() });

                ret = new JavaScriptSerializer().Deserialize<Sales>(Metodos.MetodoGet(Urls.VENTAS, Metodos.UsuarioGet(), parametros));
            }
            catch
            { }
            return ret;
        }

        public Sales Get(int page, int size, string sort, string status, int cart_id, int company_id)
        {
            return Get(page, size, sort, status, cart_id, company_id, string.Empty, string.Empty, string.Empty);
        }


        public Sales Get(int page, int size, int cart_id)
        {
            return Get(page, size, string.Empty, string.Empty, cart_id,0, string.Empty, string.Empty, string.Empty);
        }
    }
}

