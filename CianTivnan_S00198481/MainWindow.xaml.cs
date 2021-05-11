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

namespace CianTivnan_S00198481
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Game> AllGames;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            GameData db = new GameData();

            var query = from p in db.Games
                        select p;

            AllGames = query.ToList();

            lbx_Games.ItemsSource = AllGames;
        }

        private void lbx_Games_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Game SelectedGame = lbx_Games.SelectedItem as Game;

            tblk_Game.Text = SelectedGame.Name;
            img_Game.Source = new BitmapImage(new Uri(SelectedGame.GameImage, UriKind.Relative));
        }
    }
}
