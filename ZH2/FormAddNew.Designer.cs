namespace ZH2
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
            button1 = new Button();
            button2 = new Button();
            autokBindingSource = new BindingSource(components);
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)autokBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(680, 397);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(599, 397);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Mégse";
            button2.UseVisualStyleBackColor = true;
            // 
            // autokBindingSource
            // 
            autokBindingSource.DataSource = typeof(autok);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 32);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 2;
            label1.Text = "Autó azonosítója";
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", autokBindingSource, "AutoID", true));
            textBox1.Location = new Point(26, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(331, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", autokBindingSource, "Modell", true));
            textBox2.Location = new Point(26, 107);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(331, 23);
            textBox2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 89);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 4;
            label2.Text = "Modell";
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", autokBindingSource, "Gyarto", true));
            textBox3.Location = new Point(26, 168);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(331, 23);
            textBox3.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 150);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 6;
            label3.Text = "Gyártó";
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", autokBindingSource, "Evjarat", true));
            textBox4.Location = new Point(26, 228);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(331, 23);
            textBox4.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 210);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 8;
            label4.Text = "Évjárat";
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", autokBindingSource, "Uzemanyag", true));
            textBox5.Location = new Point(26, 292);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(331, 23);
            textBox5.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 274);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 10;
            label5.Text = "Üzemanyag";
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new Binding("Text", autokBindingSource, "TeljesitmenyHP", true));
            textBox6.Location = new Point(26, 355);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(331, 23);
            textBox6.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 337);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 12;
            label6.Text = "Teljesítmény";
            // 
            // FormAddNew
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormAddNew";
            Text = "FormAddNew";
            Load += FormAddNew_Load;
            ((System.ComponentModel.ISupportInitialize)autokBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private BindingSource autokBindingSource;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
    }
}