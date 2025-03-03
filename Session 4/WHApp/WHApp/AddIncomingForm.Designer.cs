namespace WHApp
{
    partial class AddIncomingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddIncomingForm));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.textList = new Guna.UI2.WinForms.Guna2TextBox();
            this.textDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.textCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.textAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoScroll = true;
            this.guna2Panel1.Controls.Add(this.AddButton);
            this.guna2Panel1.Controls.Add(this.textAmount);
            this.guna2Panel1.Controls.Add(this.textNumber);
            this.guna2Panel1.Controls.Add(this.textList);
            this.guna2Panel1.Controls.Add(this.textDate);
            this.guna2Panel1.Controls.Add(this.textCode);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(361, 368);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(16, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Оформление приходной накладной";
            // 
            // textNumber
            // 
            this.textNumber.Animated = true;
            this.textNumber.BorderColor = System.Drawing.Color.Silver;
            this.textNumber.BorderRadius = 5;
            this.textNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textNumber.DefaultText = "";
            this.textNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textNumber.ForeColor = System.Drawing.Color.Black;
            this.textNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textNumber.Location = new System.Drawing.Point(45, 61);
            this.textNumber.Name = "textNumber";
            this.textNumber.PlaceholderText = "Номер";
            this.textNumber.SelectedText = "";
            this.textNumber.Size = new System.Drawing.Size(270, 28);
            this.textNumber.TabIndex = 10;
            // 
            // textList
            // 
            this.textList.Animated = true;
            this.textList.BorderColor = System.Drawing.Color.Silver;
            this.textList.BorderRadius = 5;
            this.textList.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textList.DefaultText = "";
            this.textList.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textList.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textList.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textList.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textList.ForeColor = System.Drawing.Color.Black;
            this.textList.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textList.Location = new System.Drawing.Point(45, 172);
            this.textList.Name = "textList";
            this.textList.PlaceholderText = "Список товаров";
            this.textList.SelectedText = "";
            this.textList.Size = new System.Drawing.Size(270, 28);
            this.textList.TabIndex = 13;
            // 
            // textDate
            // 
            this.textDate.Animated = true;
            this.textDate.BorderColor = System.Drawing.Color.Silver;
            this.textDate.BorderRadius = 5;
            this.textDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textDate.DefaultText = "";
            this.textDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textDate.ForeColor = System.Drawing.Color.Black;
            this.textDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textDate.Location = new System.Drawing.Point(45, 98);
            this.textDate.Name = "textDate";
            this.textDate.PlaceholderText = "Дата получения";
            this.textDate.SelectedText = "";
            this.textDate.Size = new System.Drawing.Size(270, 28);
            this.textDate.TabIndex = 11;
            // 
            // textCode
            // 
            this.textCode.Animated = true;
            this.textCode.BorderColor = System.Drawing.Color.Silver;
            this.textCode.BorderRadius = 5;
            this.textCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textCode.DefaultText = "";
            this.textCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textCode.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textCode.ForeColor = System.Drawing.Color.Black;
            this.textCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textCode.Location = new System.Drawing.Point(45, 135);
            this.textCode.Name = "textCode";
            this.textCode.PlaceholderText = "Код поставщика";
            this.textCode.SelectedText = "";
            this.textCode.Size = new System.Drawing.Size(270, 28);
            this.textCode.TabIndex = 12;
            // 
            // textAmount
            // 
            this.textAmount.Animated = true;
            this.textAmount.BorderColor = System.Drawing.Color.Silver;
            this.textAmount.BorderRadius = 5;
            this.textAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textAmount.DefaultText = "";
            this.textAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textAmount.ForeColor = System.Drawing.Color.Black;
            this.textAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textAmount.Location = new System.Drawing.Point(45, 209);
            this.textAmount.Name = "textAmount";
            this.textAmount.PlaceholderText = "Общая сумма";
            this.textAmount.SelectedText = "";
            this.textAmount.Size = new System.Drawing.Size(270, 28);
            this.textAmount.TabIndex = 14;
            // 
            // AddButton
            // 
            this.AddButton.Animated = true;
            this.AddButton.BorderColor = System.Drawing.Color.Silver;
            this.AddButton.BorderRadius = 15;
            this.AddButton.BorderThickness = 1;
            this.AddButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddButton.FillColor = System.Drawing.Color.White;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.ForeColor = System.Drawing.Color.Black;
            this.AddButton.HoverState.BorderColor = System.Drawing.Color.SteelBlue;
            this.AddButton.HoverState.FillColor = System.Drawing.Color.White;
            this.AddButton.HoverState.ForeColor = System.Drawing.Color.SteelBlue;
            this.AddButton.Location = new System.Drawing.Point(45, 316);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(270, 40);
            this.AddButton.TabIndex = 15;
            this.AddButton.Text = "Оформить";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddIncomingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(361, 368);
            this.Controls.Add(this.guna2Panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(377, 407);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(377, 407);
            this.Name = "AddIncomingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оформить приходную накладную";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox textAmount;
        private Guna.UI2.WinForms.Guna2TextBox textNumber;
        private Guna.UI2.WinForms.Guna2TextBox textList;
        private Guna.UI2.WinForms.Guna2TextBox textDate;
        private Guna.UI2.WinForms.Guna2TextBox textCode;
        private Guna.UI2.WinForms.Guna2Button AddButton;
    }
}