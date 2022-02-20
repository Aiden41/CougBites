using CougBites.Models;
using CougBites.ViewModels;
using CougBites.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CougBites.Views
{
    public partial class SearchPage : ContentPage
    {
        SearchViewModel _viewModel;

        public SearchPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new SearchViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}