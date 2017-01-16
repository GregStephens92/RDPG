using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RDPG
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        private void minSkillsButton_Clicked(object sender, EventArgs e)
        {
            var minSkillsPage = new MinSkills();
            Navigation.PushAsync(minSkillsPage, true);           
        }
    }
}
