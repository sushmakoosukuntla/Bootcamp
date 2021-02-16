using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWPSoundBoard.Model;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPSoundBoard
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        /*We created only sounds and menuItems as properties because, in UI in row1, left side we need menuItems and in right
        side we need sounds.*/
        /**we cannot create them as variables, because if we create them as varibles in methods, we cannot access or bind them 
        through xaml*/
        /*we used private access modifier, Xaml can use this properties even it is private, because Main page is the
         * derived class and Page(xaml) is the base class*/
        private ObservableCollection<Sound> sounds;
        private List<MenuItem> menuItems;
        public MainPage()
        {
            this.InitializeComponent();            
            //sounds = new ObservableCollection<Sound>();
            //here variable sounds consists of list of all sounds(8 sounds)
            sounds = SoundManager.GetAllSounds(); //We use this sounds variable in xaml to bind the code

            //creating new list of type MenuItem which has IconFile and Category as properties
            menuItems = new List<MenuItem>(); //We use this menuItems variable in xaml to bind the code
            //SoundCategory is an enum which we have creted in Sound class.
            menuItems.Add(new MenuItem { IconFile = "Assets/Icons/animals.png", Category = SoundCategory.Animals });
            menuItems.Add(new MenuItem { IconFile = "Assets/Icons/cartoon.png", Category = SoundCategory.Cartoons });
            menuItems.Add(new MenuItem { IconFile = "Assets/Icons/taunt.png", Category = SoundCategory.Taunts });
            menuItems.Add(new MenuItem { IconFile = "Assets/Icons/warning.png", Category = SoundCategory.Warnings });
        }

        //Below are the method names created via Xaml
        private void HamburgerButton_Click(object sender, RoutedEventArgs e) //line 19 in xaml
        {
            //MySplitView is the name given for Grid.Row="1" in Xaml in line 23  
            // If the pane is open it is true, we used ! so it becomes false and the pane gets closed
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void MenuItemsListView_ItemClick(object sender, ItemClickEventArgs e) //line 31 in xaml
        {
            //When we click a category in MEnuItems the clicked object will get stored in variable e.
            //We have many properties for e of type ItemClickEventArgs but we are only using ClickedItem
            /*e.clickedItem will return the object, so we are type casting the object to the type MEnuItem 
            and storing it in menuItem variable*/
            var menuItem = (MenuItem)e.ClickedItem;
            //CategoryText is the name given for TextBlock in the remaining grid(like All Sounds) in Xaml in line 49
            //category is an enum in sound class, so we are converting it to string
            CategoryText.Text = menuItem.Category.ToString();
            //public static void GetSoundsByCategory(ObservableCollection<Sound> sounds, SoundCategory category)
            SoundManager.GetSoundsByCategory(sounds, menuItem.Category);
            BackButton.Visibility = Visibility.Visible;

        }

        private void BackButton_Click(object sender, RoutedEventArgs e) //line 21 in xaml
        {
            sounds = SoundManager.GetAllSounds();
            //CategoryText is the name given for TextBlock in the remaining grid(like All Sounds) in Xaml in line 49
            CategoryText.Text = "All Sounds";
            //If there is no item selected in MenuList, then the back button should get collapsed.It shouldnt be visible.
            MenuItemsListView.SelectedItem = null;
            BackButton.Visibility = Visibility.Collapsed;
        }

        private void SoundGridView_ItemClick(object sender, ItemClickEventArgs e) //line 55 in xaml
        {
            var sound = (Sound)e.ClickedItem;
            MyMediaElement.Source = new Uri(BaseUri, sound.AudioFile);
        }
    }
}
