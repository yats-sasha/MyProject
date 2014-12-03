namespace Homework_DS
{
    partial class MyForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Radio_File = new System.Windows.Forms.RadioButton();
            this.Radio_Screen = new System.Windows.Forms.RadioButton();
            this.TextBox_G = new System.Windows.Forms.TextBox();
            this.TextBox_L = new System.Windows.Forms.TextBox();
            this.TextBox_P = new System.Windows.Forms.TextBox();
            this.Numeric_N = new System.Windows.Forms.NumericUpDown();
            this.Numeric_M = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Numeric_Start = new System.Windows.Forms.NumericUpDown();
            this.Numeric_End = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Button_Input = new System.Windows.Forms.Button();
            this.Button_Find_Way = new System.Windows.Forms.Button();
            this.RichTextBox_Show_Way = new System.Windows.Forms.RichTextBox();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_N)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_M)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_End)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Radio_File);
            this.groupBox1.Controls.Add(this.Radio_Screen);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод графа c:";
            // 
            // Radio_File
            // 
            this.Radio_File.AutoSize = true;
            this.Radio_File.Location = new System.Drawing.Point(7, 44);
            this.Radio_File.Name = "Radio_File";
            this.Radio_File.Size = new System.Drawing.Size(57, 17);
            this.Radio_File.TabIndex = 1;
            this.Radio_File.Text = "файла";
            this.Radio_File.UseVisualStyleBackColor = true;
            // 
            // Radio_Screen
            // 
            this.Radio_Screen.AutoSize = true;
            this.Radio_Screen.Checked = true;
            this.Radio_Screen.Location = new System.Drawing.Point(7, 20);
            this.Radio_Screen.Name = "Radio_Screen";
            this.Radio_Screen.Size = new System.Drawing.Size(61, 17);
            this.Radio_Screen.TabIndex = 0;
            this.Radio_Screen.TabStop = true;
            this.Radio_Screen.Text = "экрана";
            this.Radio_Screen.UseVisualStyleBackColor = true;
            // 
            // TextBox_G
            // 
            this.TextBox_G.Location = new System.Drawing.Point(19, 120);
            this.TextBox_G.Multiline = true;
            this.TextBox_G.Name = "TextBox_G";
            this.TextBox_G.Size = new System.Drawing.Size(279, 49);
            this.TextBox_G.TabIndex = 1;
            this.TextBox_G.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // TextBox_L
            // 
            this.TextBox_L.Location = new System.Drawing.Point(19, 193);
            this.TextBox_L.Multiline = true;
            this.TextBox_L.Name = "TextBox_L";
            this.TextBox_L.Size = new System.Drawing.Size(279, 50);
            this.TextBox_L.TabIndex = 2;
            this.TextBox_L.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // TextBox_P
            // 
            this.TextBox_P.Location = new System.Drawing.Point(19, 273);
            this.TextBox_P.Multiline = true;
            this.TextBox_P.Name = "TextBox_P";
            this.TextBox_P.Size = new System.Drawing.Size(279, 49);
            this.TextBox_P.TabIndex = 3;
            this.TextBox_P.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // Numeric_N
            // 
            this.Numeric_N.Location = new System.Drawing.Point(437, 48);
            this.Numeric_N.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Numeric_N.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Numeric_N.Name = "Numeric_N";
            this.Numeric_N.Size = new System.Drawing.Size(35, 20);
            this.Numeric_N.TabIndex = 4;
            this.Numeric_N.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Numeric_M
            // 
            this.Numeric_M.Location = new System.Drawing.Point(437, 72);
            this.Numeric_M.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Numeric_M.Name = "Numeric_M";
            this.Numeric_M.Size = new System.Drawing.Size(35, 20);
            this.Numeric_M.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Количество вершин (n):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Количество дуг (m):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Вектор связей:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Вектор весов дуг:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Вектор разделителей:";
            // 
            // Numeric_Start
            // 
            this.Numeric_Start.Location = new System.Drawing.Point(629, 48);
            this.Numeric_Start.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Numeric_Start.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Numeric_Start.Name = "Numeric_Start";
            this.Numeric_Start.Size = new System.Drawing.Size(35, 20);
            this.Numeric_Start.TabIndex = 11;
            this.Numeric_Start.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Numeric_End
            // 
            this.Numeric_End.Location = new System.Drawing.Point(629, 74);
            this.Numeric_End.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Numeric_End.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Numeric_End.Name = "Numeric_End";
            this.Numeric_End.Size = new System.Drawing.Size(35, 20);
            this.Numeric_End.TabIndex = 12;
            this.Numeric_End.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(502, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Стартовая вершина:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(503, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Конечная вершина:";
            // 
            // Button_Input
            // 
            this.Button_Input.Location = new System.Drawing.Point(492, 337);
            this.Button_Input.Name = "Button_Input";
            this.Button_Input.Size = new System.Drawing.Size(80, 38);
            this.Button_Input.TabIndex = 15;
            this.Button_Input.Text = "Ввести граф";
            this.Button_Input.UseVisualStyleBackColor = true;
            this.Button_Input.Click += new System.EventHandler(this.Button_Input_Click);
            // 
            // Button_Find_Way
            // 
            this.Button_Find_Way.Location = new System.Drawing.Point(587, 337);
            this.Button_Find_Way.Name = "Button_Find_Way";
            this.Button_Find_Way.Size = new System.Drawing.Size(80, 38);
            this.Button_Find_Way.TabIndex = 16;
            this.Button_Find_Way.Text = "Найти путь";
            this.Button_Find_Way.UseVisualStyleBackColor = true;
            this.Button_Find_Way.Click += new System.EventHandler(this.Button_Find_Way_Click);
            // 
            // RichTextBox_Show_Way
            // 
            this.RichTextBox_Show_Way.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RichTextBox_Show_Way.Location = new System.Drawing.Point(313, 120);
            this.RichTextBox_Show_Way.Name = "RichTextBox_Show_Way";
            this.RichTextBox_Show_Way.ReadOnly = true;
            this.RichTextBox_Show_Way.Size = new System.Drawing.Size(354, 202);
            this.RichTextBox_Show_Way.TabIndex = 17;
            this.RichTextBox_Show_Way.Text = "";
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 390);
            this.Controls.Add(this.RichTextBox_Show_Way);
            this.Controls.Add(this.Button_Find_Way);
            this.Controls.Add(this.Button_Input);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Numeric_End);
            this.Controls.Add(this.Numeric_Start);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Numeric_M);
            this.Controls.Add(this.Numeric_N);
            this.Controls.Add(this.TextBox_P);
            this.Controls.Add(this.TextBox_L);
            this.Controls.Add(this.TextBox_G);
            this.Controls.Add(this.groupBox1);
            this.Name = "MyForm";
            this.Text = "Домашнее задание";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_N)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_M)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_End)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Radio_File;
        private System.Windows.Forms.RadioButton Radio_Screen;
        private System.Windows.Forms.TextBox TextBox_G;
        private System.Windows.Forms.TextBox TextBox_L;
        private System.Windows.Forms.TextBox TextBox_P;
        private System.Windows.Forms.NumericUpDown Numeric_N;
        private System.Windows.Forms.NumericUpDown Numeric_M;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Numeric_Start;
        private System.Windows.Forms.NumericUpDown Numeric_End;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Button_Input;
        private System.Windows.Forms.Button Button_Find_Way;
        private System.Windows.Forms.RichTextBox RichTextBox_Show_Way;
        private System.Windows.Forms.OpenFileDialog OpenFile;


    }
}

