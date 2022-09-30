namespace Dashboard_Managment_system
{
    partial class Orders
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
            this.txt_Balance = new Guna.UI.WinForms.GunaTextBox();
            this.e = new Guna.UI.WinForms.GunaLabel();
            this.DVG = new Guna.UI.WinForms.GunaDataGridView();
            this.p = new Guna.UI.WinForms.GunaLabel();
            this.o = new Guna.UI.WinForms.GunaLabel();
            this.txt_Clothtype = new Guna.UI.WinForms.GunaTextBox();
            this.d = new Guna.UI.WinForms.GunaLabel();
            this.Cus_name = new Guna.UI.WinForms.GunaTextBox();
            this.c = new Guna.UI.WinForms.GunaLabel();
            this.z = new Guna.UI.WinForms.GunaLabel();
            this.Delete = new Guna.UI.WinForms.GunaButton();
            this.Update = new Guna.UI.WinForms.GunaButton();
            this.Save = new Guna.UI.WinForms.GunaButton();
            this.txt_Ord_Id = new Guna.UI.WinForms.GunaTextBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txt_Amountpaid = new Guna.UI.WinForms.GunaTextBox();
            this.txt_DateReceived = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DVG)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Balance
            // 
            this.txt_Balance.BackColor = System.Drawing.Color.Transparent;
            this.txt_Balance.BaseColor = System.Drawing.Color.White;
            this.txt_Balance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_Balance.BorderSize = 1;
            this.txt_Balance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Balance.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Balance.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Balance.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Balance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Balance.Location = new System.Drawing.Point(593, 245);
            this.txt_Balance.Name = "txt_Balance";
            this.txt_Balance.PasswordChar = '\0';
            this.txt_Balance.Radius = 6;
            this.txt_Balance.SelectedText = "";
            this.txt_Balance.Size = new System.Drawing.Size(206, 26);
            this.txt_Balance.TabIndex = 56;
            // 
            // e
            // 
            this.e.AutoSize = true;
            this.e.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e.Location = new System.Drawing.Point(593, 211);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(85, 28);
            this.e.TabIndex = 55;
            this.e.Text = "Balance";
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
            this.DVG.Location = new System.Drawing.Point(21, 298);
            this.DVG.Name = "DVG";
            this.DVG.RowHeadersVisible = false;
            this.DVG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DVG.Size = new System.Drawing.Size(1090, 297);
            this.DVG.TabIndex = 54;
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
            // p
            // 
            this.p.AutoSize = true;
            this.p.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p.Location = new System.Drawing.Point(346, 208);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(123, 28);
            this.p.TabIndex = 52;
            this.p.Text = "Amountpaid";
            // 
            // o
            // 
            this.o.AutoSize = true;
            this.o.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o.Location = new System.Drawing.Point(94, 208);
            this.o.Name = "o";
            this.o.Size = new System.Drawing.Size(136, 28);
            this.o.TabIndex = 51;
            this.o.Text = "DateReceived";
            // 
            // txt_Clothtype
            // 
            this.txt_Clothtype.BackColor = System.Drawing.Color.Transparent;
            this.txt_Clothtype.BaseColor = System.Drawing.Color.White;
            this.txt_Clothtype.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_Clothtype.BorderSize = 1;
            this.txt_Clothtype.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Clothtype.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Clothtype.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Clothtype.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Clothtype.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Clothtype.Location = new System.Drawing.Point(593, 163);
            this.txt_Clothtype.Name = "txt_Clothtype";
            this.txt_Clothtype.PasswordChar = '\0';
            this.txt_Clothtype.Radius = 6;
            this.txt_Clothtype.SelectedText = "";
            this.txt_Clothtype.Size = new System.Drawing.Size(206, 26);
            this.txt_Clothtype.TabIndex = 49;
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d.Location = new System.Drawing.Point(593, 129);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(99, 28);
            this.d.TabIndex = 48;
            this.d.Text = "Clothtype";
            // 
            // Cus_name
            // 
            this.Cus_name.BackColor = System.Drawing.Color.Transparent;
            this.Cus_name.BaseColor = System.Drawing.Color.White;
            this.Cus_name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Cus_name.BorderSize = 1;
            this.Cus_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Cus_name.FocusedBaseColor = System.Drawing.Color.White;
            this.Cus_name.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Cus_name.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Cus_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Cus_name.Location = new System.Drawing.Point(346, 163);
            this.Cus_name.Name = "Cus_name";
            this.Cus_name.PasswordChar = '\0';
            this.Cus_name.Radius = 6;
            this.Cus_name.SelectedText = "";
            this.Cus_name.Size = new System.Drawing.Size(206, 26);
            this.Cus_name.TabIndex = 47;
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.Location = new System.Drawing.Point(346, 129);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(112, 28);
            this.c.TabIndex = 46;
            this.c.Text = "Cus_name";
            // 
            // z
            // 
            this.z.AutoSize = true;
            this.z.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.z.Location = new System.Drawing.Point(94, 129);
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(76, 28);
            this.z.TabIndex = 45;
            this.z.Text = "Ord_Id";
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
            this.Delete.Location = new System.Drawing.Point(1004, 198);
            this.Delete.Name = "Delete";
            this.Delete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Delete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Delete.OnHoverForeColor = System.Drawing.Color.White;
            this.Delete.OnHoverImage = null;
            this.Delete.OnPressedColor = System.Drawing.Color.Black;
            this.Delete.Size = new System.Drawing.Size(105, 26);
            this.Delete.TabIndex = 44;
            this.Delete.Text = "Delete";
            this.Delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.Update.Location = new System.Drawing.Point(1004, 157);
            this.Update.Name = "Update";
            this.Update.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Update.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Update.OnHoverForeColor = System.Drawing.Color.White;
            this.Update.OnHoverImage = null;
            this.Update.OnPressedColor = System.Drawing.Color.Black;
            this.Update.Size = new System.Drawing.Size(105, 26);
            this.Update.TabIndex = 43;
            this.Update.Text = "Update";
            this.Update.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.Save.Location = new System.Drawing.Point(1004, 117);
            this.Save.Name = "Save";
            this.Save.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Save.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Save.OnHoverForeColor = System.Drawing.Color.White;
            this.Save.OnHoverImage = null;
            this.Save.OnPressedColor = System.Drawing.Color.Black;
            this.Save.Size = new System.Drawing.Size(105, 26);
            this.Save.TabIndex = 42;
            this.Save.Text = "Save";
            this.Save.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // txt_Ord_Id
            // 
            this.txt_Ord_Id.BackColor = System.Drawing.Color.Transparent;
            this.txt_Ord_Id.BaseColor = System.Drawing.Color.White;
            this.txt_Ord_Id.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_Ord_Id.BorderSize = 1;
            this.txt_Ord_Id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Ord_Id.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Ord_Id.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Ord_Id.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Ord_Id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Ord_Id.Location = new System.Drawing.Point(94, 163);
            this.txt_Ord_Id.Name = "txt_Ord_Id";
            this.txt_Ord_Id.PasswordChar = '\0';
            this.txt_Ord_Id.Radius = 6;
            this.txt_Ord_Id.SelectedText = "";
            this.txt_Ord_Id.Size = new System.Drawing.Size(206, 26);
            this.txt_Ord_Id.TabIndex = 41;
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
            this.guna2GradientPanel1.TabIndex = 40;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Poppins", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(458, 11);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(169, 70);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Orders";
            // 
            // txt_Amountpaid
            // 
            this.txt_Amountpaid.BackColor = System.Drawing.Color.Transparent;
            this.txt_Amountpaid.BaseColor = System.Drawing.Color.White;
            this.txt_Amountpaid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_Amountpaid.BorderSize = 1;
            this.txt_Amountpaid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Amountpaid.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Amountpaid.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Amountpaid.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Amountpaid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Amountpaid.Location = new System.Drawing.Point(346, 245);
            this.txt_Amountpaid.Name = "txt_Amountpaid";
            this.txt_Amountpaid.PasswordChar = '\0';
            this.txt_Amountpaid.Radius = 6;
            this.txt_Amountpaid.SelectedText = "";
            this.txt_Amountpaid.Size = new System.Drawing.Size(206, 26);
            this.txt_Amountpaid.TabIndex = 57;
            // 
            // txt_DateReceived
            // 
            this.txt_DateReceived.Location = new System.Drawing.Point(94, 245);
            this.txt_DateReceived.Name = "txt_DateReceived";
            this.txt_DateReceived.Size = new System.Drawing.Size(206, 20);
            this.txt_DateReceived.TabIndex = 58;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_DateReceived);
            this.Controls.Add(this.txt_Amountpaid);
            this.Controls.Add(this.txt_Balance);
            this.Controls.Add(this.e);
            this.Controls.Add(this.DVG);
            this.Controls.Add(this.p);
            this.Controls.Add(this.o);
            this.Controls.Add(this.txt_Clothtype);
            this.Controls.Add(this.d);
            this.Controls.Add(this.Cus_name);
            this.Controls.Add(this.c);
            this.Controls.Add(this.z);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.txt_Ord_Id);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "Orders";
            this.Size = new System.Drawing.Size(1136, 614);
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DVG)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox txt_Balance;
        private Guna.UI.WinForms.GunaLabel e;
        private Guna.UI.WinForms.GunaDataGridView DVG;
        private Guna.UI.WinForms.GunaLabel p;
        private Guna.UI.WinForms.GunaLabel o;
        private Guna.UI.WinForms.GunaTextBox txt_Clothtype;
        private Guna.UI.WinForms.GunaLabel d;
        private Guna.UI.WinForms.GunaTextBox Cus_name;
        private Guna.UI.WinForms.GunaLabel c;
        private Guna.UI.WinForms.GunaLabel z;
        private Guna.UI.WinForms.GunaButton Delete;
        private Guna.UI.WinForms.GunaButton Update;
        private Guna.UI.WinForms.GunaButton Save;
        private Guna.UI.WinForms.GunaTextBox txt_Ord_Id;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI.WinForms.GunaTextBox txt_Amountpaid;
        private System.Windows.Forms.DateTimePicker txt_DateReceived;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}
