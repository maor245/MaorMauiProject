using MaorMauiProject.Views;
using Microsoft.Extensions.DependencyInjection;

namespace MaorMauiProject
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            //return new Window(new AppShell());
            //return new Window(new SignInPage());
            return new Window(new SignUpPage());
        }
    }
}