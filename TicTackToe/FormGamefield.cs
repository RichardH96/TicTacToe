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
        private int mintTurn = 0; //0 = Spieler 1 - X  |  1 = Spieler 2 - O

        List<int> listUseFields = new List<int>();

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
            this.labelGameTime.Text = (mintGametimeInSec / 60).ToString("x2") + ":" + (mintGametimeInSec % 60).ToString("x2");
            timerGameTimer.Start();
        }

        private void UpdateClock()
        {
            mintGametimeInSec++;
            this.labelGameTime.Text = (mintGametimeInSec / 60).ToString("x2") + ":" + (mintGametimeInSec % 60).ToString("x2");
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

            foreach (int temp in listUseFields)
                if (temp == (int)button.Name[button.Name.Length - 1])
                    boolDoubleUse = true;

            if (boolDoubleUse)
                return;
            else
                listUseFields.Add((int)button.Name[button.Name.Length - 1]);

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




            if (mintTurn == 0)
                mintTurn++;
            else
                mintTurn--;
        }
    }
}
