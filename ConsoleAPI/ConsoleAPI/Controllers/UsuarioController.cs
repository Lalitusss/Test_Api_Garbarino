using Api.Util;
using ConsoleAPI.Models;
using Newtonsoft.Json;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace ConsoleAPI.Controllers
{
    public class UsuarioController : ApiController
    {
        public User Get()
        {
            User U = new User();
            try
            {
                U = new JavaScriptSerializer().Deserialize <User>(Metodos.MetodoGet(Urls.GETMYUSER, Metodos.UsuarioGet()));
            }
            catch
            { }
            return U;
        }

    }
}

