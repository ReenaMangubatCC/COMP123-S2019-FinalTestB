using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
/*
 * STUDENT NAME: Reena Mangubat
 * STUDENT ID: 301000701
 * DESCRIPTION: This is the CharacterGeneratorForm - the main form of the application.
 * 
 */
namespace COMP123_S2019_FinalTestB.Views
{
    public partial class CharacterGeneratorForm : MasterForm
    {
        public CharacterGeneratorForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for the BackButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void BackButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }
        }
        /// <summary>
        /// This is the event handler for the NextButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
            {
                MainTabControl.SelectedIndex++;
            }
        }

        /// <summary>
        /// This is a method to load all of the names by reading the existing name text files
        /// </summary>
        public static void LoadNames()
        {
            string firstNamesFile = @"..\..\Data\firstNames.txt";
            string lastNamesFile = @"..\..\Data\lastNames.txt";


            using (StreamReader allFirstNames = new StreamReader(firstNamesFile, FileMode.Open))
            {
                Program.character.FirstName = allFirstNames.ReadLine();
                //Cleanup
                allFirstNames.Dispose();
                allFirstNames.Close();

            }

            using (StreamReader allLastNames = new StreamReader(lastNamesFile))
            {
                Program.character.LastName = allLastNames.ReadLine();

                allLastNames.Dispose();
                allLastNames.Close();
            }


        }

        /// <summary>
        /// This is a method to generate a full name using the previously read files
        /// </summary>
        public static void GenerateNames()
        {
            List<string> FirstName = new List<string>();
            List<string> LastName = new List<string>();

            FirstName.Add(Program.character.FirstName);
            LastName.Add(Program.character.LastName);


        }

        /// <summary>
        /// This is the event handler for the GenerateNameButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateNameButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This is the event handler for the GenerateAbilities click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateAbilitiesButton_Click(object sender, EventArgs e)
        { 

            Random strengthAbility = new Random();
            Random dexterityAbility =  new Random();
            Random constitutionAbility = new Random();
            Random intelligenceAbility = new Random();
            Random wisdomAbility = new Random();
            Random charismaAbility = new Random();

            StrengthDataLabel.Text = strengthAbility.Next(3, 18).ToString();
            DexterityDataLabel.Text = dexterityAbility.Next(3, 18).ToString();
            ConstitutionDataLabel.Text = constitutionAbility.Next(3, 18).ToString();
            IntelligenceDataLabel.Text = intelligenceAbility.Next(3, 18).ToString();
            WisdomDataLabel.Text = wisdomAbility.Next(3, 18).ToString();
            CharismaDataLabel.Text = charismaAbility.Next(3, 18).ToString();
        }
        /// <summary>
        /// This is the event handler for the generateInventoryButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateInventoryButton_Click(object sender, EventArgs e)
        {
            string inventoryFileName = @"..\..\Data\inventory.txt";
           
            using(StreamReader inventoryItems = new StreamReader(inventoryFileName))
            {
               
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
