using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCreator
{
   

    public class Character
    {
        public List<string> skills = new List<string>();
        public List<string> equipment = new List<string>();
        public List<string> languages = new List<string>();
        public List<string> proficiencies = new List<string>();
        public List<string> traits = new List<string>();
        public List<weapons> weapon = new List<weapons>();
        public List<string> clickedWeapons = new List<string>();


        public string  name, race, type, background;

        public int strength, dexterity, constitution, intelligence, wisdom, charisma;

        public  int armorClass, speed, hitPoints;

        public  int strMod, dexMod, constMod, intMod, wisMod, chaMod = 0;

        public  int strST, dexST, constST, intST, wisST, chaST;

        public  int proficiency = 2;

        public  string hitDie;

        public Character()
        { }

        public Character (string _name, string _race, string _type, string _background, int _strST, int _dexST, int _constST, int _intST, int _wisST, int _chaST,int _proficiency, int _strength, int _dexterity, int _constitution, int _inteligence, int _wisdom, int _charisma, int _armorClass, int _speed, int _hitPoints, string _hitDie, int _strMod, int _dexMod, int _constMod, int _intMod, int _wisMod, int _chaMod, List<string> _skills, List<string> _languages, List<string> _proficiencies, List<string> _equipment, List<string> _traits, List<weapons> _weapon)
        {
            name = _name;
            race = _race;
            type = _type;
            background = _background;
            strength = _strength;
            dexterity = _dexterity;
            constitution = _constitution;
            intelligence = _inteligence;
            wisdom = _wisdom;
            charisma = _charisma;
            armorClass = _armorClass;
            speed = _speed;
            hitPoints = _hitPoints;
            hitDie = _hitDie;
            skills = _skills;
            equipment = _equipment;
            languages = _languages;
            proficiencies = _proficiencies;
            traits = _traits;
            weapon = _weapon;
            strMod = _strMod;
            dexMod = _dexMod;
            constMod = _constMod;
            intMod = _intMod;
            wisMod = _wisMod;
            chaMod = _chaMod;
            proficiency = _proficiency;
            strST = _strST;
            dexST = _dexST;
            constST = _constST;
            intST = _intST;
            wisST = _wisST;
            chaST = _chaST;
        }



    }
}
