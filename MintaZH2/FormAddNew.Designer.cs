namespace MintaZH2
{
    partial class FormAddNew
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
            textBox1 = new TextBox();
            FutoBindingSource = new BindingSource(components);
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)FutoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", FutoBindingSource, "VersenyzoID", true));
            textBox1.Location = new Point(32, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 23);
            textBox1.TabIndex = 0;
            // 
            // FutoBindingSource
            // 
            FutoBindingSource.DataSource = typeof(FutoVersenyzok);
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", FutoBindingSource, "Nev", true));
            textBox2.Location = new Point(32, 101);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(296, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", FutoBindingSource, "Nemzetiseg", true));
            textBox3.Location = new Point(32, 151);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(296, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", FutoBindingSource, "EredmenyPerc", true));
            textBox4.Location = new Point(32, 203);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(296, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", FutoBindingSource, "Kategoria", true));
            textBox5.Location = new Point(32, 258);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(296, 23);
            textBox5.TabIndex = 4;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(253, 359);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormAddNew
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FormAddNew";
            Text = "FormAddNew";
            Load += FormAddNew_Load;
            ((System.ComponentModel.ISupportInitialize)FutoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private BindingSource FutoBindingSource;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
    }
}