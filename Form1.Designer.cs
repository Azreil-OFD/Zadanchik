namespace Zadanchik
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.@__BTNGame = new System.Windows.Forms.Button();
            this.@__LBSolvedTasks = new System.Windows.Forms.ListBox();
            this.@__LInfoSolvedTasks = new System.Windows.Forms.Label();
            this.@__LTask = new System.Windows.Forms.Label();
            this.@__TBTaskAnswer = new System.Windows.Forms.TextBox();
            this.@__LInfoTask = new System.Windows.Forms.Label();
            this.@__LBInfoAnswer = new System.Windows.Forms.Label();
            this.@__LRightAnswer = new System.Windows.Forms.Label();
            this.@__LWrongAnswer = new System.Windows.Forms.Label();
            this.@__LTotalAnswer = new System.Windows.Forms.Label();
            this.@__LInfoStartGame = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // __BTNGame
            // 
            this.@__BTNGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.@__BTNGame.Location = new System.Drawing.Point(12, 227);
            this.@__BTNGame.Name = "__BTNGame";
            this.@__BTNGame.Size = new System.Drawing.Size(638, 87);
            this.@__BTNGame.TabIndex = 0;
            this.@__BTNGame.Text = "Начать игру";
            this.@__BTNGame.UseVisualStyleBackColor = true;
            // 
            // __LBSolvedTasks
            // 
            this.@__LBSolvedTasks.FormattingEnabled = true;
            this.@__LBSolvedTasks.Location = new System.Drawing.Point(387, 38);
            this.@__LBSolvedTasks.Name = "__LBSolvedTasks";
            this.@__LBSolvedTasks.Size = new System.Drawing.Size(263, 186);
            this.@__LBSolvedTasks.TabIndex = 1;
            // 
            // __LInfoSolvedTasks
            // 
            this.@__LInfoSolvedTasks.AutoSize = true;
            this.@__LInfoSolvedTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.@__LInfoSolvedTasks.Location = new System.Drawing.Point(387, 13);
            this.@__LInfoSolvedTasks.Name = "__LInfoSolvedTasks";
            this.@__LInfoSolvedTasks.Size = new System.Drawing.Size(147, 20);
            this.@__LInfoSolvedTasks.TabIndex = 2;
            this.@__LInfoSolvedTasks.Text = "Решенные задачи";
            // 
            // __LTask
            // 
            this.@__LTask.AutoSize = true;
            this.@__LTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.@__LTask.Location = new System.Drawing.Point(111, 61);
            this.@__LTask.Name = "__LTask";
            this.@__LTask.Size = new System.Drawing.Size(74, 31);
            this.@__LTask.TabIndex = 3;
            this.@__LTask.Text = "1 + 1";
            this.@__LTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // __TBTaskAnswer
            // 
            this.@__TBTaskAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.@__TBTaskAnswer.Location = new System.Drawing.Point(12, 179);
            this.@__TBTaskAnswer.Name = "__TBTaskAnswer";
            this.@__TBTaskAnswer.Size = new System.Drawing.Size(369, 45);
            this.@__TBTaskAnswer.TabIndex = 4;
            this.@__TBTaskAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.@__TBTaskAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.@__TBTaskAnswer_KeyDown);
            // 
            // __LInfoTask
            // 
            this.@__LInfoTask.AutoSize = true;
            this.@__LInfoTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.@__LInfoTask.Location = new System.Drawing.Point(12, 66);
            this.@__LInfoTask.Name = "__LInfoTask";
            this.@__LInfoTask.Size = new System.Drawing.Size(93, 26);
            this.@__LInfoTask.TabIndex = 5;
            this.@__LInfoTask.Text = "Задача:";
            // 
            // __LBInfoAnswer
            // 
            this.@__LBInfoAnswer.AutoSize = true;
            this.@__LBInfoAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.@__LBInfoAnswer.Location = new System.Drawing.Point(12, 147);
            this.@__LBInfoAnswer.Name = "__LBInfoAnswer";
            this.@__LBInfoAnswer.Size = new System.Drawing.Size(166, 26);
            this.@__LBInfoAnswer.TabIndex = 6;
            this.@__LBInfoAnswer.Text = "Введите ответ:";
            // 
            // __LRightAnswer
            // 
            this.@__LRightAnswer.AutoSize = true;
            this.@__LRightAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.@__LRightAnswer.Location = new System.Drawing.Point(387, 227);
            this.@__LRightAnswer.Name = "__LRightAnswer";
            this.@__LRightAnswer.Size = new System.Drawing.Size(195, 22);
            this.@__LRightAnswer.TabIndex = 7;
            this.@__LRightAnswer.Text = "Правильных ответов: ";
            // 
            // __LWrongAnswer
            // 
            this.@__LWrongAnswer.AutoSize = true;
            this.@__LWrongAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.@__LWrongAnswer.Location = new System.Drawing.Point(387, 249);
            this.@__LWrongAnswer.Name = "__LWrongAnswer";
            this.@__LWrongAnswer.Size = new System.Drawing.Size(210, 22);
            this.@__LWrongAnswer.TabIndex = 8;
            this.@__LWrongAnswer.Text = "Неправильных ответов:";
            // 
            // __LTotalAnswer
            // 
            this.@__LTotalAnswer.AutoSize = true;
            this.@__LTotalAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.@__LTotalAnswer.Location = new System.Drawing.Point(387, 271);
            this.@__LTotalAnswer.Name = "__LTotalAnswer";
            this.@__LTotalAnswer.Size = new System.Drawing.Size(230, 22);
            this.@__LTotalAnswer.TabIndex = 9;
            this.@__LTotalAnswer.Text = "Общее количество задач:";
            // 
            // __LInfoStartGame
            // 
            this.@__LInfoStartGame.AutoSize = true;
            this.@__LInfoStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.@__LInfoStartGame.Location = new System.Drawing.Point(144, 117);
            this.@__LInfoStartGame.Name = "__LInfoStartGame";
            this.@__LInfoStartGame.Size = new System.Drawing.Size(390, 26);
            this.@__LInfoStartGame.TabIndex = 10;
            this.@__LInfoStartGame.Text = "Для начала игры нажми Начать игру";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 326);
            this.Controls.Add(this.@__LInfoStartGame);
            this.Controls.Add(this.@__LTotalAnswer);
            this.Controls.Add(this.@__LWrongAnswer);
            this.Controls.Add(this.@__LRightAnswer);
            this.Controls.Add(this.@__LBInfoAnswer);
            this.Controls.Add(this.@__LInfoTask);
            this.Controls.Add(this.@__TBTaskAnswer);
            this.Controls.Add(this.@__LTask);
            this.Controls.Add(this.@__LInfoSolvedTasks);
            this.Controls.Add(this.@__LBSolvedTasks);
            this.Controls.Add(this.@__BTNGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button __BTNGame;
        private System.Windows.Forms.ListBox __LBSolvedTasks;
        private System.Windows.Forms.Label __LInfoSolvedTasks;
        private System.Windows.Forms.Label __LTask;
        private System.Windows.Forms.TextBox __TBTaskAnswer;
        private System.Windows.Forms.Label __LInfoTask;
        private System.Windows.Forms.Label __LBInfoAnswer;
        private System.Windows.Forms.Label __LRightAnswer;
        private System.Windows.Forms.Label __LWrongAnswer;
        private System.Windows.Forms.Label __LTotalAnswer;
        private System.Windows.Forms.Label __LInfoStartGame;
    }
}

