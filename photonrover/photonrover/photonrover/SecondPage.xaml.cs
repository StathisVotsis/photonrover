using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Particle;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace photonrover
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPage : ContentPage
    {
        ParticleDevice myDevice = null;
        
        public SecondPage()
        {
            InitializeComponent();
            
            Task1();
        }

        private void Button_ClickF(object sender, EventArgs e)
        {
            Control_F();
        }

        private void Button_ClickB(object sender, EventArgs e)
        {
            Control_B();
        }

        private void Button_ClickL(object sender, EventArgs e)
        {
            Control_L();
        }

        private void Button_ClickR(object sender, EventArgs e)
        {
            Control_R();
        }

        private void Button_ClickS(object sender, EventArgs e)
        {
            Control_S();
        }

        async void Task1()
        {

            List<ParticleDevice> devices = await ParticleCloud.SharedInstance.GetDevicesAsync();
            foreach (ParticleDevice device in devices)
            {
                if (device.Name.Equals("Master2"))
                    myDevice = device;
            }


        }

        async void Control_F()
        {
            var response = await myDevice.CallFunctionAsync("control", "F-100");

        }

        async void Control_B()
        {
            var response = await myDevice.CallFunctionAsync("control", "B-100");

        }

        async void Control_L()
        {
            var response = await myDevice.CallFunctionAsync("control", "L-100");

        }

        async void Control_R()
        {
            var response = await myDevice.CallFunctionAsync("control", "R-100");

        }

        async void Control_S()
        {
            var response = await myDevice.CallFunctionAsync("control", "S");

        }
    }
}