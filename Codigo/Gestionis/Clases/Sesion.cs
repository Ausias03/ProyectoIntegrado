namespace Gestionis.Clases
{
    public class Sesion
    {
        private static Sesion instance = null;
        private static readonly object padlock = new object();

        private string apodoUsuario;
        private int numCuenta;
        private bool temaOscuro = false;
        private static bool barraExpandida = true;

        public string ApodoUsuario
        {
            get { return apodoUsuario; }
            set
            {
                apodoUsuario = value;
                numCuenta = Cuenta.IDCuentaUsuario(apodoUsuario);
            }
        }

        public int NumCuenta { get { return numCuenta; } }

        public bool TemaOscuro { get { return temaOscuro; } set { temaOscuro = value; } }

        public bool BarraExpandida { get { return barraExpandida; } set { barraExpandida = value; } }

        private Sesion() { }

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
