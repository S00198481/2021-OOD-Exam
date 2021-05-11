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
        GameData db = new GameData();
        List<Game> AllGames;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

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

        private void cbx_Platform_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem item = (ComboBoxItem)cbx_Platform.SelectedItem;
            string selection = item.Content.ToString();

            switch(selection)
            {
                case "Any":
                    lbx_Games.ItemsSource = null;
                    AllGames = null;
                    var query = from p in db.Games
                                select p;

                    AllGames = query.ToList();

                    lbx_Games.ItemsSource = AllGames;
                    break;

                case "Playstation":
                    lbx_Games.ItemsSource = null;
                    AllGames = null;
                    var query2 = from p in db.Games
                                 where p.Platform.Contains("PS")
                                select p;

                    AllGames = query2.ToList();

                    lbx_Games.ItemsSource = AllGames;
                    break;

                case "Xbox":
                    lbx_Games.ItemsSource = null;
                    AllGames = null;
                    var query3 = from p in db.Games
                                 where p.Platform.Contains("Xbox")
                                 select p;

                    AllGames = query3.ToList();

                    lbx_Games.ItemsSource = AllGames;
                    break;

                case "Switch":
                    lbx_Games.ItemsSource = null;
                    AllGames = null;
                    var query4 = from p in db.Games
                                 where p.Platform.Contains("Switch")
                                 select p;

                    AllGames = query4.ToList();

                    lbx_Games.ItemsSource = AllGames;
                    break;

                case "PC":
                    lbx_Games.ItemsSource = null;
                    AllGames = null;
                    var query5 = from p in db.Games
                                 where p.Platform.Contains("PC")
                                 select p;

                    AllGames = query5.ToList();

                    lbx_Games.ItemsSource = AllGames;
                    break;
            }
        }
    }
}
