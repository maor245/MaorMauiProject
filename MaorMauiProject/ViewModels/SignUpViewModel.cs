using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace MaorMauiProject.ViewModels
{
    public partial class SignUpViewModel : ObservableObject //ViewModelBase
    {
        [ObservableProperty]
        private string? _firstName;

       
        public SignUpViewModel()
        {
            FirstName = "Bad Cartel Team";
        }
    }
}
