namespace TicTackToe
{
    partial class FormMenue
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
            this.buttonStartPvsP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStartPvsAI = new System.Windows.Forms.Button();
            this.buttonStartAIvsAI = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStartPvsP
            // 
            this.buttonStartPvsP.Location = new System.Drawing.Point(111, 101);
            this.buttonStartPvsP.Name = "buttonStartPvsP";
            this.buttonStartPvsP.Size = new System.Drawing.Size(188, 36);
            this.buttonStartPvsP.TabIndex = 0;
            this.buttonStartPvsP.Text = "Spieler vs. Spieler";
            this.buttonStartPvsP.UseVisualStyleBackColor = true;
            this.buttonStartPvsP.Click += new System.EventHandler(this.buttonStartPvsP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menü";
            // 
            // buttonStartPvsAI
            // 
            this.buttonStartPvsAI.Location = new System.Drawing.Point(111, 143);
            this.buttonStartPvsAI.Name = "buttonStartPvsAI";
            this.buttonStartPvsAI.Size = new System.Drawing.Size(188, 36);
            this.buttonStartPvsAI.TabIndex = 0;
            this.buttonStartPvsAI.Text = "Spieler vs. KI";
            this.buttonStartPvsAI.UseVisualStyleBackColor = true;
            // 
            // buttonStartAIvsAI
            // 
            this.buttonStartAIvsAI.Location = new System.Drawing.Point(111, 185);
            this.buttonStartAIvsAI.Name = "buttonStartAIvsAI";
            this.buttonStartAIvsAI.Size = new System.Drawing.Size(188, 36);
            this.buttonStartAIvsAI.TabIndex = 0;
            this.buttonStartAIvsAI.Text = "KI vs. KI";
            this.buttonStartAIvsAI.UseVisualStyleBackColor = true;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(111, 227);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(188, 36);
            this.buttonSettings.TabIndex = 0;
            this.buttonSettings.Text = "Einstellungen";
            this.buttonSettings.UseVisualStyleBackColor = true;
            // 
            // FormMenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 378);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonStartAIvsAI);
            this.Controls.Add(this.buttonStartPvsAI);
            this.Controls.Add(this.buttonStartPvsP);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormMenue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menü";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStartPvsP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStartPvsAI;
        private System.Windows.Forms.Button buttonStartAIvsAI;
        private System.Windows.Forms.Button buttonSettings;
    }
}

