namespace TicTackToe
{
    partial class FormGamefield
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.labelGameTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPlayerX = new System.Windows.Forms.Label();
            this.labelPlayerO = new System.Windows.Forms.Label();
            this.timerGameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 80);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonGamefield_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(358, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 80);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonGamefield_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(453, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 80);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonGamefield_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(261, 237);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 80);
            this.button4.TabIndex = 0;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonGamefield_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(358, 237);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 80);
            this.button5.TabIndex = 0;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonGamefield_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(453, 237);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 80);
            this.button6.TabIndex = 0;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonGamefield_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(261, 332);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 80);
            this.button7.TabIndex = 0;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttonGamefield_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(358, 332);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(80, 80);
            this.button8.TabIndex = 0;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.buttonGamefield_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(453, 332);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(80, 80);
            this.button9.TabIndex = 0;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.buttonGamefield_Click);
            // 
            // labelGameTime
            // 
            this.labelGameTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameTime.Location = new System.Drawing.Point(261, 9);
            this.labelGameTime.Name = "labelGameTime";
            this.labelGameTime.Size = new System.Drawing.Size(272, 129);
            this.labelGameTime.TabIndex = 1;
            this.labelGameTime.Text = "Spielzeit";
            this.labelGameTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Spieler \'X\':";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Spieler \'O\':";
            // 
            // labelPlayerX
            // 
            this.labelPlayerX.AutoSize = true;
            this.labelPlayerX.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerX.Location = new System.Drawing.Point(94, 40);
            this.labelPlayerX.Name = "labelPlayerX";
            this.labelPlayerX.Size = new System.Drawing.Size(90, 17);
            this.labelPlayerX.TabIndex = 2;
            this.labelPlayerX.Text = "Spielername";
            // 
            // labelPlayerO
            // 
            this.labelPlayerO.AutoSize = true;
            this.labelPlayerO.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerO.Location = new System.Drawing.Point(94, 255);
            this.labelPlayerO.Name = "labelPlayerO";
            this.labelPlayerO.Size = new System.Drawing.Size(90, 17);
            this.labelPlayerO.TabIndex = 2;
            this.labelPlayerO.Text = "Spielername";
            // 
            // timerGameTimer
            // 
            this.timerGameTimer.Interval = 1000;
            this.timerGameTimer.Tick += new System.EventHandler(this.timerGameTimer_Tick);
            // 
            // FormGamefield
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 552);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPlayerO);
            this.Controls.Add(this.labelPlayerX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelGameTime);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormGamefield";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGamefield";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGamefield_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label labelGameTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPlayerX;
        private System.Windows.Forms.Label labelPlayerO;
        private System.Windows.Forms.Timer timerGameTimer;
    }
}