using System;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace MarkerGoogleMaps
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            LoadPin();
            AddMapStyle();
        }

        private void LoadPin()
        {
            try
            {
                var pin1 = new Pin()
                {
                    Icon = BitmapDescriptorFactory.FromView(new BindingPinView("https://cdn.the-scientist.com/assets/articleNo/67177/aImg/36169/article-cal-s.png")),
                    Type = PinType.Place,
                    Position = new Position(16.745344, -93.0801975),
                    ZIndex = 5,
                    Label="Pin1",
                    Address = "Direccion",
                    Flat = true
                };

                var pin2 = new Pin()
                {
                    Icon = BitmapDescriptorFactory.FromView(new BindingPinView("https://cdn.the-scientist.com/assets/articleNo/67177/aImg/36169/article-cal-s.png")),
                    Type = PinType.Place,
                    Position = new Position(16.7428318, -93.0891797),
                    ZIndex = 5,
                    Flat = true,
                    Label = "Pin2"
                };

                var pin3 = new Pin()
                {
                    Icon = BitmapDescriptorFactory.FromView(new BindingPinView("https://cdn.the-scientist.com/assets/articleNo/67177/aImg/36169/article-cal-s.png")),
                    Type = PinType.Place,
                    Position = new Position(16.7464585, -93.0893835),
                    ZIndex = 5,
                    Flat = true,
                    Label = "Pin3"
                };

                var pin4 = new Pin()
                {
                    Icon = BitmapDescriptorFactory.FromView(new BindingPinView("https://cdn.the-scientist.com/assets/articleNo/67177/aImg/36169/article-cal-s.png")),
                    Type = PinType.Place,
                    Position = new Position(16.7439435, -93.0932709),
                    ZIndex = 5,
                    Flat = true,
                    Label = "Pin4"
                };

                var pin5 = new Pin()
                {
                    Icon = BitmapDescriptorFactory.FromView(new BindingPinView("https://cdn.the-scientist.com/assets/articleNo/67177/aImg/36169/article-cal-s.png")),
                    Type = PinType.Place,
                    Position = new Position(16.7465938, -93.087603),
                    ZIndex = 5,
                    Flat = true,
                    Label = "Pin5"
                };
                //map.SelectedPin = pin1;
                map.Pins.Add(pin1);
                map.Pins.Add(pin2);
                map.Pins.Add(pin3);
                map.Pins.Add(pin4);
                map.Pins.Add(pin5);
                map.MoveToRegion(MapSpan.FromCenterAndRadius(pin1.Position, Distance.FromMeters(5000)), true);
            }
            catch(Exception ex)
            {

            }
        }


        void AddMapStyle()
        {
            try
            {
                var assembly = typeof(MainPage).GetTypeInfo().Assembly;
                var stream = assembly.GetManifestResourceStream($"MarkerGoogleMaps.MapStyle.json");
                string styleFile;
                using (var reader = new System.IO.StreamReader(stream))
                {
                    styleFile = reader.ReadToEnd();
                }

                map.MapStyle = MapStyle.FromJson(styleFile);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
