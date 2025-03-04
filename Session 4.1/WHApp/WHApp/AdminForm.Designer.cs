namespace WHApp
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.addWarehouseButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.listWH = new System.Windows.Forms.ListView();
            this.updateButton = new Guna.UI2.WinForms.Guna2Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.addProductButton = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.updateProductsButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.listProducts = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.addClientButton = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.updateClientsButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.listClients = new System.Windows.Forms.ListView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.addSupplierButton = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.updateSuppliersButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.listSuppliers = new System.Windows.Forms.ListView();
            this.guna2TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.guna2TabControl1.Controls.Add(this.tabPage1);
            this.guna2TabControl1.Controls.Add(this.tabPage2);
            this.guna2TabControl1.Controls.Add(this.tabPage3);
            this.guna2TabControl1.Controls.Add(this.tabPage4);
            this.guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 80);
            this.guna2TabControl1.Location = new System.Drawing.Point(0, 0);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(800, 450);
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
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 80);
            this.guna2TabControl1.TabIndex = 0;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.White;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.addWarehouseButton);
            this.tabPage1.Controls.Add(this.guna2Panel1);
            this.tabPage1.Controls.Add(this.updateButton);
            this.tabPage1.Location = new System.Drawing.Point(184, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(612, 442);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Администрирование складами";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Администрирование складами";
            // 
            // addWarehouseButton
            // 
            this.addWarehouseButton.Animated = true;
            this.addWarehouseButton.BorderColor = System.Drawing.Color.Silver;
            this.addWarehouseButton.BorderRadius = 20;
            this.addWarehouseButton.BorderThickness = 1;
            this.addWarehouseButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addWarehouseButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addWarehouseButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addWarehouseButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addWarehouseButton.FillColor = System.Drawing.Color.White;
            this.addWarehouseButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.addWarehouseButton.ForeColor = System.Drawing.Color.Black;
            this.addWarehouseButton.HoverState.BorderColor = System.Drawing.Color.SteelBlue;
            this.addWarehouseButton.HoverState.FillColor = System.Drawing.Color.White;
            this.addWarehouseButton.HoverState.ForeColor = System.Drawing.Color.SteelBlue;
            this.addWarehouseButton.Image = global::WHApp.Properties.Resources.Plus_Math;
            this.addWarehouseButton.ImageSize = new System.Drawing.Size(25, 25);
            this.addWarehouseButton.Location = new System.Drawing.Point(6, 326);
            this.addWarehouseButton.Name = "addWarehouseButton";
            this.addWarehouseButton.Size = new System.Drawing.Size(40, 40);
            this.addWarehouseButton.TabIndex = 8;
            this.addWarehouseButton.Click += new System.EventHandler(this.addWarehouseButton_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.listWH);
            this.guna2Panel1.Location = new System.Drawing.Point(6, 66);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(598, 251);
            this.guna2Panel1.TabIndex = 7;
            // 
            // listWH
            // 
            this.listWH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listWH.HideSelection = false;
            this.listWH.Location = new System.Drawing.Point(3, 3);
            this.listWH.Name = "listWH";
            this.listWH.Size = new System.Drawing.Size(592, 245);
            this.listWH.TabIndex = 0;
            this.listWH.UseCompatibleStateImageBehavior = false;
            // 
            // updateButton
            // 
            this.updateButton.Animated = true;
            this.updateButton.BorderColor = System.Drawing.Color.Silver;
            this.updateButton.BorderRadius = 20;
            this.updateButton.BorderThickness = 1;
            this.updateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateButton.FillColor = System.Drawing.Color.White;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.updateButton.ForeColor = System.Drawing.Color.Black;
            this.updateButton.HoverState.BorderColor = System.Drawing.Color.SteelBlue;
            this.updateButton.HoverState.FillColor = System.Drawing.Color.White;
            this.updateButton.HoverState.ForeColor = System.Drawing.Color.SteelBlue;
            this.updateButton.Image = global::WHApp.Properties.Resources.update;
            this.updateButton.ImageSize = new System.Drawing.Size(25, 25);
            this.updateButton.Location = new System.Drawing.Point(564, 326);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(40, 40);
            this.updateButton.TabIndex = 6;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.addProductButton);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.updateProductsButton);
            this.tabPage2.Controls.Add(this.guna2Panel2);
            this.tabPage2.Location = new System.Drawing.Point(184, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(612, 442);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Администрирование позицией товаров";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // addProductButton
            // 
            this.addProductButton.Animated = true;
            this.addProductButton.BorderColor = System.Drawing.Color.Silver;
            this.addProductButton.BorderRadius = 20;
            this.addProductButton.BorderThickness = 1;
            this.addProductButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addProductButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addProductButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addProductButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addProductButton.FillColor = System.Drawing.Color.White;
            this.addProductButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.addProductButton.ForeColor = System.Drawing.Color.Black;
            this.addProductButton.HoverState.BorderColor = System.Drawing.Color.SteelBlue;
            this.addProductButton.HoverState.FillColor = System.Drawing.Color.White;
            this.addProductButton.HoverState.ForeColor = System.Drawing.Color.SteelBlue;
            this.addProductButton.Image = global::WHApp.Properties.Resources.Plus_Math;
            this.addProductButton.ImageSize = new System.Drawing.Size(25, 25);
            this.addProductButton.Location = new System.Drawing.Point(6, 326);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(40, 40);
            this.addProductButton.TabIndex = 19;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Администрирование позицией товаров";
            // 
            // updateProductsButton
            // 
            this.updateProductsButton.Animated = true;
            this.updateProductsButton.BorderColor = System.Drawing.Color.Silver;
            this.updateProductsButton.BorderRadius = 20;
            this.updateProductsButton.BorderThickness = 1;
            this.updateProductsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateProductsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateProductsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateProductsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateProductsButton.FillColor = System.Drawing.Color.White;
            this.updateProductsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.updateProductsButton.ForeColor = System.Drawing.Color.Black;
            this.updateProductsButton.HoverState.BorderColor = System.Drawing.Color.SteelBlue;
            this.updateProductsButton.HoverState.FillColor = System.Drawing.Color.White;
            this.updateProductsButton.HoverState.ForeColor = System.Drawing.Color.SteelBlue;
            this.updateProductsButton.Image = global::WHApp.Properties.Resources.update;
            this.updateProductsButton.ImageSize = new System.Drawing.Size(25, 25);
            this.updateProductsButton.Location = new System.Drawing.Point(564, 326);
            this.updateProductsButton.Name = "updateProductsButton";
            this.updateProductsButton.Size = new System.Drawing.Size(40, 40);
            this.updateProductsButton.TabIndex = 9;
            this.updateProductsButton.Click += new System.EventHandler(this.updateProductsButton_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel2.BorderRadius = 5;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.listProducts);
            this.guna2Panel2.Location = new System.Drawing.Point(6, 66);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(598, 251);
            this.guna2Panel2.TabIndex = 8;
            // 
            // listProducts
            // 
            this.listProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listProducts.HideSelection = false;
            this.listProducts.Location = new System.Drawing.Point(3, 3);
            this.listProducts.Name = "listProducts";
            this.listProducts.Size = new System.Drawing.Size(592, 245);
            this.listProducts.TabIndex = 0;
            this.listProducts.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.addClientButton);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.updateClientsButton);
            this.tabPage3.Controls.Add(this.guna2Panel3);
            this.tabPage3.Location = new System.Drawing.Point(184, 4);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(612, 442);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Администрирование клиентами";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // addClientButton
            // 
            this.addClientButton.Animated = true;
            this.addClientButton.BorderColor = System.Drawing.Color.Silver;
            this.addClientButton.BorderRadius = 20;
            this.addClientButton.BorderThickness = 1;
            this.addClientButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addClientButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addClientButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addClientButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addClientButton.FillColor = System.Drawing.Color.White;
            this.addClientButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.addClientButton.ForeColor = System.Drawing.Color.Black;
            this.addClientButton.HoverState.BorderColor = System.Drawing.Color.SteelBlue;
            this.addClientButton.HoverState.FillColor = System.Drawing.Color.White;
            this.addClientButton.HoverState.ForeColor = System.Drawing.Color.SteelBlue;
            this.addClientButton.Image = global::WHApp.Properties.Resources.Plus_Math;
            this.addClientButton.ImageSize = new System.Drawing.Size(25, 25);
            this.addClientButton.Location = new System.Drawing.Point(6, 326);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(40, 40);
            this.addClientButton.TabIndex = 21;
            this.addClientButton.Click += new System.EventHandler(this.addClientButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Администрирование клиентами";
            // 
            // updateClientsButton
            // 
            this.updateClientsButton.Animated = true;
            this.updateClientsButton.BorderColor = System.Drawing.Color.Silver;
            this.updateClientsButton.BorderRadius = 20;
            this.updateClientsButton.BorderThickness = 1;
            this.updateClientsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateClientsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateClientsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateClientsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateClientsButton.FillColor = System.Drawing.Color.White;
            this.updateClientsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.updateClientsButton.ForeColor = System.Drawing.Color.Black;
            this.updateClientsButton.HoverState.BorderColor = System.Drawing.Color.SteelBlue;
            this.updateClientsButton.HoverState.FillColor = System.Drawing.Color.White;
            this.updateClientsButton.HoverState.ForeColor = System.Drawing.Color.SteelBlue;
            this.updateClientsButton.Image = global::WHApp.Properties.Resources.update;
            this.updateClientsButton.ImageSize = new System.Drawing.Size(25, 25);
            this.updateClientsButton.Location = new System.Drawing.Point(564, 326);
            this.updateClientsButton.Name = "updateClientsButton";
            this.updateClientsButton.Size = new System.Drawing.Size(40, 40);
            this.updateClientsButton.TabIndex = 10;
            this.updateClientsButton.Click += new System.EventHandler(this.updateClientsButton_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel3.BorderRadius = 5;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Controls.Add(this.listClients);
            this.guna2Panel3.Location = new System.Drawing.Point(6, 66);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(598, 251);
            this.guna2Panel3.TabIndex = 9;
            // 
            // listClients
            // 
            this.listClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listClients.HideSelection = false;
            this.listClients.Location = new System.Drawing.Point(3, 3);
            this.listClients.Name = "listClients";
            this.listClients.Size = new System.Drawing.Size(592, 245);
            this.listClients.TabIndex = 0;
            this.listClients.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.Controls.Add(this.addSupplierButton);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.updateSuppliersButton);
            this.tabPage4.Controls.Add(this.guna2Panel4);
            this.tabPage4.Location = new System.Drawing.Point(184, 4);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(612, 442);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Администрирование поставщиками";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // addSupplierButton
            // 
            this.addSupplierButton.Animated = true;
            this.addSupplierButton.BorderColor = System.Drawing.Color.Silver;
            this.addSupplierButton.BorderRadius = 20;
            this.addSupplierButton.BorderThickness = 1;
            this.addSupplierButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addSupplierButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addSupplierButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addSupplierButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addSupplierButton.FillColor = System.Drawing.Color.White;
            this.addSupplierButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.addSupplierButton.ForeColor = System.Drawing.Color.Black;
            this.addSupplierButton.HoverState.BorderColor = System.Drawing.Color.SteelBlue;
            this.addSupplierButton.HoverState.FillColor = System.Drawing.Color.White;
            this.addSupplierButton.HoverState.ForeColor = System.Drawing.Color.SteelBlue;
            this.addSupplierButton.Image = global::WHApp.Properties.Resources.Plus_Math;
            this.addSupplierButton.ImageSize = new System.Drawing.Size(25, 25);
            this.addSupplierButton.Location = new System.Drawing.Point(6, 326);
            this.addSupplierButton.Name = "addSupplierButton";
            this.addSupplierButton.Size = new System.Drawing.Size(40, 40);
            this.addSupplierButton.TabIndex = 21;
            this.addSupplierButton.Click += new System.EventHandler(this.addSupplierButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Администрирование поставщиками";
            // 
            // updateSuppliersButton
            // 
            this.updateSuppliersButton.Animated = true;
            this.updateSuppliersButton.BorderColor = System.Drawing.Color.Silver;
            this.updateSuppliersButton.BorderRadius = 20;
            this.updateSuppliersButton.BorderThickness = 1;
            this.updateSuppliersButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateSuppliersButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateSuppliersButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateSuppliersButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateSuppliersButton.FillColor = System.Drawing.Color.White;
            this.updateSuppliersButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.updateSuppliersButton.ForeColor = System.Drawing.Color.Black;
            this.updateSuppliersButton.HoverState.BorderColor = System.Drawing.Color.SteelBlue;
            this.updateSuppliersButton.HoverState.FillColor = System.Drawing.Color.White;
            this.updateSuppliersButton.HoverState.ForeColor = System.Drawing.Color.SteelBlue;
            this.updateSuppliersButton.Image = global::WHApp.Properties.Resources.update;
            this.updateSuppliersButton.ImageSize = new System.Drawing.Size(25, 25);
            this.updateSuppliersButton.Location = new System.Drawing.Point(564, 326);
            this.updateSuppliersButton.Name = "updateSuppliersButton";
            this.updateSuppliersButton.Size = new System.Drawing.Size(40, 40);
            this.updateSuppliersButton.TabIndex = 11;
            this.updateSuppliersButton.Click += new System.EventHandler(this.updateSuppliersButton_Click);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel4.BorderRadius = 5;
            this.guna2Panel4.BorderThickness = 1;
            this.guna2Panel4.Controls.Add(this.listSuppliers);
            this.guna2Panel4.Location = new System.Drawing.Point(6, 66);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(598, 251);
            this.guna2Panel4.TabIndex = 10;
            // 
            // listSuppliers
            // 
            this.listSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listSuppliers.HideSelection = false;
            this.listSuppliers.Location = new System.Drawing.Point(3, 3);
            this.listSuppliers.Name = "listSuppliers";
            this.listSuppliers.Size = new System.Drawing.Size(592, 245);
            this.listSuppliers.TabIndex = 0;
            this.listSuppliers.UseCompatibleStateImageBehavior = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2TabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приложение для автоматизации складского учета";
            this.guna2TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView listWH;
        private Guna.UI2.WinForms.Guna2Button updateButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.ListView listProducts;
        private Guna.UI2.WinForms.Guna2Button updateProductsButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.ListView listClients;
        private Guna.UI2.WinForms.Guna2Button updateClientsButton;
        private Guna.UI2.WinForms.Guna2Button updateSuppliersButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.ListView listSuppliers;
        private Guna.UI2.WinForms.Guna2Button addWarehouseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button addProductButton;
        private Guna.UI2.WinForms.Guna2Button addClientButton;
        private Guna.UI2.WinForms.Guna2Button addSupplierButton;
    }
}