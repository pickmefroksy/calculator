using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace calculator
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                int n1 = Convert.ToInt32(num1.Text);
                int n2 = Convert.ToInt32(num2.Text);
                sum.Text = (n1 + n2).ToString();
            }
            catch (Exception exc) { }
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            try
            {
                int n1 = Convert.ToInt32(num1.Text);
                int n2 = Convert.ToInt32(num2.Text);
                generation.Text = (n1 * n2).ToString();
            }
            catch (Exception exc) { }
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            try
            {
                int n1 = Convert.ToInt32(num1.Text);
                int n2 = Convert.ToInt32(num2.Text);
                degree.Text = (n1 / n2).ToString();
            }
            catch (Exception exc) { }
            
        }
        

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            try
            {
                int n1 = Convert.ToInt32(num1.Text);
                int n2 = Convert.ToInt32(num2.Text);
                difference.Text = (n1 - n2).ToString();
            }
            catch (Exception exc) { }
            
        }

        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            await DisplayAlert("Справка", "Новик Егор", "Закрыть");
        }
    }
}
