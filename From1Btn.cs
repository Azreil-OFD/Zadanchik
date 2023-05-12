using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Zadanchik
{
    public partial class Form1
    {

        private void __BTNGame_StartGame(object sender, EventArgs e)
        {
            StartGame();
            NextTask();
        }

        private void __BTNGame_Next(object sender, EventArgs e)
        {

            NextTaskProvider();

        }

        private void __TBTaskAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NextTaskProvider();
            }
        }


    }
}
