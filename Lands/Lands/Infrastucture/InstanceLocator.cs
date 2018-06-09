namespace Lands.Infrastucture
{
    using ViewModels;

    class InstanceLocator
    {
        #region Propertiess
        public MainViewModel Main
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}
