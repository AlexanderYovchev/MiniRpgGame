using MiniRpgGame.CharacterClasses.CharacterClassInterface;
using MiniRpgGame.Monsters;
using MiniRpgGame.Monsters.Forest_Monsters;
using MiniRpgGame.Monsters.Mountain_Monsters;
using MiniRpgGame.Monsters.Swamp_Monsters;
using MiniRpgGame.Weapons;
using MiniRpgGame.Weapons.WarriorWeapon;
using MiniRpgGame.WeaponsLists;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MiniRpgGame.UserControls
{
    /// <summary>
    /// Interaction logic for MainMenuUC.xaml
    /// </summary>
    public partial class MainMenuUC : UserControl
    {
        private Type originalMonsterType;

        public Random RandomEncounter { get; set; } = new Random();

        private BackgroundWorker worker;
        public ICharacterClasses CurrentCharacter { get; set; }
        public IWeapon CurrentWeapon { get; set; }

        public WeaponsRepository ShopRepository { get; set; }
        public IMonster CurrentMonster { get; set; }

        public ImageBrush CurrentImage { get; set; }


        public MainMenuUC(ICharacterClasses currentCharacter, IWeapon currentWeapon, IMonster currentMonster, ImageBrush currentImage)
        {
            InitializeComponent();

            TransferStats(currentCharacter, currentWeapon, currentMonster, currentImage);

            SavedStats();

            ExpectedBackgroundImage();

            ShopRepository = new WarriorWeaponsRepository();
            ShopRepository.PopulateList();
            CurrentWeapon = ShopRepository.FindWeapon("Katana");
            CurrentCharacter.Weapon = CurrentWeapon;

            if (CurrentMonster != null)
            {
                MonsterHealthBar.Value = CurrentMonster.Health;
            }

            if (MonsterHealthBar.Value > 0)
            {
                RegionsButton.IsEnabled = false;
            }
            else if (MonsterHealthBar.Value == 0)
            {
                RegionsButton.IsEnabled = true;
            }

            CharacterClassPickedImage();
            

            CharacterAttackTextBlock.Text = $"Damage: {CurrentCharacter.Weapon.MinDmg} - {CurrentCharacter.Weapon.MaxDmg}";
        }

        private void CharacterClassPickedImage()
        {
            string characterTypeName = CurrentCharacter.GetType().Name;

            WarriorImage.Visibility = characterTypeName == "Warrior" ? Visibility.Visible : Visibility.Collapsed;
            MageImage.Visibility = characterTypeName == "Mage" ? Visibility.Visible : Visibility.Collapsed;
            ArcherImage.Visibility = characterTypeName == "Archer" ? Visibility.Visible: Visibility.Collapsed;

            CharacterClassTypeTextBox.Text = characterTypeName;



        }

        private void CharacterInfoButton_Click(object sender, RoutedEventArgs e)
        {
            Content = new CharacterUC(CurrentCharacter, CurrentWeapon, CurrentMonster, CurrentImage);
        }

        private void RoamButton_Click(object sender, RoutedEventArgs e)
        {
            originalMonsterType = CurrentMonster.GetType();
            int encounterValue = RandomEncounter.Next(1, 1000);
            if (CurrentMonster.GetType().Name == "ForestMonstersAbstract")
            {
                
                if (encounterValue > 500 && encounterValue <= 700)
                {
                    CurrentMonster = new ForestRat();
                    
                    MonsterFoundLogic();
                }
                else if (encounterValue > 700 && encounterValue <= 850)
                {
                    CurrentMonster = new Rabbit();
                    
                    MonsterFoundLogic();
                }
                else if (encounterValue > 850 && encounterValue <= 950)
                {
                    CurrentMonster = new Squirrel();
                    
                    MonsterFoundLogic();

                }
                else if (encounterValue > 950)
                {
                    CurrentMonster = new Deer();
                    
                    MonsterFoundLogic();

                }

                else
                {
                    RoamButton.IsEnabled = true;
                }

                
            }

            else if (CurrentMonster.GetType().Name == "SwampsMonsterAbstract")
            {
                if (encounterValue > 300 && encounterValue <= 600)
                {
                    CurrentMonster = new Mosquito();
                    MonsterFoundLogic();
                }
                else if (encounterValue > 600 && encounterValue <= 800)
                {
                    CurrentMonster = new Frog();
                    MonsterFoundLogic();
                }
                else if (encounterValue > 800 && encounterValue <= 900)
                {
                    CurrentMonster = new Turtle();
                    MonsterFoundLogic();

                }
                else if (encounterValue > 900 && encounterValue <= 980)
                {
                    CurrentMonster = new Alligator();
                    MonsterFoundLogic();

                }
                else if (encounterValue > 980)
                {
                    CurrentMonster = new MudGhoul();
                    MonsterFoundLogic();
                }

                else
                {
                    RoamButton.IsEnabled = true;
                }
            }

            else if (CurrentMonster.GetType().Name == "MountainMonstersAbstract")
            {
                if (encounterValue > 300 && encounterValue <= 600)
                {
                    CurrentMonster = new MountainGoat();
                    MonsterFoundLogic();
                }
                else if (encounterValue > 600 && encounterValue <= 800)
                {
                    CurrentMonster = new MountainLion();
                    MonsterFoundLogic();
                }
                else if (encounterValue > 800 && encounterValue <= 900)
                {
                    CurrentMonster = new MountainEagle();
                    MonsterFoundLogic();

                }
                else if (encounterValue > 900 && encounterValue <= 990)
                {
                    CurrentMonster = new RockGolem();
                    MonsterFoundLogic();

                }
                else if (encounterValue > 990)
                {
                    CurrentMonster = new MountainDragon();
                    MonsterFoundLogic();
                }

                else
                {
                    RoamButton.IsEnabled = true;
                }
            }
        }

        private void CharacterAttackButton_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentMonster.Health <= 0)
            {
                MonsterImage.Visibility = Visibility.Collapsed;
                CharacterHealthBar.Value = CharacterHealthBar.Maximum;
                CurrentCharacter.LevelUp();
                CharacterHealthBar.Maximum = CurrentCharacter.Health;
                CurrentCharacter.Health = (int)CharacterHealthBar.Maximum;
                CurrentMonster = (IMonster)Activator.CreateInstance(originalMonsterType);
                RoamButton.IsEnabled = true;
                CharacterAttackButton.IsEnabled = false;

            }
            else
            {
                CharacterInfoButton.IsEnabled = false;
                RegionsButton.IsEnabled = false;
                ShopButton.IsEnabled = false;
                RoamButton.IsEnabled = false;
                CharacterAttackButton.IsEnabled = false;
                int damage = CurrentCharacter.Weapon.AttackInitialize();
                CurrentMonster.Health -= damage;

                MonsterHealthBar.Value = CurrentMonster.Health;

                ShowFloatingDamage(MonsterFloatDmg, damage);

                BackgroundWorkerInitialization();

                
            }
            

        }

        private void BackgroundWorkerInitialization()
        {
            worker = new BackgroundWorker();
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
            worker.WorkerReportsProgress = true;
            worker.DoWork += worker_DoWork;
            worker.ProgressChanged += worker_ProgressChanged;
            worker.RunWorkerAsync();
        }

        private void worker_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            MonsterAttackProgressBar.Value = e.ProgressPercentage;

        }

        private void worker_DoWork(object? sender, DoWorkEventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(10);
                worker.ReportProgress(i);
            }
        }

        private void worker_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
        {
            int damage = CurrentMonster.MonsterAttack();
            CurrentCharacter.Health -= damage;

            CharacterHealthBar.Value = CurrentCharacter.Health;

            ShowFloatingDamage(CharacterFloatDmg, damage);

            MonsterAttackProgressBar.Value = 0;

            CharacterInfoButton.IsEnabled = true;
            RegionsButton.IsEnabled = true;
            ShopButton.IsEnabled = true;
            RoamButton.IsEnabled = true;
            CharacterAttackButton.IsEnabled = true;
        }

        private void RegionsButton_Click(object sender, RoutedEventArgs e)
        {
            Content = new RegionsUC(CurrentCharacter, CurrentWeapon, CurrentMonster, CurrentImage);
        }

        public void ExpectedBackgroundImage()
        {
            ImageBrush expectedImage = BackgroundImage;

            expectedImage.ImageSource = BackgroundImage.ImageSource;

            
            if (expectedImage.ImageSource.ToString() == new BitmapImage(new Uri("pack://application:,,,/MiniRpgGame;component/images/backgroundpic.png")).ToString())
            {
                RoamButton.IsEnabled = false;
                CharacterAttackButton.IsEnabled = false;
            }
            else
            {
                originalMonsterType = CurrentMonster.GetType().BaseType;
            }
        }

        public void TransferStats(ICharacterClasses currentCharacter, IWeapon currentWeapon, IMonster currentMonster, ImageBrush currentImage)
        {
            this.CurrentImage = currentImage;
            this.CurrentImage.ImageSource = currentImage.ImageSource;
            BackgroundImage.ImageSource = this.CurrentImage.ImageSource;


            this.CurrentCharacter = currentCharacter;
            this.CurrentWeapon = currentWeapon;
            this.CurrentMonster = currentMonster;
            CharacterHealthBar.Maximum = CurrentCharacter.HealthCap;
            CharacterHealthBar.Value = CurrentCharacter.Health;
            

            if (CurrentMonster != null)
            {
                MonsterImage.Source = CurrentMonster.MonsterImage;
            }
        }

        public async void ShowFloatingDamage(TextBlock targetTextblock, int damage)
        {
            targetTextblock.Text = $"-{damage.ToString()}";
            
            targetTextblock.Visibility = Visibility.Visible;

            DoubleAnimation popAnimation = new DoubleAnimation
            {
                From = 0,
                To = -30,  
                Duration = TimeSpan.FromSeconds(0.5)
            };

            DoubleAnimation fadeAnimation = new DoubleAnimation
            {
                From = 1.0,
                To = 0.0,
                Duration = TimeSpan.FromSeconds(2.0)
            };

            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(popAnimation);
            storyboard.Children.Add(fadeAnimation);
            Storyboard.SetTarget(popAnimation, targetTextblock);
            Storyboard.SetTarget(fadeAnimation, targetTextblock);
            Storyboard.SetTargetProperty(popAnimation, new PropertyPath("(UIElement.RenderTransform).(TranslateTransform.Y)"));
            Storyboard.SetTargetProperty(fadeAnimation, new PropertyPath(UIElement.OpacityProperty));

            TranslateTransform translateTransform = new TranslateTransform();
            targetTextblock.RenderTransform = translateTransform;

            storyboard.Begin();

            await Task.Delay(1500 + (int)fadeAnimation.Duration.TimeSpan.TotalMilliseconds);

            targetTextblock.Visibility = Visibility.Collapsed;
        } 

        public void SavedStats()
        {
            if (CurrentMonster != null)
            {
                CharacterHealthBar.Value = CurrentCharacter.Health;
                MonsterHealthBar.Value = CurrentMonster.Health;
                MonsterHealthBar.Maximum = CurrentMonster.HealthCap;
            }
            

            
        }

        public void MonsterFoundLogic()
        {
            CharacterAttackButton.IsEnabled = true;
            MonsterImage.Source = CurrentMonster.MonsterImage;
            MonsterHealthBar.Maximum = CurrentMonster.HealthCap;
            MonsterHealthBar.Value = MonsterHealthBar.Maximum;
            CurrentMonster.Health = (int)MonsterHealthBar.Value;
            RoamButton.IsEnabled = false;
            MonsterImage.Visibility = Visibility.Visible;
        }
    }
}
