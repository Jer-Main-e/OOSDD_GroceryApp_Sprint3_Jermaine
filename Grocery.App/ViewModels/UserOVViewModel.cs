using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;
using System.Collections.ObjectModel;

namespace Grocery.App.ViewModels
{
    public class UserOVViewModel : BaseViewModel
    {
        public ObservableCollection<UserOV> UserOV { get; set; }
        //Het viewmodel voor de user overview
        public UserOVViewModel()
        {
            Title = "Boodschappenlijst";
        }

    }
}