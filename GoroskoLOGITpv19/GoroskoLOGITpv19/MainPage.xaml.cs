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
            vkl = true;
            while (vkl != false)
            {

                h.BackgroundColor = Color.Gray;
                await Task.Run(() => Thread.Sleep(1000));
                h.BackgroundColor = Color.White;
                await Task.Run(() => Thread.Sleep(1000));
                b.BackgroundColor = Color.Aqua;
                await Task.Run(() => Thread.Sleep(1000));
                b.BackgroundColor = Color.White;
                await Task.Run(() => Thread.Sleep(1000));
                f.BackgroundColor = Color.Aqua;
                await Task.Run(() => Thread.Sleep(1000));
                f.BackgroundColor = Color.White;
                await Task.Run(() => Thread.Sleep(1000));
            }
        }

        private void off_Clicked(object sender, EventArgs e)
        {
            h.BackgroundColor = Color.White;
            b.BackgroundColor = Color.White;
            f.BackgroundColor = Color.White;
            vkl = false;
        }
    }
}
