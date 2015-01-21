namespace flashcards
{
    partial class mainForm
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
            this.btnTestCards = new System.Windows.Forms.Button();
            this.btnTestPacks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTestCards
            // 
            this.btnTestCards.Location = new System.Drawing.Point(40, 53);
            this.btnTestCards.Name = "btnTestCards";
            this.btnTestCards.Size = new System.Drawing.Size(113, 41);
            this.btnTestCards.TabIndex = 0;
            this.btnTestCards.Text = "test cards";
            this.btnTestCards.UseVisualStyleBackColor = true;
            this.btnTestCards.Click += new System.EventHandler(this.btnTestCards_Click);
            // 
            // btnTestPacks
            // 
            this.btnTestPacks.Location = new System.Drawing.Point(204, 53);
            this.btnTestPacks.Name = "btnTestPacks";
            this.btnTestPacks.Size = new System.Drawing.Size(113, 41);
            this.btnTestPacks.TabIndex = 1;
            this.btnTestPacks.Text = "test packs";
            this.btnTestPacks.UseVisualStyleBackColor = true;
            this.btnTestPacks.Click += new System.EventHandler(this.btnTestPacks_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 207);
            this.Controls.Add(this.btnTestPacks);
            this.Controls.Add(this.btnTestCards);
            this.Name = "mainForm";
            this.Text = "Flashcards";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTestCards;
        private System.Windows.Forms.Button btnTestPacks;

    }
}

