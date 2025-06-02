using Dominio.Interfaces;

namespace Dominio
{
    public abstract class Usuario : IValidable
    {
        private string _correo;
        private string _password;

        public string Correo
        {
            get { return _correo; }
        }

        public void Validar()
        {
            this.ValidarCorreo();
            this.ValidarPassword();
        }

        private void ValidarCorreo()
        {
            if (string.IsNullOrWhiteSpace(this._correo))
            {
                throw new Exception("El correo no puede estar vacío");
            }

            if (!this._correo.Contains("@"))
            {
                throw new Exception("El correo debe contener el caracter '@'");
            }
        }

        private void ValidarPassword()
        {
            if (string.IsNullOrWhiteSpace(this._password))
            {
                throw new Exception("La contraseña no puede estar vacía");
            }
        }

        public Usuario(string correo,
         string password)
        {
            this._correo = correo;
            this._password = password;
        }
    }
}
