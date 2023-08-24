using MiniRpgGame.CharacterClasses.CharacterClassInterface;
using MiniRpgGame.Monsters;
using MiniRpgGame.Weapons;
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

namespace MiniRpgGame.UserControls
{
    /// <summary>
    /// Interaction logic for RegionsUC.xaml
    /// </summary>
    public partial class RegionsUC : UserControl
    {
        public ICharacterClasses CurrentCharacter { get; set; }
        public IWeapon CurrentWeapon { get; set; }
        public IMonster CurrentMonster { get; set; }

        public ImageBrush CurrentImage { get; set; }
        public RegionsUC(ICharacterClasses currentCharacter, IWeapon currentWeapon, IMonster currentMonster, ImageBrush currentImage)
        {
            InitializeComponent();

            this.CurrentCharacter = currentCharacter;
            this.CurrentWeapon = currentWeapon;
            this.CurrentMonster = currentMonster;
            this.CurrentImage = currentImage;
            this.CurrentImage.ImageSource = currentImage.ImageSource;

            BackgroundImage.ImageSource = CurrentImage.ImageSource;

            
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;

            if (mainWindow != null)
            {
                mainWindow.Content = new MainMenuUC(CurrentCharacter, CurrentWeapon, CurrentMonster, CurrentImage);
            }
        }

        private void ForestButton_Click(object sender, RoutedEventArgs e)
        {
            this.CurrentImage = new ImageBrush();
            this.CurrentImage.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/MiniRpgGame;component/images/forestImage.png"));
            CurrentMonster = new ForestMonstersAbstract();

            Content = new MainMenuUC(CurrentCharacter, CurrentWeapon, CurrentMonster, CurrentImage);
        }

        private void SwampsButton_Click(object sender, RoutedEventArgs e)
        {
            this.CurrentImage = new ImageBrush();
            this.CurrentImage.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/MiniRpgGame;component/images/swampsImage.png"));
            CurrentMonster = new SwampsMonsterAbstract();

            Content = new MainMenuUC(CurrentCharacter, CurrentWeapon, CurrentMonster, CurrentImage);
        }

        private void MountainsButton_Click(object sender, RoutedEventArgs e)
        {
            this.CurrentImage = new ImageBrush();
            this.CurrentImage.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/MiniRpgGame;component/images/mountainImage.png"));
            CurrentMonster = new MountainMonstersAbstract();

            Content = new MainMenuUC(CurrentCharacter, CurrentWeapon, CurrentMonster, CurrentImage);
        }

        private void SeaButton_Click(object sender, RoutedEventArgs e)
        {
            this.CurrentImage = new ImageBrush();
            this.CurrentImage.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/MiniRpgGame;component/images/seaImage.png"));
            CurrentMonster = new SeaMonstersAbstract();

            Content = new MainMenuUC(CurrentCharacter, CurrentWeapon, CurrentMonster, CurrentImage);
        }

        private void UnderworldButton_Click(object sender, RoutedEventArgs e)
        {
            this.CurrentImage = new ImageBrush();
            this.CurrentImage.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/MiniRpgGame;component/images/underworldImage.png"));
            CurrentMonster = new UnderworldMonstersAbstract();

            Content = new MainMenuUC(CurrentCharacter, CurrentWeapon, CurrentMonster, CurrentImage);
        }
    }
}
