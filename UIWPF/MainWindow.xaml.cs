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
using Factory.Factories;
using Logic.Interfaces;

namespace UIWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public ISongLogic songLogic { get; private set; }
        public IImageLogic imageLogic { get; private set; }
        public MainWindow()
        {
            songLogic = SongLogicFactory.GetSongLogic();
            imageLogic = ImageLogicFactory.GetImageLogic();
            InitializeComponent();


            lbSongs.ItemsSource = songLogic.GetAllSongs();
            lbImages.ItemsSource = imageLogic.GetAllImages();
        }

        private void btnSearchMusic_Click(object sender, RoutedEventArgs e)
        {
            lbSongs.ItemsSource = songLogic.SearchSongs(tbSongSearch.Text);
        }

        private void btnSearchImages_Click(object sender, RoutedEventArgs e)
        {
            lbImages.ItemsSource = imageLogic.SearchImages(tbImageSearch.Text);
        }
    }
}
