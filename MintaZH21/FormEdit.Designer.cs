namespace MintaZH21
{
    partial class FormEdit
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
            components = new System.ComponentModel.Container();
            vizsgaKérdésBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)vizsgaKérdésBindingSource).BeginInit();
            SuspendLayout();
            // 
            // vizsgaKérdésBindingSource
            // 
            vizsgaKérdésBindingSource.DataSource = typeof(VizsgaKerdes);
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", vizsgaKérdésBindingSource, "Szam", true));
            textBox1.Location = new Point(106, 198);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(353, 23);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(481, 341);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "FormEdit";
            Text = "FormEdit";
            Load += FormEdit_Load;
            ((System.ComponentModel.ISupportInitialize)vizsgaKérdésBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource vizsgaKérdésBindingSource;
        private TextBox textBox1;
        private Button button1;
    }
}