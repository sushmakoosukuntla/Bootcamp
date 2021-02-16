using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPSoundBoard.Model
{
    public static class SoundManager
    {
        /*An ObservableCollection is a dynamic collection of objects of a given type. 
         * Objects can be added, removed or be updated with an automatic notification of actions. 
         * When an object is added to or removed from an observable collection, the UI is automatically updated.*/
        public static ObservableCollection<Sound> GetAllSounds()
        {
            //Empty list of type Sound will get created in the line below and the list name is sounds.
            var sounds = new ObservableCollection<Sound>();
            var allSounds = GetSounds();
            sounds.Clear(); 
            foreach(var sound in allSounds)
            {
                sounds.Add(sound);
            }
            return sounds;
            //The above foreach can write like below(shortcut)
            //allSounds.ForEach(sound => sounds.Add(sound));
        }

        public static void GetSoundsByCategory(ObservableCollection<Sound> sounds, SoundCategory category)
        {
            var allSounds = GetSounds();
            var filteredSounds = allSounds.Where(sound => sound.Category == category).ToList();
            sounds.Clear();
            filteredSounds.ForEach(sound => sounds.Add(sound));
        }
        private static List<Sound> GetSounds()
        {
            var sounds = new List<Sound>();
            sounds.Add(new Sound("Cow", SoundCategory.Animals));
            sounds.Add(new Sound("Cat", SoundCategory.Animals));

            sounds.Add(new Sound("Gun", SoundCategory.Cartoons));
            sounds.Add(new Sound("Spring", SoundCategory.Cartoons));

            sounds.Add(new Sound("Clock", SoundCategory.Taunts));
            sounds.Add(new Sound("LOL", SoundCategory.Taunts));

            sounds.Add(new Sound("Ship", SoundCategory.Warnings));
            sounds.Add(new Sound("Siren", SoundCategory.Warnings));

            return sounds;
        }
    }
}
