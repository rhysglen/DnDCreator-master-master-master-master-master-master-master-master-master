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
    public partial class charScreen5 : UserControl
    {
       public string nameVar;

        public charScreen5()
        {
            InitializeComponent();
        }

        private void nameNextButton_Click(object sender, EventArgs e)
        {
            nameVar = nameBox.Text;
            Form1.newCharacter.name = nameVar;
            Form f = this.FindForm();
            f.Controls.Remove(this);
            finalScreen f1 = new finalScreen();
            f.Controls.Add(f1);
        }

        private void nameBackButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            charScreen6 cs6 = new charScreen6();
            f.Controls.Add(cs6);
        }
    }
}
