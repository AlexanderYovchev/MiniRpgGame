using MiniRpgGame.CharacterClasses;
using MiniRpgGame.CharacterClasses.CharacterClassInterface;
using MiniRpgGame.Monsters;
using MiniRpgGame.UserControls;
using MiniRpgGame.Weapons;
using MiniRpgGame.Weapons.ArcherWeapon.ArcherStarterWeapons;
using MiniRpgGame.Weapons.MageWeapon.MageStarterWeapons;
using MiniRpgGame.Weapons.WarriorWeapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace MiniRpgGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public IWeapon CurrentWeapon { get; set; }
        public ICharacterClasses CurrentCharacter { get; set; }
        public IEnumerable<Type>? WeaponsList { get; set; }

        public IMonster Monster { get; set; }

        public ImageBrush CurrentImage { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            this.CurrentImage = new ImageBrush();
            this.CurrentImage.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/MiniRpgGame;component/images/backgroundpic.png"));
            BackgroundImage.ImageSource = CurrentImage.ImageSource;
            var pickedCharacterClass = Assembly.GetExecutingAssembly().GetTypes().Where(type => type.IsSubclassOf(typeof(CharacterAbstractClass)));

            foreach (var characterClass in pickedCharacterClass)
            {
                ClassDropDownMenu.Items.Add(characterClass.Name.ToString());
            }

            ClassDropDownMenu.SelectionChanged += ClassDropDownMenu_SelectionChanged;
        }

        private void BeginButton_Click(object sender, RoutedEventArgs e)
        {
            if (ClassDropDownMenu.SelectedItem != null && WeaponClassDropDownMenu.SelectedItem != null)
            {
                string selectedClass = ClassDropDownMenu.SelectedItem.ToString();
                string selectedWeapon = WeaponClassDropDownMenu.SelectedItem.ToString();

                Type characterType = Type.GetType($"MiniRpgGame.CharacterClasses.{selectedClass}");
                Type weaponType = WeaponsList.First(t => t.Name == selectedWeapon);


                if (characterType != null && typeof(ICharacterClasses).IsAssignableFrom(characterType) &&
                    weaponType != null && typeof(IWeapon).IsAssignableFrom(weaponType))
                {
                    CurrentCharacter = (ICharacterClasses)Activator.CreateInstance(characterType);
                    CurrentWeapon = (IWeapon)Activator.CreateInstance(weaponType);

                    CurrentCharacter.Weapon = CurrentWeapon;

                    CurrentCharacter.Name = CharacterNameField.Text;


                    ErrorMsgBlock.Text = $"{CurrentCharacter.Name}\n{CurrentCharacter.GetType().Name}\n{CurrentWeapon.Name}";


                    var newContent = new MainMenuUC(CurrentCharacter, CurrentWeapon, Monster, CurrentImage);
                    Content = newContent;

                    
                }
            }
            else
            {
                ErrorMsgBlock.Text = "Please fill all the blanks!";
            }
        }

        private void ClassDropDownMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            WeaponsList = null;

            string selectedClass = ClassDropDownMenu.SelectedItem as string;

            if (selectedClass == "Warrior")
            {
                WeaponsList = Assembly.GetExecutingAssembly().GetTypes().Where(type => type.IsSubclassOf(typeof(WarriorStartedWeapon)));
            }
            else if (selectedClass == "Archer")
            {
                WeaponsList = Assembly.GetExecutingAssembly().GetTypes().Where(type => type.IsSubclassOf(typeof(ArcherStarterWeaponClass)));
            }
            else if (selectedClass == "Mage")
            {
                WeaponsList = Assembly.GetExecutingAssembly().GetTypes().Where(type => type.IsSubclassOf(typeof(MageStartedWeaponClass)));
            }

            WeaponClassDropDownMenu.Items.Clear();

            foreach (var weapon in WeaponsList)
            {
                WeaponClassDropDownMenu.Items.Add(weapon.Name.ToString());
            }
        }
    }
}
