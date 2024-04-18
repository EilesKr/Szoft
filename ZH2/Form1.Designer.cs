namespace ZH2
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
            dataGridView1 = new DataGridView();
            autoIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modellDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gyartoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            evjaratDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            uzemanyagDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            teljesitmenyHPDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            autokBindingSource = new BindingSource(components);
            buttonOpen = new Button();
            buttonSave = new Button();
            buttonDelete = new Button();
            buttonAddNew = new Button();
            buttonErdekesseg = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)autokBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { autoIDDataGridViewTextBoxColumn, modellDataGridViewTextBoxColumn, gyartoDataGridViewTextBoxColumn, evjaratDataGridViewTextBoxColumn, uzemanyagDataGridViewTextBoxColumn, teljesitmenyHPDataGridViewTextBoxColumn });
            dataGridView1.DataSource = autokBindingSource;
            dataGridView1.Location = new Point(40, 146);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(702, 268);
            dataGridView1.TabIndex = 0;
            // 
            // autoIDDataGridViewTextBoxColumn
            // 
            autoIDDataGridViewTextBoxColumn.DataPropertyName = "AutoID";
            autoIDDataGridViewTextBoxColumn.HeaderText = "AutoID";
            autoIDDataGridViewTextBoxColumn.Name = "autoIDDataGridViewTextBoxColumn";
            // 
            // modellDataGridViewTextBoxColumn
            // 
            modellDataGridViewTextBoxColumn.DataPropertyName = "Modell";
            modellDataGridViewTextBoxColumn.HeaderText = "Modell";
            modellDataGridViewTextBoxColumn.Name = "modellDataGridViewTextBoxColumn";
            // 
            // gyartoDataGridViewTextBoxColumn
            // 
            gyartoDataGridViewTextBoxColumn.DataPropertyName = "Gyarto";
            gyartoDataGridViewTextBoxColumn.HeaderText = "Gyarto";
            gyartoDataGridViewTextBoxColumn.Name = "gyartoDataGridViewTextBoxColumn";
            // 
            // evjaratDataGridViewTextBoxColumn
            // 
            evjaratDataGridViewTextBoxColumn.DataPropertyName = "Evjarat";
            evjaratDataGridViewTextBoxColumn.HeaderText = "Evjarat";
            evjaratDataGridViewTextBoxColumn.Name = "evjaratDataGridViewTextBoxColumn";
            // 
            // uzemanyagDataGridViewTextBoxColumn
            // 
            uzemanyagDataGridViewTextBoxColumn.DataPropertyName = "Uzemanyag";
            uzemanyagDataGridViewTextBoxColumn.HeaderText = "Uzemanyag";
            uzemanyagDataGridViewTextBoxColumn.Name = "uzemanyagDataGridViewTextBoxColumn";
            // 
            // teljesitmenyHPDataGridViewTextBoxColumn
            // 
            teljesitmenyHPDataGridViewTextBoxColumn.DataPropertyName = "TeljesitmenyHP";
            teljesitmenyHPDataGridViewTextBoxColumn.HeaderText = "TeljesitmenyHP";
            teljesitmenyHPDataGridViewTextBoxColumn.Name = "teljesitmenyHPDataGridViewTextBoxColumn";
            // 
            // autokBindingSource
            // 
            autokBindingSource.DataSource = typeof(autok);
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(667, 98);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(75, 23);
            buttonOpen.TabIndex = 1;
            buttonOpen.Text = "Megnyitás";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(586, 98);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Mentés";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(505, 98);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Törlés";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonAddNew
            // 
            buttonAddNew.Location = new Point(424, 98);
            buttonAddNew.Name = "buttonAddNew";
            buttonAddNew.Size = new Size(75, 23);
            buttonAddNew.TabIndex = 4;
            buttonAddNew.Text = "Új sor";
            buttonAddNew.UseVisualStyleBackColor = true;
            buttonAddNew.Click += buttonAddNew_Click;
            // 
            // buttonErdekesseg
            // 
            buttonErdekesseg.Location = new Point(40, 98);
            buttonErdekesseg.Name = "buttonErdekesseg";
            buttonErdekesseg.Size = new Size(75, 23);
            buttonErdekesseg.TabIndex = 5;
            buttonErdekesseg.Text = "Érdekesség";
            buttonErdekesseg.UseVisualStyleBackColor = true;
            buttonErdekesseg.Click += buttonErdekesseg_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonErdekesseg);
            Controls.Add(buttonAddNew);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSave);
            Controls.Add(buttonOpen);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)autokBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonOpen;
        private Button buttonSave;
        private DataGridViewTextBoxColumn autoIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modellDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gyartoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn evjaratDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn uzemanyagDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn teljesitmenyHPDataGridViewTextBoxColumn;
        private BindingSource autokBindingSource;
        private Button buttonDelete;
        private Button buttonAddNew;
        private Button buttonErdekesseg;
    }
}