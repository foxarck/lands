
namespace lands.infraestructura
{
    using modelo_vista;
    public class instansloqueidor
    {
        #region properties
        public mainviewmodel main
        {
            get;
            set;
        }
        #endregion

        #region constructor
        public instansloqueidor()
        {
            this.main = new mainviewmodel();                
        }
        #endregion
    }
}
