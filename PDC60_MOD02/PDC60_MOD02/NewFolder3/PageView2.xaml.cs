using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using PDC60_MOD02.NewFolder4;

namespace PDC60_MOD02.NewFolder3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageView2 : ContentPage
    {
        public PageView2()
        {
            InitializeComponent();
            BindingContext = new StudentInformationViewModel();
        }
    }
}