namespace PreLaboratorio
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
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox11 = new TextBox();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11 });
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1144, 547);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Grado";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Sección";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Número de teléfono";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Número de matrícula";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Ciclo académico actual";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "CUI";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Promedio actual";
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "Es alérgico (Si/No)";
            Column9.Name = "Column9";
            // 
            // Column10
            // 
            Column10.HeaderText = "Nombre de mamá";
            Column10.Name = "Column10";
            // 
            // Column11
            // 
            Column11.HeaderText = "Teléfono de mamá";
            Column11.Name = "Column11";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1157, 32);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1157, 74);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Grado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1157, 160);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 4;
            label3.Text = "Teléfono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1157, 118);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 3;
            label4.Text = "Sección";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1157, 250);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 6;
            label5.Text = "Ciclo actual";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1155, 207);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 5;
            label6.Text = "Matrícula";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1156, 382);
            label7.Name = "label7";
            label7.Size = new Size(104, 15);
            label7.TabIndex = 8;
            label7.Text = "Es alérgico (Si/No)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1160, 297);
            label8.Name = "label8";
            label8.Size = new Size(26, 15);
            label8.TabIndex = 7;
            label8.Text = "CUI";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1160, 466);
            label9.Name = "label9";
            label9.Size = new Size(89, 15);
            label9.TabIndex = 10;
            label9.Text = "Teléfono mamá";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1157, 426);
            label10.Name = "label10";
            label10.Size = new Size(88, 15);
            label10.TabIndex = 9;
            label10.Text = "Nombre mamá";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1266, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 23);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1266, 74);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(174, 23);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1266, 115);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(174, 23);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(1266, 157);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(174, 23);
            textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(1266, 199);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(174, 23);
            textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(1266, 247);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(174, 23);
            textBox6.TabIndex = 16;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(1266, 294);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(174, 23);
            textBox7.TabIndex = 17;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(1266, 336);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(174, 23);
            textBox8.TabIndex = 18;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(1266, 379);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(174, 23);
            textBox9.TabIndex = 19;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(1266, 426);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(174, 23);
            textBox10.TabIndex = 20;
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(1157, 495);
            button1.Name = "button1";
            button1.Size = new Size(313, 65);
            button1.TabIndex = 21;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(23, 564);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 22;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(143, 564);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 23;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(1266, 463);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(174, 23);
            textBox11.TabIndex = 24;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1157, 339);
            label11.Name = "label11";
            label11.Size = new Size(59, 15);
            label11.TabIndex = 25;
            label11.Text = "Promedio";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1537, 629);
            Controls.Add(label11);
            Controls.Add(textBox11);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox11;
        private Label label11;
    }
}
