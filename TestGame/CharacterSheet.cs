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
    public partial class CharacterSheet : Form
    {

        public Player player = new Player();
        public CharacterSheet()
        {
            InitializeComponent();

            characterName.Text = player.Name;
            characterClass.Text = player.PClass;
            characterLevel.Text = player.Level.ToString();
            characterStrength.Text = player.Strength.ToString();
            characterHealth.Text = player.Health.ToString();
            characterMana.Text = player.Mana.ToString();
            characterExp.Text = player.Experience.ToString();
        }

        public void UpdatePlayerInfo(int playerHealth)
        {
            characterHealth.Text = playerHealth.ToString();
        }

        
    }
}
