using MiniRpgGame.CharacterClasses.CharacterClassInterface;
using MiniRpgGame.Monsters;
using MiniRpgGame.Weapons;
using MiniRpgGame.Weapons.WarriorWeapon;
using MiniRpgGame.WeaponsLists;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    
    public partial class ShopUC : UserControl
    {
        public ICharacterClasses CurrentCharacter { get; set; }
        public IWeapon CurrentWeapon { get; set; }

        public IMonster CurrentMonster { get; set; }

        public ImageBrush CurrentImage { get; set; }

        public WeaponsRepository ShopRepository { get; set; }

        public ShopUC(ICharacterClasses currentCharacter, IWeapon currentWeapon, IMonster currentMonster, ImageBrush currentImage)
        {
            InitializeComponent();
            this.CurrentCharacter = currentCharacter;
            this.CurrentWeapon = currentWeapon;
            this.CurrentMonster = currentMonster;
            this.CurrentImage = currentImage;
            this.CurrentImage.ImageSource = currentImage.ImageSource;
            
            
            

            if (CurrentCharacter.GetType().Name == "Warrior")
            {
                ShopRepository = new WarriorWeaponsRepository();
            }
            else if (CurrentCharacter.GetType().Name == "Archer")
            {
                ShopRepository = new ArcherWeaponsRepository();
            }
            else if (CurrentCharacter.GetType().Name == "Mage")
            {
                ShopRepository = new MageWeaponsRepository();
            }
            
            ShopRepository.PopulateList();
            var currentRepos = ShopRepository.WeaponsList;
            foreach (var weapon in currentRepos)
            {
                ShopBox.Items.Add(weapon);
                
            }

            ShopBox.DisplayMemberPath = "Name";

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
