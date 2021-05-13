using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.Media.Capture;
using Windows.System.Display;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPCamera
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MediaCapture MediaCapture { get; set; }
        public DisplayRequest DisplayRequest { get; set; } = new DisplayRequest();

        public bool isPreviewing { get; set; }

        public MainPage()
        {
            this.InitializeComponent();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            await GetVideoDevicesAsync();
        }

        protected async override void OnNavigatedFrom(NavigationEventArgs e)
        {
            await CleanupCameraAsync();
        }

        private async Task GetVideoDevicesAsync()
        {
            DeviceInformationCollection devices = await DeviceInformation.FindAllAsync(DeviceClass.VideoCapture);
            foreach (var device in devices)
            {
                CameraComboBox.Items.Add(new CameraItem
                {
                    device = device
                });
            }
        }

        private async Task CleanupCameraAsync()
        {
            if (MediaCapture != null)
            {
                if (isPreviewing)
                {
                    await MediaCapture.StopPreviewAsync();
                }

                await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                {
                    PreviewControl.Source = null;

                })
            }
        }

        private async Task CameraComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            await CleanupCameraAsync();
            var camItem = (CameraItem) CameraComboBox.SelectedItem;
            await StartPreviewAsync(camItem.device.id);
        }

        private async Task StartPreviewAsync(string id)
        {
            try
            {
                var mediaInitSettings = new MediaCaptureInitializationSettings { VideoDeviceId = id };
                MediaCapture = new MediaCapture();
                await MediaCapture.InitializeAsync(mediaInitSettings);
                DisplayRequest.RequestActive();
                DisplayInformation.AutoRotationPreferences = DisplayOrientations.Landscape;
            }
            catch (UnauthorizedAccessException)
            {
                ShowMessage("Camera Access Denied");
                return;
            }

            try
            {
                PreviewControl.Source = MediaCapture;
                await MediaCapture.StartPreviewAsync();
                isPreviewing = true;
            }
            catch (System.IO.FileLoadException)
            {

            }
        }

        private void ShowMessage(string v)
        {
            WarningMsg.Text = msg;
        }
    }
}
