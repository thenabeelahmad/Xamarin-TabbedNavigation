using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XTabbedNav
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();

            Title = "Tabbed Navigation Demo"; //CurrentPage?.Title;
        }
       
    }
}