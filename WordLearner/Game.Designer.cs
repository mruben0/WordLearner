namespace WordLearner
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.asking = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.TextBox();
            this.Checkbutton = new System.Windows.Forms.Button();
            this.True = new System.Windows.Forms.Label();
            this.False = new System.Windows.Forms.Label();
            this.flCount = new System.Windows.Forms.Label();
            this.trCount = new System.Windows.Forms.Label();
            this.Saylabel = new System.Windows.Forms.Label();
            this.RightAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // asking
            // 
            this.asking.AutoSize = true;
            this.asking.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asking.Location = new System.Drawing.Point(27, 39);
            this.asking.Name = "asking";
            this.asking.Size = new System.Drawing.Size(25, 33);
            this.asking.TabIndex = 0;
            this.asking.Text = "/";
            // 
            // answer
            // 
            this.answer.BackColor = System.Drawing.SystemColors.Window;
            this.answer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer.ForeColor = System.Drawing.SystemColors.InfoText;
            this.answer.Location = new System.Drawing.Point(67, 142);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(302, 27);
            this.answer.TabIndex = 1;
            this.answer.TextChanged += new System.EventHandler(this.answer_TextChanged);
            this.answer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.answer_KeyPress);
            // 
            // Checkbutton
            // 
            this.Checkbutton.Location = new System.Drawing.Point(445, 131);
            this.Checkbutton.Name = "Checkbutton";
            this.Checkbutton.Size = new System.Drawing.Size(116, 50);
            this.Checkbutton.TabIndex = 2;
            this.Checkbutton.Text = "Done";
            this.Checkbutton.UseVisualStyleBackColor = true;
            this.Checkbutton.Click += new System.EventHandler(this.Checkbutton_Click);
            // 
            // True
            // 
            this.True.AutoSize = true;
            this.True.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.True.Location = new System.Drawing.Point(455, 229);
            this.True.Name = "True";
            this.True.Size = new System.Drawing.Size(65, 24);
            this.True.TabIndex = 3;
            this.True.Text = "True  /";
            this.True.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // False
            // 
            this.False.AutoSize = true;
            this.False.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.False.Location = new System.Drawing.Point(526, 229);
            this.False.Name = "False";
            this.False.Size = new System.Drawing.Size(56, 24);
            this.False.TabIndex = 4;
            this.False.Text = "False";
            // 
            // flCount
            // 
            this.flCount.AutoSize = true;
            this.flCount.Location = new System.Drawing.Point(547, 272);
            this.flCount.Name = "flCount";
            this.flCount.Size = new System.Drawing.Size(13, 13);
            this.flCount.TabIndex = 5;
            this.flCount.Text = "0";
            // 
            // trCount
            // 
            this.trCount.AutoSize = true;
            this.trCount.Location = new System.Drawing.Point(469, 272);
            this.trCount.Name = "trCount";
            this.trCount.Size = new System.Drawing.Size(13, 13);
            this.trCount.TabIndex = 6;
            this.trCount.Text = "0";
            this.trCount.Click += new System.EventHandler(this.label2_Click);
            // 
            // Saylabel
            // 
            this.Saylabel.AutoSize = true;
            this.Saylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saylabel.Location = new System.Drawing.Point(64, 229);
            this.Saylabel.Name = "Saylabel";
            this.Saylabel.Size = new System.Drawing.Size(18, 25);
            this.Saylabel.TabIndex = 7;
            this.Saylabel.Text = "/";
            // 
            // RightAnswer
            // 
            this.RightAnswer.AutoSize = true;
            this.RightAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightAnswer.Location = new System.Drawing.Point(69, 258);
            this.RightAnswer.Name = "RightAnswer";
            this.RightAnswer.Size = new System.Drawing.Size(0, 25);
            this.RightAnswer.TabIndex = 8;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 425);
            this.Controls.Add(this.RightAnswer);
            this.Controls.Add(this.Saylabel);
            this.Controls.Add(this.trCount);
            this.Controls.Add(this.flCount);
            this.Controls.Add(this.False);
            this.Controls.Add(this.True);
            this.Controls.Add(this.Checkbutton);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.asking);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label asking;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Button Checkbutton;
        private System.Windows.Forms.Label True;
        private System.Windows.Forms.Label False;
        private System.Windows.Forms.Label flCount;
        private System.Windows.Forms.Label trCount;
        private System.Windows.Forms.Label Saylabel;
        private System.Windows.Forms.Label RightAnswer;
    }
}