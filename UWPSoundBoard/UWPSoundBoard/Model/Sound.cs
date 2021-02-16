using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPSoundBoard.Model
{
    //enum has fixed values. so, in sound board we have fixed categories, so we created enum with variable SoundCategory
    public enum SoundCategory
    {
        Animals,
        Cartoons,
        Taunts,
        Warnings
    }
    //we are mainly working on sound board app. So, for sound we have some properties below
    public class Sound
    {
        public string Name { get; set; }
        public SoundCategory Category { get; set; }
        public string AudioFile { get; set; }
        public string ImageFile { get; set; }

        //Below is the constructor, when we create a sound object, we give name category which are the parameters for constructor
        //we give Audio and Image file paths in the sound object, which we used in Media
        public Sound(string name, SoundCategory category)
        {
            Name = name;
            Category = category;
            AudioFile = $"/Assets/Audio/{Category}/{Name}.Wav";
            ImageFile = $"/Assets/Images/{Category}/{Name}.png";
        }
    }
} 
