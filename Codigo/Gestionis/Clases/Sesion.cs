namespace Gestionis.Clases
{
    public class Sesion
    {
        private static Sesion instance = null;
        private static readonly object padlock = new object();

        private string apodoUsuario;
        private int numCuenta;

        private Sesion() { }

        public string ApodoUsuario
        {
            get { return apodoUsuario; }
            set
            {
                apodoUsuario = value;
                numCuenta = Cuenta.IDCuentaUsuario(apodoUsuario);
            }
        }

        public int NumCuenta
        {
            get { return numCuenta; }
        }

        public static Sesion Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Sesion();
                    }
                    return instance;
                }
            }
        }
    }
}
