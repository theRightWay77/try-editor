
namespace попытка_редактора___1
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
            this.listViewWords = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.Deserialize = new System.Windows.Forms.Button();
            this.Serialize = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.Example = new System.Windows.Forms.TextBox();
            this.Translation = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TheWord = new System.Windows.Forms.TextBox();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewWords
            // 
            this.listViewWords.HideSelection = false;
            this.listViewWords.Location = new System.Drawing.Point(12, 42);
            this.listViewWords.Name = "listViewWords";
            this.listViewWords.Size = new System.Drawing.Size(313, 355);
            this.listViewWords.TabIndex = 0;
            this.listViewWords.UseCompatibleStateImageBehavior = false;
            this.listViewWords.View = System.Windows.Forms.View.List;
            this.listViewWords.SelectedIndexChanged += new System.EventHandler(this.listViewWords_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "все слова";
            // 
            // Deserialize
            // 
            this.Deserialize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Deserialize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deserialize.Location = new System.Drawing.Point(348, 364);
            this.Deserialize.Name = "Deserialize";
            this.Deserialize.Size = new System.Drawing.Size(167, 33);
            this.Deserialize.TabIndex = 6;
            this.Deserialize.Text = "Deserialize";
            this.Deserialize.UseVisualStyleBackColor = false;
            this.Deserialize.Click += new System.EventHandler(this.Deserialize_Click);
            // 
            // Serialize
            // 
            this.Serialize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Serialize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Serialize.Location = new System.Drawing.Point(525, 364);
            this.Serialize.Name = "Serialize";
            this.Serialize.Size = new System.Drawing.Size(167, 33);
            this.Serialize.TabIndex = 7;
            this.Serialize.Text = "Serialize";
            this.Serialize.UseVisualStyleBackColor = false;
            this.Serialize.Click += new System.EventHandler(this.Serialize_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.Example);
            this.panel.Controls.Add(this.Translation);
            this.panel.Controls.Add(this.Add);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.TheWord);
            this.panel.Location = new System.Drawing.Point(348, 42);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(344, 308);
            this.panel.TabIndex = 8;
            // 
            // Example
            // 
            this.Example.Location = new System.Drawing.Point(23, 187);
            this.Example.Name = "Example";
            this.Example.Size = new System.Drawing.Size(268, 22);
            this.Example.TabIndex = 9;
            // 
            // Translation
            // 
            this.Translation.Location = new System.Drawing.Point(23, 113);
            this.Translation.Name = "Translation";
            this.Translation.Size = new System.Drawing.Size(268, 22);
            this.Translation.TabIndex = 9;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Location = new System.Drawing.Point(183, 235);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(108, 33);
            this.Add.TabIndex = 10;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Пример";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Перевод";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Слово на дигорском";
            // 
            // TheWord
            // 
            this.TheWord.Location = new System.Drawing.Point(23, 51);
            this.TheWord.Name = "TheWord";
            this.TheWord.Size = new System.Drawing.Size(268, 22);
            this.TheWord.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.Serialize);
            this.Controls.Add(this.Deserialize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewWords);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewWords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Deserialize;
        private System.Windows.Forms.Button Serialize;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TheWord;
        private System.Windows.Forms.TextBox Example;
        private System.Windows.Forms.TextBox Translation;
    }
}

