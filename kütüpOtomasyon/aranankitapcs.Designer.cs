namespace kütüpOtomasyon
{
    partial class aranankitapcs
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
            groupBox1 = new GroupBox();
            kyayın_textBox3 = new TextBox();
            kyazar_textBox2 = new TextBox();
            kitapad_textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(kyayın_textBox3);
            groupBox1.Controls.Add(kyazar_textBox2);
            groupBox1.Controls.Add(kitapad_textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(16, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(383, 161);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Arama Formu";
            // 
            // kyayın_textBox3
            // 
            kyayın_textBox3.Location = new Point(99, 120);
            kyayın_textBox3.Name = "kyayın_textBox3";
            kyayın_textBox3.Size = new Size(269, 27);
            kyayın_textBox3.TabIndex = 5;
            kyayın_textBox3.TextChanged += kyayın_textBox3_TextChanged;
            // 
            // kyazar_textBox2
            // 
            kyazar_textBox2.Location = new Point(97, 77);
            kyazar_textBox2.Name = "kyazar_textBox2";
            kyazar_textBox2.Size = new Size(271, 27);
            kyazar_textBox2.TabIndex = 4;
            kyazar_textBox2.TextChanged += kyazar_textBox2_TextChanged;
            // 
            // kitapad_textBox1
            // 
            kitapad_textBox1.Location = new Point(97, 39);
            kitapad_textBox1.Name = "kitapad_textBox1";
            kitapad_textBox1.Size = new Size(271, 27);
            kitapad_textBox1.TabIndex = 3;
            kitapad_textBox1.TextChanged += kitapad_textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 120);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 2;
            label3.Text = "Yayın Evi :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 77);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "Yazar :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 38);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Kitap Adı :";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 185);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(780, 253);
            dataGridView1.TabIndex = 1;
            // 
            // aranankitapcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "aranankitapcs";
            Text = "aranankitapcs";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox kyayın_textBox3;
        private TextBox kyazar_textBox2;
        private TextBox kitapad_textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
    }
}