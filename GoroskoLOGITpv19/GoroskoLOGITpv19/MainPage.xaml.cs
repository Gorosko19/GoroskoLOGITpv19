using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GoroskoLOGITpv19
{
  
    public partial class MainPage : ContentPage
    {
        bool vkl;
        public MainPage()
        {
            InitializeComponent();
        }

        private async void on_Clicked(object sender, EventArgs e)
        {
            oni.IsVisible = true;
            {
                bool result = await DisplayAlert("Подтвердить действие", "Вы уверенны что хотите нажать?", "Да", "Нет");
                await DisplayAlert("Уведомление", "Вы выбрали: " + (result ? "Нажать" : "Отменить"), "OK");
                h.Opacity = 0;
                b.Opacity = 0;
                b.Opacity = 0;
                h.Opacity = 0;
                f.Opacity = 0;
                f.Opacity = 0;


            }
            oni.IsVisible = false;
        }

        private async void off_Clicked(object sender, EventArgs e)
        {
            a.IsVisible = true;
            {
                bool result = await DisplayAlert("Подтвердить действие", "Вы уверенны что хотите нажать?", "Да", "Нет");
                await DisplayAlert("Уведомление", "Вы выбрали: " + (result ? "Нажать" : "Отменить"), "OK");
                h.Opacity = 1;
                b.Opacity = 1;
                b.Opacity = 1;
                h.Opacity = 1;
                f.Opacity = 1;
                f.Opacity = 1;
            }
            a.IsVisible = false;

        }
        Random rnd = new Random();
        private void Ramdom_Clicked(object sender, EventArgs e)
        {
            s.IsVisible = true;
            {
                int r = rnd.Next(0, 255);
                int g = rnd.Next(0, 255);
                int b1 = rnd.Next(0, 255);
                h.BackgroundColor = Color.FromRgb(r, g, b1);
                r = rnd.Next(0, 255);
                g = rnd.Next(0, 255);
                b1 = rnd.Next(0, 255);
                b.BackgroundColor = Color.FromRgb(r, g, b1);
                r = rnd.Next(0, 255);
                g = rnd.Next(0, 255);
                b1 = rnd.Next(0, 255);
                f.BackgroundColor = Color.FromRgb(r, g, b1);
            }
            s.IsVisible = false;
        }

        private async void wh_Clicked(object sender, EventArgs e)
        {
            d.IsVisible = true;
            bool vkl = true;
            while (vkl != false)
            {
                h.Opacity = 0;
                b.BackgroundColor = Color.Aqua;
                f.BackgroundColor = Color.Aqua;
                await Task.Run(() => System.Threading.Thread.Sleep(500));
                for (int i = 0; i < 3; i++)
                {
                    h.Opacity = 0;
                    b.Opacity = 0;
                    f.BackgroundColor = Color.Aqua;
                    await Task.Run(() => System.Threading.Thread.Sleep(500));
                }

                h.Opacity = 0;
                b.Opacity = 0;
                f.Opacity = 0;
                await Task.Run(() => System.Threading.Thread.Sleep(500));

            }
            d.IsVisible = false;
        }
    }
}
