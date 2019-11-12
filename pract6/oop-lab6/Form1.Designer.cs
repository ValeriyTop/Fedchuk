namespace oop-lab6
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonResult = new System.Windows.Forms.Button();
            this.checkBoxWindowsill = new System.Windows.Forms.CheckBox();
            this.radioButtonTwoCam = new System.Windows.Forms.RadioButton();
            this.radioButtonOneCam = new System.Windows.Forms.RadioButton();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(111, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Розміри вікна:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(111, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ширина (см) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(111, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Висота (см) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(139, 235);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Матеріал:";
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(559, 260);
            this.buttonResult.Margin = new System.Windows.Forms.Padding(5);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(144, 35);
            this.buttonResult.TabIndex = 4;
            this.buttonResult.Text = "Розрахувати";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.ButtonResult_Click);
            // 
            // checkBoxWindowsill
            // 
            this.checkBoxWindowsill.AutoSize = true;
            this.checkBoxWindowsill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxWindowsill.Location = new System.Drawing.Point(559, 225);
            this.checkBoxWindowsill.Margin = new System.Windows.Forms.Padding(5);
            this.checkBoxWindowsill.Name = "checkBoxWindowsill";
            this.checkBoxWindowsill.Size = new System.Drawing.Size(123, 24);
            this.checkBoxWindowsill.TabIndex = 5;
            this.checkBoxWindowsill.Text = "Підвіконня";
            this.checkBoxWindowsill.UseVisualStyleBackColor = true;
            // 
            // radioButtonTwoCam
            // 
            this.radioButtonTwoCam.AutoSize = true;
            this.radioButtonTwoCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonTwoCam.Location = new System.Drawing.Point(550, 165);
            this.radioButtonTwoCam.Margin = new System.Windows.Forms.Padding(5);
            this.radioButtonTwoCam.Name = "radioButtonTwoCam";
            this.radioButtonTwoCam.Size = new System.Drawing.Size(144, 24);
            this.radioButtonTwoCam.TabIndex = 6;
            this.radioButtonTwoCam.TabStop = true;
            this.radioButtonTwoCam.Text = "Двокамерний";
            this.radioButtonTwoCam.UseVisualStyleBackColor = true;
            // 
            // radioButtonOneCam
            // 
            this.radioButtonOneCam.AutoSize = true;
            this.radioButtonOneCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonOneCam.Location = new System.Drawing.Point(550, 129);
            this.radioButtonOneCam.Margin = new System.Windows.Forms.Padding(5);
            this.radioButtonOneCam.Name = "radioButtonOneCam";
            this.radioButtonOneCam.Size = new System.Drawing.Size(156, 24);
            this.radioButtonOneCam.TabIndex = 7;
            this.radioButtonOneCam.TabStop = true;
            this.radioButtonOneCam.Text = "Однокамерний";
            this.radioButtonOneCam.UseVisualStyleBackColor = true;
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaterial.FormattingEnabled = true;
            this.comboBoxMaterial.Items.AddRange(new object[] {
            "Дерево",
            "Метал",
            "Металопластик"});
            this.comboBoxMaterial.Location = new System.Drawing.Point(246, 231);
            this.comboBoxMaterial.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(199, 28);
            this.comboBoxMaterial.TabIndex = 8;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(246, 185);
            this.textBoxHeight.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(215, 27);
            this.textBoxHeight.TabIndex = 9;
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(246, 135);
            this.textBoxWidth.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(215, 27);
            this.textBoxWidth.TabIndex = 10;

            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(149, 294);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(0, 20);
            this.labelPrice.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(545, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Склопакет:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 692);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.comboBoxMaterial);
            this.Controls.Add(this.radioButtonOneCam);
            this.Controls.Add(this.radioButtonTwoCam);
            this.Controls.Add(this.checkBoxWindowsill);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.CheckBox checkBoxWindowsill;
        private System.Windows.Forms.RadioButton radioButtonTwoCam;
        private System.Windows.Forms.RadioButton radioButtonOneCam;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label label6;
    }
}