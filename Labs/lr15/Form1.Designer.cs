
namespace lr15
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnChooseColor = new System.Windows.Forms.Button();
            this.panelChooseColor = new System.Windows.Forms.Panel();
            this.btnChooseFont = new System.Windows.Forms.Button();
            this.txtChooseFont = new System.Windows.Forms.TextBox();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.txtChooseFile = new System.Windows.Forms.TextBox();
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.txtChooseFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChooseColor
            // 
            this.btnChooseColor.Location = new System.Drawing.Point(109, 261);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(106, 23);
            this.btnChooseColor.TabIndex = 0;
            this.btnChooseColor.Text = "Выбор цвета";
            this.btnChooseColor.UseVisualStyleBackColor = true;
            this.btnChooseColor.Click += new System.EventHandler(this.btnChooseColor_Click);
            // 
            // panelChooseColor
            // 
            this.panelChooseColor.Location = new System.Drawing.Point(230, 261);
            this.panelChooseColor.Name = "panelChooseColor";
            this.panelChooseColor.Size = new System.Drawing.Size(200, 23);
            this.panelChooseColor.TabIndex = 1;
            // 
            // btnChooseFont
            // 
            this.btnChooseFont.Location = new System.Drawing.Point(109, 120);
            this.btnChooseFont.Name = "btnChooseFont";
            this.btnChooseFont.Size = new System.Drawing.Size(106, 23);
            this.btnChooseFont.TabIndex = 2;
            this.btnChooseFont.Text = "Выбор шрифта";
            this.btnChooseFont.UseVisualStyleBackColor = true;
            this.btnChooseFont.Click += new System.EventHandler(this.btnChooseFont_Click);
            // 
            // txtChooseFont
            // 
            this.txtChooseFont.Location = new System.Drawing.Point(230, 123);
            this.txtChooseFont.Name = "txtChooseFont";
            this.txtChooseFont.Size = new System.Drawing.Size(200, 20);
            this.txtChooseFont.TabIndex = 3;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(109, 168);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(106, 23);
            this.btnChooseFile.TabIndex = 4;
            this.btnChooseFile.Text = "Выбор файла";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // txtChooseFile
            // 
            this.txtChooseFile.Location = new System.Drawing.Point(230, 171);
            this.txtChooseFile.Name = "txtChooseFile";
            this.txtChooseFile.Size = new System.Drawing.Size(200, 20);
            this.txtChooseFile.TabIndex = 5;
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Location = new System.Drawing.Point(109, 217);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(106, 23);
            this.btnChooseFolder.TabIndex = 6;
            this.btnChooseFolder.Text = "Выбор каталога";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // txtChooseFolder
            // 
            this.txtChooseFolder.Location = new System.Drawing.Point(230, 220);
            this.txtChooseFolder.Name = "txtChooseFolder";
            this.txtChooseFolder.Size = new System.Drawing.Size(200, 20);
            this.txtChooseFolder.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Результат выражения";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(556, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(541, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Введите колличество слагаемых";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(565, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Введите целое число x";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(556, 184);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 20);
            this.textBox2.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(587, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Посчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(528, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Сохранить результат выражения";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 532);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChooseFolder);
            this.Controls.Add(this.btnChooseFolder);
            this.Controls.Add(this.txtChooseFile);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.txtChooseFont);
            this.Controls.Add(this.btnChooseFont);
            this.Controls.Add(this.panelChooseColor);
            this.Controls.Add(this.btnChooseColor);
            this.Name = "Form1";
            this.Text = "Тестирование диалоговых окон";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseColor;
        private System.Windows.Forms.Panel panelChooseColor;
        private System.Windows.Forms.Button btnChooseFont;
        private System.Windows.Forms.TextBox txtChooseFont;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.TextBox txtChooseFile;
        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.TextBox txtChooseFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

