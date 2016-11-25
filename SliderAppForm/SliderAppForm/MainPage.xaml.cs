using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SliderAppForm
{
    public partial class MainPage : ContentPage
    {
        public Slider MySlider = new Slider
        {
            Minimum = 0,
            Maximum = 100,
            Value = 0
        };

        public Label TitleLabel = new Label
        {
            HorizontalTextAlignment = TextAlignment.Center,
            FontSize = 24,
            Text = "Valeur du slider"
        };

        public Label ValueLabel = new Label
        {
            HorizontalTextAlignment = TextAlignment.Center,
            FontSize = 24
        };

        public MainPage()
        {
            InitializeComponent();

            ValueLabel.SetBinding(Label.TextProperty, "Value");
            ValueLabel.BindingContext = MySlider;

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children = {
                    TitleLabel,
                    ValueLabel,
                    MySlider
                }
            };
        }
    } 
}