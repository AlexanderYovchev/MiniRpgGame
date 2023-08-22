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
    /// Interaction logic for CharacterUC.xaml
    /// </summary>
    public partial class CharacterUC : UserControl
    {
        public ICharacterClasses CurrentCharacter { get; set; }
        public IWeapon CurrentWeapon { get; set; }

        public IMonster CurrentMonster { get; set; }

        public ImageBrush CurrentImage { get; set; }
        public CharacterUC(ICharacterClasses currentCharacter, IWeapon currentWeapon, IMonster currentMonster, ImageBrush currentImage)
        {
            InitializeComponent();

            this.CurrentCharacter = currentCharacter;
            this.CurrentWeapon = currentWeapon;
            this.CurrentMonster = currentMonster;
            this.CurrentImage = currentImage;
            this.CurrentImage.ImageSource = currentImage.ImageSource;

            BackgroundImage.ImageSource = CurrentImage.ImageSource;
            CharacterInfoDisplay();
        }

        private void CharacterInfoDisplay()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Character Info:");
            sb.AppendLine($"Name: {CurrentCharacter.Name}");
            sb.AppendLine($"Class Type: {CurrentCharacter.GetType().Name}");
            sb.AppendLine($"Health: {CurrentCharacter.Health}");
            sb.AppendLine($"Level: {CurrentCharacter.Level}");
            sb.AppendLine($"Xp: {CurrentCharacter.Xp}");
            sb.AppendLine();
            sb.AppendLine();
            sb.AppendLine($"Weapon: {CurrentCharacter.Weapon.Name}");
            sb.AppendLine($"Weapon dmg: {CurrentCharacter.Weapon.MinDmg} - {CurrentCharacter.Weapon.MaxDmg}");
            sb.AppendLine($"Weapon Info: {CurrentCharacter.Weapon.WeaponInfo()}");

            CharacterInfoPanel.Text = sb.ToString();

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;

            if (mainWindow != null)
            {
                mainWindow.Content = new MainMenuUC(CurrentCharacter, CurrentWeapon, CurrentMonster, CurrentImage);
                
            }
        }
    }
}
