using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MetronomeApp.Tempo;

namespace MetronomeApp
{
    public partial class frmMetronome : Form
    {
        public frmMetronome()
        {
            InitializeComponent();
        }



        private void btnPlay_Click(object sender, EventArgs e)
        {
            // Checks to see the state of the app to see if the metronome is running or not.
            setState("Play");

            
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            setState("Pause");
        }

        private void setState(string appState)
        {
            // Sets the state of the app to see if the metronome needs to run or not.
            Tempo start = new Tempo();
            switch (appState)
            {
                case "Play":
                    start.metronomePlayTest();
                    break;
                case "Pause":
                    start.metronomeStopTest();
                    break;
                default:
                    break;



            }
        }
    } 
}