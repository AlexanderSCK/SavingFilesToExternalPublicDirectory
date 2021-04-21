# SavingFilesToExternalPublicDirectory
Sample app for trying to save files in Xamarin API level 29 to external public storage
The main app is based upon the concept of Services and Characteresitics and uses PLugin.BLE to connect to specific bluetooth devices.
When the user connects he is redirected to the BluetoothDataPage where information from the bluetooth device is gathered, transformed into a string and saved to faile in Downloads
Only the saving to file functionlity is currently present, because when a user enters the BluetoothDataPage and treis to execute save a file button it trhwos a Sytstem.UnauthorizdAccess error
The saving files function is working on the main page, but it needs to be done into the BluetoothDataPage, because all the logic is based there.
The user uses Dependency services for saving method in Android
The devices it was tried on was Samsung Galaxy S10
For some reason only the saving method in the main page is working not the one based in the BluetoothDataPage
Please install all necessary PLugins in order to replicate the real world application
