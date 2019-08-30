using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterGenerator
{
    public partial class formCharSheet : Form
    {
        public int noOfDice;
        public int sidedDice;
        public int diceTotal;

        public formCharSheet()
        {
            InitializeComponent();                      
        }

        public void ButtonGenerate_Click(object sender, EventArgs e)
        {
            // for strength
            diceTotal = 0;
            Int32.TryParse(comboBoxDiceNumStr.Text, out noOfDice);
            Int32.TryParse(comboBoxDiceTypeStr.Text, out sidedDice);
            GenerateRandomValue(noOfDice, sidedDice);
            textStr.Text = diceTotal.ToString();

            // for dexterity
            diceTotal = 0;
            Int32.TryParse(comboBoxDiceNumDex.Text, out noOfDice);
            Int32.TryParse(comboBoxDiceTypeDex.Text, out sidedDice);
            GenerateRandomValue(noOfDice, sidedDice);
            textDex.Text = diceTotal.ToString();

            // for constitution
            diceTotal = 0;
            Int32.TryParse(comboBoxDiceNumCon.Text, out noOfDice);
            Int32.TryParse(comboBoxDiceTypeCon.Text, out sidedDice);
            GenerateRandomValue(noOfDice, sidedDice);
            textCon.Text = diceTotal.ToString();

            // for intelligence
            diceTotal = 0;
            Int32.TryParse(comboBoxDiceNumInt.Text, out noOfDice);
            Int32.TryParse(comboBoxDiceTypeInt.Text, out sidedDice);
            GenerateRandomValue(noOfDice, sidedDice);
            textInt.Text = diceTotal.ToString();

            // for wisdom
            diceTotal = 0;
            Int32.TryParse(comboBoxDiceNumWis.Text, out noOfDice);
            Int32.TryParse(comboBoxDiceTypeWis.Text, out sidedDice);
            GenerateRandomValue(noOfDice, sidedDice);
            textWis.Text = diceTotal.ToString();

            // for charisma
            diceTotal = 0;
            Int32.TryParse(comboBoxDiceNumCha.Text, out noOfDice);
            Int32.TryParse(comboBoxDiceTypeCha.Text, out sidedDice);
            GenerateRandomValue(noOfDice, sidedDice);
            textCha.Text = diceTotal.ToString();

            // for hit points
            diceTotal = 0;
            Int32.TryParse(comboBoxDiceNumHP.Text, out noOfDice);
            Int32.TryParse(comboBoxDiceTypeHP.Text, out sidedDice);
            GenerateRandomValue(noOfDice, sidedDice);
            textHP.Text = diceTotal.ToString();

        }

        public int GenerateRandomValue(int noOfDice, int sidedDice)
        {
            Random randNum = new Random();
            for (int i = 0; i < noOfDice; i++)
            {
                diceTotal += randNum.Next(1, sidedDice + 1); // in random the min value is inclusive but the max value is exclusive so we add one
            }
            return diceTotal;
        }
    }
}
