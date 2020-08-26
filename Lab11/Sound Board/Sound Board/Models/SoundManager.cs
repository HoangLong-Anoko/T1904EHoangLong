using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sound_Board.Models
{
    class SoundManager
    {
        private static List<Sound> GetSounds()
        {
            var Sounds = new List<Sound>();
            Sounds.Add(new Sound("Cow", SoundCategory.Animals));
            Sounds.Add(new Sound("Cat", SoundCategory.Animals));

            Sounds.Add(new Sound("Gun", SoundCategory.Cartoons));
            Sounds.Add(new Sound("Spring", SoundCategory.Cartoons));

            Sounds.Add(new Sound("Clock", SoundCategory.Taunts));
            Sounds.Add(new Sound("LOL", SoundCategory.Taunts));

            Sounds.Add(new Sound("Ship", SoundCategory.Warnings));
            Sounds.Add(new Sound("Siren", SoundCategory.Warnings));

            return Sounds;
        }

        public static void GetAllSounds(ObservableCollection<Sound> sounds)
        {
            var allsounds = GetSounds();
            sounds.Clear();
            allsounds.ForEach(p => sounds.Add(p));
        }

        public static void GetSoundsByCategory(ObservableCollection<Sound> sounds, SoundCategory category)
        {
            var allsounds = GetSounds();
            var filteredSounds = allsounds.Where(p => p.Category == category).ToList();
            sounds.Clear();
            filteredSounds.ForEach(p => sounds.Add(p));
        }

        public static void GetSoundByName(ObservableCollection<Sound> sounds, string name)
        {
            var allsounds = GetSounds();
            var filteredSounds = allsounds.Where(p => p.Name == name).ToList();
            sounds.Clear();
            filteredSounds.ForEach(p => sounds.Add(p));
        }
    }
}
