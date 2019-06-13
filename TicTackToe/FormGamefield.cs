using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTackToe
{
    public partial class FormGamefield : Form
    {
        //################################### Membervariables ##############################################
        #region Membervariables

        private int mintGametimeInSec = 0;
        private int mintTurn = 0; //0 = Player 1 - X  |  1 = Player 2 - O
        private int mintVictoryPlayer = 0;      //1 = Player 1 - X    |    2 = Player 2 - O

        List<Button> listUsedFields = new List<Button>();
        List<char> listVictoryFields = new List<char>();
        List<char> listUsedFieldsX = new List<char>();
        List<char> listUsedFieldsO = new List<char>();

        FormMenue formMenue = null;

        #endregion

        public FormGamefield(FormMenue formMenue)
        {
            InitializeComponent();
            this.formMenue = formMenue;
            StartClock();
        }

        //################################### Methoden ##############################################
        #region Methoden

        private void StartClock()
        {
            this.labelGameTime.Text = (mintGametimeInSec / 60).ToString("D2") + ":" + (mintGametimeInSec % 60).ToString("D2");
            timerGameTimer.Start();
        }

        private void UpdateClock()
        {
            mintGametimeInSec++;
            this.labelGameTime.Text = (mintGametimeInSec / 60).ToString("D2") + ":" + (mintGametimeInSec % 60).ToString("D2");
        }

        private bool CheckVictory()
        {


            if (listUsedFieldsX.Contains('1') && listUsedFieldsX.Contains('2') && listUsedFieldsX.Contains('3'))
            {
                mintVictoryPlayer = 1;
                listVictoryFields.Add('1');
                listVictoryFields.Add('2');
                listVictoryFields.Add('3');
            }
            else if (listUsedFieldsX.Contains('1') && listUsedFieldsX.Contains('5') && listUsedFieldsX.Contains('9'))
            {
                mintVictoryPlayer = 1;
                listVictoryFields.Add('1');
                listVictoryFields.Add('5');
                listVictoryFields.Add('9');
            }
            else if (listUsedFieldsX.Contains('1') && listUsedFieldsX.Contains('4') && listUsedFieldsX.Contains('7'))
            {
                mintVictoryPlayer = 1;
                listVictoryFields.Add('1');
                listVictoryFields.Add('4');
                listVictoryFields.Add('7');
            }
            else if (listUsedFieldsX.Contains('2') && listUsedFieldsX.Contains('5') && listUsedFieldsX.Contains('8'))
            {
                mintVictoryPlayer = 1;
                listVictoryFields.Add('2');
                listVictoryFields.Add('5');
                listVictoryFields.Add('8');
            }
            else if (listUsedFieldsX.Contains('3') && listUsedFieldsX.Contains('5') && listUsedFieldsX.Contains('7'))
            {
                mintVictoryPlayer = 1;
                listVictoryFields.Add('3');
                listVictoryFields.Add('5');
                listVictoryFields.Add('7');
            }
            else if (listUsedFieldsX.Contains('3') && listUsedFieldsX.Contains('6') && listUsedFieldsX.Contains('9'))
            {
                mintVictoryPlayer = 1;
                listVictoryFields.Add('3');
                listVictoryFields.Add('6');
                listVictoryFields.Add('9');
            }
            else if (listUsedFieldsX.Contains('4') && listUsedFieldsX.Contains('5') && listUsedFieldsX.Contains('6'))
            {
                mintVictoryPlayer = 1;
                listVictoryFields.Add('4');
                listVictoryFields.Add('5');
                listVictoryFields.Add('6');
            }
            else if (listUsedFieldsX.Contains('7') && listUsedFieldsX.Contains('8') && listUsedFieldsX.Contains('9'))
            {
                mintVictoryPlayer = 1;
                listVictoryFields.Add('7');
                listVictoryFields.Add('8');
                listVictoryFields.Add('9');
            }

            if (listUsedFieldsO.Contains('1') && listUsedFieldsO.Contains('2') && listUsedFieldsO.Contains('3'))
            {
                mintVictoryPlayer = 2;
                listVictoryFields.Add('1');
                listVictoryFields.Add('2');
                listVictoryFields.Add('3');
            }
            else if (listUsedFieldsO.Contains('1') && listUsedFieldsO.Contains('5') && listUsedFieldsO.Contains('9'))
            {
                mintVictoryPlayer = 2;
                listVictoryFields.Add('1');
                listVictoryFields.Add('5');
                listVictoryFields.Add('9');
            }
            else if (listUsedFieldsO.Contains('1') && listUsedFieldsO.Contains('4') && listUsedFieldsO.Contains('7'))
            {
                mintVictoryPlayer = 2;
                listVictoryFields.Add('1');
                listVictoryFields.Add('4');
                listVictoryFields.Add('7');
            }
            else if (listUsedFieldsO.Contains('2') && listUsedFieldsO.Contains('5') && listUsedFieldsO.Contains('8'))
            {
                mintVictoryPlayer = 2;
                listVictoryFields.Add('2');
                listVictoryFields.Add('5');
                listVictoryFields.Add('8');
            }
            else if (listUsedFieldsO.Contains('3') && listUsedFieldsO.Contains('5') && listUsedFieldsO.Contains('7'))
            {
                mintVictoryPlayer = 2;
                listVictoryFields.Add('3');
                listVictoryFields.Add('5');
                listVictoryFields.Add('7');
            }
            else if (listUsedFieldsO.Contains('3') && listUsedFieldsO.Contains('6') && listUsedFieldsO.Contains('9'))
            {
                mintVictoryPlayer = 2;
                listVictoryFields.Add('3');
                listVictoryFields.Add('6');
                listVictoryFields.Add('9');
            }
            else if (listUsedFieldsO.Contains('4') && listUsedFieldsO.Contains('5') && listUsedFieldsO.Contains('6'))
            {
                mintVictoryPlayer = 2;
                listVictoryFields.Add('4');
                listVictoryFields.Add('5');
                listVictoryFields.Add('6');
            }
            else if (listUsedFieldsO.Contains('7') && listUsedFieldsO.Contains('8') && listUsedFieldsO.Contains('9'))
            {
                mintVictoryPlayer = 2;
                listVictoryFields.Add('7');
                listVictoryFields.Add('8');
                listVictoryFields.Add('9');
            }

            if (listVictoryFields.Count != 0)
                return true;

            return false;
        }

        private void EndGame()
        {
            foreach (char temp in listVictoryFields)
                foreach (Button button in listUsedFields)
                    if (button.Name[button.Name.Length - 1] != temp)
                        button.Text = string.Empty;
        }
            
    

        #endregion

        //################################### Events ##############################################
        #region Events
        private void timerGameTimer_Tick(object sender, EventArgs e)
        {
            UpdateClock();
        }


        #endregion

        private void FormGamefield_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.formMenue.Visible = true;
        }

        private void buttonGamefield_Click(object sender, EventArgs e)
        {
            bool boolDoubleUse = false;
            Button button = (Button)sender;

            foreach (Button temp in listUsedFields)
                if (temp == button)
                    boolDoubleUse = true;

            if (boolDoubleUse)
                return;
            else
                listUsedFields.Add(button);

            if (mintTurn == 0)
                listUsedFieldsX.Add(button.Name[button.Name.Length - 1]);
            else
                listUsedFieldsO.Add(button.Name[button.Name.Length - 1]);

            switch (button.Name[button.Name.Length - 1])
            {
                case '1':
                    button.Text = (mintTurn == 0 ? "X" : "O");
                    break;

                case '2':
                    button.Text = (mintTurn == 0 ? "X" : "O");
                    break;

                case '3':
                    button.Text = (mintTurn == 0 ? "X" : "O");
                    break;

                case '4':
                    button.Text = (mintTurn == 0 ? "X" : "O");
                    break;

                case '5':
                    button.Text = (mintTurn == 0 ? "X" : "O");
                    break;

                case '6':
                    button.Text = (mintTurn == 0 ? "X" : "O");
                    break;

                case '7':
                    button.Text = (mintTurn == 0 ? "X" : "O");
                    break;

                case '8':
                    button.Text = (mintTurn == 0 ? "X" : "O");
                    break;

                case '9':
                    button.Text = (mintTurn == 0 ? "X" : "O");
                    break;
                    
            }


            if (CheckVictory()) 
            {
                timerGameTimer.Stop();
                EndGame();
                MessageBox.Show("Spieler " + mintVictoryPlayer + " (" + (mintVictoryPlayer == 1 ? "X" : "O") + ") hat gewonnen!\r\n" +
                    "Spielzeit = " + (mintGametimeInSec / 60).ToString("D2") + ":" + (mintGametimeInSec % 60).ToString("D2"));
            }

            if (mintTurn == 0)
                mintTurn++;
            else
                mintTurn--;
        }
    }
}
