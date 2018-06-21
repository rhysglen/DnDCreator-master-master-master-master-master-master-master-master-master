using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace DnDCreator.Screens
{
    public partial class finalScreen : UserControl
    {
        public finalScreen()
        {
            InitializeComponent();

            // races
            #region race ifs

            

            if (Form1.newCharacter.race == "Half-Elf")
            {
                Form1.newCharacter.charisma = Form1.newCharacter.charisma + 2;
                Form1.newCharacter.speed = 30;
                Form1.newCharacter.traits.Add("Darkvision");
                Form1.newCharacter.traits.Add("Fey Ancestry");
                Form1.newCharacter.proficiencies.Add("Skill Versatility");

                Form1.newCharacter.languages.Add("Common");
                Form1.newCharacter.languages.Add("Elvish");
                Form1.newCharacter.languages.Add("One Extra");

            }
            else if (Form1.newCharacter.race == "Half-Orc")
            {
                Form1.newCharacter.strength = Form1.newCharacter.strength + 2;
                Form1.newCharacter.constitution = Form1.newCharacter.constitution + 1;
                Form1.newCharacter.speed = 30;
                Form1.newCharacter.traits.Add("Darkvision");
                Form1.newCharacter.traits.Add("Menacing");
                Form1.newCharacter.traits.Add("Relentless Endurance");
                Form1.newCharacter.traits.Add("Savage Attacks");
                Form1.newCharacter.languages.Add("Common");
                Form1.newCharacter.languages.Add("Orc");
                Form1.newCharacter.skills.Add("Intimidation");

            }
            else if (Form1.newCharacter.race == "High Elf")
            {
                Form1.newCharacter.dexterity = Form1.newCharacter.dexterity + 2;
                Form1.newCharacter.intelligence = Form1.newCharacter.intelligence + 1;
                Form1.newCharacter.traits.Add("Elf Weapon Training");
                Form1.newCharacter.proficiencies.Add("Longsword");
                Form1.newCharacter.proficiencies.Add("Shortsword");
                Form1.newCharacter.proficiencies.Add("Shortbow");
                Form1.newCharacter.proficiencies.Add("Longbow");
                Form1.newCharacter.traits.Add("Extra Cantrip");
                Form1.newCharacter.speed = 30;
                Form1.newCharacter.traits.Add("Darkvision");
                Form1.newCharacter.traits.Add("Keen Senses");
                Form1.newCharacter.traits.Add("Fey Ancestry");
                Form1.newCharacter.traits.Add("Trance");
                Form1.newCharacter.languages.Add("Common");
                Form1.newCharacter.languages.Add("Elvish");
                Form1.newCharacter.languages.Add("One Extra");
                Form1.newCharacter.skills.Add("Perception");
            }
            else if (Form1.newCharacter.race == "Wood Elf")
            {
                Form1.newCharacter.dexterity = Form1.newCharacter.dexterity + 2;
                Form1.newCharacter.wisdom = Form1.newCharacter.wisdom + 1;
                Form1.newCharacter.proficiencies.Add("Elf Weapon Training");
                Form1.newCharacter.proficiencies.Add("Longsword");
                Form1.newCharacter.proficiencies.Add("Shortsword");
                Form1.newCharacter.proficiencies.Add("Shortbow");
                Form1.newCharacter.proficiencies.Add("Longbow");
                Form1.newCharacter.traits.Add("Fleet Footed");
                Form1.newCharacter.traits.Add("Mask of the Wild");
                Form1.newCharacter.speed = 35;
                Form1.newCharacter.traits.Add("Darkvision");
                Form1.newCharacter.traits.Add("Keen Senses");
                Form1.newCharacter.traits.Add("Fey Ancestry");
                Form1.newCharacter.traits.Add("Trance");
                Form1.newCharacter.languages.Add("Common");
                Form1.newCharacter.languages.Add("Elvish");
                Form1.newCharacter.skills.Add("Perception");
            }
            else if (Form1.newCharacter.race == "Dark Elf")
            {
                Form1.newCharacter.dexterity = Form1.newCharacter.dexterity + 2;
                Form1.newCharacter.charisma = Form1.newCharacter.charisma + 1;
                Form1.newCharacter.traits.Add("Drow Weapon Training");
                Form1.newCharacter.proficiencies.Add("Rapier");
                Form1.newCharacter.proficiencies.Add("Shortsword");
                Form1.newCharacter.proficiencies.Add("Hand Crossbow");
                Form1.newCharacter.traits.Add("Drow Magic");
                Form1.newCharacter.traits.Add("Sunlight Sensitivity");
                Form1.newCharacter.speed = 35;
                Form1.newCharacter.traits.Add("Superior Darkvision");
                Form1.newCharacter.traits.Add("Keen Senses");
                Form1.newCharacter.skills.Add("Perception");
                Form1.newCharacter.traits.Add("Fey Ancestry");
                Form1.newCharacter.traits.Add("Trance");
                Form1.newCharacter.languages.Add("Common");
                Form1.newCharacter.languages.Add("Elvish");
            }
            else if (Form1.newCharacter.race == "Hill Dwarf")
            {
                Form1.newCharacter.constitution = Form1.newCharacter.constitution + 2;
                Form1.newCharacter.wisdom = Form1.newCharacter.wisdom + 1;
                Form1.newCharacter.traits.Add("Dwarven Toughness");
                Form1.newCharacter.speed = 25;
                Form1.newCharacter.traits.Add("Darkvision");
                Form1.newCharacter.traits.Add("Dwarven Resilience");
                Form1.newCharacter.traits.Add("Dwarven Combat Training");
                Form1.newCharacter.proficiencies.Add("Battleaxe");
                Form1.newCharacter.proficiencies.Add("Handaxe");
                Form1.newCharacter.proficiencies.Add("Light Hammer");
                Form1.newCharacter.proficiencies.Add("Warhammer");
                Form1.newCharacter.traits.Add("Stonecutting");
                Form1.newCharacter.traits.Add("Artisan Tool Form1.newCharacter.proficiency");
                Form1.newCharacter.languages.Add("Common");
                Form1.newCharacter.languages.Add("Dwarvish");
            }
            else if (Form1.newCharacter.race == "Mountain Dwarf")
            {
                Form1.newCharacter.constitution = Form1.newCharacter.constitution + 2;
                Form1.newCharacter.strength = Form1.newCharacter.strength + 2;
                Form1.newCharacter.traits.Add("Dwarven Armor Training");
                Form1.newCharacter.proficiencies.Add("Medium Armor");
                Form1.newCharacter.proficiencies.Add("Light Armor");
                Form1.newCharacter.speed = 25;
                Form1.newCharacter.traits.Add("Darkvision");
                Form1.newCharacter.traits.Add("Dwarven Resilience");
                Form1.newCharacter.traits.Add("Dwarven Combat Training");
                Form1.newCharacter.proficiencies.Add("Battleaxe");
                Form1.newCharacter.proficiencies.Add("Handaxe");
                Form1.newCharacter.proficiencies.Add("Light Hammer");
                Form1.newCharacter.proficiencies.Add("Warhammer");
                Form1.newCharacter.traits.Add("Stonecutting");
                Form1.newCharacter.traits.Add("Artisan Tool Form1.newCharacter.proficiency");
                Form1.newCharacter.languages.Add("Common");
                Form1.newCharacter.languages.Add("Dwarvish");
            }
            else if (Form1.newCharacter.race == "Human")
            {
                Form1.newCharacter.strength = Form1.newCharacter.strength + 1;
                Form1.newCharacter.dexterity = Form1.newCharacter.dexterity + 1;
                Form1.newCharacter.constitution = Form1.newCharacter.constitution + 1;
                Form1.newCharacter.intelligence = Form1.newCharacter.intelligence + 1;
                Form1.newCharacter.wisdom = Form1.newCharacter.wisdom + 1;
                Form1.newCharacter.charisma = Form1.newCharacter.charisma + 1;
                Form1.newCharacter.speed = 30;
                Form1.newCharacter.languages.Add("Common");
                Form1.newCharacter.languages.Add("One Extra");
            }
            else if (Form1.newCharacter.race == "Tiefling")
            {
                Form1.newCharacter.intelligence = Form1.newCharacter.intelligence + 1;
                Form1.newCharacter.charisma = Form1.newCharacter.charisma + 2;
                Form1.newCharacter.speed = 30;
                Form1.newCharacter.traits.Add("Darkvision");
                Form1.newCharacter.traits.Add("Hellish Resistance");
                Form1.newCharacter.traits.Add("Infernal Legacy");
                Form1.newCharacter.languages.Add("Common");
                Form1.newCharacter.languages.Add("Infernal");
            }
            else if (Form1.newCharacter.race == "Lightfoot Halfling")
            {
                Form1.newCharacter.dexterity = Form1.newCharacter.dexterity + 2;
                Form1.newCharacter.charisma = Form1.newCharacter.charisma + 1;
                Form1.newCharacter.traits.Add("Naturally Stealthy");
                Form1.newCharacter.speed = 25;
                Form1.newCharacter.traits.Add("Lucky");
                Form1.newCharacter.traits.Add("Brave");
                Form1.newCharacter.traits.Add("Halfling Nimbleness");
                Form1.newCharacter.languages.Add("Common");
                Form1.newCharacter.languages.Add("Halfling");
            }
            else if (Form1.newCharacter.race == "Stout Halfling")
            {
                Form1.newCharacter.dexterity = Form1.newCharacter.dexterity + 2;
                Form1.newCharacter.constitution = Form1.newCharacter.constitution + 1;
                Form1.newCharacter.traits.Add("Stout Resilience");
                Form1.newCharacter.speed = 25;
                Form1.newCharacter.traits.Add("Lucky");
                Form1.newCharacter.traits.Add("Brave");
                Form1.newCharacter.traits.Add("Halfling Nimbleness");
                Form1.newCharacter.languages.Add("Common");
                Form1.newCharacter.languages.Add("Halfling");
            }
            else if (Form1.newCharacter.race == "Dragonborn")
            {
                Form1.newCharacter.strength = Form1.newCharacter.strength + 2;
                Form1.newCharacter.charisma = Form1.newCharacter.charisma + 1;
                Form1.newCharacter.speed = 30;
                Form1.newCharacter.traits.Add("Dragonic Ancestry");
                Form1.newCharacter.traits.Add("Breath Weapon");
                Form1.newCharacter.traits.Add("Damage Resistance");
                Form1.newCharacter.languages.Add("Common");
                Form1.newCharacter.languages.Add("Dragonic");
            }
            else if (Form1.newCharacter.race == "Forest Gnome")
            {
                Form1.newCharacter.intelligence = Form1.newCharacter.intelligence + 2;
                Form1.newCharacter.dexterity = Form1.newCharacter.dexterity + 1;
                Form1.newCharacter.traits.Add("Natural Illusionist");
                Form1.newCharacter.traits.Add("Speak with Small Beasts");
                Form1.newCharacter.speed = 25;
                Form1.newCharacter.traits.Add("Darkvision");
                Form1.newCharacter.traits.Add("Gnome Cunning");
                Form1.newCharacter.languages.Add("Common");
                Form1.newCharacter.languages.Add("Gnomish");
            }
            else if (Form1.newCharacter.race == "Rock Gnome")
            {
                Form1.newCharacter.intelligence = Form1.newCharacter.intelligence + 2;
                Form1.newCharacter.constitution = Form1.newCharacter.constitution + 1;
                Form1.newCharacter.traits.Add("Artificer's Lore");
                Form1.newCharacter.traits.Add("Tinker");
                Form1.newCharacter.speed = 25;
                Form1.newCharacter.traits.Add("Darkvision");
                Form1.newCharacter.traits.Add("Gnome Cunning");
                Form1.newCharacter.languages.Add("Common");
                Form1.newCharacter.languages.Add("Gnomish");
            }
            #endregion
           
            // classes
            #region class ifs

            //CLASSES
            if (Form1.newCharacter.type == "Cleric")
            {
                Form1.newCharacter.hitPoints = 8 + Form1.newCharacter.constMod;
                Form1.newCharacter.hitDie = "1d8";
                Form1.newCharacter.proficiencies.Add("Light Armor");
                Form1.newCharacter.proficiencies.Add("Medium Armor");
                Form1.newCharacter.proficiencies.Add("Sheilds");
                Form1.newCharacter.proficiencies.Add("Simple Weapons");
                Form1.newCharacter.strST = Form1.newCharacter.strMod;
                Form1.newCharacter.dexST = Form1.newCharacter.dexMod;
                Form1.newCharacter.constST = Form1.newCharacter.constMod;
                Form1.newCharacter.wisST = Form1.newCharacter.wisMod + Form1.newCharacter.proficiency;
                Form1.newCharacter.intST = Form1.newCharacter.intMod;
                Form1.newCharacter.chaST = Form1.newCharacter.chaMod + Form1.newCharacter.proficiency;
                Form1.newCharacter.equipment.Add("Shield");
                Form1.newCharacter.equipment.Add("Holy Symbol");
                Form1.newCharacter.traits.Add("Spellcasting");
                Form1.newCharacter.traits.Add("Devine Domain");
            }
            else if (Form1.newCharacter.type == "Druid")
            {
                Form1.newCharacter.hitPoints = 8 + Form1.newCharacter.constMod;
                Form1.newCharacter.hitDie = "1d8";
                Form1.newCharacter.proficiencies.Add("Light Armor");
                Form1.newCharacter.proficiencies.Add("Medium Armor");
                Form1.newCharacter.proficiencies.Add("Sheilds");
                Form1.newCharacter.proficiencies.Add("Clubs");
                Form1.newCharacter.proficiencies.Add("Daggers");
                Form1.newCharacter.proficiencies.Add("Darts");
                Form1.newCharacter.proficiencies.Add("Javelins");
                Form1.newCharacter.proficiencies.Add("Maces");
                Form1.newCharacter.proficiencies.Add("Quarterstaffs");
                Form1.newCharacter.proficiencies.Add("Scimitars");
                Form1.newCharacter.proficiencies.Add("Sickles");
                Form1.newCharacter.proficiencies.Add("Slings");
                Form1.newCharacter.proficiencies.Add("Spears");
                Form1.newCharacter.proficiencies.Add("Herbalism Kits");
                Form1.newCharacter.strST = Form1.newCharacter.strMod;
                Form1.newCharacter.dexST = Form1.newCharacter.dexMod;
                Form1.newCharacter.constST = Form1.newCharacter.constMod;
                Form1.newCharacter.wisST = Form1.newCharacter.wisMod + Form1.newCharacter.proficiency;
                Form1.newCharacter.intST = Form1.newCharacter.intMod + Form1.newCharacter.proficiency;
                Form1.newCharacter.chaST = Form1.newCharacter.chaMod;
                Form1.newCharacter.equipment.Add("Leather Armor");
                Form1.newCharacter.equipment.Add("Druidic Focus");
                Form1.newCharacter.equipment.Add("Explorer's Pack");
                Form1.newCharacter.traits.Add("Spellcasting");
                Form1.newCharacter.traits.Add("Druidic");
            }
            else if (Form1.newCharacter.type == "Barbarian")
            {
                Form1.newCharacter.hitPoints = 12 + Form1.newCharacter.constMod;
                Form1.newCharacter.hitDie = "1d12";
                Form1.newCharacter.proficiencies.Add("Light Armor");
                Form1.newCharacter.proficiencies.Add("Medium Armor");
                Form1.newCharacter.proficiencies.Add("Shields");
                Form1.newCharacter.proficiencies.Add("Simple Weapons");
                Form1.newCharacter.proficiencies.Add("Martial Weapons");
                Form1.newCharacter.strST = Form1.newCharacter.strMod + Form1.newCharacter.proficiency;
                Form1.newCharacter.dexST = Form1.newCharacter.dexMod;
                Form1.newCharacter.constST = Form1.newCharacter.constMod + Form1.newCharacter.proficiency;
                Form1.newCharacter.wisST = Form1.newCharacter.wisMod;
                Form1.newCharacter.intST = Form1.newCharacter.intMod;
                Form1.newCharacter.chaST = Form1.newCharacter.chaMod;
                Form1.newCharacter.equipment.Add("Explorer's Pack");
                weapons newweapon;
                newweapon = new weapons("Javelin X4", Form1.newCharacter.proficiency + Form1.newCharacter.strMod, "1d6 Piercing");
                Form1.newCharacter.weapon.Add(newweapon);
                Form1.newCharacter.traits.Add("Rage");
                Form1.newCharacter.traits.Add("Unarmored Defence");
            }
            else if (Form1.newCharacter.type == "Rogue")
            {
                Form1.newCharacter.hitPoints = 8 + Form1.newCharacter.constMod;
                Form1.newCharacter.hitDie = "1d8";
                Form1.newCharacter.proficiencies.Add("Light Armor");
                Form1.newCharacter.strST = Form1.newCharacter.strMod;
                Form1.newCharacter.dexST = Form1.newCharacter.dexMod + Form1.newCharacter.proficiency;
                Form1.newCharacter.constST = Form1.newCharacter.constMod;
                Form1.newCharacter.wisST = Form1.newCharacter.wisMod;
                Form1.newCharacter.intST = Form1.newCharacter.intMod + Form1.newCharacter.proficiency;
                Form1.newCharacter.chaST = Form1.newCharacter.chaMod;
                Form1.newCharacter.proficiencies.Add("Simple Weapons");
                Form1.newCharacter.proficiencies.Add("Hand Crossbow");
                Form1.newCharacter.proficiencies.Add("Longswords");
                Form1.newCharacter.proficiencies.Add("Rapiers");
                Form1.newCharacter.proficiencies.Add("Shortswords");
                Form1.newCharacter.proficiencies.Add("Thieves' Tools");
                Form1.newCharacter.traits.Add("Sneak Attack");
                Form1.newCharacter.traits.Add("Expertise");
                Form1.newCharacter.traits.Add("Thieves Cant");
                Form1.newCharacter.equipment.Add("Leather Armor");
                weapons newweapon;
                newweapon = new weapons("Dagger X2", Form1.newCharacter.proficiency + Form1.newCharacter.dexMod, "1d4 Piercing");
                Form1.newCharacter.weapon.Add(newweapon);

            }
            else if (Form1.newCharacter.type == "Paladin")
            {
                Form1.newCharacter.hitDie = "1d10";
                Form1.newCharacter.hitPoints = 10 + Form1.newCharacter.constMod;
                Form1.newCharacter.proficiencies.Add("All Armor");
                Form1.newCharacter.proficiencies.Add("Sheilds");
                Form1.newCharacter.proficiencies.Add("Simple Weapons");
                Form1.newCharacter.proficiencies.Add("Martial Weapons");
                Form1.newCharacter.strST = Form1.newCharacter.strMod;
                Form1.newCharacter.dexST = Form1.newCharacter.dexMod;
                Form1.newCharacter.constST = Form1.newCharacter.constMod;
                Form1.newCharacter.wisST = Form1.newCharacter.wisMod + Form1.newCharacter.proficiency;
                Form1.newCharacter.intST = Form1.newCharacter.intMod;
                Form1.newCharacter.chaST = Form1.newCharacter.chaMod + Form1.newCharacter.proficiency;
                Form1.newCharacter.equipment.Add("Chain Mail");
                Form1.newCharacter.equipment.Add("Holy Symbol");
                Form1.newCharacter.traits.Add("Lay on Hands");
                Form1.newCharacter.traits.Add("Divine Sense");
            }
            else if (Form1.newCharacter.type == "Monk")
            {
                Form1.newCharacter.hitPoints = 8 + Form1.newCharacter.constMod;
                Form1.newCharacter.hitDie = "1d8";
                Form1.newCharacter.proficiencies.Add("Simple Weapons");
                Form1.newCharacter.proficiencies.Add("Shortswords");
                Form1.newCharacter.proficiencies.Add("Artisan's Tools or Musical Instument");
                Form1.newCharacter.strST = Form1.newCharacter.strMod + Form1.newCharacter.proficiency;
                Form1.newCharacter.dexST = Form1.newCharacter.dexMod + Form1.newCharacter.proficiency;
                Form1.newCharacter.constST = Form1.newCharacter.constMod;
                Form1.newCharacter.wisST = Form1.newCharacter.wisMod;
                Form1.newCharacter.intST = Form1.newCharacter.intMod;
                Form1.newCharacter.chaST = Form1.newCharacter.chaMod;
                weapons newweapon;
                newweapon = new weapons("Dart X10", Form1.newCharacter.proficiency + Form1.newCharacter.dexMod, "1d4 Piercing");
                Form1.newCharacter.weapon.Add(newweapon);
                Form1.newCharacter.traits.Add("Unarmored Defence");
                Form1.newCharacter.traits.Add("Martial Arts");
            }
            else if (Form1.newCharacter.type == "Bard")
            {
                Form1.newCharacter.hitDie = "1d8";
                Form1.newCharacter.hitPoints = 8 + Form1.newCharacter.constMod;
                Form1.newCharacter.proficiencies.Add("Light Armor");
                Form1.newCharacter.proficiencies.Add("Simple Weapons");
                Form1.newCharacter.proficiencies.Add("Hand Crossbow");
                Form1.newCharacter.proficiencies.Add("Longswords");
                Form1.newCharacter.proficiencies.Add("Rapiers");
                Form1.newCharacter.proficiencies.Add("Shortswords");
                Form1.newCharacter.proficiencies.Add("Three Musical Instuments");
                Form1.newCharacter.strST = Form1.newCharacter.strMod;
                Form1.newCharacter.dexST = Form1.newCharacter.dexMod + Form1.newCharacter.proficiency;
                Form1.newCharacter.constST = Form1.newCharacter.constMod;
                Form1.newCharacter.wisST = Form1.newCharacter.wisMod;
                Form1.newCharacter.intST = Form1.newCharacter.intMod;
                Form1.newCharacter.chaST = Form1.newCharacter.chaMod + Form1.newCharacter.proficiency;
                Form1.newCharacter.equipment.Add("Leather Armor");
                weapons newweapon;
                newweapon = new weapons("Dagger", Form1.newCharacter.proficiency + Form1.newCharacter.strMod, "1d4 Piercing");
                Form1.newCharacter.weapon.Add(newweapon);
                Form1.newCharacter.traits.Add("Spellcasting");
                Form1.newCharacter.traits.Add("Bardic Inspiration");
                //choose 3 skills 
            }
            else if (Form1.newCharacter.type == "Wizard")
            {
                Form1.newCharacter.hitDie = "1d6";
                Form1.newCharacter.hitPoints = 6 + Form1.newCharacter.constMod;
                Form1.newCharacter.proficiencies.Add("Daggers");
                Form1.newCharacter.proficiencies.Add("Darts");
                Form1.newCharacter.proficiencies.Add("Slings");
                Form1.newCharacter.proficiencies.Add("Quarterstaffs");
                Form1.newCharacter.proficiencies.Add("Light Crossbows");
                Form1.newCharacter.strST = Form1.newCharacter.strMod;
                Form1.newCharacter.dexST = Form1.newCharacter.dexMod;
                Form1.newCharacter.constST = Form1.newCharacter.constMod;
                Form1.newCharacter.wisST = Form1.newCharacter.wisMod + Form1.newCharacter.proficiency;
                Form1.newCharacter.intST = Form1.newCharacter.intMod + Form1.newCharacter.proficiency;
                Form1.newCharacter.chaST = Form1.newCharacter.chaMod;
                Form1.newCharacter.equipment.Add("Spellbook");

            }
            else if (Form1.newCharacter.type == "Warlock")
            {
                Form1.newCharacter.hitDie = "1d8";
                Form1.newCharacter.hitPoints = 8 + Form1.newCharacter.constMod;
                Form1.newCharacter.proficiencies.Add("Light Armor");
                Form1.newCharacter.proficiencies.Add("Simple Weapons");
                Form1.newCharacter.strST = Form1.newCharacter.strMod;
                Form1.newCharacter.dexST = Form1.newCharacter.dexMod;
                Form1.newCharacter.constST = Form1.newCharacter.constMod;
                Form1.newCharacter.wisST = Form1.newCharacter.wisMod + Form1.newCharacter.proficiency;
                Form1.newCharacter.intST = Form1.newCharacter.intMod;
                Form1.newCharacter.chaST = Form1.newCharacter.chaMod + Form1.newCharacter.proficiency;
                Form1.newCharacter.equipment.Add("Leather Armor");
                weapons newweapon;
                newweapon = new weapons("Dagger X2", Form1.newCharacter.proficiency + Form1.newCharacter.strMod, "1d4 Piercing");
                Form1.newCharacter.weapon.Add(newweapon);
                Form1.newCharacter.traits.Add("Otherworldly Patron");
                Form1.newCharacter.traits.Add("Pact Magic");
            }
            else if (Form1.newCharacter.type == "Sorcerer")
            {
                Form1.newCharacter.hitDie = "1d6";
                Form1.newCharacter.hitPoints = 6 + Form1.newCharacter.constMod;
                Form1.newCharacter.proficiencies.Add("Daggers");
                Form1.newCharacter.proficiencies.Add("Darts");
                Form1.newCharacter.proficiencies.Add("Slings");
                Form1.newCharacter.proficiencies.Add("Quarterstaffs");
                Form1.newCharacter.proficiencies.Add("Light Crossbows");
                Form1.newCharacter.strST = Form1.newCharacter.strMod;
                Form1.newCharacter.dexST = Form1.newCharacter.dexMod;
                Form1.newCharacter.constST = Form1.newCharacter.constMod + Form1.newCharacter.proficiency;
                Form1.newCharacter.wisST = Form1.newCharacter.wisMod;
                Form1.newCharacter.intST = Form1.newCharacter.intMod;
                Form1.newCharacter.chaST = Form1.newCharacter.chaMod + Form1.newCharacter.proficiency;
                weapons newweapon;
                newweapon = new weapons("Dagger X2", Form1.newCharacter.proficiency + Form1.newCharacter.strMod, "1d4 Piercing");
                Form1.newCharacter.weapon.Add(newweapon);
                Form1.newCharacter.traits.Add("Spellcasting");
                Form1.newCharacter.traits.Add("Sorcerous Origin");


            }
            else if (Form1.newCharacter.type == "Fighter")
            {
                Form1.newCharacter.hitDie = "1d10";
                Form1.newCharacter.hitPoints = 10 + Form1.newCharacter.constMod;
                Form1.newCharacter.proficiencies.Add("All Armor");
                Form1.newCharacter.proficiencies.Add("Sheilds");
                Form1.newCharacter.proficiencies.Add("Simple Weapons");
                Form1.newCharacter.proficiencies.Add("Martial Weapons");
                Form1.newCharacter.strST = Form1.newCharacter.strMod + Form1.newCharacter.proficiency;
                Form1.newCharacter.dexST = Form1.newCharacter.dexMod;
                Form1.newCharacter.constST = Form1.newCharacter.constMod + Form1.newCharacter.proficiency;
                Form1.newCharacter.wisST = Form1.newCharacter.wisMod;
                Form1.newCharacter.intST = Form1.newCharacter.intMod;
                Form1.newCharacter.chaST = Form1.newCharacter.chaMod;
                Form1.newCharacter.traits.Add("Fighting Style");
                Form1.newCharacter.traits.Add("Second Wind");
            }
            else if (Form1.newCharacter.type == "Ranger")
            {
                Form1.newCharacter.hitDie = "1d10";
                Form1.newCharacter.hitPoints = 10 + Form1.newCharacter.constMod;
                Form1.newCharacter.proficiencies.Add("Light Armor");
                Form1.newCharacter.proficiencies.Add("Medium Armor");
                Form1.newCharacter.proficiencies.Add("Simple Weapons");
                Form1.newCharacter.proficiencies.Add("Martial Weapons");
                Form1.newCharacter.strST = Form1.newCharacter.strMod + Form1.newCharacter.proficiency;
                Form1.newCharacter.dexST = Form1.newCharacter.dexMod + Form1.newCharacter.proficiency;
                Form1.newCharacter.constST = Form1.newCharacter.constMod;
                Form1.newCharacter.wisST = Form1.newCharacter.wisMod;
                Form1.newCharacter.intST = Form1.newCharacter.intMod;
                Form1.newCharacter.chaST = Form1.newCharacter.chaMod;
                Form1.newCharacter.traits.Add("Favored Enemy");
                Form1.newCharacter.traits.Add("Natural Explorer");
                weapons newweapon;
                newweapon = new weapons("Longbow", Form1.newCharacter.proficiency + Form1.newCharacter.dexMod, "1d8 Piercing");
                Form1.newCharacter.weapon.Add(newweapon);
                Form1.newCharacter.equipment.Add("Arrows X20");
            }
            #endregion

            #region armor
            if (Form1.newCharacter.equipment.Contains("Leather Armor"))
            {
                Form1.newCharacter.armorClass = 11 + Form1.newCharacter.dexMod;
            }
           else if (Form1.newCharacter.equipment.Contains("Scale Mail"))
            {
                Form1.newCharacter.armorClass = 14 + Form1.newCharacter.dexMod;
            }
            else if (Form1.newCharacter.equipment.Contains("Chain Mail"))
            {
                Form1.newCharacter.armorClass = 16;
            }
            else
            {
                Form1.newCharacter.armorClass = 10 + Form1.newCharacter.constMod; 
            }
            #endregion

            //BACKGROUND 
            #region back ifs
            if (Form1.newCharacter.background == "Acolyte")
            {
                Form1.newCharacter.skills.Add("Insight");
                Form1.newCharacter.skills.Add("Religion");
                Form1.newCharacter.languages.Add("Two Extra");
                Form1.newCharacter.equipment.Add("Holy Symbol");
                Form1.newCharacter.equipment.Add("Prayer book / Prayer Wheel");
                Form1.newCharacter.equipment.Add("5 sticks of incense");
                Form1.newCharacter.equipment.Add("Vestments");
                Form1.newCharacter.equipment.Add("Common Clothes");
                Form1.newCharacter.equipment.Add("15 Gold");

            }
            else if (Form1.newCharacter.background == "Charlatan")
            {
                Form1.newCharacter.skills.Add("Deception");
                Form1.newCharacter.skills.Add("Sleight of Hand");
                Form1.newCharacter.proficiencies.Add("Disguise Kit");
                Form1.newCharacter.proficiencies.Add("Forgery Kit");
                Form1.newCharacter.equipment.Add("Fine Clothes");
                Form1.newCharacter.equipment.Add("Disguise Kit");
                Form1.newCharacter.equipment.Add("Tools of the Con");
                Form1.newCharacter.equipment.Add("Weighted Die");
                Form1.newCharacter.equipment.Add("Marked Cards");
                Form1.newCharacter.equipment.Add("Signet Ring of a Fake Duke");
                Form1.newCharacter.equipment.Add("15 Gold");
            }
            else if (Form1.newCharacter.background == "Criminal")
            {
                Form1.newCharacter.skills.Add("Deception");
                Form1.newCharacter.skills.Add("Stealth");
                Form1.newCharacter.proficiencies.Add("One Gaming Set");
                Form1.newCharacter.proficiencies.Add("Thieves' Tools");
                Form1.newCharacter.equipment.Add("Crowbar");
                Form1.newCharacter.equipment.Add("Dark Clothes with a Hood");
                Form1.newCharacter.equipment.Add("15 Gold");
            }
            else if (Form1.newCharacter.background == "Entertainer")
            {
                Form1.newCharacter.skills.Add("Acrobatics");
                Form1.newCharacter.skills.Add("Performance");
                Form1.newCharacter.proficiencies.Add("Disguise Kit");
                Form1.newCharacter.proficiencies.Add("One Musical Instrument");
                Form1.newCharacter.equipment.Add("One Musical Instrument");
                Form1.newCharacter.equipment.Add("The Favor of an Admirer");
                Form1.newCharacter.equipment.Add("A Costume");
                Form1.newCharacter.equipment.Add("15 Gold");
            }
            else if (Form1.newCharacter.background == "Folk Hero")
            {
                Form1.newCharacter.skills.Add("Animal Handling");
                Form1.newCharacter.skills.Add("Survival");
                Form1.newCharacter.proficiencies.Add("One type of Artisan's Tools");
                Form1.newCharacter.proficiencies.Add("Land Vehicles");
                Form1.newCharacter.equipment.Add("One type of Artisan's Tools");
                Form1.newCharacter.equipment.Add("A Shovel");
                Form1.newCharacter.equipment.Add("An Iron Pot");
                Form1.newCharacter.equipment.Add("Common Clothes");
                Form1.newCharacter.equipment.Add("10 Gold");
            }
            else if (Form1.newCharacter.background == "Guild Merchant")
            {
                Form1.newCharacter.skills.Add("Insight");
                Form1.newCharacter.skills.Add("Persuasion");
                Form1.newCharacter.proficiencies.Add("One type of Artisan's Tools");
                Form1.newCharacter.languages.Add("One Extra");
                Form1.newCharacter.equipment.Add("One type of Artisan's Tools");
                Form1.newCharacter.equipment.Add("A Letter of Introduction");
                Form1.newCharacter.equipment.Add("Traveler's Clothes");
                Form1.newCharacter.equipment.Add("15 Gold");
            }
            else if (Form1.newCharacter.background == "Hermit")
            {
                Form1.newCharacter.skills.Add("Medicine");
                Form1.newCharacter.skills.Add("Religion");
                Form1.newCharacter.proficiencies.Add("Herbalism Kit");
                Form1.newCharacter.languages.Add("One Extra");
                Form1.newCharacter.equipment.Add("A scroll case of studies and prayer");
                Form1.newCharacter.equipment.Add("A Winter Blanket");
                Form1.newCharacter.equipment.Add("Common Clothes");
                Form1.newCharacter.equipment.Add("Herbalism Kit");
                Form1.newCharacter.equipment.Add("5 Gold");
            }
            else if (Form1.newCharacter.background == "Noble ")
            {
                Form1.newCharacter.skills.Add("History");
                Form1.newCharacter.skills.Add("Persuasion");
                Form1.newCharacter.proficiencies.Add("One type of Gaming Set");
                Form1.newCharacter.languages.Add("One Extra");
                Form1.newCharacter.equipment.Add("A Scroll of Pedigree");
                Form1.newCharacter.equipment.Add("Signet Ring");
                Form1.newCharacter.equipment.Add("Fine Clothes");
                Form1.newCharacter.equipment.Add("One type of Gaming Set");
                Form1.newCharacter.equipment.Add("25 Gold");
            }
            else if (Form1.newCharacter.background == "Outlander")
            {
                Form1.newCharacter.skills.Add("Athletics");
                Form1.newCharacter.skills.Add("Survival");
                Form1.newCharacter.proficiencies.Add("One Musical Instrument");
                Form1.newCharacter.languages.Add("One Extra");
                Form1.newCharacter.equipment.Add("A Staff");
                Form1.newCharacter.equipment.Add("A Hunting Trap");
                Form1.newCharacter.equipment.Add("Hunting Trophy");
                Form1.newCharacter.equipment.Add("Traveler's Clothes");
                Form1.newCharacter.equipment.Add("10 Gold");
            }
            else if (Form1.newCharacter.background == "Sage")
            {
                Form1.newCharacter.skills.Add("Arcana");
                Form1.newCharacter.skills.Add("History");
                Form1.newCharacter.proficiencies.Add("One Musical Instrument");
                Form1.newCharacter.languages.Add("Two Extra");
                Form1.newCharacter.equipment.Add("A Bottle of Black ink");
                Form1.newCharacter.equipment.Add("A Quill");
                Form1.newCharacter.equipment.Add("A Smalll Knife");
                Form1.newCharacter.equipment.Add("A Letter From a Dead Friend");
                Form1.newCharacter.equipment.Add("Common Clothes");
                Form1.newCharacter.equipment.Add("10 Gold");
            }
            else if (Form1.newCharacter.background == "Sailor")
            {
                Form1.newCharacter.skills.Add("Athletics");
                Form1.newCharacter.skills.Add("Perception");
                Form1.newCharacter.proficiencies.Add("Navigator's Tools");
                Form1.newCharacter.proficiencies.Add("Water Vehicles");
                Form1.newCharacter.equipment.Add("A Belaying Pin");
                Form1.newCharacter.equipment.Add("50 Feet of Silk Rope");
                Form1.newCharacter.equipment.Add("A Lucky Charm");
                Form1.newCharacter.equipment.Add("Common Clothes");
                Form1.newCharacter.equipment.Add("10 Gold");
            }
            else if (Form1.newCharacter.background == "Soldier")
            {
                Form1.newCharacter.skills.Add("Athletics");
                Form1.newCharacter.skills.Add("Intimidation");
                Form1.newCharacter.proficiencies.Add("One type of Gaming Set");
                Form1.newCharacter.proficiencies.Add("Land Vehicles");
                Form1.newCharacter.equipment.Add("Insigna of Rank");
                Form1.newCharacter.equipment.Add("A War Trophy");
                Form1.newCharacter.equipment.Add("Bone Die");
                Form1.newCharacter.equipment.Add("Common Clothes");
                Form1.newCharacter.equipment.Add("10 Gold");
            }
            else if (Form1.newCharacter.background == "Urchin")
            {
                Form1.newCharacter.skills.Add("Sleight of Hand");
                Form1.newCharacter.skills.Add("Stealth");
                Form1.newCharacter.proficiencies.Add("Disguise Kit");
                Form1.newCharacter.proficiencies.Add("Thieves' Tools");
                Form1.newCharacter.equipment.Add("Small Knife");
                Form1.newCharacter.equipment.Add("Home City Map");
                Form1.newCharacter.equipment.Add("A Pet Mouse");
                Form1.newCharacter.equipment.Add("Common Clothes");
                Form1.newCharacter.equipment.Add("A Token to Remember Your Parents");
                Form1.newCharacter.equipment.Add("10 Gold");
            }
#endregion
           
            // abiility modifiers 
            #region strMod

            switch (Form1.newCharacter.strength)
            {
                case 4:
                    Form1.newCharacter.strMod = -3;
                    break;
                case 5:
                    Form1.newCharacter.strMod = -3;
                    break;
                case 6:
                    Form1.newCharacter.strMod = -2;
                    break;
                case 7:
                    Form1.newCharacter.strMod = -2;
                    break;
                case 8:
                    Form1.newCharacter.strMod = -1;
                    break;
                case 9:
                    Form1.newCharacter.strMod = -1;
                    break;
                case 10:
                    Form1.newCharacter.strMod = 0;
                    break;
                case 11:
                    Form1.newCharacter.strMod = 0;
                    break;
                case 12:
                    Form1.newCharacter.strMod = 1;
                    break;
                case 13:
                    Form1.newCharacter.strMod = 1;
                    break;
                case 14:
                    Form1.newCharacter.strMod = 2;
                    break;
                case 15:
                    Form1.newCharacter.strMod = 2;
                    break;
                case 16:
                    Form1.newCharacter.strMod = 3;
                    break;
                case 17:
                    Form1.newCharacter.strMod = 3;
                    break;
                case 18:
                    Form1.newCharacter.strMod = 4;
                    break;
                case 19:
                    Form1.newCharacter.strMod = 4;
                    break;
                case 20:
                    Form1.newCharacter.strMod = 5;
                    break;
                case 21:
                    Form1.newCharacter.strMod = 5;
                    break;
                case 22:
                    Form1.newCharacter.strMod = 6;
                    break;
                case 23:
                    Form1.newCharacter.strMod = 6;
                    break;
                case 24:
                    Form1.newCharacter.strMod = 7;
                    break;
            }
            #endregion

            #region dexMod
            switch (Form1.newCharacter.dexterity)
            {
                case 4:
                    Form1.newCharacter.dexMod = -3;
                    break;
                case 5:
                    Form1.newCharacter.dexMod = -3;
                    break;
                case 6:
                    Form1.newCharacter.dexMod = -2;
                    break;
                case 7:
                    Form1.newCharacter.dexMod = -2;
                    break;
                case 8:
                    Form1.newCharacter.dexMod = -1;
                    break;
                case 9:
                    Form1.newCharacter.dexMod = -1;
                    break;
                case 10:
                    Form1.newCharacter.dexMod = 0;
                    break;
                case 11:
                    Form1.newCharacter.dexMod = 0;
                    break;
                case 12:
                    Form1.newCharacter.dexMod = 1;
                    break;
                case 13:
                    Form1.newCharacter.dexMod = 1;
                    break;
                case 14:
                    Form1.newCharacter.dexMod = 2;
                    break;
                case 15:
                    Form1.newCharacter.dexMod = 2;
                    break;
                case 16:
                    Form1.newCharacter.dexMod = 3;
                    break;
                case 17:
                    Form1.newCharacter.dexMod = 3;
                    break;
                case 18:
                    Form1.newCharacter.dexMod = 4;
                    break;
                case 19:
                    Form1.newCharacter.dexMod = 4;
                    break;
                case 20:
                    Form1.newCharacter.dexMod = 5;
                    break;
                case 21:
                    Form1.newCharacter.dexMod = 5;
                    break;
                case 22:
                    Form1.newCharacter.dexMod = 6;
                    break;
                case 23:
                    Form1.newCharacter.dexMod = 6;
                    break;
                case 24:
                    Form1.newCharacter.dexMod = 7;
                    break;
            }
            #endregion

            #region conMOD

            switch (Form1.newCharacter.constitution)
            {
                case 4:
                    Form1.newCharacter.constMod = -3;
                    break;
                case 5:
                    Form1.newCharacter.constMod = -3;
                    break;
                case 6:
                    Form1.newCharacter.constMod = -2;
                    break;
                case 7:
                    Form1.newCharacter.constMod = -2;
                    break;
                case 8:
                    Form1.newCharacter.constMod = -1;
                    break;
                case 9:
                    Form1.newCharacter.constMod = -1;
                    break;
                case 10:
                    Form1.newCharacter.constMod = 0;
                    break;
                case 11:
                    Form1.newCharacter.constMod = 0;
                    break;
                case 12:
                    Form1.newCharacter.constMod = 1;
                    break;
                case 13:
                    Form1.newCharacter.constMod = 1;
                    break;
                case 14:
                    Form1.newCharacter.constMod = 2;
                    break;
                case 15:
                    Form1.newCharacter.constMod = 2;
                    break;
                case 16:
                    Form1.newCharacter.constMod = 3;
                    break;
                case 17:
                    Form1.newCharacter.constMod = 3;
                    break;
                case 18:
                    Form1.newCharacter.constMod = 4;
                    break;
                case 19:
                    Form1.newCharacter.constMod = 4;
                    break;
                case 20:
                    Form1.newCharacter.constMod = 5;
                    break;
                case 21:
                    Form1.newCharacter.constMod = 5;
                    break;
                case 22:
                    Form1.newCharacter.constMod = 6;
                    break;
                case 23:
                    Form1.newCharacter.constMod = 6;
                    break;
                case 24:
                    Form1.newCharacter.constMod = 7;
                    break;
            }
            #endregion

            #region intMod

            switch (Form1.newCharacter.intelligence)
            {
                case 4:
                    Form1.newCharacter.intMod = -3;
                    break;
                case 5:
                    Form1.newCharacter.intMod = -3;
                    break;
                case 6:
                    Form1.newCharacter.intMod = -2;
                    break;
                case 7:
                    Form1.newCharacter.intMod = -2;
                    break;
                case 8:
                    Form1.newCharacter.intMod = -1;
                    break;
                case 9:
                    Form1.newCharacter.intMod = -1;
                    break;
                case 10:
                    Form1.newCharacter.intMod = 0;
                    break;
                case 11:
                    Form1.newCharacter.intMod = 0;
                    break;
                case 12:
                    Form1.newCharacter.intMod = 1;
                    break;
                case 13:
                    Form1.newCharacter.intMod = 1;
                    break;
                case 14:
                    Form1.newCharacter.intMod = 2;
                    break;
                case 15:
                    Form1.newCharacter.intMod = 2;
                    break;
                case 16:
                    Form1.newCharacter.intMod = 3;
                    break;
                case 17:
                    Form1.newCharacter.intMod = 3;
                    break;
                case 18:
                    Form1.newCharacter.intMod = 4;
                    break;
                case 19:
                    Form1.newCharacter.intMod = 4;
                    break;
                case 20:
                    Form1.newCharacter.intMod = 5;
                    break;
                case 21:
                    Form1.newCharacter.intMod = 5;
                    break;
                case 22:
                    Form1.newCharacter.intMod = 6;
                    break;
                case 23:
                    Form1.newCharacter.intMod = 6;
                    break;
                case 24:
                    Form1.newCharacter.intMod = 7;
                    break;
            }
            #endregion

            #region wisMod

            switch (Form1.newCharacter.wisdom)
            {
                case 4:
                    Form1.newCharacter.wisMod = -3;
                    break;
                case 5:
                    Form1.newCharacter.wisMod = -3;
                    break;
                case 6:
                    Form1.newCharacter.wisMod = -2;
                    break;
                case 7:
                    Form1.newCharacter.wisMod = -2;
                    break;
                case 8:
                    Form1.newCharacter.wisMod = -1;
                    break;
                case 9:
                    Form1.newCharacter.wisMod = -1;
                    break;
                case 10:
                    Form1.newCharacter.wisMod = 0;
                    break;
                case 11:
                    Form1.newCharacter.wisMod = 0;
                    break;
                case 12:
                    Form1.newCharacter.wisMod = 1;
                    break;
                case 13:
                    Form1.newCharacter.wisMod = 1;
                    break;
                case 14:
                    Form1.newCharacter.wisMod = 2;
                    break;
                case 15:
                    Form1.newCharacter.wisMod = 2;
                    break;
                case 16:
                    Form1.newCharacter.wisMod = 3;
                    break;
                case 17:
                    Form1.newCharacter.wisMod = 3;
                    break;
                case 18:
                    Form1.newCharacter.wisMod = 4;
                    break;
                case 19:
                    Form1.newCharacter.wisMod = 4;
                    break;
                case 20:
                    Form1.newCharacter.wisMod = 5;
                    break;
                case 21:
                    Form1.newCharacter.wisMod = 5;
                    break;
                case 22:
                    Form1.newCharacter.wisMod = 6;
                    break;
                case 23:
                    Form1.newCharacter.wisMod = 6;
                    break;
                case 24:
                    Form1.newCharacter.wisMod = 7;
                    break;
            }
            #endregion

            #region chaMod

            switch (Form1.newCharacter.charisma)
            {
                case 4:
                    Form1.newCharacter.chaMod = -3;
                    break;
                case 5:
                    Form1.newCharacter.chaMod = -3;
                    break;
                case 6:
                    Form1.newCharacter.chaMod = -2;
                    break;
                case 7:
                    Form1.newCharacter.chaMod = -2;
                    break;
                case 8:
                    Form1.newCharacter.chaMod = -1;
                    break;
                case 9:
                    Form1.newCharacter.chaMod = -1;
                    break;
                case 10:
                    Form1.newCharacter.chaMod = 0;
                    break;
                case 11:
                    Form1.newCharacter.chaMod = 0;
                    break;
                case 12:
                    Form1.newCharacter.chaMod = 1;
                    break;
                case 13:
                    Form1.newCharacter.chaMod = 1;
                    break;
                case 14:
                    Form1.newCharacter.chaMod = 2;
                    break;
                case 15:
                    Form1.newCharacter.chaMod = 2;
                    break;
                case 16:
                    Form1.newCharacter.chaMod = 3;
                    break;
                case 17:
                    Form1.newCharacter.chaMod = 3;
                    break;
                case 18:
                    Form1.newCharacter.chaMod = 4;
                    break;
                case 19:
                    Form1.newCharacter.chaMod = 4;
                    break;
                case 20:
                    Form1.newCharacter.chaMod = 5;
                    break;
                case 21:
                    Form1.newCharacter.chaMod = 5;
                    break;
                case 22:
                    Form1.newCharacter.chaMod = 6;
                    break;
                case 23:
                    Form1.newCharacter.chaMod = 6;
                    break;
                case 24:
                    Form1.newCharacter.chaMod = 7;
                    break;
            }

            #endregion
            nameLabel.Text = Form1.newCharacter.name;
            raceBox.Text = Form1.newCharacter.race;
            classBox.Text = Form1.newCharacter.type;
            bgBox.Text = Form1.newCharacter.background;
            strBox.Text = Convert.ToString(Form1.newCharacter.strength);
            dexBox.Text = Convert.ToString(Form1.newCharacter.dexterity);
            conBox.Text = Convert.ToString(Form1.newCharacter.constitution);
            wisBox.Text = Convert.ToString(Form1.newCharacter.wisdom);
            intBox.Text = Convert.ToString(Form1.newCharacter.intelligence);
            chaBox.Text = Convert.ToString(Form1.newCharacter.charisma);
            armorBox.Text = Convert.ToString(Form1.newCharacter.armorClass);
            speedBox.Text = Convert.ToString(Form1.newCharacter.speed);
            hitBox.Text = Convert.ToString(Form1.newCharacter.hitPoints);
            hitBox.Text += "        " + Convert.ToString(Form1.newCharacter.hitDie);
            strModbox.Text = Convert.ToString(Form1.newCharacter.strMod);
            dexModBox.Text = Convert.ToString(Form1.newCharacter.dexMod);
            conModBox.Text = Convert.ToString(Form1.newCharacter.constMod);
            intModBox.Text = Convert.ToString(Form1.newCharacter.intMod);
            wisModBox.Text = Convert.ToString(Form1.newCharacter.wisMod);
            chaModBox.Text = Convert.ToString(Form1.newCharacter.chaMod);

            // skills
            #region skill ifs 

            skillBox.Text += "Athletics";
            skillBox.Text += "\nAcrobatics";
            skillBox.Text += "\nSleight of Hand";
            skillBox.Text += "\nStealth";
            skillBox.Text += "\nArcana";
            skillBox.Text += "\nHistory";
            skillBox.Text += "\nInvestigation";
            skillBox.Text += "\nNature ";
            skillBox.Text += "\nReligion";
            skillBox.Text += "\nAnimal Handling";
            skillBox.Text += "\nInsight";
            skillBox.Text += "\nMedicine";
            skillBox.Text += "\nPerception";
            skillBox.Text += "\nSurvival";
            skillBox.Text += "\nDeception";
            skillBox.Text += "\nIntimidation";
            skillBox.Text += "\nPerformance";
            skillBox.Text += "\nPersuasion";



            if (Form1.newCharacter.skills.Contains("Athletics"))
            {
                Form1.newCharacter.strMod = Form1.newCharacter.strMod + Form1.newCharacter.proficiency;
                skillModBox.Text += "\n" + Form1.newCharacter.strMod;
                Form1.newCharacter.strMod = Form1.newCharacter.strMod - Form1.newCharacter.proficiency;
            }
            else
            {
                skillModBox.Text +=  Convert.ToString(Form1.newCharacter.strMod);
            }

            if (Form1.newCharacter.skills.Contains("Acrobatics"))
            {
                Form1.newCharacter.dexMod = Form1.newCharacter.dexMod + Form1.newCharacter.proficiency;
                skillModBox.Text += "\n" + Form1.newCharacter.dexMod;
                Form1.newCharacter.dexMod = Form1.newCharacter.dexMod - Form1.newCharacter.proficiency;
            }
            else
            {
                skillModBox.Text += "\n" + Convert.ToString(Form1.newCharacter.dexMod);
            }

            if (Form1.newCharacter.skills.Contains("Sleight of Hand"))
            {
                Form1.newCharacter.dexMod = Form1.newCharacter.dexMod + Form1.newCharacter.proficiency;
                skillModBox.Text += "\n" + Form1.newCharacter.dexMod;
                Form1.newCharacter.dexMod = Form1.newCharacter.dexMod - Form1.newCharacter.proficiency;
            }
            else
            {
                skillModBox.Text += "\n" + Convert.ToString(Form1.newCharacter.dexMod);
            }

            if (Form1.newCharacter.skills.Contains("Stealth"))
            {
                Form1.newCharacter.dexMod = Form1.newCharacter.dexMod + Form1.newCharacter.proficiency;
                skillModBox.Text += "\n" + Form1.newCharacter.dexMod;
                Form1.newCharacter.dexMod = Form1.newCharacter.dexMod - Form1.newCharacter.proficiency;
            }
            else
            {
                skillModBox.Text += "\n" + Convert.ToString(Form1.newCharacter.dexMod);
            }

            if (Form1.newCharacter.skills.Contains("Arcana"))
            {
                Form1.newCharacter.intMod = Form1.newCharacter.intMod + Form1.newCharacter.proficiency;
                skillModBox.Text += "\n" + Form1.newCharacter.intMod;
                Form1.newCharacter.intMod = Form1.newCharacter.intMod - Form1.newCharacter.proficiency;
            }
            else
            {
                skillModBox.Text += "\n" + Convert.ToString(Form1.newCharacter.intMod);
            }

            if (Form1.newCharacter.skills.Contains("History"))
            {
                Form1.newCharacter.intMod = Form1.newCharacter.intMod + Form1.newCharacter.proficiency;
                skillModBox.Text += "\n" + Form1.newCharacter.intMod;
                Form1.newCharacter.intMod = Form1.newCharacter.intMod - Form1.newCharacter.proficiency;
            }
            else
            {
                skillModBox.Text += "\n" + Convert.ToString(Form1.newCharacter.intMod);
            }

            if (Form1.newCharacter.skills.Contains("Investigation"))
            {
                Form1.newCharacter.intMod = Form1.newCharacter.intMod + Form1.newCharacter.proficiency;
                skillModBox.Text += "\n" + Form1.newCharacter.intMod;
                Form1.newCharacter.intMod = Form1.newCharacter.intMod - Form1.newCharacter.proficiency;
            }
            else
            {
                skillModBox.Text += "\n" + Convert.ToString(Form1.newCharacter.intMod);
            }

            if (Form1.newCharacter.skills.Contains("Nature"))
            {
                Form1.newCharacter.intMod = Form1.newCharacter.intMod + Form1.newCharacter.proficiency;
                skillModBox.Text += "\n" + Form1.newCharacter.intMod;
                Form1.newCharacter.intMod = Form1.newCharacter.intMod - Form1.newCharacter.proficiency;
            }
            else
            {
                skillModBox.Text += "\n" + Convert.ToString(Form1.newCharacter.intMod);
            }

            if (Form1.newCharacter.skills.Contains("Religion"))
            {
                Form1.newCharacter.intMod = Form1.newCharacter.intMod + Form1.newCharacter.proficiency;
                skillModBox.Text += "\n" + Form1.newCharacter.intMod;
                Form1.newCharacter.intMod = Form1.newCharacter.intMod - Form1.newCharacter.proficiency;
            }
            else
            {
                skillModBox.Text += "\n" + Convert.ToString(Form1.newCharacter.intMod);
            }

            if (Form1.newCharacter.skills.Contains("Animal Handling"))
            {
                Form1.newCharacter.wisMod = Form1.newCharacter.wisMod + Form1.newCharacter.proficiency;
                skillModBox.Text += "\n" + Form1.newCharacter.wisMod;
                Form1.newCharacter.wisMod = Form1.newCharacter.wisMod - Form1.newCharacter.proficiency;
            }
            else
            {
                skillModBox.Text += "\n" + Convert.ToString(Form1.newCharacter.wisMod);
            }

            if (Form1.newCharacter.skills.Contains("Insight"))
            {
                Form1.newCharacter.wisMod = Form1.newCharacter.wisMod + Form1.newCharacter.proficiency;
                skillModBox.Text += "\n" + Form1.newCharacter.wisMod;
                Form1.newCharacter.wisMod = Form1.newCharacter.wisMod - Form1.newCharacter.proficiency;
            }
            else
            {
                skillModBox.Text += "\n" + Convert.ToString(Form1.newCharacter.wisMod);
            }

            if (Form1.newCharacter.skills.Contains("Medicine"))
            {
                Form1.newCharacter.wisMod = Form1.newCharacter.wisMod + Form1.newCharacter.proficiency;
                skillModBox.Text += "\n" + Form1.newCharacter.wisMod;
                Form1.newCharacter.wisMod = Form1.newCharacter.wisMod - Form1.newCharacter.proficiency;
            }
            else
            {
                skillModBox.Text += "\n" + Convert.ToString(Form1.newCharacter.wisMod);
            }

            if (Form1.newCharacter.skills.Contains("Perception"))
            {
                Form1.newCharacter.wisMod = Form1.newCharacter.wisMod + Form1.newCharacter.proficiency;
                skillModBox.Text += "\n" + Form1.newCharacter.wisMod;
                Form1.newCharacter.wisMod = Form1.newCharacter.wisMod - Form1.newCharacter.proficiency;
            }
            else
            {
                skillModBox.Text += "\n" + Convert.ToString(Form1.newCharacter.wisMod);
            }

            if (Form1.newCharacter.skills.Contains("Survival"))
            {
                    Form1.newCharacter.wisMod = Form1.newCharacter.wisMod + Form1.newCharacter.proficiency;
                    skillModBox.Text += "\n" + Form1.newCharacter.wisMod;
                    Form1.newCharacter.wisMod = Form1.newCharacter.wisMod - Form1.newCharacter.proficiency;
            }
            else
            {
                skillModBox.Text += "\n" + Convert.ToString(Form1.newCharacter.wisMod);
            }

            if (Form1.newCharacter.skills.Contains("Deception"))
            {
                Form1.newCharacter.chaMod = Form1.newCharacter.chaMod + Form1.newCharacter.proficiency;
                skillModBox.Text += "\n" + Form1.newCharacter.chaMod;
                Form1.newCharacter.chaMod = Form1.newCharacter.chaMod - Form1.newCharacter.proficiency;
            }
            else
            {
                skillModBox.Text += "\n" + Convert.ToString(Form1.newCharacter.chaMod);
            }

            if (Form1.newCharacter.skills.Contains("Intimidation"))
            {
                Form1.newCharacter.wisMod = Form1.newCharacter.wisMod + Form1.newCharacter.proficiency;
                skillModBox.Text += "\n" + Form1.newCharacter.wisMod;
                Form1.newCharacter.wisMod = Form1.newCharacter.wisMod - Form1.newCharacter.proficiency;
            }
            else
            {
                skillModBox.Text += "\n" + Convert.ToString(Form1.newCharacter.chaMod);
            }

            if (Form1.newCharacter.skills.Contains("Performance"))
            {
                Form1.newCharacter.wisMod = Form1.newCharacter.wisMod + Form1.newCharacter.proficiency;
                skillModBox.Text += "\n" + Form1.newCharacter.wisMod;
                Form1.newCharacter.wisMod = Form1.newCharacter.wisMod - Form1.newCharacter.proficiency;
            }
            else
            {
                skillModBox.Text += "\n" + Convert.ToString(Form1.newCharacter.chaMod);
            }

            if (Form1.newCharacter.skills.Contains("Persuasion"))
            {
                Form1.newCharacter.wisMod = Form1.newCharacter.wisMod + Form1.newCharacter.proficiency;
                skillModBox.Text += "\n" + Form1.newCharacter.wisMod;
                Form1.newCharacter.wisMod = Form1.newCharacter.wisMod - Form1.newCharacter.proficiency;
            }
            else
            {
                skillModBox.Text += "\n" + Convert.ToString(Form1.newCharacter.chaMod);
            }

            #endregion

            //Save Throws 
            #region ST 
            svBox.Text += "Strength   " + Form1.newCharacter.strST;
            svBox.Text += "\nDexterity   " + Form1.newCharacter.dexST;
            svBox.Text += "\nConstitution   " + Form1.newCharacter.constST;
            svBox.Text += "\nIntelligence   " + Form1.newCharacter.intST;
            svBox.Text += "\nWisdom   " + Form1.newCharacter.wisST;
            svBox.Text += "\nCharisma   " + Form1.newCharacter.wisST;
            #endregion
          
            #region equip + prof + lang + traits
            // Equipment 
            for (int i = 0; i < Form1.newCharacter.equipment.Count; i++)
            {
                equipBox.Text += "\n" + Form1.newCharacter.equipment[i];
            }

            // proficiencies 
            for (int i = 0; i < Form1.newCharacter.proficiencies.Count; i++)
            {
                profBox.Text += "\n" + Form1.newCharacter.proficiencies[i];

            }

            //Languages
            for (int i = 0; i < Form1.newCharacter.languages.Count; i++)
            {
                profBox.Text += "\n" + Form1.newCharacter.languages[i];
            }

            //Traits
            for (int i = 0; i < Form1.newCharacter.traits.Count; i++)
            {
                traitBox1.Text += "\n" + Form1.newCharacter.traits[i];
            }

            #endregion

            #region weapons
            // weapons
            #region weapon obj
            // Simple weapons
            weapons club = new weapons("Club", Form1.newCharacter.strMod + Form1.newCharacter.proficiency, "1d4 Bludgeoning");
            weapons dagger = new weapons("Dagger", Form1.newCharacter.strMod + Form1.newCharacter.proficiency, "1d4 Piercing");
            weapons greatclub = new weapons("Greatclub", Form1.newCharacter.strMod + Form1.newCharacter.proficiency, "1d8 Bludgeoning");
            weapons handaxe = new weapons("Handaxe", Form1.newCharacter.strMod + Form1.newCharacter.proficiency, "1d6 Slashing");
            weapons javelin = new weapons("Javelin", Form1.newCharacter.strMod + Form1.newCharacter.proficiency, "1d6 Piercing");
            weapons lighthammer = new weapons("Light Hammer", Form1.newCharacter.strMod + Form1.newCharacter.proficiency, "1d4 Bludgeoning");
            weapons mace = new weapons("Mace", Form1.newCharacter.strMod + Form1.newCharacter.proficiency, "1d6 Bludgeoning");
            weapons quarterstaff = new weapons("Quarterstaff", Form1.newCharacter.strMod + Form1.newCharacter.proficiency, "1d6 Bludgeoning");
            weapons sickle = new weapons("Sickle", Form1.newCharacter.strMod + Form1.newCharacter.proficiency, "1d4 Slashing");
            weapons spear = new weapons("Spear", Form1.newCharacter.strMod + Form1.newCharacter.proficiency, "1d6 Piercing");
            weapons lightCB = new weapons("Light Crossbow", Form1.newCharacter.dexMod + Form1.newCharacter.proficiency, "1d8 Piercing");
            weapons dart = new weapons("Dart", Form1.newCharacter.dexMod + Form1.newCharacter.proficiency, "1d4 Piercing");
            weapons shortbow = new weapons("Shortbow", Form1.newCharacter.dexMod + Form1.newCharacter.proficiency, "1d6 Piercing");
            weapons sling = new weapons("Sling", Form1.newCharacter.dexMod + Form1.newCharacter.proficiency, "1d4 Bludgeoning");

            //Martial Weapons
            weapons battleaxe = new weapons("Battleaxe", Form1.newCharacter.strMod + Form1.newCharacter.proficiency, "1d8 Slashing");
            weapons flail = new weapons("Flail", Form1.newCharacter.strMod + Form1.newCharacter.proficiency, "1d8 Bludgeoning");
            weapons glaive = new weapons("Glaive", Form1.newCharacter.strMod + Form1.newCharacter.proficiency, "1d10 Slashing");
            weapons greataxe = new weapons("Greataxe", Form1.newCharacter.strMod + Form1.newCharacter.proficiency, "1d12 Slashing");
            weapons greatsword = new weapons("Greatsword", Form1.newCharacter.strMod + Form1.newCharacter.proficiency, "2d6 Slashing");
            weapons halberd = new weapons("Halberd", Form1.newCharacter.strMod + Form1.newCharacter.proficiency, "1d10 Slashing");
            weapons lance = new weapons("Lance", Form1.newCharacter.strMod + Form1.newCharacter.proficiency, "1d12 Piercing");
            weapons longsword = new weapons("Longsword", Form1.newCharacter.strMod + Form1.newCharacter.proficiency, "1d8 Slashing");
            weapons maul = new weapons("Maul", Form1.newCharacter.strMod + Form1.newCharacter.proficiency, "2d6 Bludgeoning");
            weapons morningstar = new weapons("Morningstar", Form1.newCharacter.strMod + Form1.newCharacter.proficiency, "1d8 Piercing");
            weapons pike = new weapons("Pike", Form1.newCharacter.strMod + Form1.newCharacter.proficiency, "1d10 Piercing");
            weapons rapier = new weapons("Rapier", Form1.newCharacter.strMod + Form1.newCharacter.proficiency, "1d8 Piercing");
            weapons scimitar = new weapons("Scimitar", Form1.newCharacter.strMod + Form1.newCharacter.proficiency, "1d6 Slashing");
            weapons shortsword = new weapons("Shortsword", Form1.newCharacter.strMod + Form1.newCharacter.proficiency, "1d6 Piercing");
            weapons trident = new weapons("Trident", Form1.newCharacter.strMod + Form1.newCharacter.proficiency, "1d6 Piercing");
            weapons warpick = new weapons("War Pick", Form1.newCharacter.strMod + Form1.newCharacter.proficiency, "1d8 Piercing");
            weapons warhammer = new weapons("Warhammer", Form1.newCharacter.strMod + Form1.newCharacter.proficiency, "1d8 Bludgeoning");
            weapons whip = new weapons("Whip", Form1.newCharacter.strMod + Form1.newCharacter.proficiency, "1d4 Slashing");
            weapons blowgun = new weapons("Blowgun", Form1.newCharacter.dexMod + Form1.newCharacter.proficiency, "1 piercing");
            weapons handCB = new weapons("Hand Crossbow", Form1.newCharacter.dexMod + Form1.newCharacter.proficiency, "1d6 piercing");
            weapons heavyCB = new weapons("Heavy Crossbow", Form1.newCharacter.dexMod + Form1.newCharacter.proficiency, "1d10 piercing");
            weapons longbow = new weapons("LongBow", Form1.newCharacter.dexMod + Form1.newCharacter.proficiency, "1d8 piercing");
            #endregion

            #region weapon ifs 
            if (Form1.newCharacter.clickedWeapons.Contains("Club"))
            {
                Form1.newCharacter.weapon.Add(club);
            }
            if (Form1.newCharacter.clickedWeapons.Contains("Dagger"))
            {
                Form1.newCharacter.weapon.Add(dagger);
            }
            if (Form1.newCharacter.clickedWeapons.Contains("Greatclub"))
            {
                Form1.newCharacter.weapon.Add(greatclub);
            }
            if (Form1.newCharacter.clickedWeapons.Contains("Handaxe"))
            {
                Form1.newCharacter.weapon.Add(handaxe);
            }
            if (Form1.newCharacter.clickedWeapons.Contains("Javelin"))
            {
                Form1.newCharacter.weapon.Add(javelin);
            }
            if (Form1.newCharacter.clickedWeapons.Contains("Light Hammer"))
            {
                Form1.newCharacter.weapon.Add(lighthammer);
            }
            if (Form1.newCharacter.clickedWeapons.Contains("Mace"))
            {
                Form1.newCharacter.weapon.Add(mace);
            }
            if (Form1.newCharacter.clickedWeapons.Contains("Quarterstaff"))
            {
                Form1.newCharacter.weapon.Add(quarterstaff);
            }
            if (Form1.newCharacter.clickedWeapons.Contains("Sickle"))
            {
                Form1.newCharacter.weapon.Add(sickle);
            }
            if (Form1.newCharacter.clickedWeapons.Contains("Spear"))
            {
                Form1.newCharacter.weapon.Add(spear);
            }
            if (Form1.newCharacter.clickedWeapons.Contains("Light Crossbow"))
            {
                Form1.newCharacter.weapon.Add(lightCB);
            }
            if (Form1.newCharacter.clickedWeapons.Contains("Dart"))
            {
                Form1.newCharacter.weapon.Add(dart);
            }
            if (Form1.newCharacter.clickedWeapons.Contains("Shortbow"))
            {
                Form1.newCharacter.weapon.Add(shortbow);
            }
            if (Form1.newCharacter.clickedWeapons.Contains("Sling"))
            {
                Form1.newCharacter.weapon.Add(sling);
            }
            if (Form1.newCharacter.clickedWeapons.Contains("Battleaxe"))
            {
                Form1.newCharacter.weapon.Add(battleaxe);
            }
            if (Form1.newCharacter.clickedWeapons.Contains("Flail"))
            {
                Form1.newCharacter.weapon.Add(flail);
            }
            if (Form1.newCharacter.clickedWeapons.Contains("Glaive"))
            {
                Form1.newCharacter.weapon.Add(glaive);
            }
            if (Form1.newCharacter.clickedWeapons.Contains("Greataxe"))
            {
                Form1.newCharacter.weapon.Add(greataxe);
            }
            if (Form1.newCharacter.clickedWeapons.Contains("Greatsword"))
            {
                Form1.newCharacter.weapon.Add(greatsword);
            }
            if (Form1.newCharacter.clickedWeapons.Contains("Halberd"))
            {
                Form1.newCharacter.weapon.Add(halberd);
            }
            if (Form1.newCharacter.clickedWeapons.Contains("Lance"))
            {
                Form1.newCharacter.weapon.Add(lance);
            }
            if (Form1.newCharacter.clickedWeapons.Contains("Longsword"))
            {
                Form1.newCharacter.weapon.Add(longsword);
            }
            if (Form1.newCharacter.clickedWeapons.Contains("Maul"))
            {
                Form1.newCharacter.weapon.Add(maul);
            }
            if (Form1.newCharacter.clickedWeapons.Contains("Morningstar"))
            {
                Form1.newCharacter.weapon.Add(morningstar);
            }
            if (Form1.newCharacter.clickedWeapons.Contains("Pike"))
            {
                Form1.newCharacter.weapon.Add(pike);
            }
            if (Form1.newCharacter.clickedWeapons.Contains("Rapier"))
            {
                Form1.newCharacter.weapon.Add(rapier);
            }
            if (Form1.newCharacter.clickedWeapons.Contains("Scimitar"))
            {
                Form1.newCharacter.weapon.Add(scimitar);
            }
            if (Form1.newCharacter.clickedWeapons.Contains("Shortsword"))
            {
                Form1.newCharacter.weapon.Add(shortsword);
            }
            if (Form1.newCharacter.clickedWeapons.Contains("Trident"))
            {
                Form1.newCharacter.weapon.Add(trident);
            }
            if (Form1.newCharacter.clickedWeapons.Contains("War Pick"))
            {
                Form1.newCharacter.weapon.Add(warpick);
            }
            if (Form1.newCharacter.clickedWeapons.Contains("Warhammer"))
            {
                Form1.newCharacter.weapon.Add(warhammer);
            }
            if (Form1.newCharacter.clickedWeapons.Contains("Whip"))
            {
                Form1.newCharacter.weapon.Add(whip);
            }
            if (Form1.newCharacter.clickedWeapons.Contains("Blowgun"))
            {
                Form1.newCharacter.weapon.Add(blowgun);
            }
            if (Form1.newCharacter.clickedWeapons.Contains("Hand Crossbow"))
            {
                Form1.newCharacter.weapon.Add(handCB);
            }
            if (Form1.newCharacter.clickedWeapons.Contains("Heavy Crossbow "))
            {
                Form1.newCharacter.weapon.Add(heavyCB);
            }
            if (Form1.newCharacter.clickedWeapons.Contains("Longbow"))
            {
                Form1.newCharacter.weapon.Add(longbow);
            }

            #endregion 

            foreach (weapons w in Form1.newCharacter.weapon)
            {
                weapBox.Text += "\n" + w.name + "            ";
                weapBox.Text += "+" + w.atkBonus + "             ";
                weapBox.Text += w.damage + "\n";
                weapBox.Text += "\n";
            }
            #endregion
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            Form1.charList.Add(Form1.newCharacter);


            //XmlWriter writer = XmlWriter.Create("DnDCreator/Character.xml");

            ////Write the root element
            //writer.WriteStartElement("Character");

           

            //foreach ( Character c in Form1.charList)
            //{
            //    //Start an element
            //    writer.WriteStartElement("Name", Form1.newCharacter.name);

            //    //Write sub-elements
            //    writer.WriteElementString("race", Form1.newCharacter.race);
            //    writer.WriteElementString("class", Form1.newCharacter.type);
            //    writer.WriteElementString("backgraound", Form1.newCharacter.background);
            //    writer.WriteElementString("strength", Convert.ToString(Form1.newCharacter.strength));
            //    writer.WriteElementString("dexterity", Convert.ToString(Form1.newCharacter.dexterity));
            //    writer.WriteElementString("constitution", Convert.ToString(Form1.newCharacter.constitution));
            //    writer.WriteElementString("wisdom", Convert.ToString(Form1.newCharacter.wisdom));
            //    writer.WriteElementString("intelligence", Convert.ToString(Form1.newCharacter.intelligence));
            //    writer.WriteElementString("charisma", Convert.ToString(Form1.newCharacter.charisma));
            //    writer.WriteElementString("armor", Convert.ToString(Form1.newCharacter.armorClass));
            //    writer.WriteElementString("speed", Convert.ToString(Form1.newCharacter.speed));
            //    writer.WriteElementString("hit die", Convert.ToString(Form1.newCharacter.hitDie));
            //    writer.WriteElementString("hit points", Convert.ToString(Form1.newCharacter.hitPoints));
            //    writer.WriteElementString("str mod", Convert.ToString(Form1.newCharacter.strMod));
            //    writer.WriteElementString("dex mod", Convert.ToString(Form1.newCharacter.dexMod));
            //    writer.WriteElementString("const mod", Convert.ToString(Form1.newCharacter.constMod));
            //    writer.WriteElementString("wis mod", Convert.ToString(Form1.newCharacter.wisMod));
            //    writer.WriteElementString("int mod", Convert.ToString(Form1.newCharacter.intMod));
            //    writer.WriteElementString("cha mod", Convert.ToString(Form1.newCharacter.chaMod));
            //    writer.WriteElementString("proficiency", Convert.ToString(Form1.newCharacter.proficiency));
            //    writer.WriteElementString("str st", Convert.ToString(Form1.newCharacter.strST));
            //    writer.WriteElementString("dex ST", Convert.ToString(Form1.newCharacter.dexST));
            //    writer.WriteElementString("const ST", Convert.ToString(Form1.newCharacter.constST));
            //    writer.WriteElementString("wis ST", Convert.ToString(Form1.newCharacter.wisST));
            //    writer.WriteElementString("int ST", Convert.ToString(Form1.newCharacter.intST));
            //    writer.WriteElementString("cha ST", Convert.ToString(Form1.newCharacter.chaST));
            //    for (int i = 0; i < Form1.newCharacter.skills.Count; i++)
            //    {
            //        writer.WriteElementString("skills", Convert.ToString(Form1.newCharacter.skills));
            //    }
            //    for (int i = 0; i < Form1.newCharacter.equipment.Count; i++)
            //    {
            //        writer.WriteElementString("equipment", Convert.ToString(Form1.newCharacter.equipment));
            //    }
            //    for (int i = 0; i < Form1.newCharacter.languages.Count; i++)
            //    {
            //        writer.WriteElementString("languages", Convert.ToString(Form1.newCharacter.languages));
            //    }
            //    for (int i = 0; i < Form1.newCharacter.proficiencies.Count; i++)
            //    {
            //        writer.WriteElementString("proficiencies", Convert.ToString(Form1.newCharacter.proficiencies));
            //    }
            //    for (int i = 0; i < Form1.newCharacter.traits.Count; i++)
            //    {
            //        writer.WriteElementString("traits", Convert.ToString(Form1.newCharacter.traits));
            //    }
            //    foreach (weapons w in Form1.newCharacter.weapon)
            //    {
            //        writer.WriteElementString("weapons", Convert.ToString(Form1.newCharacter.weapon));
            //    }

            //}
            //// end the root element
            //writer.WriteEndElement();

            ////Write the XML to file and close the writer
            //writer.Close();

            Form f = this.FindForm();
            f.Controls.Remove(this);
            charScreen0 cs0 = new charScreen0();
            f.Controls.Add(cs0);
        }
    }
}
