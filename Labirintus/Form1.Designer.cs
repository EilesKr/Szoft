namespace Labirintus
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            labelRestart = new Label();
            labelTime = new Label();
            labelStep = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // labelRestart
            // 
            labelRestart.AutoSize = true;
            labelRestart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelRestart.Location = new Point(12, 9);
            labelRestart.Name = "labelRestart";
            labelRestart.Size = new Size(352, 21);
            labelRestart.TabIndex = 0;
            labelRestart.Text = "Az újrakezdéshez nyomd meg az 'R' gombot.";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelTime.Location = new Point(12, 41);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(81, 19);
            labelTime.TabIndex = 1;
            labelTime.Text = "Eltelt idő: --";
            // 
            // labelStep
            // 
            labelStep.AutoSize = true;
            labelStep.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelStep.Location = new Point(12, 63);
            labelStep.Name = "labelStep";
            labelStep.Size = new Size(169, 19);
            labelStep.TabIndex = 2;
            labelStep.Text = "Megtett lépések száma: --";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1034, 538);
            Controls.Add(labelStep);
            Controls.Add(labelTime);
            Controls.Add(labelRestart);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label labelRestart;
        private Label labelTime;
        private Label labelStep;
    }
}