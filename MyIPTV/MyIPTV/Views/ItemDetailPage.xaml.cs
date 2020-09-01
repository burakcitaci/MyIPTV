using System.ComponentModel;
using Xamarin.Forms;
using MyIPTV.ViewModels;

namespace MyIPTV.Views
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