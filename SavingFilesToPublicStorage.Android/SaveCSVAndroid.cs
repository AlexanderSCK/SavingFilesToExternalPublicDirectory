using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SavingFilesToPublicStorage.Droid;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

[assembly: Xamarin.Forms.Dependency(typeof(SaveCSVAndroid))]
namespace SavingFilesToPublicStorage.Droid
{
    class SaveCSVAndroid : ISaveCSV
    {
        
        public void SaveData(string s, string info)
        {
            string DocumentPath = Path.Combine(Android.OS.Environment.ExternalStorageDirectory.AbsolutePath, Android.OS.Environment.DirectoryDownloads);
            string filePath = Path.Combine(DocumentPath, $"{info}.csv");
            File.WriteAllText(filePath, s);
        }
    }
}