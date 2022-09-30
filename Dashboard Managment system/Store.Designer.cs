namespace Dashboard_Managment_system
{
    partial class Store
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_Quantity = new Guna.UI.WinForms.GunaTextBox();
            this.DVG = new Guna.UI.WinForms.GunaDataGridView();
            this.Quantity = new Guna.UI.WinForms.GunaLabel();
            this.txt_St_type = new Guna.UI.WinForms.GunaTextBox();
            this.St_type = new Guna.UI.WinForms.GunaLabel();
            this.txt_St_name = new Guna.UI.WinForms.GunaTextBox();
            this.St_name = new Guna.UI.WinForms.GunaLabel();
            this.St_id = new Guna.UI.WinForms.GunaLabel();
            this.Delete = new Guna.UI.WinForms.GunaButton();
            this.Update = new Guna.UI.WinForms.GunaButton();
            this.Save = new Guna.UI.WinForms.GunaButton();
            this.txt_St_id = new Guna.UI.WinForms.GunaTextBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DVG)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.BackColor = System.Drawing.Color.Transparent;
            this.txt_Quantity.BaseColor = System.Drawing.Color.White;
            this.txt_Quantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_Quantity.BorderSize = 1;
            this.txt_Quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Quantity.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Quantity.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Quantity.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Quantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Quantity.Location = new System.Drawing.Point(738, 194);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.PasswordChar = '\0';
            this.txt_Quantity.Radius = 6;
            this.txt_Quantity.SelectedText = "";
            this.txt_Quantity.Size = new System.Drawing.Size(206, 31);
            this.txt_Quantity.TabIndex = 90;
            // 
            // DVG
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DVG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DVG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DVG.BackgroundColor = System.Drawing.Color.DimGray;
            this.DVG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DVG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DVG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DVG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DVG.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DVG.DefaultCellStyle = dataGridViewCellStyle6;
            this.DVG.EnableHeadersVisualStyles = false;
            this.DVG.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DVG.Location = new System.Drawing.Point(17, 299);
            this.DVG.Name = "DVG";
            this.DVG.RowHeadersVisible = false;
            this.DVG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DVG.Size = new System.Drawing.Size(1102, 315);
            this.DVG.TabIndex = 88;
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
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.Location = new System.Drawing.Point(737, 162);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(89, 28);
            this.Quantity.TabIndex = 86;
            this.Quantity.Text = "Quantity";
            // 
            // txt_St_type
            // 
            this.txt_St_type.BackColor = System.Drawing.Color.Transparent;
            this.txt_St_type.BaseColor = System.Drawing.Color.White;
            this.txt_St_type.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_St_type.BorderSize = 1;
            this.txt_St_type.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_St_type.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_St_type.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_St_type.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_St_type.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_St_type.Location = new System.Drawing.Point(512, 194);
            this.txt_St_type.Name = "txt_St_type";
            this.txt_St_type.PasswordChar = '\0';
            this.txt_St_type.Radius = 6;
            this.txt_St_type.SelectedText = "";
            this.txt_St_type.Size = new System.Drawing.Size(206, 31);
            this.txt_St_type.TabIndex = 85;
            // 
            // St_type
            // 
            this.St_type.AutoSize = true;
            this.St_type.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.St_type.Location = new System.Drawing.Point(511, 162);
            this.St_type.Name = "St_type";
            this.St_type.Size = new System.Drawing.Size(84, 28);
            this.St_type.TabIndex = 84;
            this.St_type.Text = "St_type";
            // 
            // txt_St_name
            // 
            this.txt_St_name.BackColor = System.Drawing.Color.Transparent;
            this.txt_St_name.BaseColor = System.Drawing.Color.White;
            this.txt_St_name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_St_name.BorderSize = 1;
            this.txt_St_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_St_name.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_St_name.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_St_name.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_St_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_St_name.Location = new System.Drawing.Point(270, 194);
            this.txt_St_name.Name = "txt_St_name";
            this.txt_St_name.PasswordChar = '\0';
            this.txt_St_name.Radius = 6;
            this.txt_St_name.SelectedText = "";
            this.txt_St_name.Size = new System.Drawing.Size(206, 31);
            this.txt_St_name.TabIndex = 83;
            // 
            // St_name
            // 
            this.St_name.AutoSize = true;
            this.St_name.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.St_name.Location = new System.Drawing.Point(269, 162);
            this.St_name.Name = "St_name";
            this.St_name.Size = new System.Drawing.Size(96, 28);
            this.St_name.TabIndex = 82;
            this.St_name.Text = "St_name";
            // 
            // St_id
            // 
            this.St_id.AutoSize = true;
            this.St_id.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.St_id.Location = new System.Drawing.Point(29, 162);
            this.St_id.Name = "St_id";
            this.St_id.Size = new System.Drawing.Size(61, 28);
            this.St_id.TabIndex = 81;
            this.St_id.Text = "St_id";
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
            this.Delete.Location = new System.Drawing.Point(1014, 199);
            this.Delete.Name = "Delete";
            this.Delete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Delete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Delete.OnHoverForeColor = System.Drawing.Color.White;
            this.Delete.OnHoverImage = null;
            this.Delete.OnPressedColor = System.Drawing.Color.Black;
            this.Delete.Size = new System.Drawing.Size(105, 26);
            this.Delete.TabIndex = 80;
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
            this.Update.Location = new System.Drawing.Point(1014, 120);
            this.Update.Name = "Update";
            this.Update.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Update.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Update.OnHoverForeColor = System.Drawing.Color.White;
            this.Update.OnHoverImage = null;
            this.Update.OnPressedColor = System.Drawing.Color.Black;
            this.Update.Size = new System.Drawing.Size(105, 26);
            this.Update.TabIndex = 79;
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
            this.Save.Location = new System.Drawing.Point(1014, 158);
            this.Save.Name = "Save";
            this.Save.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Save.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Save.OnHoverForeColor = System.Drawing.Color.White;
            this.Save.OnHoverImage = null;
            this.Save.OnPressedColor = System.Drawing.Color.Black;
            this.Save.Size = new System.Drawing.Size(105, 26);
            this.Save.TabIndex = 78;
            this.Save.Text = "Save";
            this.Save.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // txt_St_id
            // 
            this.txt_St_id.BackColor = System.Drawing.Color.Transparent;
            this.txt_St_id.BaseColor = System.Drawing.Color.White;
            this.txt_St_id.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_St_id.BorderSize = 1;
            this.txt_St_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_St_id.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_St_id.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_St_id.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_St_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_St_id.Location = new System.Drawing.Point(30, 194);
            this.txt_St_id.Name = "txt_St_id";
            this.txt_St_id.PasswordChar = '\0';
            this.txt_St_id.Radius = 6;
            this.txt_St_id.SelectedText = "";
            this.txt_St_id.Size = new System.Drawing.Size(206, 31);
            this.txt_St_id.TabIndex = 77;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.gunaLabel1);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1136, 100);
            this.guna2GradientPanel1.TabIndex = 76;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Poppins", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(461, 14);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(138, 70);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Store";
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.DVG);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.txt_St_type);
            this.Controls.Add(this.St_type);
            this.Controls.Add(this.txt_St_name);
            this.Controls.Add(this.St_name);
            this.Controls.Add(this.St_id);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.txt_St_id);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "Store";
            this.Size = new System.Drawing.Size(1136, 641);
            this.Load += new System.EventHandler(this.Store_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DVG)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox txt_Quantity;
        private Guna.UI.WinForms.GunaDataGridView DVG;
        private Guna.UI.WinForms.GunaLabel Quantity;
        private Guna.UI.WinForms.GunaTextBox txt_St_type;
        private Guna.UI.WinForms.GunaLabel St_type;
        private Guna.UI.WinForms.GunaTextBox txt_St_name;
        private Guna.UI.WinForms.GunaLabel St_name;
        private Guna.UI.WinForms.GunaLabel St_id;
        private Guna.UI.WinForms.GunaButton Delete;
        private Guna.UI.WinForms.GunaButton Update;
        private Guna.UI.WinForms.GunaButton Save;
        private Guna.UI.WinForms.GunaTextBox txt_St_id;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}
