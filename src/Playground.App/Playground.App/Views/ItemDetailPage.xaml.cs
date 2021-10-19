using Playground.App.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Playground.App.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}