namespace Lands.ViewModels
{
    class MainViewModel
    {
        #region ViewModels
        public loginViewModel Loggin
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            this.Loggin = new LoginViewModel();
        }
        #endregion
    }
}
