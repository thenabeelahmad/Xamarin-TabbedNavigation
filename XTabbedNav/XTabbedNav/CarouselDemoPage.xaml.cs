using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XTabbedNav
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class CarouselDemoPage : CarouselDemoPage
    {
        public CarouselDemoPage ()
        {
            Thickness padding;
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                case Device.Android:
                    padding = new Thickness(0, 40, 0, 0);
                    break;
                default:
                    padding = new Thickness();
                    break;
            }

            var redContentPage = new ContentPage {
                Padding = padding,
                Content = new StackLayout {
                    Children = {
                        new Label {
                            Text = "Red",
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new BoxView {
                            Color = Color.Red,
                            WidthRequest = 200,
                            HeightRequest = 200,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.CenterAndExpand
                        }
                    }
                }
            };
            var greenContentPage = new ContentPage {
                Padding = padding,
                Content = new StackLayout {
                }
            };
            var blueContentPage = new ContentPage {
                Padding = padding,
                Content = new StackLayout {
                }
            };
            Children.Add (redContentPage);
            Children.Add (greenContentPage);
            Children.Add (blueContentPage);
        }
    }
}