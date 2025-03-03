namespace WHApp
{
    partial class AuthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this.AuthEmailButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.textLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.textPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.textPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.AuthLoginButton = new Guna.UI2.WinForms.Guna2Button();
            this.toggleSwitchPass = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.toggleSwitchPassword = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2Panel1.SuspendLayout();
            this.guna2TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AuthEmailButton
            // 
            this.AuthEmailButton.Animated = true;
            this.AuthEmailButton.BorderColor = System.Drawing.Color.Silver;
            this.AuthEmailButton.BorderRadius = 15;
            this.AuthEmailButton.BorderThickness = 1;
            this.AuthEmailButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AuthEmailButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AuthEmailButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AuthEmailButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AuthEmailButton.FillColor = System.Drawing.Color.White;
            this.AuthEmailButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthEmailButton.ForeColor = System.Drawing.Color.Black;
            this.AuthEmailButton.HoverState.BorderColor = System.Drawing.Color.SteelBlue;
            this.AuthEmailButton.HoverState.FillColor = System.Drawing.Color.White;
            this.AuthEmailButton.HoverState.ForeColor = System.Drawing.Color.SteelBlue;
            this.AuthEmailButton.Location = new System.Drawing.Point(123, 256);
            this.AuthEmailButton.Name = "AuthEmailButton";
            this.AuthEmailButton.Size = new System.Drawing.Size(270, 40);
            this.AuthEmailButton.TabIndex = 3;
            this.AuthEmailButton.Text = "Войти";
            this.AuthEmailButton.Click += new System.EventHandler(this.AuthEmailButton_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.toggleSwitchPassword);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.textPassword);
            this.guna2Panel1.Controls.Add(this.textLogin);
            this.guna2Panel1.Location = new System.Drawing.Point(39, 15);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(442, 220);
            this.guna2Panel1.TabIndex = 4;
            // 
            // textLogin
            // 
            this.textLogin.Animated = true;
            this.textLogin.BorderColor = System.Drawing.Color.Silver;
            this.textLogin.BorderRadius = 5;
            this.textLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textLogin.DefaultText = "";
            this.textLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLogin.ForeColor = System.Drawing.Color.Black;
            this.textLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textLogin.Location = new System.Drawing.Point(84, 87);
            this.textLogin.Name = "textLogin";
            this.textLogin.PlaceholderText = "Введите свой логин";
            this.textLogin.SelectedText = "";
            this.textLogin.Size = new System.Drawing.Size(270, 28);
            this.textLogin.TabIndex = 3;
            // 
            // textPassword
            // 
            this.textPassword.Animated = true;
            this.textPassword.BorderColor = System.Drawing.Color.Silver;
            this.textPassword.BorderRadius = 5;
            this.textPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPassword.DefaultText = "";
            this.textPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.textPassword.ForeColor = System.Drawing.Color.Black;
            this.textPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textPassword.Location = new System.Drawing.Point(84, 158);
            this.textPassword.Name = "textPassword";
            this.textPassword.PlaceholderText = "Введите свой пароль";
            this.textPassword.SelectedText = "";
            this.textPassword.Size = new System.Drawing.Size(270, 28);
            this.textPassword.TabIndex = 4;
            this.textPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(92, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(92, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(107, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Вход в учётную запись";
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Controls.Add(this.tabPage1);
            this.guna2TabControl1.Controls.Add(this.tabPage2);
            this.guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(0, 0);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(543, 367);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.Black;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.Black;
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.Black;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabIndex = 5;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AuthLoginButton);
            this.tabPage1.Controls.Add(this.guna2Panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(535, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Вход по логину";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.guna2Panel2);
            this.tabPage2.Controls.Add(this.AuthEmailButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(535, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Вход по почте";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel2.BorderRadius = 5;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.toggleSwitchPass);
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.Controls.Add(this.label6);
            this.guna2Panel2.Controls.Add(this.textEmail);
            this.guna2Panel2.Controls.Add(this.textPass);
            this.guna2Panel2.Location = new System.Drawing.Point(39, 15);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(442, 220);
            this.guna2Panel2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(107, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Вход в учётную запись";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(92, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Пароль";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(92, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Почта";
            // 
            // textEmail
            // 
            this.textEmail.Animated = true;
            this.textEmail.BorderColor = System.Drawing.Color.Silver;
            this.textEmail.BorderRadius = 5;
            this.textEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textEmail.DefaultText = "";
            this.textEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textEmail.ForeColor = System.Drawing.Color.Black;
            this.textEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textEmail.Location = new System.Drawing.Point(84, 87);
            this.textEmail.Name = "textEmail";
            this.textEmail.PlaceholderText = "Введите свою почту";
            this.textEmail.SelectedText = "";
            this.textEmail.Size = new System.Drawing.Size(270, 28);
            this.textEmail.TabIndex = 4;
            // 
            // textPass
            // 
            this.textPass.Animated = true;
            this.textPass.BorderColor = System.Drawing.Color.Silver;
            this.textPass.BorderRadius = 5;
            this.textPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPass.DefaultText = "";
            this.textPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textPass.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPass.ForeColor = System.Drawing.Color.Black;
            this.textPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textPass.Location = new System.Drawing.Point(84, 158);
            this.textPass.Name = "textPass";
            this.textPass.PlaceholderText = "Введите свой пароль";
            this.textPass.SelectedText = "";
            this.textPass.Size = new System.Drawing.Size(270, 28);
            this.textPass.TabIndex = 3;
            this.textPass.UseSystemPasswordChar = true;
            // 
            // AuthLoginButton
            // 
            this.AuthLoginButton.Animated = true;
            this.AuthLoginButton.BorderColor = System.Drawing.Color.Silver;
            this.AuthLoginButton.BorderRadius = 15;
            this.AuthLoginButton.BorderThickness = 1;
            this.AuthLoginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AuthLoginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AuthLoginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AuthLoginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AuthLoginButton.FillColor = System.Drawing.Color.White;
            this.AuthLoginButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthLoginButton.ForeColor = System.Drawing.Color.Black;
            this.AuthLoginButton.HoverState.BorderColor = System.Drawing.Color.SteelBlue;
            this.AuthLoginButton.HoverState.FillColor = System.Drawing.Color.White;
            this.AuthLoginButton.HoverState.ForeColor = System.Drawing.Color.SteelBlue;
            this.AuthLoginButton.Location = new System.Drawing.Point(123, 256);
            this.AuthLoginButton.Name = "AuthLoginButton";
            this.AuthLoginButton.Size = new System.Drawing.Size(270, 40);
            this.AuthLoginButton.TabIndex = 5;
            this.AuthLoginButton.Text = "Войти";
            this.AuthLoginButton.Click += new System.EventHandler(this.AuthLoginButton_Click);
            // 
            // toggleSwitchPass
            // 
            this.toggleSwitchPass.Animated = true;
            this.toggleSwitchPass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleSwitchPass.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleSwitchPass.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleSwitchPass.CheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleSwitchPass.Location = new System.Drawing.Point(371, 161);
            this.toggleSwitchPass.Name = "toggleSwitchPass";
            this.toggleSwitchPass.Size = new System.Drawing.Size(44, 20);
            this.toggleSwitchPass.TabIndex = 6;
            this.toggleSwitchPass.UncheckedState.BorderColor = System.Drawing.Color.Silver;
            this.toggleSwitchPass.UncheckedState.BorderThickness = 1;
            this.toggleSwitchPass.UncheckedState.FillColor = System.Drawing.Color.White;
            this.toggleSwitchPass.UncheckedState.InnerBorderColor = System.Drawing.Color.Black;
            this.toggleSwitchPass.UncheckedState.InnerColor = System.Drawing.Color.Black;
            this.toggleSwitchPass.CheckedChanged += new System.EventHandler(this.toggleSwitchPass_CheckedChanged);
            // 
            // toggleSwitchPassword
            // 
            this.toggleSwitchPassword.Animated = true;
            this.toggleSwitchPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleSwitchPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleSwitchPassword.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleSwitchPassword.CheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleSwitchPassword.Location = new System.Drawing.Point(371, 161);
            this.toggleSwitchPassword.Name = "toggleSwitchPassword";
            this.toggleSwitchPassword.Size = new System.Drawing.Size(44, 20);
            this.toggleSwitchPassword.TabIndex = 8;
            this.toggleSwitchPassword.UncheckedState.BorderColor = System.Drawing.Color.Silver;
            this.toggleSwitchPassword.UncheckedState.BorderThickness = 1;
            this.toggleSwitchPassword.UncheckedState.FillColor = System.Drawing.Color.White;
            this.toggleSwitchPassword.UncheckedState.InnerBorderColor = System.Drawing.Color.Black;
            this.toggleSwitchPassword.UncheckedState.InnerColor = System.Drawing.Color.Black;
            this.toggleSwitchPassword.CheckedChanged += new System.EventHandler(this.toggleSwitchPassword_CheckedChanged);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(543, 367);
            this.Controls.Add(this.guna2TabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(559, 406);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(559, 406);
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приложение для автоматизации складского учета";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button AuthEmailButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox textPassword;
        private Guna.UI2.WinForms.Guna2TextBox textLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox textEmail;
        private Guna.UI2.WinForms.Guna2TextBox textPass;
        private Guna.UI2.WinForms.Guna2Button AuthLoginButton;
        private Guna.UI2.WinForms.Guna2ToggleSwitch toggleSwitchPassword;
        private Guna.UI2.WinForms.Guna2ToggleSwitch toggleSwitchPass;
    }
}

