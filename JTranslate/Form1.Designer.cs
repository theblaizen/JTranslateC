namespace JTranslate
{
    partial class JTranslateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JTranslateForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbPath = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbWords = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNotTranslated = new System.Windows.Forms.Label();
            this.lbOriginalWords = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.cb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMoveTo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose file:";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(82, 13);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(92, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(13, 110);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(94, 23);
            this.btnTranslate.TabIndex = 2;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(119, 73);
            this.tb1.Multiline = true;
            this.tb1.Name = "tb1";
            this.tb1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb1.Size = new System.Drawing.Size(389, 424);
            this.tb1.TabIndex = 3;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(548, 73);
            this.tb2.Multiline = true;
            this.tb2.Name = "tb2";
            this.tb2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb2.Size = new System.Drawing.Size(380, 424);
            this.tb2.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(13, 149);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear fields";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Location = new System.Drawing.Point(196, 18);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(0, 13);
            this.lbPath.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Words in dictionary";
            // 
            // lbWords
            // 
            this.lbWords.AutoSize = true;
            this.lbWords.Location = new System.Drawing.Point(39, 219);
            this.lbWords.Name = "lbWords";
            this.lbWords.Size = new System.Drawing.Size(21, 13);
            this.lbWords.TabIndex = 8;
            this.lbWords.Text = "lab";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 474);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save translate";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(581, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Not translated words: ";
            // 
            // lbNotTranslated
            // 
            this.lbNotTranslated.AutoSize = true;
            this.lbNotTranslated.Location = new System.Drawing.Point(697, 54);
            this.lbNotTranslated.Name = "lbNotTranslated";
            this.lbNotTranslated.Size = new System.Drawing.Size(0, 13);
            this.lbNotTranslated.TabIndex = 11;
            // 
            // lbOriginalWords
            // 
            this.lbOriginalWords.AutoSize = true;
            this.lbOriginalWords.Location = new System.Drawing.Point(211, 54);
            this.lbOriginalWords.Name = "lbOriginalWords";
            this.lbOriginalWords.Size = new System.Drawing.Size(0, 13);
            this.lbOriginalWords.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Words: ";
            // 
            // cb
            // 
            this.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb.FormattingEnabled = true;
            this.cb.Location = new System.Drawing.Point(13, 73);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(94, 21);
            this.cb.TabIndex = 14;
            this.cb.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Select language:";
            // 
            // btnMoveTo
            // 
            this.btnMoveTo.Location = new System.Drawing.Point(514, 269);
            this.btnMoveTo.Name = "btnMoveTo";
            this.btnMoveTo.Size = new System.Drawing.Size(27, 23);
            this.btnMoveTo.TabIndex = 16;
            this.btnMoveTo.Text = "<<";
            this.btnMoveTo.UseVisualStyleBackColor = true;
            this.btnMoveTo.Click += new System.EventHandler(this.btnMoveTo_Click);
            // 
            // JTranslateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 506);
            this.Controls.Add(this.btnMoveTo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.lbOriginalWords);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbNotTranslated);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbWords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbPath);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JTranslateForm";
            this.Text = "JTranslate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbWords;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbNotTranslated;
        private System.Windows.Forms.Label lbOriginalWords;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMoveTo;
    }
}

