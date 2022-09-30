namespace Dashboard_Managment_system
{
    partial class Payment
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
            this.txt_balance = new Guna.UI.WinForms.GunaTextBox();
            this.DVG = new Guna.UI.WinForms.GunaDataGridView();
            this.p = new Guna.UI.WinForms.GunaLabel();
            this.o = new Guna.UI.WinForms.GunaLabel();
            this.txt_Pay_type = new Guna.UI.WinForms.GunaTextBox();
            this.y = new Guna.UI.WinForms.GunaLabel();
            this.txt_clothtype = new Guna.UI.WinForms.GunaTextBox();
            this.l = new Guna.UI.WinForms.GunaLabel();
            this.Pay_id = new Guna.UI.WinForms.GunaLabel();
            this.Delete = new Guna.UI.WinForms.GunaButton();
            this.Update = new Guna.UI.WinForms.GunaButton();
            this.Save = new Guna.UI.WinForms.GunaButton();
            this.txt_id = new Guna.UI.WinForms.GunaTextBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.DTP = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DVG)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_balance
            // 
            this.txt_balance.BackColor = System.Drawing.Color.Transparent;
            this.txt_balance.BaseColor = System.Drawing.Color.White;
            this.txt_balance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_balance.BorderSize = 1;
            this.txt_balance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_balance.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_balance.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_balance.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_balance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_balance.Location = new System.Drawing.Point(27, 239);
            this.txt_balance.Name = "txt_balance";
            this.txt_balance.PasswordChar = '\0';
            this.txt_balance.Radius = 6;
            this.txt_balance.SelectedText = "";
            this.txt_balance.Size = new System.Drawing.Size(206, 31);
            this.txt_balance.TabIndex = 89;
            // 
            // DVG
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.DVG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DVG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DVG.BackgroundColor = System.Drawing.Color.DimGray;
            this.DVG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DVG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DVG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DVG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DVG.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DVG.DefaultCellStyle = dataGridViewCellStyle3;
            this.DVG.EnableHeadersVisualStyles = false;
            this.DVG.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.DVG.Location = new System.Drawing.Point(16, 299);
            this.DVG.Name = "DVG";
            this.DVG.RowHeadersVisible = false;
            this.DVG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DVG.Size = new System.Drawing.Size(1102, 315);
            this.DVG.TabIndex = 88;
            this.DVG.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.DeepPurple;
            this.DVG.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.DVG.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DVG.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DVG.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DVG.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DVG.ThemeStyle.BackColor = System.Drawing.Color.DimGray;
            this.DVG.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.DVG.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.DVG.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DVG.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DVG.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DVG.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DVG.ThemeStyle.HeaderStyle.Height = 4;
            this.DVG.ThemeStyle.ReadOnly = false;
            this.DVG.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.DVG.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DVG.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DVG.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DVG.ThemeStyle.RowsStyle.Height = 22;
            this.DVG.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
            this.DVG.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // p
            // 
            this.p.AutoSize = true;
            this.p.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p.Location = new System.Drawing.Point(27, 202);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(133, 28);
            this.p.TabIndex = 87;
            this.p.Text = "Pay_balance";
            // 
            // o
            // 
            this.o.AutoSize = true;
            this.o.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o.Location = new System.Drawing.Point(735, 116);
            this.o.Name = "o";
            this.o.Size = new System.Drawing.Size(101, 28);
            this.o.TabIndex = 86;
            this.o.Text = "Pay_Date";
            // 
            // txt_Pay_type
            // 
            this.txt_Pay_type.BackColor = System.Drawing.Color.Transparent;
            this.txt_Pay_type.BaseColor = System.Drawing.Color.White;
            this.txt_Pay_type.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_Pay_type.BorderSize = 1;
            this.txt_Pay_type.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Pay_type.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Pay_type.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Pay_type.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Pay_type.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Pay_type.Location = new System.Drawing.Point(509, 157);
            this.txt_Pay_type.Name = "txt_Pay_type";
            this.txt_Pay_type.PasswordChar = '\0';
            this.txt_Pay_type.Radius = 6;
            this.txt_Pay_type.SelectedText = "";
            this.txt_Pay_type.Size = new System.Drawing.Size(206, 31);
            this.txt_Pay_type.TabIndex = 85;
            // 
            // y
            // 
            this.y.AutoSize = true;
            this.y.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y.Location = new System.Drawing.Point(509, 123);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(95, 28);
            this.y.TabIndex = 84;
            this.y.Text = "Pay-type";
            // 
            // txt_clothtype
            // 
            this.txt_clothtype.BackColor = System.Drawing.Color.Transparent;
            this.txt_clothtype.BaseColor = System.Drawing.Color.White;
            this.txt_clothtype.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_clothtype.BorderSize = 1;
            this.txt_clothtype.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_clothtype.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_clothtype.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_clothtype.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_clothtype.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_clothtype.Location = new System.Drawing.Point(267, 157);
            this.txt_clothtype.Name = "txt_clothtype";
            this.txt_clothtype.PasswordChar = '\0';
            this.txt_clothtype.Radius = 6;
            this.txt_clothtype.SelectedText = "";
            this.txt_clothtype.Size = new System.Drawing.Size(206, 31);
            this.txt_clothtype.TabIndex = 83;
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(267, 123);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(144, 28);
            this.l.TabIndex = 82;
            this.l.Text = "Pay_clothtype";
            // 
            // Pay_id
            // 
            this.Pay_id.AutoSize = true;
            this.Pay_id.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pay_id.Location = new System.Drawing.Point(27, 123);
            this.Pay_id.Name = "Pay_id";
            this.Pay_id.Size = new System.Drawing.Size(76, 28);
            this.Pay_id.TabIndex = 81;
            this.Pay_id.Text = "Pay_id";
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
            this.Delete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Delete.OnHoverBorderColor = System.Drawing.Color.White;
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
            this.Update.Location = new System.Drawing.Point(1014, 158);
            this.Update.Name = "Update";
            this.Update.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Update.OnHoverBorderColor = System.Drawing.Color.White;
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
            this.Save.Location = new System.Drawing.Point(1014, 118);
            this.Save.Name = "Save";
            this.Save.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Save.OnHoverBorderColor = System.Drawing.Color.White;
            this.Save.OnHoverForeColor = System.Drawing.Color.White;
            this.Save.OnHoverImage = null;
            this.Save.OnPressedColor = System.Drawing.Color.Black;
            this.Save.Size = new System.Drawing.Size(105, 26);
            this.Save.TabIndex = 78;
            this.Save.Text = "Save";
            this.Save.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.Transparent;
            this.txt_id.BaseColor = System.Drawing.Color.White;
            this.txt_id.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_id.BorderSize = 1;
            this.txt_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_id.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_id.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_id.Location = new System.Drawing.Point(27, 157);
            this.txt_id.Name = "txt_id";
            this.txt_id.PasswordChar = '\0';
            this.txt_id.Radius = 6;
            this.txt_id.SelectedText = "";
            this.txt_id.Size = new System.Drawing.Size(206, 31);
            this.txt_id.TabIndex = 77;
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
            // DTP
            // 
            this.DTP.CheckedState.Parent = this.DTP;
            this.DTP.FillColor = System.Drawing.Color.White;
            this.DTP.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DTP.HoverState.Parent = this.DTP;
            this.DTP.Location = new System.Drawing.Point(740, 158);
            this.DTP.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DTP.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DTP.Name = "DTP";
            this.DTP.ShadowDecoration.Parent = this.DTP;
            this.DTP.Size = new System.Drawing.Size(206, 31);
            this.DTP.TabIndex = 90;
            this.DTP.Value = new System.DateTime(2022, 9, 29, 17, 25, 42, 447);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Poppins", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(464, 16);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(217, 70);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Payment";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DTP);
            this.Controls.Add(this.txt_balance);
            this.Controls.Add(this.DVG);
            this.Controls.Add(this.p);
            this.Controls.Add(this.o);
            this.Controls.Add(this.txt_Pay_type);
            this.Controls.Add(this.y);
            this.Controls.Add(this.txt_clothtype);
            this.Controls.Add(this.l);
            this.Controls.Add(this.Pay_id);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "Payment";
            this.Size = new System.Drawing.Size(1136, 637);
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DVG)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox txt_balance;
        private Guna.UI.WinForms.GunaDataGridView DVG;
        private Guna.UI.WinForms.GunaLabel p;
        private Guna.UI.WinForms.GunaLabel o;
        private Guna.UI.WinForms.GunaTextBox txt_Pay_type;
        private Guna.UI.WinForms.GunaLabel y;
        private Guna.UI.WinForms.GunaTextBox txt_clothtype;
        private Guna.UI.WinForms.GunaLabel l;
        private Guna.UI.WinForms.GunaLabel Pay_id;
        private Guna.UI.WinForms.GunaButton Delete;
        private Guna.UI.WinForms.GunaButton Update;
        private Guna.UI.WinForms.GunaButton Save;
        private Guna.UI.WinForms.GunaTextBox txt_id;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTP;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}
