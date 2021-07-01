using System.ComponentModel;
using Toolkit.Mobile.ViewModels;
using Xamarin.Forms;

namespace Toolkit.Mobile.Views
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