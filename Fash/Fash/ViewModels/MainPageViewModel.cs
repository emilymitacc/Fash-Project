using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace Fash.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        private readonly INavigationService _navigationService;
        public ICommand GoToLoginCommand => new DelegateCommand(GoToLogin);
        public ICommand GoToSignUpCommand => new DelegateCommand(GoToSignUp);

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        private async void GoToLogin()
        {
            await _navigationService.NavigateAsync("LoginPage");
        }
        private async void GoToSignUp()
        {
            await _navigationService.NavigateAsync("SignUpPage");
        }
    }
}
