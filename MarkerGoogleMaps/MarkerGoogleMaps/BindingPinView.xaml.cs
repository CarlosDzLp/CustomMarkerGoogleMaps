using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MarkerGoogleMaps
{
    public partial class BindingPinView : StackLayout
    {
        public BindingPinView(string  url)
        {
            InitializeComponent();
            img.Source = url;
        }
    }
}
