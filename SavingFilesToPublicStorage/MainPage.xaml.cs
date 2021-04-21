using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.BLE;
using Plugin.BLE.Abstractions.Contracts;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using Plugin.BLE.Abstractions;
using System.Threading;

namespace SavingFilesToPublicStorage
{
    public partial class MainPage : ContentPage
    {
        private readonly IAdapter _bluetoothAdapter;
        private List<IDevice> _gattDevices = new List<IDevice>();
        private List<IDevice> devicesFound = new List<IDevice>();
        CancellationTokenSource source = new CancellationTokenSource();
        private string fileContent;
        private string infoFileName;
        private string dateFile;
        private string fileName;
        public MainPage()
        {
            InitializeComponent();
            //_bluetoothAdapter = CrossBluetoothLE.Current.Adapter;
            //_bluetoothAdapter.DeviceDiscovered += (s, a) =>
            //{
            //    _gattDevices.Add(a.Device);
            //};
            //CancellationToken token = source.Token;
            //dateFile = DateTime.Now.ToString("MM-dd-yyyy-hh-mm-ss-tt");
            //fileName = "TestFile";

        }

        private void SaveFile_Clicked(object sender, EventArgs e)
        {
            var saveCSVService = DependencyService.Get<ISaveCSV>();
            fileContent = "Test";
            infoFileName = $"{fileName}{dateFile}";

            saveCSVService.SaveData(fileContent, infoFileName);
        }

        private async void Navigate_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BluetoothDataPage());
        }
    }
}
