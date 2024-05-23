namespace JustDoIT
{
    partial class FrmToDo
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
            this.TitleTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.NewBtn = new MaterialSkin.Controls.MaterialButton();
            this.EditBtn = new MaterialSkin.Controls.MaterialButton();
            this.SaveBtn = new MaterialSkin.Controls.MaterialButton();
            this.DeleteBtn = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DescriptionTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.AnimateReadOnly = false;
            this.TitleTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TitleTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TitleTextBox.Depth = 0;
            this.TitleTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TitleTextBox.HideSelection = true;
            this.TitleTextBox.LeadingIcon = null;
            this.TitleTextBox.Location = new System.Drawing.Point(6, 82);
            this.TitleTextBox.MaxLength = 32767;
            this.TitleTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.PasswordChar = '\0';
            this.TitleTextBox.PrefixSuffixText = null;
            this.TitleTextBox.ReadOnly = false;
            this.TitleTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TitleTextBox.SelectedText = "";
            this.TitleTextBox.SelectionLength = 0;
            this.TitleTextBox.SelectionStart = 0;
            this.TitleTextBox.ShortcutsEnabled = true;
            this.TitleTextBox.Size = new System.Drawing.Size(499, 48);
            this.TitleTextBox.TabIndex = 1;
            this.TitleTextBox.TabStop = false;
            this.TitleTextBox.Text = "Title: ...";
            this.TitleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TitleTextBox.TrailingIcon = null;
            this.TitleTextBox.UseSystemPasswordChar = false;
            this.TitleTextBox.Click += new System.EventHandler(this.TitleTextBox_Click);
            // 
            // NewBtn
            // 
            this.NewBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NewBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.NewBtn.Depth = 0;
            this.NewBtn.HighEmphasis = true;
            this.NewBtn.Icon = null;
            this.NewBtn.Location = new System.Drawing.Point(7, 222);
            this.NewBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NewBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.NewBtn.Size = new System.Drawing.Size(64, 36);
            this.NewBtn.TabIndex = 2;
            this.NewBtn.Text = "New";
            this.NewBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.NewBtn.UseAccentColor = false;
            this.NewBtn.UseVisualStyleBackColor = true;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.EditBtn.Depth = 0;
            this.EditBtn.HighEmphasis = true;
            this.EditBtn.Icon = null;
            this.EditBtn.Location = new System.Drawing.Point(173, 222);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EditBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.EditBtn.Size = new System.Drawing.Size(64, 36);
            this.EditBtn.TabIndex = 2;
            this.EditBtn.Text = "Edit";
            this.EditBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.EditBtn.UseAccentColor = false;
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SaveBtn.Depth = 0;
            this.SaveBtn.HighEmphasis = true;
            this.SaveBtn.Icon = null;
            this.SaveBtn.Location = new System.Drawing.Point(339, 222);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SaveBtn.Size = new System.Drawing.Size(64, 36);
            this.SaveBtn.TabIndex = 2;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SaveBtn.UseAccentColor = false;
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DeleteBtn.Depth = 0;
            this.DeleteBtn.HighEmphasis = true;
            this.DeleteBtn.Icon = null;
            this.DeleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteBtn.Location = new System.Drawing.Point(501, 222);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.DeleteBtn.Size = new System.Drawing.Size(73, 36);
            this.DeleteBtn.TabIndex = 2;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DeleteBtn.UseAccentColor = false;
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(817, 209);
            this.dataGridView1.TabIndex = 3;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.AnimateReadOnly = false;
            this.DescriptionTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DescriptionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.DescriptionTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DescriptionTextBox.Depth = 0;
            this.DescriptionTextBox.HideSelection = true;
            this.DescriptionTextBox.Location = new System.Drawing.Point(7, 137);
            this.DescriptionTextBox.MaxLength = 32767;
            this.DescriptionTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.PasswordChar = '\0';
            this.DescriptionTextBox.ReadOnly = false;
            this.DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DescriptionTextBox.SelectedText = "";
            this.DescriptionTextBox.SelectionLength = 0;
            this.DescriptionTextBox.SelectionStart = 0;
            this.DescriptionTextBox.ShortcutsEnabled = true;
            this.DescriptionTextBox.Size = new System.Drawing.Size(498, 76);
            this.DescriptionTextBox.TabIndex = 4;
            this.DescriptionTextBox.TabStop = false;
            this.DescriptionTextBox.Text = "Description: ...";
            this.DescriptionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DescriptionTextBox.UseSystemPasswordChar = false;
            this.DescriptionTextBox.Click += new System.EventHandler(this.DescriptionTextBox_Click);
            // 
            // FrmToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(829, 482);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.NewBtn);
            this.Controls.Add(this.TitleTextBox);
            this.Name = "FrmToDo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "To Do List";
            this.Load += new System.EventHandler(this.FrmToDo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 TitleTextBox;
        private MaterialSkin.Controls.MaterialButton NewBtn;
        private MaterialSkin.Controls.MaterialButton EditBtn;
        private MaterialSkin.Controls.MaterialButton SaveBtn;
        private MaterialSkin.Controls.MaterialButton DeleteBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 DescriptionTextBox;
    }
}

