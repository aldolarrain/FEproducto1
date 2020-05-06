namespace AppProducto1.ViewModels
{
    using AppProducto1.Services;
    using System;
    using System.Collections.ObjectModel;

    public class MainViewModel
    {
        #region Attributes
        private ApiService apiService;
        #endregion

        #region Properties
        public ObservableCollection<ListProductViewModel> Products { get; set; }
        #endregion

        public MainViewModel()
        {
            apiService = new ApiService();
            Products = new ObservableCollection<ListProductViewModel>();
            LoadProducts();
        }
        #region Method
        private void LoadProducts()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
