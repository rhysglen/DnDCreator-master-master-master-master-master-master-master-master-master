﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDCreator
{
    public partial class Form1 : Form
    {
        public static Character newCharacter;
        public static List<Character> charList = new List<Character>();


        public Form1()
        {
            InitializeComponent();

            newCharacter = new Character();
            Form f = this.FindForm();
            f.Controls.Remove(this);
            DnDCreator.Screens.charScreen0 cs0 = new DnDCreator.Screens.charScreen0();
            f.Controls.Add(cs0);

        }
    }
}
