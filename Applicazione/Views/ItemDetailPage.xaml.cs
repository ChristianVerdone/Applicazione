using Applicazione.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Applicazione.Views
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