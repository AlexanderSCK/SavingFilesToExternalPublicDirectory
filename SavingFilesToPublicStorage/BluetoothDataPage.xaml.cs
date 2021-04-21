using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.BLE.Abstractions.Contracts;
using Plugin.BLE;
using Plugin.BLE.Abstractions;
using System.IO;
using Xamarin.Forms.PlatformConfiguration;
using System.Collections;

namespace SavingFilesToPublicStorage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BluetoothDataPage : ContentPage
    {
        private string dateFile;
        private string fileName;
        private string infoFileName;
        private string fileContent;

        public BluetoothDataPage()
        {
            InitializeComponent();
            dateFile = DateTime.Now.ToString("MM-dd-yyyy-hh-mm-ss-tt");
            fileName = "TestAt:";





        }



        private async void SaveData_Clicked(object sender, EventArgs e)
        {
            var saveCSVService = DependencyService.Get<ISaveCSV>();
            var readWritePermission = DependencyService.Get<IReadWritePermission>();
            var status = await readWritePermission.CheckStatusAsync();
            if (status != PermissionStatus.Granted)
            {
                status = await readWritePermission.RequestAsync();
            }
            fileContent = "Test";
            infoFileName = $"{fileName}{dateFile}";

            saveCSVService.SaveData(fileContent, infoFileName);
        }
    }

}