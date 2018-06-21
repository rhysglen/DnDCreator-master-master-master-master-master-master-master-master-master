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
    public partial class charScreen0 : UserControl
    {
        public charScreen0()
        {
            InitializeComponent();

           // XmlReader reader = XmlReader.Create("DndCreator/Character.xml");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            charScreen1 cs1 = new charScreen1();
            f.Controls.Add(cs1);
        }
    }
}
