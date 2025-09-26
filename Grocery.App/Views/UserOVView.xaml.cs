using Grocery.App.ViewModels;

namespace Grocery.App.Views;

public partial class UserOVView : ContentPage
{
    public UserOVView(UserOVViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (BindingContext is UserOVViewModel bindingContext)
        {
            bindingContext.OnAppearing();

        }
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        if (BindingContext is UserOVViewModel bindingContext)
        {
            bindingContext.OnDisappearing();
        }
    }
}