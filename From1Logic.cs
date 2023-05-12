using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Zadanchik
{
    public partial class Form1
    {
        // These are private fields used by the math game.
        // This field tracks the current level of the game.
        private Random rng = new Random(); // This field is a pseudorandom number generator used to generate math problems.
        private int CorrectAnsver; // This field stores the correct answer to the current math problem.
        private static RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider(); // This field is a cryptographic random number generator used to generate random numbers for security-related purposes.
        private int LvL = 0;
        private int ScoreOK = 0;
        private int ScoreNo = 0;

        public void UpdateText()
        {
            __LRightAnswer.Text = $"Правильных ответов: {ScoreOK}";
            __LWrongAnswer.Text = $"Неправильных ответов: {ScoreNo}";
            __LTotalAnswer.Text = $"Общее количество задач: {LvL - 1}";
        }
         public async void HighlightButton(Button button, bool isGreen, int durationInSeconds)
        {
            // Set the color based on the input parameter
            Color highlightColor = isGreen ? Color.Green : Color.Red;

            // Highlight the button by changing its background color
            button.BackColor = highlightColor;

            // Wait for the specified duration
            await Task.Delay(durationInSeconds * 1000);

            // Reset the button's background color
            button.BackColor = SystemColors.Control;
        }

        public static byte RollDice(byte numberSides)
        {
            if (numberSides <= 0)
                throw new ArgumentOutOfRangeException("numberSides");

            // Create a byte array to hold the random value.
            byte[] randomNumber = new byte[1];
            do
            {
                // Fill the array with a random value.
                rngCsp.GetBytes(randomNumber);
            }
            while (!IsFairRoll(randomNumber[0], numberSides));
            // Return the random number mod the number
            // of sides.  The possible values are zero-
            // based, so we add one.
            return (byte)((randomNumber[0] % numberSides) + 1);
        }

        private static bool IsFairRoll(byte roll, byte numSides)
        {
            // There are MaxValue / numSides full sets of numbers that can come up
            // in a single byte.  For instance, if we have a 6 sided die, there are
            // 42 full sets of 1-6 that come up.  The 43rd set is incomplete.
            int fullSetsOfValues = Byte.MaxValue / numSides;

            // If the roll is within this range of fair values, then we let it continue.
            // In the 6 sided die case, a roll between 0 and 251 is allowed.  (We use
            // < rather than <= since the = portion allows through an extra 0 value).
            // 252 through 255 would provide an extra 0, 1, 2, 3 so they are not fair
            // to use.
            return roll < numSides * fullSetsOfValues;
        }

        // This method calculates the integer power of a number using bit manipulation.
        private int IntPow(int x, uint pow)
        {
            int ret = 1; // Initialize the result to 1.
            while (pow != 0) // Repeat until the power is 0.
            {
                if ((pow & 1) == 1) // If the least significant bit of the power is 1:
                    ret *= x; // Multiply the result by the base.
                x *= x; // Square the base.
                pow >>= 1; // Shift the power to the right by 1.
            }
            return ret; // Return the result.
        }


        // This method generates random math problems with two numbers and an operator.
        private Tuple<int, int, string, int> generateData()
        {
            // Generate two random numbers between 1 and 200.
            var a = RollDice(15);
            var b = RollDice(15);

            // Create an array of mathematical operators.
            string[] myArr = new string[5];
            myArr[0] = "*"; // multiplication
            myArr[1] = "/"; // division
            myArr[2] = "-"; // subtraction
            myArr[3] = "+"; // addition
            myArr[4] = "^"; // exponentiation

            // Choose a random operator from the array.
            var zn = myArr[rng.Next(0, myArr.Length - 1)];

            // Calculate the correct answer based on the chosen operator.
            var _CorrectAnsver = 0;
            switch (zn)
            {
                case "*": // multiplication
                    _CorrectAnsver = a * b;
                    break;
                case "/": // division
                    _CorrectAnsver = a / b;
                    break;
                case "-": // subtraction
                    _CorrectAnsver = a - b;
                    break;
                case "+": // addition
                    _CorrectAnsver = a + b;
                    break;
                case "^": // exponentiation
                    _CorrectAnsver = IntPow(a, (uint)b);
                    break;
            }

            // Return a tuple containing the two numbers, the operator, and the correct answer.
            return Tuple.Create((int)a, (int)b, zn, _CorrectAnsver);
        }


        private void NextTaskProvider()
        {
            if (__TBTaskAnswer.Text.Length == 0)
            {
                return;
            }
            else
            {
                if (CheckAnswer(__TBTaskAnswer.Text))
                {
                    __TBTaskAnswer.Text = "";
                    NextTask();
                }

            }

            UpdateText();
        }

        // This method generates a new math problem and updates the game level.
        private void NextTask()
        {
            
            // Increase the game level.
            LvL++;

            // Generate a new math problem and repeat until the correct answer is greater than 0.
            var data = generateData();
            while (true)
            {
                data = generateData();
                if (data.Item4 > 0)
                {
                    break;
                }
            }

            // Extract the two numbers, the operator, and the correct answer from the generated data tuple.
            var a = data.Item1;
            var b = data.Item2;
            var zn = data.Item3;
            CorrectAnsver = data.Item4;
            // Display the math problem to the user.

            Console.WriteLine(CorrectAnsver.ToString());

            __LTask.Text = $"{a} {zn} {b}";
        }



        // This method hides the elements of the math game and displays the start menu.
        private void StartMenu()
        {
            __LTask.Text = ""; // Clear the text of the math problem label.
            __LTask.Hide(); // Hide the math problem label.
            __LInfoTask.Hide(); // Hide the label that describes the math problem.
            __TBTaskAnswer.Hide(); // Hide the text box for entering math problem answers.
            __LBInfoAnswer.Hide(); // Hide the label that describes the answer text box.
            __LBSolvedTasks.Hide(); // Hide the list box that displays the solved math problems.
            __LInfoSolvedTasks.Hide(); // Hide the label that describes the solved math problems list box.
            __LRightAnswer.Hide(); // Hide the label that displays the number of correct answers.
            __LWrongAnswer.Hide(); // Hide the label that displays the number of incorrect answers.
            __LTotalAnswer.Hide(); // Hide the label that displays the total number of answers.

            __LInfoStartGame.Show(); // Show the label that describes the start game button.
            __BTNGame.Size = new System.Drawing.Size(638, 87); // Set the size of the start game button.
            __BTNGame.Click += __BTNGame_StartGame; // Attach the __BTNGame_StartGame event handler to the start game button.
        }

        // This method displays the elements of the math game and hides the start menu.
        private void StartGame()
        {
            __LTask.Show(); // Show the math problem label.
            __LInfoTask.Show(); // Show the label that describes the math problem.
            __TBTaskAnswer.Show(); // Show the text box for entering math problem answers.
            __LBInfoAnswer.Show(); // Show the label that describes the answer text box.
            __LBSolvedTasks.Show(); // Show the list box that displays the solved math problems.
            __LInfoSolvedTasks.Show(); // Show the label that describes the solved math problems list box.
            __LRightAnswer.Show(); // Show the label that displays the number of correct answers.
            __LWrongAnswer.Show(); // Show the label that displays the number of incorrect answers.
            __LTotalAnswer.Show(); // Show the label that displays the total number of answers.
            __LInfoStartGame.Hide(); // Hide the label that describes the start game button.
            __BTNGame.Text = "Далее";
            __BTNGame.Size = new System.Drawing.Size(369, 87); // Set the size of the next problem button.
            __BTNGame.Click -= __BTNGame_StartGame; // Detach the __BTNGame_StartGame event handler from the start game button.
            __BTNGame.Click += __BTNGame_Next; // Attach the __BTNGame_Next event handler to the next problem button.
        }


        // This method checks the user's answer to the current math problem.
        private bool CheckAnswer(string answer)
        {
            var _ansver = 0;
            try
            {
                _ansver = Convert.ToInt32(answer); // Convert the user's answer to an integer.
            }
            catch (System.FormatException)
            {
                // If the conversion fails, display an error message and return false.
                MessageBox.Show("Введите валидный ответ"); // Show a message box with an error message.
                return false; // Return false to indicate that the answer was invalid.
            }
            var result = CorrectAnsver == _ansver;
            HighlightButton(__BTNGame, result, 1);
            if (result)
                ScoreOK++;
            else
                ScoreNo++;

            // If the conversion succeeds, add the current math problem and the correct answer to the solved tasks list and return true.
            __LBSolvedTasks.Items.Add(__LTask.Text.ToString() + " = " + CorrectAnsver.ToString() + "\t" + (result ? "Правильно" : "Ошибка")); // Add the current math problem and the correct answer to the solved tasks list.
            return true; // Return true to indicate that the answer was valid.
        }



    }
}