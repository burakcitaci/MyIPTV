using System;
using System.Collections.Generic;
using MyIPTV.ViewModels;
using MyIPTV.Views;
using Xamarin.Forms;

namespace MyIPTV
{
   public partial class AppShell : Xamarin.Forms.Shell
   {
      public AppShell()
      {
         InitializeComponent();
         Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
         Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
      }

   }
}
