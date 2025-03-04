namespace WHApp
{
    partial class AddProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.AddButton = new Guna.UI2.WinForms.Guna2Button();
            this.textPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.textName = new Guna.UI2.WinForms.Guna2TextBox();
            this.textIzm = new Guna.UI2.WinForms.Guna2TextBox();
            this.textArt = new Guna.UI2.WinForms.Guna2TextBox();
            this.textCat = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textSerial = new Guna.UI2.WinForms.Guna2TextBox();
            this.textMin = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoScroll = true;
            this.guna2Panel1.Controls.Add(this.textMin);
            this.guna2Panel1.Controls.Add(this.textSerial);
            this.guna2Panel1.Controls.Add(this.AddButton);
            this.guna2Panel1.Controls.Add(this.textPrice);
            this.guna2Panel1.Controls.Add(this.textName);
            this.guna2Panel1.Controls.Add(this.textIzm);
            this.guna2Panel1.Controls.Add(this.textArt);
            this.guna2Panel1.Controls.Add(this.textCat);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(647, 379);
            this.guna2Panel1.TabIndex = 1;
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
            this.AddButton.Location = new System.Drawing.Point(191, 327);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(270, 40);
            this.AddButton.TabIndex = 15;
            this.AddButton.Text = "Добавить";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // textPrice
            // 
            this.textPrice.Animated = true;
            this.textPrice.BorderColor = System.Drawing.Color.Silver;
            this.textPrice.BorderRadius = 5;
            this.textPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPrice.DefaultText = "";
            this.textPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPrice.ForeColor = System.Drawing.Color.Black;
            this.textPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textPrice.Location = new System.Drawing.Point(39, 260);
            this.textPrice.Name = "textPrice";
            this.textPrice.PlaceholderText = "Цена за единицу";
            this.textPrice.SelectedText = "";
            this.textPrice.Size = new System.Drawing.Size(270, 28);
            this.textPrice.TabIndex = 14;
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
            this.textName.Location = new System.Drawing.Point(39, 61);
            this.textName.Name = "textName";
            this.textName.PlaceholderText = "Наименование";
            this.textName.SelectedText = "";
            this.textName.Size = new System.Drawing.Size(270, 28);
            this.textName.TabIndex = 10;
            // 
            // textIzm
            // 
            this.textIzm.Animated = true;
            this.textIzm.BorderColor = System.Drawing.Color.Silver;
            this.textIzm.BorderRadius = 5;
            this.textIzm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textIzm.DefaultText = "";
            this.textIzm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textIzm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textIzm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textIzm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textIzm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textIzm.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textIzm.ForeColor = System.Drawing.Color.Black;
            this.textIzm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textIzm.Location = new System.Drawing.Point(39, 211);
            this.textIzm.Name = "textIzm";
            this.textIzm.PlaceholderText = "Единица измерения";
            this.textIzm.SelectedText = "";
            this.textIzm.Size = new System.Drawing.Size(270, 28);
            this.textIzm.TabIndex = 13;
            // 
            // textArt
            // 
            this.textArt.Animated = true;
            this.textArt.BorderColor = System.Drawing.Color.Silver;
            this.textArt.BorderRadius = 5;
            this.textArt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textArt.DefaultText = "";
            this.textArt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textArt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textArt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textArt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textArt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textArt.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textArt.ForeColor = System.Drawing.Color.Black;
            this.textArt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textArt.Location = new System.Drawing.Point(39, 110);
            this.textArt.Name = "textArt";
            this.textArt.PlaceholderText = "Артикул";
            this.textArt.SelectedText = "";
            this.textArt.Size = new System.Drawing.Size(270, 28);
            this.textArt.TabIndex = 11;
            // 
            // textCat
            // 
            this.textCat.Animated = true;
            this.textCat.BorderColor = System.Drawing.Color.Silver;
            this.textCat.BorderRadius = 5;
            this.textCat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textCat.DefaultText = "";
            this.textCat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textCat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textCat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textCat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textCat.ForeColor = System.Drawing.Color.Black;
            this.textCat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textCat.Location = new System.Drawing.Point(39, 160);
            this.textCat.Name = "textCat";
            this.textCat.PlaceholderText = "Категория";
            this.textCat.SelectedText = "";
            this.textCat.Size = new System.Drawing.Size(270, 28);
            this.textCat.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(231, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Добавление товара";
            // 
            // textSerial
            // 
            this.textSerial.Animated = true;
            this.textSerial.BorderColor = System.Drawing.Color.Silver;
            this.textSerial.BorderRadius = 5;
            this.textSerial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textSerial.DefaultText = "";
            this.textSerial.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textSerial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textSerial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textSerial.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textSerial.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textSerial.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textSerial.ForeColor = System.Drawing.Color.Black;
            this.textSerial.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textSerial.Location = new System.Drawing.Point(340, 61);
            this.textSerial.Name = "textSerial";
            this.textSerial.PlaceholderText = "Серийный номер";
            this.textSerial.SelectedText = "";
            this.textSerial.Size = new System.Drawing.Size(270, 28);
            this.textSerial.TabIndex = 16;
            // 
            // textMin
            // 
            this.textMin.Animated = true;
            this.textMin.BorderColor = System.Drawing.Color.Silver;
            this.textMin.BorderRadius = 5;
            this.textMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textMin.DefaultText = "";
            this.textMin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textMin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textMin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textMin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textMin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textMin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textMin.ForeColor = System.Drawing.Color.Black;
            this.textMin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textMin.Location = new System.Drawing.Point(340, 110);
            this.textMin.Name = "textMin";
            this.textMin.PlaceholderText = "Минимальный остаток";
            this.textMin.SelectedText = "";
            this.textMin.Size = new System.Drawing.Size(270, 28);
            this.textMin.TabIndex = 17;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(647, 379);
            this.Controls.Add(this.guna2Panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(663, 418);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(663, 418);
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить товар";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox textMin;
        private Guna.UI2.WinForms.Guna2TextBox textSerial;
        private Guna.UI2.WinForms.Guna2Button AddButton;
        private Guna.UI2.WinForms.Guna2TextBox textPrice;
        private Guna.UI2.WinForms.Guna2TextBox textName;
        private Guna.UI2.WinForms.Guna2TextBox textIzm;
        private Guna.UI2.WinForms.Guna2TextBox textArt;
        private Guna.UI2.WinForms.Guna2TextBox textCat;
        private System.Windows.Forms.Label label3;
    }
}