namespace WHApp
{
    partial class AddSupplierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSupplierForm));
            this.textContact = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddButton = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textName = new Guna.UI2.WinForms.Guna2TextBox();
            this.textINN = new Guna.UI2.WinForms.Guna2TextBox();
            this.textAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // textContact
            // 
            this.textContact.Animated = true;
            this.textContact.BorderColor = System.Drawing.Color.Silver;
            this.textContact.BorderRadius = 5;
            this.textContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textContact.DefaultText = "";
            this.textContact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textContact.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textContact.ForeColor = System.Drawing.Color.Black;
            this.textContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textContact.Location = new System.Drawing.Point(37, 170);
            this.textContact.Name = "textContact";
            this.textContact.PlaceholderText = "Контактные данные";
            this.textContact.SelectedText = "";
            this.textContact.Size = new System.Drawing.Size(270, 28);
            this.textContact.TabIndex = 36;
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
            this.AddButton.Location = new System.Drawing.Point(37, 321);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(270, 40);
            this.AddButton.TabIndex = 35;
            this.AddButton.Text = "Добавить";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(53, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = "Добавление поставщика";
            // 
            // textName
            // 
            this.textName.Animated = true;
            this.textName.BorderColor = System.Drawing.Color.Silver;
            this.textName.BorderRadius = 5;
            this.textName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textName.DefaultText = "";
            this.textName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textName.ForeColor = System.Drawing.Color.Black;
            this.textName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textName.Location = new System.Drawing.Point(37, 79);
            this.textName.Name = "textName";
            this.textName.PlaceholderText = "Название";
            this.textName.SelectedText = "";
            this.textName.Size = new System.Drawing.Size(270, 28);
            this.textName.TabIndex = 32;
            // 
            // textINN
            // 
            this.textINN.Animated = true;
            this.textINN.BorderColor = System.Drawing.Color.Silver;
            this.textINN.BorderRadius = 5;
            this.textINN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textINN.DefaultText = "";
            this.textINN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textINN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textINN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textINN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textINN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textINN.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textINN.ForeColor = System.Drawing.Color.Black;
            this.textINN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textINN.Location = new System.Drawing.Point(37, 124);
            this.textINN.Name = "textINN";
            this.textINN.PlaceholderText = "ИНН/КПП";
            this.textINN.SelectedText = "";
            this.textINN.Size = new System.Drawing.Size(270, 28);
            this.textINN.TabIndex = 33;
            // 
            // textAddress
            // 
            this.textAddress.Animated = true;
            this.textAddress.BorderColor = System.Drawing.Color.Silver;
            this.textAddress.BorderRadius = 5;
            this.textAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textAddress.DefaultText = "";
            this.textAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textAddress.ForeColor = System.Drawing.Color.Black;
            this.textAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textAddress.Location = new System.Drawing.Point(37, 215);
            this.textAddress.Name = "textAddress";
            this.textAddress.PlaceholderText = "Адрес";
            this.textAddress.SelectedText = "";
            this.textAddress.Size = new System.Drawing.Size(270, 28);
            this.textAddress.TabIndex = 37;
            // 
            // AddSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(345, 379);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textContact);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textINN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSupplierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить поставщика";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox textContact;
        private Guna.UI2.WinForms.Guna2Button AddButton;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox textName;
        private Guna.UI2.WinForms.Guna2TextBox textINN;
        private Guna.UI2.WinForms.Guna2TextBox textAddress;
    }
}