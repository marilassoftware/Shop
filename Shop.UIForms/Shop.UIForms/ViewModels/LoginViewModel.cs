namespace Shop.UIForms.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using Shop.UIForms.Views;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class LoginViewModel
    {
        public LoginViewModel()
        {
            //this.apiService = new ApiService();
            this.Email = "jzuluaga55@gmail.com";
            this.Password = "123456";
            //this.IsEnabled = true;
        }

        public string Email { get; set; }

        public string Password { get; set; }

        public ICommand LoginCommand { get { return new RelayCommand(Login); } }

        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter an email.",
                    "Accept");
                return;
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter a password.",
                    "Accept");
                return;
            }

            MainViewModel.GetInstance().Products = new ProductsViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new ProductsPage());

            //this.IsRunning = true;
            //this.IsEnabled = false;

            //var request = new TokenRequest
            //{
            //    Password = this.Password,
            //    Username = this.Email
            //};

            //var url = Application.Current.Resources["UrlAPI"].ToString();
            //var response = await this.apiService.GetTokenAsync(
            //    url,
            //    "/Account",
            //    "/CreateToken",
            //    request);

            //this.IsRunning = false;
            //this.IsEnabled = true;

            //if (!response.IsSuccess)
            //{
            //    await Application.Current.MainPage.DisplayAlert(
            //        "Error",
            //        "Email or password incorrect.",
            //        "Accept");
            //    return;
            //}

            //var token = (TokenResponse)response.Result;
            //var mainViewModel = MainViewModel.GetInstance();
            //mainViewModel.Token = token;
            //mainViewModel.Products = new ProductsViewModel();
            //await Application.Current.MainPage.Navigation.PushAsync(new ProductsPage());


        }
    }
}
