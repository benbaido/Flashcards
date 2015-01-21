namespace flashcards.testForms
{
    partial class cardFace
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
            this.gbFrontAndBack = new System.Windows.Forms.GroupBox();
            this.gbFlipable = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.tbOpenFile = new System.Windows.Forms.TextBox();
            this.tbFileOpened = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // gbFrontAndBack
            // 
            this.gbFrontAndBack.Location = new System.Drawing.Point(504, 12);
            this.gbFrontAndBack.Name = "gbFrontAndBack";
            this.gbFrontAndBack.Size = new System.Drawing.Size(428, 516);
            this.gbFrontAndBack.TabIndex = 0;
            this.gbFrontAndBack.TabStop = false;
            this.gbFrontAndBack.Text = "Front and Back Seperate";
            // 
            // gbFlipable
            // 
            this.gbFlipable.Location = new System.Drawing.Point(12, 234);
            this.gbFlipable.Name = "gbFlipable";
            this.gbFlipable.Size = new System.Drawing.Size(486, 294);
            this.gbFlipable.TabIndex = 1;
            this.gbFlipable.TabStop = false;
            this.gbFlipable.Text = "FlipableCard";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Open Pack";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(404, 56);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 20);
            this.btnOpenFile.TabIndex = 3;
            this.btnOpenFile.Text = "open file";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // tbOpenFile
            // 
            this.tbOpenFile.Location = new System.Drawing.Point(15, 56);
            this.tbOpenFile.Name = "tbOpenFile";
            this.tbOpenFile.Size = new System.Drawing.Size(383, 20);
            this.tbOpenFile.TabIndex = 4;
            // 
            // tbFileOpened
            // 
            this.tbFileOpened.Location = new System.Drawing.Point(16, 90);
            this.tbFileOpened.Name = "tbFileOpened";
            this.tbFileOpened.Size = new System.Drawing.Size(462, 20);
            this.tbFileOpened.TabIndex = 5;
            // 
            // cardFace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 537);
            this.Controls.Add(this.tbFileOpened);
            this.Controls.Add(this.tbOpenFile);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbFlipable);
            this.Controls.Add(this.gbFrontAndBack);
            this.Name = "cardFace";
            this.Text = "cardFace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFrontAndBack;
        private System.Windows.Forms.GroupBox gbFlipable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox tbOpenFile;
        private System.Windows.Forms.TextBox tbFileOpened;
    }
}