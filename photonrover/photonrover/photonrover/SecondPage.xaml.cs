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
            var response = await myDevice.CallFunctionAsync("relayOff", "B-100");

        }
    }
}