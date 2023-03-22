using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGame
{
    public partial class Form1 : Form
    {
        private bool isCharacterSheetOpen = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void characterButton_Click(object sender, EventArgs e)
        {
            if (isCharacterSheetOpen)
            {
                CharacterSheet form2 = Application.OpenForms.OfType<CharacterSheet>().FirstOrDefault();
                if(form2 != null)
                {
                    form2.Close();
                }
                isCharacterSheetOpen = false;
            }
            else
            {
                CharacterSheet form2 = new CharacterSheet();
                form2.Show();
                isCharacterSheetOpen = true;
            }
            
        }

        private void attackButton_Click(object sender, EventArgs e)
        {
            CharacterSheet form2 = Application.OpenForms.OfType<CharacterSheet>().FirstOrDefault();
            if(form2 != null)
            {
                Player player = new Player();
                player.Health -= 10;
                form2.UpdatePlayerInfo(player.Health);
                
            }
        }
    }
}
