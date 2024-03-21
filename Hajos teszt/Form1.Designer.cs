namespace Hajos_teszt
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            valaszGomb1 = new ValaszGomb();
            valaszGomb2 = new ValaszGomb();
            valaszGomb3 = new ValaszGomb();
            kovetkezo = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 194);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 244);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 25);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(377, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(411, 176);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // valaszGomb1
            // 
            valaszGomb1.BackColor = Color.LightGray;
            valaszGomb1.BorderStyle = BorderStyle.None;
            valaszGomb1.Location = new Point(72, 56);
            valaszGomb1.Multiline = true;
            valaszGomb1.Name = "valaszGomb1";
            valaszGomb1.ReadOnly = true;
            valaszGomb1.Size = new Size(197, 29);
            valaszGomb1.TabIndex = 6;
            // 
            // valaszGomb2
            // 
            valaszGomb2.BackColor = Color.LightGray;
            valaszGomb2.BorderStyle = BorderStyle.None;
            valaszGomb2.Location = new Point(72, 91);
            valaszGomb2.Multiline = true;
            valaszGomb2.Name = "valaszGomb2";
            valaszGomb2.ReadOnly = true;
            valaszGomb2.Size = new Size(197, 29);
            valaszGomb2.TabIndex = 7;
            // 
            // valaszGomb3
            // 
            valaszGomb3.BackColor = Color.LightGray;
            valaszGomb3.BorderStyle = BorderStyle.None;
            valaszGomb3.Location = new Point(72, 126);
            valaszGomb3.Multiline = true;
            valaszGomb3.Name = "valaszGomb3";
            valaszGomb3.ReadOnly = true;
            valaszGomb3.Size = new Size(197, 29);
            valaszGomb3.TabIndex = 8;
            // 
            // kovetkezo
            // 
            kovetkezo.Location = new Point(312, 157);
            kovetkezo.Name = "kovetkezo";
            kovetkezo.Size = new Size(59, 31);
            kovetkezo.TabIndex = 9;
            kovetkezo.Text = "-->";
            kovetkezo.UseVisualStyleBackColor = true;
            kovetkezo.Click += kovetkezo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(kovetkezo);
            Controls.Add(valaszGomb3);
            Controls.Add(valaszGomb2);
            Controls.Add(valaszGomb1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private PictureBox pictureBox1;
        private ValaszGomb valaszGomb1;
        private ValaszGomb valaszGomb2;
        private ValaszGomb valaszGomb3;
        private Button kovetkezo;
    }
}