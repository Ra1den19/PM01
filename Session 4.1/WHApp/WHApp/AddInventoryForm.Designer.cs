namespace WHApp
{
    partial class AddInventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddInventoryForm));
            this.AddButton = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textDateEvent = new Guna.UI2.WinForms.Guna2TextBox();
            this.textResults = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
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
            this.AddButton.Location = new System.Drawing.Point(39, 321);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(270, 40);
            this.AddButton.TabIndex = 26;
            this.AddButton.Text = "Провести";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(36, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Проведение инвентаризации";
            // 
            // textDateEvent
            // 
            this.textDateEvent.Animated = true;
            this.textDateEvent.BorderColor = System.Drawing.Color.Silver;
            this.textDateEvent.BorderRadius = 5;
            this.textDateEvent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textDateEvent.DefaultText = "";
            this.textDateEvent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textDateEvent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textDateEvent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textDateEvent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textDateEvent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textDateEvent.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textDateEvent.ForeColor = System.Drawing.Color.Black;
            this.textDateEvent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textDateEvent.Location = new System.Drawing.Point(39, 79);
            this.textDateEvent.Name = "textDateEvent";
            this.textDateEvent.PlaceholderText = "Дата события";
            this.textDateEvent.SelectedText = "";
            this.textDateEvent.Size = new System.Drawing.Size(270, 28);
            this.textDateEvent.TabIndex = 21;
            // 
            // textResults
            // 
            this.textResults.Animated = true;
            this.textResults.BorderColor = System.Drawing.Color.Silver;
            this.textResults.BorderRadius = 5;
            this.textResults.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textResults.DefaultText = "";
            this.textResults.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textResults.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textResults.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textResults.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textResults.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textResults.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textResults.ForeColor = System.Drawing.Color.Black;
            this.textResults.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textResults.Location = new System.Drawing.Point(39, 124);
            this.textResults.Name = "textResults";
            this.textResults.PlaceholderText = "Результаты";
            this.textResults.SelectedText = "";
            this.textResults.Size = new System.Drawing.Size(270, 28);
            this.textResults.TabIndex = 23;
            // 
            // AddInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(345, 379);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textDateEvent);
            this.Controls.Add(this.textResults);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddInventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Провести инвентаризацию";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button AddButton;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox textDateEvent;
        private Guna.UI2.WinForms.Guna2TextBox textResults;
    }
}