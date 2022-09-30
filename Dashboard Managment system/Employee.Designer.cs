namespace Dashboard_Managment_system
{
    partial class Employee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DVG = new Guna.UI.WinForms.GunaDataGridView();
            this.Em_Gander = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.Em_phone = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.Em_name = new Guna.UI.WinForms.GunaTextBox();
            this.name = new Guna.UI.WinForms.GunaLabel();
            this.Id = new Guna.UI.WinForms.GunaLabel();
            this.Delete = new Guna.UI.WinForms.GunaButton();
            this.Update = new Guna.UI.WinForms.GunaButton();
            this.Save = new Guna.UI.WinForms.GunaButton();
            this.Em_Id = new Guna.UI.WinForms.GunaTextBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.Em_address = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DVG)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DVG
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DVG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DVG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DVG.BackgroundColor = System.Drawing.Color.DimGray;
            this.DVG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DVG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DVG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DVG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DVG.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DVG.DefaultCellStyle = dataGridViewCellStyle3;
            this.DVG.EnableHeadersVisualStyles = false;
            this.DVG.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DVG.Location = new System.Drawing.Point(3, 296);
            this.DVG.Name = "DVG";
            this.DVG.RowHeadersVisible = false;
            this.DVG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DVG.Size = new System.Drawing.Size(1116, 315);
            this.DVG.TabIndex = 37;
            this.DVG.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DVG.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DVG.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DVG.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DVG.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DVG.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DVG.ThemeStyle.BackColor = System.Drawing.Color.DimGray;
            this.DVG.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DVG.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DVG.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DVG.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DVG.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DVG.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DVG.ThemeStyle.HeaderStyle.Height = 4;
            this.DVG.ThemeStyle.ReadOnly = false;
            this.DVG.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DVG.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DVG.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DVG.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DVG.ThemeStyle.RowsStyle.Height = 22;
            this.DVG.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DVG.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Em_Gander
            // 
            this.Em_Gander.BackColor = System.Drawing.Color.Transparent;
            this.Em_Gander.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Em_Gander.BorderRadius = 6;
            this.Em_Gander.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Em_Gander.DropDownHeight = 105;
            this.Em_Gander.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Em_Gander.FocusedColor = System.Drawing.Color.Empty;
            this.Em_Gander.FocusedState.Parent = this.Em_Gander;
            this.Em_Gander.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Em_Gander.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Em_Gander.FormattingEnabled = true;
            this.Em_Gander.HoverState.Parent = this.Em_Gander;
            this.Em_Gander.IntegralHeight = false;
            this.Em_Gander.ItemHeight = 30;
            this.Em_Gander.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Em_Gander.ItemsAppearance.Parent = this.Em_Gander;
            this.Em_Gander.Location = new System.Drawing.Point(92, 247);
            this.Em_Gander.Name = "Em_Gander";
            this.Em_Gander.ShadowDecoration.Parent = this.Em_Gander;
            this.Em_Gander.Size = new System.Drawing.Size(206, 36);
            this.Em_Gander.TabIndex = 36;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(92, 210);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(119, 28);
            this.gunaLabel2.TabIndex = 35;
            this.gunaLabel2.Text = "Em_Gander";
            // 
            // Em_phone
            // 
            this.Em_phone.BackColor = System.Drawing.Color.Transparent;
            this.Em_phone.BaseColor = System.Drawing.Color.White;
            this.Em_phone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Em_phone.BorderSize = 1;
            this.Em_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Em_phone.FocusedBaseColor = System.Drawing.Color.White;
            this.Em_phone.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Em_phone.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Em_phone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Em_phone.Location = new System.Drawing.Point(576, 161);
            this.Em_phone.Name = "Em_phone";
            this.Em_phone.PasswordChar = '\0';
            this.Em_phone.Radius = 6;
            this.Em_phone.SelectedText = "";
            this.Em_phone.Size = new System.Drawing.Size(206, 36);
            this.Em_phone.TabIndex = 32;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(576, 127);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(109, 28);
            this.gunaLabel4.TabIndex = 31;
            this.gunaLabel4.Text = "Em_phone";
            // 
            // Em_name
            // 
            this.Em_name.BackColor = System.Drawing.Color.Transparent;
            this.Em_name.BaseColor = System.Drawing.Color.White;
            this.Em_name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Em_name.BorderSize = 1;
            this.Em_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Em_name.FocusedBaseColor = System.Drawing.Color.White;
            this.Em_name.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Em_name.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Em_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Em_name.Location = new System.Drawing.Point(334, 161);
            this.Em_name.Name = "Em_name";
            this.Em_name.PasswordChar = '\0';
            this.Em_name.Radius = 6;
            this.Em_name.SelectedText = "";
            this.Em_name.Size = new System.Drawing.Size(206, 36);
            this.Em_name.TabIndex = 30;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(334, 127);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(105, 28);
            this.name.TabIndex = 29;
            this.name.Text = "Em_name";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.Location = new System.Drawing.Point(94, 127);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(70, 28);
            this.Id.TabIndex = 28;
            this.Id.Text = "Em_Id";
            // 
            // Delete
            // 
            this.Delete.AnimationHoverSpeed = 0.07F;
            this.Delete.AnimationSpeed = 0.03F;
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Delete.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Delete.BorderColor = System.Drawing.Color.Black;
            this.Delete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Delete.FocusedColor = System.Drawing.Color.Empty;
            this.Delete.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Image = null;
            this.Delete.ImageSize = new System.Drawing.Size(20, 20);
            this.Delete.Location = new System.Drawing.Point(1014, 196);
            this.Delete.Name = "Delete";
            this.Delete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Delete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Delete.OnHoverForeColor = System.Drawing.Color.White;
            this.Delete.OnHoverImage = null;
            this.Delete.OnPressedColor = System.Drawing.Color.Black;
            this.Delete.Size = new System.Drawing.Size(105, 26);
            this.Delete.TabIndex = 27;
            this.Delete.Text = "Delete";
            this.Delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.AnimationHoverSpeed = 0.07F;
            this.Update.AnimationSpeed = 0.03F;
            this.Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Update.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Update.BorderColor = System.Drawing.Color.Black;
            this.Update.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Update.FocusedColor = System.Drawing.Color.Empty;
            this.Update.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.Color.White;
            this.Update.Image = null;
            this.Update.ImageSize = new System.Drawing.Size(20, 20);
            this.Update.Location = new System.Drawing.Point(1014, 155);
            this.Update.Name = "Update";
            this.Update.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Update.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Update.OnHoverForeColor = System.Drawing.Color.White;
            this.Update.OnHoverImage = null;
            this.Update.OnPressedColor = System.Drawing.Color.Black;
            this.Update.Size = new System.Drawing.Size(105, 26);
            this.Update.TabIndex = 26;
            this.Update.Text = "Update";
            this.Update.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Save
            // 
            this.Save.AnimationHoverSpeed = 0.07F;
            this.Save.AnimationSpeed = 0.03F;
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Save.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Save.BorderColor = System.Drawing.Color.Black;
            this.Save.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Save.FocusedColor = System.Drawing.Color.Empty;
            this.Save.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.Image = null;
            this.Save.ImageSize = new System.Drawing.Size(20, 20);
            this.Save.Location = new System.Drawing.Point(1014, 115);
            this.Save.Name = "Save";
            this.Save.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Save.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Save.OnHoverForeColor = System.Drawing.Color.White;
            this.Save.OnHoverImage = null;
            this.Save.OnPressedColor = System.Drawing.Color.Black;
            this.Save.Size = new System.Drawing.Size(105, 26);
            this.Save.TabIndex = 25;
            this.Save.Text = "Save";
            this.Save.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Em_Id
            // 
            this.Em_Id.BackColor = System.Drawing.Color.Transparent;
            this.Em_Id.BaseColor = System.Drawing.Color.White;
            this.Em_Id.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Em_Id.BorderSize = 1;
            this.Em_Id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Em_Id.FocusedBaseColor = System.Drawing.Color.White;
            this.Em_Id.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Em_Id.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Em_Id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Em_Id.Location = new System.Drawing.Point(94, 161);
            this.Em_Id.Name = "Em_Id";
            this.Em_Id.PasswordChar = '\0';
            this.Em_Id.Radius = 6;
            this.Em_Id.SelectedText = "";
            this.Em_Id.Size = new System.Drawing.Size(206, 36);
            this.Em_Id.TabIndex = 24;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.gunaLabel3);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1136, 100);
            this.guna2GradientPanel1.TabIndex = 23;
            // 
            // Em_address
            // 
            this.Em_address.BackColor = System.Drawing.Color.Transparent;
            this.Em_address.BaseColor = System.Drawing.Color.White;
            this.Em_address.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Em_address.BorderSize = 1;
            this.Em_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Em_address.FocusedBaseColor = System.Drawing.Color.White;
            this.Em_address.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Em_address.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Em_address.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Em_address.Location = new System.Drawing.Point(334, 247);
            this.Em_address.Name = "Em_address";
            this.Em_address.PasswordChar = '\0';
            this.Em_address.Radius = 6;
            this.Em_address.SelectedText = "";
            this.Em_address.Size = new System.Drawing.Size(206, 36);
            this.Em_address.TabIndex = 39;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(334, 213);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(127, 28);
            this.gunaLabel1.TabIndex = 38;
            this.gunaLabel1.Text = "Em_address";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("Poppins", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Location = new System.Drawing.Point(452, 14);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(233, 70);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "Employee";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Em_address);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.DVG);
            this.Controls.Add(this.Em_Gander);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.Em_phone);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.Em_name);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Em_Id);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "Employee";
            this.Size = new System.Drawing.Size(1136, 614);
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DVG)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView DVG;
        private Guna.UI2.WinForms.Guna2ComboBox Em_Gander;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox Em_phone;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox Em_name;
        private Guna.UI.WinForms.GunaLabel name;
        private Guna.UI.WinForms.GunaLabel Id;
        private Guna.UI.WinForms.GunaButton Delete;
        private Guna.UI.WinForms.GunaButton Update;
        private Guna.UI.WinForms.GunaButton Save;
        private Guna.UI.WinForms.GunaTextBox Em_Id;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI.WinForms.GunaTextBox Em_address;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
    }
}
