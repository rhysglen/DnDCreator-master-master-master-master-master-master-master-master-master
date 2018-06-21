using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDCreator.Screens
{
    public partial class CharScreen4 : UserControl
    {
        public CharScreen4()
        {
            InitializeComponent();

            // // equipment screen set up 
            if (Form1.newCharacter.type == "Barbarian")
            {
                primary1Button.Enabled = true;
                primary1Button.Visible = true;
                second2Button.Visible = true;
                second2Button.Enabled = true;
                primary2Button.Visible = true;
                primary2Button.Enabled = true;
                second1Button.Enabled = true;
                second1Button.Visible = true;

                primary1Button.Text = "A Greataxe";
                primary2Button.Text = "Any Martial Weapon";

                second1Button.Text = "Two Handaxes";
                second2Button.Text = "Any Simple Weapon";
            }

            // Character.clickedWeapons.Add(primary2Box.Text);

            // Character.clickedWeapons.Add(second2Box.Text);

            if (Form1.newCharacter.type == "Bard")
            {

                primary1Button.Enabled = true;
                primary1Button.Visible = true;
                second2Button.Visible = true;
                second2Button.Enabled = true;
                primary2Button.Visible = true;
                primary2Button.Enabled = true;
                second1Button.Enabled = true;
                second1Button.Visible = true;
                primary3Button.Enabled = true;
                primary3Button.Visible = true;
                other1Button.Visible = true;
                other1Button.Enabled = true;
                other2Button.Visible = true;
                other2Button.Enabled = true;

                primary1Button.Text = "A Rapier";
                primary2Button.Text = "A Longsword";
                primary3Button.Text = "Any Simple Weapon";

                second1Button.Text = "Diplomat's Pack";
                second2Button.Text = "Entertainer's Pack";

                other1Button.Text = "A Lute";
                other2Button.Text = "Any Musical Instrument";
            }

            else if (Form1.newCharacter.type == "Cleric")
            {
                primary1Button.Enabled = true;
                primary1Button.Visible = true;
                second2Button.Visible = true;
                second2Button.Enabled = true;
                primary2Button.Visible = true;
                primary2Button.Enabled = true;
                second1Button.Enabled = true;
                second1Button.Visible = true;
                primary3Button.Enabled = true;
                primary3Button.Visible = true;
                other1Button.Visible = true;
                other1Button.Enabled = true;
                other2Button.Visible = true;
                other2Button.Enabled = true;
                armor1Button.Visible = true;
                armor1Button.Enabled = true;
                armor2Button.Enabled = true;
                armor2Button.Visible = true;

                primary1Button.Text = "A Mace";
                primary2Button.Text = "A WarHammer (Only if Proficient)";

                second1Button.Text = "Light Crossbow + 20 Bolts";
                second2Button.Text = "Any Simple Weapon";

                armor1Button.Text = "Scale Mail";
                armor2Button.Text = "Leather Armor";

                other1Button.Text = "A Priest's Pack";
                other2Button.Text = "An Explorer's Pack";
                if (Form1.newCharacter.proficiencies.Contains("Martial Weapons"))
                {
                    primary2Button.Enabled = true;
                }
                else
                {
                    primary2Button.Enabled = false;
                }   
            }
            else if (Form1.newCharacter.type == "Druid")
            {

                primary1Button.Enabled = true;
                primary1Button.Visible = true;
                primary2Button.Enabled = true;
                primary2Button.Visible = true;
                second1Button.Enabled = true;
                second2Button.Enabled = true;
                second1Button.Visible = true;
                second2Button.Visible = true;

                primary1Button.Text = "A Wooden Shield";
                primary2Button.Text = "Any Simple Weapon";
                second1Button.Text = "A Scimitar";
                second2Button.Text = "Any Simple Melee Weapon";

            }
            else if (Form1.newCharacter.type == "Fighter")
            {
                primary1Button.Enabled = true;
                primary1Button.Visible = true;
                second2Button.Visible = true;
                second2Button.Enabled = true;
                primary2Button.Visible = true;
                primary2Button.Enabled = true;
                second1Button.Enabled = true;
                second1Button.Visible = true;
                other1Button.Visible = true;
                other1Button.Enabled = true;
                other2Button.Visible = true;
                other2Button.Enabled = true;
                armor1Button.Visible = true;
                armor1Button.Enabled = true;
                armor2Button.Enabled = true;
                armor2Button.Visible = true;

                primary1Button.Text = "A Martial Weapon + Shield";
                primary2Button.Text = "Two Martial Weapons";

                second1Button.Text = "Light Crossbow + 20 Bolts";
                second2Button.Text = "2 Handaxes";

                armor1Button.Text = "Chain Mail";
                armor2Button.Text = "Leather Armor + Longbow";

                other1Button.Text = "Dungeoneer's Pack";
                other2Button.Text = "An Explorer's Pack";

            }
            else if (Form1.newCharacter.type == "Monk")
            {

                primary1Button.Enabled = true;
                primary1Button.Visible = true;
                second2Button.Visible = true;
                second2Button.Enabled = true;
                primary2Button.Visible = true;
                primary2Button.Enabled = true;
                second1Button.Enabled = true;
                second1Button.Visible = true;

                primary1Button.Text = "A Shortsword";
                primary2Button.Text = "A Simple Weapon";

                second1Button.Text = "Dungeoneer's Pack";
                second2Button.Text = "Explorer's Pack";

            }
            else if (Form1.newCharacter.type == "Paladin")
            {
                primary1Button.Enabled = true;
                primary1Button.Visible = true;
                second2Button.Visible = true;
                second2Button.Enabled = true;
                primary2Button.Visible = true;
                primary2Button.Enabled = true;
                second1Button.Enabled = true;
                second1Button.Visible = true;
                other1Button.Visible = true;
                other1Button.Enabled = true;
                other2Button.Visible = true;
                other2Button.Enabled = true;
                
                primary1Button.Text = "A Martial Weapon + Shield";
                primary2Button.Text = "Two Martial Weapons";

                second1Button.Text = "5 Javelin";
                second2Button.Text = "Any Simple weapon";
                
                other1Button.Text = "Priest's Pack";
                other2Button.Text = "An Explorer's Pack";

            }
            else if (Form1.newCharacter.type == "Ranger")
            {
                primary1Button.Enabled = true;
                primary1Button.Visible = true;
                armor2Button.Visible = true;
                armor2Button.Enabled = true;
                primary2Button.Visible = true;
                primary2Button.Enabled = true;
                armor1Button.Enabled = true;
                armor1Button.Visible = true;
                other1Button.Visible = true;
                other1Button.Enabled = true;
                other2Button.Visible = true;
                other2Button.Enabled = true;
               
               primary1Button.Text = "2 Shortsword";
                primary2Button.Text = "Two Simple Melee Weapons";

                armor1Button.Text = "Scale Mail";
                armor2Button.Text = "Leather Armor";

                other1Button.Text = "Dungeoneer's Pack";
                other2Button.Text = "An Explorer's Pack";
            }
            else if (Form1.newCharacter.type == "Rogue")
            {
                primary1Button.Enabled = true;
                primary1Button.Visible = true;
                second2Button.Visible = true;
                second2Button.Enabled = true;
                primary2Button.Visible = true;
                primary2Button.Enabled = true;
                second1Button.Enabled = true;
                second1Button.Visible = true;
                other1Button.Visible = true;
                other1Button.Enabled = true;
                other2Button.Visible = true;
                other2Button.Enabled = true;
                other3Button.Visible = true;
                other3Button.Enabled = true;
                
                primary1Button.Text = "A Rapier";
                primary2Button.Text = "A Shortsword";

                second1Button.Text = "Shortbow";
                second2Button.Text = "A Shortsword";
                
                other1Button.Text = "Burglar's Pack";
                other2Button.Text = "A Dungeoneer's Pack";
                other3Button.Text = "An Explorer's Pack";
            }
            else if (Form1.newCharacter.type == "Sorcerer")
            {
                primary1Button.Enabled = true;
                primary1Button.Visible = true;
                second2Button.Visible = true;
                second2Button.Enabled = true;
                primary2Button.Visible = true;
                primary2Button.Enabled = true;
                second1Button.Enabled = true;
                second1Button.Visible = true;
                other1Button.Visible = true;
                other1Button.Enabled = true;
                other2Button.Visible = true;
                other2Button.Enabled = true;
                
                primary1Button.Text = "A Light Crossbow";
                primary2Button.Text = "Any Simple Weapon";

                second1Button.Text = "Arcane Focus";
                second2Button.Text = "Component Pounch";
                
                other1Button.Text = "A Dungeoneer's Pack";
                other2Button.Text = "An Explorer's Pack";

            }
            else if (Form1.newCharacter.type == "Warlock")
            {
                primary1Button.Enabled = true;
                primary1Button.Visible = true;
                second2Button.Visible = true;
                second2Button.Enabled = true;
                primary2Button.Visible = true;
                primary2Button.Enabled = true;
                second1Button.Enabled = true;
                second1Button.Visible = true;
                other1Button.Visible = true;
                other1Button.Enabled = true;
                other2Button.Visible = true;
                other2Button.Enabled = true;
                
                primary1Button.Text = "A Light Crossbow";
                primary2Button.Text = "Any Simple Weapon";

                second1Button.Text = "Arcane Focus";
                second2Button.Text = "Component Pounch";
                
                other1Button.Text = "A Dungeoneer's Pack";
                other2Button.Text = "An Scholar's Pack";
            }
            else if (Form1.newCharacter.type == "Wizard")
            {
                primary1Button.Enabled = true;
                primary1Button.Visible = true;
                second2Button.Visible = true;
                second2Button.Enabled = true;
                primary2Button.Visible = true;
                primary2Button.Enabled = true;
                second1Button.Enabled = true;
                second1Button.Visible = true;
                other1Button.Visible = true;
                other1Button.Enabled = true;
                other2Button.Visible = true;
                other2Button.Enabled = true;
                
                primary1Button.Text = "A Quarterstaff";
                primary2Button.Text = "A Dagger";

                second1Button.Text = "Arcane Focus";
                second2Button.Text = "Component Pounch";
                
                other1Button.Text = "An Explorer 's Pack";
                other2Button.Text = "A Scholar's Pack";
            }

        }
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
        weapons Halberd = new weapons("Halberd", Form1.newCharacter.strMod + Form1.newCharacter.proficiency, "1d10 Slashing");
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
        // button presses
        private void primary1Button_CheckedChanged(object sender, EventArgs e)
        {
            if (primary1Button.Checked && Form1.newCharacter.type == "Barbarian")
            {
                Form1.newCharacter.weapon.Add(greataxe);
            }
           else if (primary1Button.Checked && Form1.newCharacter.type == "Monk")
            {
                Form1.newCharacter.weapon.Add(shortsword);
            }
             else if (primary1Button.Checked && Form1.newCharacter.type == "Sorcerer")
            {
                Form1.newCharacter.weapon.Add(lightCB);
                Form1.newCharacter.equipment.Add("20 Bolts");
                
            }
            else if (primary1Button.Checked && Form1.newCharacter.type == "Warlock")
            {
                Form1.newCharacter.weapon.Add(lightCB);
                Form1.newCharacter.equipment.Add("20 Bolts");
                
            }
             else if (primary1Button.Checked && Form1.newCharacter.type == "Ranger")
            {
                Form1.newCharacter.weapon.Add(shortsword);
                Form1.newCharacter.weapon.Add(shortsword);
            }
            else if (primary1Button.Checked && Form1.newCharacter.type == "Bard")
            {
                Form1.newCharacter.weapon.Add(rapier);
            }
              else if (primary1Button.Checked && Form1.newCharacter.type == "Rogue")
            {
                Form1.newCharacter.weapon.Add(rapier);
            }
           else if (primary1Button.Checked && Form1.newCharacter.type == "Cleric")
            {
                Form1.newCharacter.weapon.Add(mace);
            }
            else if (primary1Button.Checked && Form1.newCharacter.type == "Wizard")
            {
                Form1.newCharacter.weapon.Add(quarterstaff);
            }
            else if (primary1Button.Checked && Form1.newCharacter.type == "Druid")
            {
                Form1.newCharacter.equipment.Add("Wooden Shield");
            }
            else if (primary1Button.Checked && Form1.newCharacter.type == "Fighter")
            {
                Form1.newCharacter.equipment.Add("Shield");

                primary1Box.Enabled = true;
                primary1Box.Visible = true;
                primary1Box.Items.Add("Flail");
                primary1Box.Items.Add("Glaive");
                primary1Box.Items.Add("Battleaxe");
                primary1Box.Items.Add("Greatsword");
                primary1Box.Items.Add("Halberd");
                primary1Box.Items.Add("Lance");
                primary1Box.Items.Add("Longsword");
                primary1Box.Items.Add("Maul");
                primary1Box.Items.Add("Morningstar");
                primary1Box.Items.Add("Pike");
                primary1Box.Items.Add("Rapier");
                primary1Box.Items.Add("Scimitar");
                primary1Box.Items.Add("Shortsword");
                primary1Box.Items.Add("Trident");
                primary1Box.Items.Add("War Pick");
                primary1Box.Items.Add("Warhammer");
                primary1Box.Items.Add("Whip");


            }
                 else if (primary1Button.Checked && Form1.newCharacter.type == "Paladin")
            {
                Form1.newCharacter.equipment.Add("Shield");

                primary1Box.Enabled = true;
                primary1Box.Visible = true;
                primary1Box.Items.Add("Flail");
                primary1Box.Items.Add("Glaive");
                primary1Box.Items.Add("Battleaxe");
                primary1Box.Items.Add("Greatsword");
                primary1Box.Items.Add("Halberd");
                primary1Box.Items.Add("Lance");
                primary1Box.Items.Add("Longsword");
                primary1Box.Items.Add("Maul");
                primary1Box.Items.Add("Morningstar");
                primary1Box.Items.Add("Pike");
                primary1Box.Items.Add("Rapier");
                primary1Box.Items.Add("Scimitar");
                primary1Box.Items.Add("Shortsword");
                primary1Box.Items.Add("Trident");
                primary1Box.Items.Add("War Pick");
                primary1Box.Items.Add("Warhammer");
                primary1Box.Items.Add("Whip");


            }
        }
            private void primary2Button_CheckedChanged(object sender, EventArgs e)
            {
            if (primary2Button.Checked && Form1.newCharacter.type == "Barbarian")
            {

                primary2Box.Enabled = true;
                primary2Box.Visible = true;

                primary2Box.Items.Add("Flail");
                primary2Box.Items.Add("Glaive");
                primary2Box.Items.Add("Battleaxe");
                primary2Box.Items.Add("Greatsword");
                primary2Box.Items.Add("Halberd");
                primary2Box.Items.Add("Lance");
                primary2Box.Items.Add("Longsword");
                primary2Box.Items.Add("Maul");
                primary2Box.Items.Add("Morningstar");
                primary2Box.Items.Add("Pike");
                primary2Box.Items.Add("Rapier");
                primary2Box.Items.Add("Scimitar");
                primary2Box.Items.Add("Shortsword");
                primary2Box.Items.Add("Trident");
                primary2Box.Items.Add("War Pick");
                primary2Box.Items.Add("Warhammer");
                primary2Box.Items.Add("Whip");


            }
            else if (primary2Button.Checked && Form1.newCharacter.type == "Fighter")
            {
               

                primary2Box.Enabled = true;
                primary2Box.Visible = true;

                primary2Box.Items.Add("Flail");
                primary2Box.Items.Add("Glaive");
                primary2Box.Items.Add("Battleaxe");
                primary2Box.Items.Add("Greatsword");
                primary2Box.Items.Add("Halberd");
                primary2Box.Items.Add("Lance");
                primary2Box.Items.Add("Longsword");
                primary2Box.Items.Add("Maul");
                primary2Box.Items.Add("Morningstar");
                primary2Box.Items.Add("Pike");
                primary2Box.Items.Add("Rapier");
                primary2Box.Items.Add("Scimitar");
                primary2Box.Items.Add("Shortsword");
                primary2Box.Items.Add("Trident");
                primary2Box.Items.Add("War Pick");
                primary2Box.Items.Add("Warhammer");
                primary2Box.Items.Add("Whip");


            }
              else if (primary2Button.Checked && Form1.newCharacter.type == "Paladin")
            {
               

                primary2Box.Enabled = true;
                primary2Box.Visible = true;

                primary2Box.Items.Add("Flail");
                primary2Box.Items.Add("Glaive");
                primary2Box.Items.Add("Battleaxe");
                primary2Box.Items.Add("Greatsword");
                primary2Box.Items.Add("Halberd");
                primary2Box.Items.Add("Lance");
                primary2Box.Items.Add("Longsword");
                primary2Box.Items.Add("Maul");
                primary2Box.Items.Add("Morningstar");
                primary2Box.Items.Add("Pike");
                primary2Box.Items.Add("Rapier");
                primary2Box.Items.Add("Scimitar");
                primary2Box.Items.Add("Shortsword");
                primary2Box.Items.Add("Trident");
                primary2Box.Items.Add("War Pick");
                primary2Box.Items.Add("Warhammer");
                primary2Box.Items.Add("Whip");


            }
            else if (primary2Button.Checked && Form1.newCharacter.type == "Bard")
            {
                Form1.newCharacter.weapon.Add(longsword);
            }
             else if (primary2Button.Checked && Form1.newCharacter.type == "Rogue")
            {
                Form1.newCharacter.weapon.Add(shortsword);
            }
            else if (primary2Button.Checked && Form1.newCharacter.type == "Cleric")
            {
                Form1.newCharacter.weapon.Add(warhammer);
            }
            else if (primary2Button.Checked && Form1.newCharacter.type == "Wizard")
            {
                Form1.newCharacter.weapon.Add(dagger);
            }
            else if (primary2Button.Checked && Form1.newCharacter.type == "Druid")
            {
                primary2Box.Visible = true;
                primary2Box.Enabled = true;

                primary2Box.Items.Add("Club");
                primary2Box.Items.Add("Dagger");
                primary2Box.Items.Add("Greatclub");
                primary2Box.Items.Add("Handaxe");
                primary2Box.Items.Add("Javelin");
                primary2Box.Items.Add("Light Hammer");
                primary2Box.Items.Add("Mace");
                primary2Box.Items.Add("Quarterstaff");
                primary2Box.Items.Add("Sickle");
                primary2Box.Items.Add("Spear");
                primary2Box.Items.Add("Rapier");
                primary2Box.Items.Add("Light Crossbow");
                primary2Box.Items.Add("Dart");
                primary2Box.Items.Add("Shortbow");
                primary2Box.Items.Add("Sling");
            }
            else if (primary2Button.Checked && Form1.newCharacter.type == "Sorcerer")
            {
                primary2Box.Visible = true;
                primary2Box.Enabled = true;

                primary2Box.Items.Add("Club");
                primary2Box.Items.Add("Dagger");
                primary2Box.Items.Add("Greatclub");
                primary2Box.Items.Add("Handaxe");
                primary2Box.Items.Add("Javelin");
                primary2Box.Items.Add("Light Hammer");
                primary2Box.Items.Add("Mace");
                primary2Box.Items.Add("Quarterstaff");
                primary2Box.Items.Add("Sickle");
                primary2Box.Items.Add("Spear");
                primary2Box.Items.Add("Rapier");
                primary2Box.Items.Add("Light Crossbow");
                primary2Box.Items.Add("Dart");
                primary2Box.Items.Add("Shortbow");
                primary2Box.Items.Add("Sling");
            }
              else if (primary2Button.Checked && Form1.newCharacter.type == "Warlock")
            {
                primary2Box.Visible = true;
                primary2Box.Enabled = true;

                primary2Box.Items.Add("Club");
                primary2Box.Items.Add("Dagger");
                primary2Box.Items.Add("Greatclub");
                primary2Box.Items.Add("Handaxe");
                primary2Box.Items.Add("Javelin");
                primary2Box.Items.Add("Light Hammer");
                primary2Box.Items.Add("Mace");
                primary2Box.Items.Add("Quarterstaff");
                primary2Box.Items.Add("Sickle");
                primary2Box.Items.Add("Spear");
                primary2Box.Items.Add("Rapier");
                primary2Box.Items.Add("Light Crossbow");
                primary2Box.Items.Add("Dart");
                primary2Box.Items.Add("Shortbow");
                primary2Box.Items.Add("Sling");
            }
            else if (primary2Button.Checked && Form1.newCharacter.type == "Monk")
            {
                primary2Box.Visible = true;
                primary2Box.Enabled = true;

                primary2Box.Items.Add("Club");
                primary2Box.Items.Add("Dagger");
                primary2Box.Items.Add("Greatclub");
                primary2Box.Items.Add("Handaxe");
                primary2Box.Items.Add("Javelin");
                primary2Box.Items.Add("Light Hammer");
                primary2Box.Items.Add("Mace");
                primary2Box.Items.Add("Quarterstaff");
                primary2Box.Items.Add("Sickle");
                primary2Box.Items.Add("Spear");
                primary2Box.Items.Add("Rapier");
                primary2Box.Items.Add("Light Crossbow");
                primary2Box.Items.Add("Dart");
                primary2Box.Items.Add("Shortbow");
                primary2Box.Items.Add("Sling");
            }
               else if (primary2Button.Checked && Form1.newCharacter.type == "Ranger")
            {
                primary2Box.Visible = true;
                primary2Box.Enabled = true;

                primary2Box.Items.Add("Club");
                primary2Box.Items.Add("Dagger");
                primary2Box.Items.Add("Greatclub");
                primary2Box.Items.Add("Handaxe");
                primary2Box.Items.Add("Javelin");
                primary2Box.Items.Add("Light Hammer");
                primary2Box.Items.Add("Mace");
                primary2Box.Items.Add("Quarterstaff");
                primary2Box.Items.Add("Sickle");
                primary2Box.Items.Add("Spear");
                primary2Box.Items.Add("Rapier");
            }
        }

            private void primary3Button_CheckedChanged(object sender, EventArgs e)
        {
              if (primary3Button.Checked && Form1.newCharacter.type == "Bard")
            {
                primary3Box.Visible = true;
                primary3Box.Enabled = true;

                primary3Box.Items.Add("Club");
                primary3Box.Items.Add("Dagger");
                primary3Box.Items.Add("Greatclub");
                primary3Box.Items.Add("Handaxe");
                primary3Box.Items.Add("Javelin");
                primary3Box.Items.Add("Light Hammer");
                primary3Box.Items.Add("Mace");
                primary3Box.Items.Add("Quarterstaff");
                primary3Box.Items.Add("Sickle");
                primary3Box.Items.Add("Spear");
                primary3Box.Items.Add("Rapier");
                primary3Box.Items.Add("Light Crossbow");
                primary3Box.Items.Add("Dart");
                primary3Box.Items.Add("Shortbow");
                primary3Box.Items.Add("Sling");
            }
          
        }

            private void second1Button_CheckedChanged(object sender, EventArgs e)
            {
                if (second1Button.Checked && Form1.newCharacter.type == "Barbarian")
                {
                    Form1.newCharacter.weapon.Add(handaxe);
                    Form1.newCharacter.weapon.Add(handaxe);
                }
                else if (second1Button.Checked && Form1.newCharacter.type == "Bard")
                {
                    Form1.newCharacter.equipment.Add("Diplomat's Pack");
                }
                else if (second1Button.Checked && Form1.newCharacter.type == "Cleric")
                {
                     Form1.newCharacter.weapon.Add(lightCB);

                }
                else if (second1Button.Checked && Form1.newCharacter.type == "Palidin")
                {                 
                     weapons javelinx5 = new weapons("Javelin X5", Form1.newCharacter.strMod + Form1.newCharacter.proficiency, "1d6 Piercing");
                }
            else if (second1Button.Checked && Form1.newCharacter.type == "Druid")
            {
                Form1.newCharacter.weapon.Add(scimitar);
            }
                else if (second1Button.Checked && Form1.newCharacter.type == "Fighter")
            {
                Form1.newCharacter.weapon.Add(lightCB);
                Form1.newCharacter.equipment.Add("Bolts x20");
            }
               else if (second1Button.Checked && Form1.newCharacter.type == "Rogue")
            {
                Form1.newCharacter.weapon.Add(shortbow);
                Form1.newCharacter.equipment.Add("Arrows x20");
            }
                 else if (second1Button.Checked && Form1.newCharacter.type == "Sorcerer")
            {
                Form1.newCharacter.equipment.Add("Arcane Focus");
            }
                else if (second1Button.Checked && Form1.newCharacter.type == "Warlock")
            {
                Form1.newCharacter.equipment.Add("Arcane Focus");
            }
                else if (second1Button.Checked && Form1.newCharacter.type == "Wizard")
            {
                Form1.newCharacter.equipment.Add("Arcane Focus");
            }
        }
        }
        }

        private void second2Button_CheckedChanged(object sender, EventArgs e)
            {

            if (second2Button.Checked && Form1.newCharacter.type == "Barbarian")
            {

                second2Box.Enabled = true;
                second2Box.Visible = true;

                second2Box.Items.Add("Club");
                second2Box.Items.Add("Dagger");
                second2Box.Items.Add("Greatclub");
                second2Box.Items.Add("Handaxe");
                second2Box.Items.Add("Javelin");
                second2Box.Items.Add("Light Hammer");
                second2Box.Items.Add("Mace");
                second2Box.Items.Add("Quarterstaff");
                second2Box.Items.Add("Sickle");
                second2Box.Items.Add("Spear");
                second2Box.Items.Add("Rapier");
                second2Box.Items.Add("Light Crossbow");
                second2Box.Items.Add("Dart");
                second2Box.Items.Add("Shortbow");
                second2Box.Items.Add("Sling");
            }
            else if (second2Button.Checked && Form1.newCharacter.type == "Cleric")
            {
                second2Box.Visible = true;
                second2Box.Enabled = true;

                second2Box.Items.Add("Club");
                second2Box.Items.Add("Dagger");
                second2Box.Items.Add("Greatclub");
                second2Box.Items.Add("Handaxe");
                second2Box.Items.Add("Javelin");
                second2Box.Items.Add("Light Hammer");
                second2Box.Items.Add("Mace");
                second2Box.Items.Add("Quarterstaff");
                second2Box.Items.Add("Sickle");
                second2Box.Items.Add("Spear");
                second2Box.Items.Add("Rapier");
                second2Box.Items.Add("Light Crossbow");
                second2Box.Items.Add("Dart");
                second2Box.Items.Add("Shortbow");
                second2Box.Items.Add("Sling");

            }
              else if (second2Button.Checked && Form1.newCharacter.type == "Paladin")
            {
                second2Box.Visible = true;
                second2Box.Enabled = true;

                second2Box.Items.Add("Club");
                second2Box.Items.Add("Dagger");
                second2Box.Items.Add("Greatclub");
                second2Box.Items.Add("Handaxe");
                second2Box.Items.Add("Javelin");
                second2Box.Items.Add("Light Hammer");
                second2Box.Items.Add("Mace");
                second2Box.Items.Add("Quarterstaff");
                second2Box.Items.Add("Sickle");
                second2Box.Items.Add("Spear");
                second2Box.Items.Add("Rapier");
                second2Box.Items.Add("Light Crossbow");
                second2Box.Items.Add("Dart");
                second2Box.Items.Add("Shortbow");
                second2Box.Items.Add("Sling");

            }
            else if (second2Button.Checked && Form1.newCharacter.type == "Fighter")
            {
                Form1.newCharacter.weapon.Add(handaxe);
                Form1.newCharacter.weapon.Add(handaxe);
            }

            else if (second2Button.Checked && Form1.newCharacter.type == "Bard")
            {
                Form1.newCharacter.equipment.Add("Explorer's Pack");
            }
              else if (second2Button.Checked && Form1.newCharacter.type == "Sorcerer")
            {
                Form1.newCharacter.equipment.Add("Component Pounch");
            }
              else if (second2Button.Checked && Form1.newCharacter.type == "Warlock")
            {
                Form1.newCharacter.equipment.Add("Component Pounch");
            }
              else if (second2Button.Checked && Form1.newCharacter.type == "Wizard")
            {
                Form1.newCharacter.equipment.Add("Component Pounch");
            }
            else if (second2Button.Checked && Form1.newCharacter.type == "Druid")
            {
                second2Box.Visible = true;
                second2Box.Enabled = true;

                second2Box.Items.Add("Club");
                second2Box.Items.Add("Dagger");
                second2Box.Items.Add("Greatclub");
                second2Box.Items.Add("Handaxe");
                second2Box.Items.Add("Javelin");
                second2Box.Items.Add("Light Hammer");
                second2Box.Items.Add("Mace");
                second2Box.Items.Add("Quarterstaff");
                second2Box.Items.Add("Sickle");
                second2Box.Items.Add("Spear");
                second2Box.Items.Add("Rapier");
            }
        }

        private void second3Button_CheckedChanged(object sender, EventArgs e)
            {

            }

            private void armor1Button_CheckedChanged(object sender, EventArgs e)
            {
                if (armor1Button.Checked && Form1.newCharacter.type == "Fighter")
                {
                Form1.newCharacter.equipment.Add("Chain Mail");
                }
                else if (armor1Button.Checked && Form1.newCharacter.type == "Ranger")
                {
                Form1.newCharacter.equipment.Add("Scale Mail");
                }
            }

            private void armor2Button_CheckedChanged(object sender, EventArgs e)
            {
            if (armor2Button.Checked && Form1.newCharacter.type == "Fighter")
            {
                Form1.newCharacter.equipment.Add("Leather Armor");
                Form1.newCharacter.weapon.Add(longbow);
                Form1.newCharacter.equipment.Add("Arrows x20");
            }
             elseb if (armor2Button.Checked && Form1.newCharacter.type == "Ranger")
            {
                Form1.newCharacter.equipment.Add("Leather Armor");
            }
        }

            private void other1Button_CheckedChanged(object sender, EventArgs e)
            {

            if (other1Button.Checked && Form1.newCharacter.type == "Bard")
            {
                Form1.newCharacter.equipment.Add("Lute");
            }

            else if (other1Button.Checked && Form1.newCharacter.type == "Cleric")
            {
                Form1.newCharacter.equipment.Add("Priest's Pack");
            }
            
             else if (other1Button.Checked && Form1.newCharacter.type == "Rogue")
            {
                Form1.newCharacter.equipment.Add("Buglars's Pack");
            }
            else if (other1Button.Checked && Form1.newCharacter.type == "Paladin")
            {
                Form1.newCharacter.equipment.Add("Priest's Pack");
            }
    
            else if (other1Button.Checked && Form1.newCharacter.type == "Fighter")
            {
                Form1.newCharacter.equipment.Add("Dungeoneer's Pack");
            }
             else if (other1Button.Checked && Form1.newCharacter.type == "Monk")
            {
                Form1.newCharacter.equipment.Add("Dungeoneer's Pack");
            }
              else if (other1Button.Checked && Form1.newCharacter.type == "Ranger")
            {
                Form1.newCharacter.equipment.Add("Dungeoneer's Pack");
            }
              else if (other1Button.Checked && Form1.newCharacter.type == "Sorcerer")
            {
                Form1.newCharacter.equipment.Add("Dungeoneer's Pack");
            }
              else if (other1Button.Checked && Form1.newCharacter.type == "Warlock")
            {
                Form1.newCharacter.equipment.Add("Scholar's Pack");
            }
              else if (other1Button.Checked && Form1.newCharacter.type == "Wizard")
            {
                Form1.newCharacter.equipment.Add("Scholar's Pack");
            }
        }

            private void other2Button_CheckedChanged(object sender, EventArgs e)
        {

             if (other2Button.Checked && Form1.newCharacter.type == "Bard")
            {
                Form1.newCharacter.equipment.Add("Any Musical Instrument");
            }
            else if (other2Button.Checked && Form1.newCharacter.type == "Fighter")
            {
                Form1.newCharacter.equipment.Add("Explorer's Pack");
            }
                else if (other2Button.Checked && Form1.newCharacter.type == "Fighter")
            {
                Form1.newCharacter.equipment.Add("Dungeoneers's Pack");
            }
               else if (other2Button.Checked && Form1.newCharacter.type == "Warlock")
            {
                Form1.newCharacter.equipment.Add("Dungeoneers's Pack");
            }
             else if (other2Button.Checked && Form1.newCharacter.type == "Paladin")
            {
                Form1.newCharacter.equipment.Add("Explorer's Pack");
            }
                  else if (other2Button.Checked && Form1.newCharacter.type == "Wizard")
            {
                Form1.newCharacter.equipment.Add("Explorer's Pack");
            }
            else if (other2Button.Checked && Form1.newCharacter.type == "Cleric")
            {
                Form1.newCharacter.equipment.Add("Explorer's Pack");
            }
             else if (other2Button.Checked && Form1.newCharacter.type == "Sorcerer")
            {
                Form1.newCharacter.equipment.Add("Explorer's Pack");
            }
             else if (other2Button.Checked && Form1.newCharacter.type == "Monk")
            {
                Form1.newCharacter.equipment.Add("Explorer's Pack");
            }
              else if (other2Button.Checked && Form1.newCharacter.type == "Ranger")
            {
                Form1.newCharacter.equipment.Add("Explorer's Pack");
            }

        }

        private void other3Button_CheckedChanged(object sender, EventArgs e)
            {
                 else if (other3Button.Checked && Form1.newCharacter.type == "Rogue")
                {
                     Form1.newCharacter.equipment.Add("Explorer's Pack");
                }
            }

        private void weapButtonNext_Click(object sender, EventArgs e)
        {
            if (primary1Button.Checked)
            {
                Form1.newCharacter.clickedWeapons.Add(primary1Box.Text);
            }
            else if (primary2Button.Checked)
            {
                Form1.newCharacter.clickedWeapons.Add(primary2Box.Text);
            }
            else if (primary3Button.Checked)
            {
                Form1.newCharacter.clickedWeapons.Add(primary3Box.Text);
            }
            else if (primary2Button.Checked && Form1.newCharacter.type == "Fighter")
            {
                Form1.newCharacter.clickedWeapons.Add(primary2Box.Text);
                Form1.newCharacter.clickedWeapons.Add(primary2Box.Text);
            }
            else if (primary2Button.Checked && Form1.newCharacter.type == "Paladin")
            {
                Form1.newCharacter.clickedWeapons.Add(primary2Box.Text);
                Form1.newCharacter.clickedWeapons.Add(primary2Box.Text);
            }
            else if (primary2Button.Checked && Form1.newCharacter.type == "Ranger")
            {
                Form1.newCharacter.clickedWeapons.Add(primary2Box.Text);
                Form1.newCharacter.clickedWeapons.Add(primary2Box.Text);
            }

            if (second1Button.Checked)
            {
                Form1.newCharacter.clickedWeapons.Add(second1Box.Text);
            }
            else if (second2Button.Checked)
            {
                Form1.newCharacter.clickedWeapons.Add(second2Box.Text);
            }
            else if (second3Button.Checked)
            {
                Form1.newCharacter.clickedWeapons.Add(second3Box.Text);
            }

          
            Form f = this.FindForm();
            f.Controls.Remove(this);
            charScreen5 cs5 = new charScreen5();
            f.Controls.Add(cs5);
        }
    }
    }

