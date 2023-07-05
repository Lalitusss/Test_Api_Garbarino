namespace ConsoleAPI.Models
{
    public class Usuario
    {
        public string password { get; set; }
        public string username { get; set; }
        public string auth_type { get; set; }

        public Usuario(string password, string username, string auth_type)
        {
            this.password = password;
            this.username = username;
            this.auth_type = auth_type;
        }

        public Usuario()
        {
            this.username = "integracion.marketplace+nocobrador@gmail.com";
            this.password = "nocobrador";
            this.auth_type = "USER";
        }

        //public Usuario()
        //{
        //    this.username = "integracion.marketplace@gmail.com";
        //    this.password = "Garbarino2018";
        //    this.auth_type = "USER";
        //}
    }
}