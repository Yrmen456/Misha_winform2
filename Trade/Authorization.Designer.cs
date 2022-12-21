
namespace Trade
{
    partial class Authorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.LogUpBtn = new System.Windows.Forms.Button();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.LogUpBtn2 = new System.Windows.Forms.Button();
            this.FormPanel = new System.Windows.Forms.Panel();
            this.PasswordBtn = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.FormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogUpBtn
            // 
            this.LogUpBtn.Location = new System.Drawing.Point(198, 268);
            this.LogUpBtn.Name = "LogUpBtn";
            this.LogUpBtn.Size = new System.Drawing.Size(123, 43);
            this.LogUpBtn.TabIndex = 4;
            this.LogUpBtn.Text = "Войти";
            this.LogUpBtn.UseVisualStyleBackColor = true;
            this.LogUpBtn.Click += new System.EventHandler(this.LogUpBtn_Click);
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTextBox.Location = new System.Drawing.Point(198, 132);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(280, 30);
            this.LoginTextBox.TabIndex = 1;
            this.LoginTextBox.Text = "Yrmen45";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextBox.Location = new System.Drawing.Point(198, 216);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(280, 30);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.Text = "qwerty";
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(193, 104);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(68, 25);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "Логин";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.Location = new System.Drawing.Point(193, 188);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(80, 25);
            this.PasswordLabel.TabIndex = 0;
            this.PasswordLabel.Text = "Пароль";
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Location = new System.Drawing.Point(356, 268);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(122, 43);
            this.LogOutBtn.TabIndex = 5;
            this.LogOutBtn.Text = "Отмена";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // LogUpBtn2
            // 
            this.LogUpBtn2.Location = new System.Drawing.Point(247, 334);
            this.LogUpBtn2.Name = "LogUpBtn2";
            this.LogUpBtn2.Size = new System.Drawing.Size(183, 43);
            this.LogUpBtn2.TabIndex = 6;
            this.LogUpBtn2.Text = "Зайти как Гость";
            this.LogUpBtn2.UseVisualStyleBackColor = true;
            this.LogUpBtn2.Click += new System.EventHandler(this.LogUpBtn2_Click);
            // 
            // FormPanel
            // 
            this.FormPanel.BackColor = System.Drawing.Color.Transparent;
            this.FormPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FormPanel.Controls.Add(this.PasswordBtn);
            this.FormPanel.Controls.Add(this.TitleLabel);
            this.FormPanel.Controls.Add(this.LogUpBtn2);
            this.FormPanel.Controls.Add(this.LogOutBtn);
            this.FormPanel.Controls.Add(this.LogUpBtn);
            this.FormPanel.Controls.Add(this.PasswordLabel);
            this.FormPanel.Controls.Add(this.LoginTextBox);
            this.FormPanel.Controls.Add(this.LoginLabel);
            this.FormPanel.Controls.Add(this.PasswordTextBox);
            this.FormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormPanel.Location = new System.Drawing.Point(0, 0);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(667, 429);
            this.FormPanel.TabIndex = 6;
            this.FormPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormPanel_MouseDown);
            // 
            // PasswordBtn
            // 
            this.PasswordBtn.Location = new System.Drawing.Point(485, 216);
            this.PasswordBtn.Margin = new System.Windows.Forms.Padding(0);
            this.PasswordBtn.Name = "PasswordBtn";
            this.PasswordBtn.Size = new System.Drawing.Size(30, 30);
            this.PasswordBtn.TabIndex = 3;
            this.PasswordBtn.Text = "☺";
            this.PasswordBtn.UseVisualStyleBackColor = true;
            this.PasswordBtn.Click += new System.EventHandler(this.PasswordBtn_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.Location = new System.Drawing.Point(24, 35);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(187, 32);
            this.TitleLabel.TabIndex = 6;
            this.TitleLabel.Text = "Авторизация";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleLabel_MouseDown);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(667, 429);
            this.Controls.Add(this.FormPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Authorization_Shown);
            this.FormPanel.ResumeLayout(false);
            this.FormPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LogUpBtn;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Button LogUpBtn2;
        private System.Windows.Forms.Panel FormPanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button PasswordBtn;
    }
}

