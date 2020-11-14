using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RadioApp;
using System.Threading;


namespace RadioGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Radio myRadio = new Radio();
        BrushConverter bc = new BrushConverter();

        public MainWindow()
        {
            InitializeComponent();
        }
        private void RadioControl_Click(object sender, RoutedEventArgs e)
        {
            Button controlB = (Button)sender;
            switch(controlB.Content)
            {
                case "On":
                    myRadio.TurnOn();
                    DisplayBox.Text = "On";
                    DisplayBox.Background = Brushes.Azure;
                    break;
                case "Off":
                    myRadio.TurnOff();
                    DisplayBox.Background = (Brush)bc.ConvertFrom("#FFF7F6F6");
                    DisplayBox.Text = "";
                    break;
                case "Play":
                    DisplayBox.Text = myRadio.Play();
                    break;
                case "Pause":
                    myRadio.Pause();
                    BPause.Content = "Continue";
                    break;
                case "Continue":
                    myRadio.Continue();
                    BPause.Content = "Pause";
                    break;
                case "Volume Up":
                    DisplayBox.Text = $"Volume: {myRadio.VolUp()}";
                    break;
                case "Volume Down":
                    DisplayBox.Text = $"Volume: {myRadio.VolDown()}"; 
                    break;
            }
        }
        private void Channel_Click(object sender, RoutedEventArgs e)
        {  
            Button b = (Button)sender;
            switch(b.Content) 
            {
                case "1":
                    myRadio.Channel = 1;
                    break;
                case "2":
                    myRadio.Channel = 2;
                    break;
                case "3":
                    myRadio.Channel = 3;
                    break;
                case "4":
                    myRadio.Channel = 4;
                    break;
            }
            if (myRadio.Playing) DisplayBox.Text = myRadio.Play();

        }
        private void Playlist_Click(object sender, RoutedEventArgs e)
        {
            Button mine = (Button)sender;

            switch (mine.Content)
            {
                case "PlayList":
                    DisplayBox.Text = myRadio.PlayList();
                    break;
                case "Next":
                    DisplayBox.Text = myRadio.NextSong();
                    break;
                case "Previous":
                    DisplayBox.Text = myRadio.PreviousSong();
                    break;
            }
        }
    }
}
