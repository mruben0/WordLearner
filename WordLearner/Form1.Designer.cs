namespace WordLearner
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pathFinder = new System.Windows.Forms.TextBox();
            this.browse = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.label = new System.Windows.Forms.Label();
            this.FileChoosed = new System.Windows.Forms.Button();
            this.Copyright = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pathFinder
            // 
            this.pathFinder.Location = new System.Drawing.Point(42, 83);
            this.pathFinder.Name = "pathFinder";
            this.pathFinder.Size = new System.Drawing.Size(382, 20);
            this.pathFinder.TabIndex = 0;
            this.pathFinder.TextChanged += new System.EventHandler(this.pathFinder_TextChanged);
            // 
            // browse
            // 
            this.browse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browse.Location = new System.Drawing.Point(477, 73);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(100, 39);
            this.browse.TabIndex = 1;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(12, 18);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 21);
            this.label.TabIndex = 2;
            // 
            // FileChoosed
            // 
            this.FileChoosed.Location = new System.Drawing.Point(268, 147);
            this.FileChoosed.Name = "FileChoosed";
            this.FileChoosed.Size = new System.Drawing.Size(108, 50);
            this.FileChoosed.TabIndex = 3;
            this.FileChoosed.Text = "Done";
            this.FileChoosed.UseVisualStyleBackColor = true;
            this.FileChoosed.Click += new System.EventHandler(this.FileChoosed_Click);
            // 
            // Copyright
            // 
            this.Copyright.BackColor = System.Drawing.Color.Teal;
            this.Copyright.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Copyright.Font = new System.Drawing.Font("Modern No. 20", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copyright.Location = new System.Drawing.Point(-26, 271);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(649, 96);
            this.Copyright.TabIndex = 4;
            this.Copyright.Text = "Ram6ler";
            this.Copyright.UseVisualStyleBackColor = false;
            this.Copyright.Click += new System.EventHandler(this.Copyright_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 354);
            this.Controls.Add(this.Copyright);
            this.Controls.Add(this.FileChoosed);
            this.Controls.Add(this.label);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.pathFinder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Word Learner Application";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pathFinder;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button FileChoosed;
        private System.Windows.Forms.Button Copyright;
    }
}

