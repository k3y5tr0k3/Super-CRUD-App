namespace SuperCRUDLib.Windows.SuperHeroListWindow
{
    partial class SuperHeroList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridPanel = new System.Windows.Forms.Panel();
            this.SuperheroListDataGridView = new System.Windows.Forms.DataGridView();
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.DetailsButton = new System.Windows.Forms.Button();
            this.PageNoLabel = new System.Windows.Forms.Label();
            this.of = new System.Windows.Forms.Label();
            this.TotalPagesLabel = new System.Windows.Forms.Label();
            this.PrevPage = new System.Windows.Forms.Button();
            this.NextPage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalRecords = new System.Windows.Forms.Label();
            this.DataGridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SuperheroListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridPanel
            // 
            this.DataGridPanel.Controls.Add(this.SuperheroListDataGridView);
            this.DataGridPanel.Location = new System.Drawing.Point(12, 52);
            this.DataGridPanel.Name = "DataGridPanel";
            this.DataGridPanel.Size = new System.Drawing.Size(776, 353);
            this.DataGridPanel.TabIndex = 0;
            // 
            // SuperheroListDataGridView
            // 
            this.SuperheroListDataGridView.AllowUserToOrderColumns = true;
            this.SuperheroListDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SuperheroListDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SuperheroListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SuperheroListDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.SuperheroListDataGridView.Location = new System.Drawing.Point(3, 3);
            this.SuperheroListDataGridView.Name = "SuperheroListDataGridView";
            this.SuperheroListDataGridView.Size = new System.Drawing.Size(770, 347);
            this.SuperheroListDataGridView.TabIndex = 5;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(12, 12);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(93, 34);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Clicked);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(111, 12);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(93, 34);
            this.UpdateButton.TabIndex = 2;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(210, 12);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(93, 34);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // DetailsButton
            // 
            this.DetailsButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsButton.Location = new System.Drawing.Point(695, 15);
            this.DetailsButton.Name = "DetailsButton";
            this.DetailsButton.Size = new System.Drawing.Size(93, 34);
            this.DetailsButton.TabIndex = 4;
            this.DetailsButton.Text = "Details";
            this.DetailsButton.UseVisualStyleBackColor = true;
            this.DetailsButton.Click += new System.EventHandler(this.DetailsButton_Clicked);
            // 
            // PageNoLabel
            // 
            this.PageNoLabel.AutoSize = true;
            this.PageNoLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageNoLabel.ForeColor = System.Drawing.Color.White;
            this.PageNoLabel.Location = new System.Drawing.Point(378, 421);
            this.PageNoLabel.Name = "PageNoLabel";
            this.PageNoLabel.Size = new System.Drawing.Size(13, 15);
            this.PageNoLabel.TabIndex = 0;
            this.PageNoLabel.Text = "1";
            // 
            // of
            // 
            this.of.AutoSize = true;
            this.of.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.of.ForeColor = System.Drawing.Color.SkyBlue;
            this.of.Location = new System.Drawing.Point(397, 420);
            this.of.Name = "of";
            this.of.Size = new System.Drawing.Size(17, 15);
            this.of.TabIndex = 0;
            this.of.Text = "of";
            // 
            // TotalPagesLabel
            // 
            this.TotalPagesLabel.AutoSize = true;
            this.TotalPagesLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPagesLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.TotalPagesLabel.Location = new System.Drawing.Point(420, 421);
            this.TotalPagesLabel.Name = "TotalPagesLabel";
            this.TotalPagesLabel.Size = new System.Drawing.Size(13, 15);
            this.TotalPagesLabel.TabIndex = 7;
            this.TotalPagesLabel.Text = "1";
            // 
            // PrevPage
            // 
            this.PrevPage.Location = new System.Drawing.Point(338, 416);
            this.PrevPage.Name = "PrevPage";
            this.PrevPage.Size = new System.Drawing.Size(25, 25);
            this.PrevPage.TabIndex = 6;
            this.PrevPage.Text = "<";
            this.PrevPage.UseVisualStyleBackColor = true;
            this.PrevPage.Click += new System.EventHandler(this.PrevPage_Click);
            // 
            // NextPage
            // 
            this.NextPage.Location = new System.Drawing.Point(449, 416);
            this.NextPage.Name = "NextPage";
            this.NextPage.Size = new System.Drawing.Size(25, 25);
            this.NextPage.TabIndex = 7;
            this.NextPage.Text = ">";
            this.NextPage.UseVisualStyleBackColor = true;
            this.NextPage.Click += new System.EventHandler(this.NextPage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(692, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalRecords
            // 
            this.TotalRecords.AutoSize = true;
            this.TotalRecords.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalRecords.ForeColor = System.Drawing.Color.White;
            this.TotalRecords.Location = new System.Drawing.Point(734, 420);
            this.TotalRecords.Name = "TotalRecords";
            this.TotalRecords.Size = new System.Drawing.Size(0, 15);
            this.TotalRecords.TabIndex = 11;
            // 
            // SuperHeroList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TotalRecords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NextPage);
            this.Controls.Add(this.PrevPage);
            this.Controls.Add(this.TotalPagesLabel);
            this.Controls.Add(this.of);
            this.Controls.Add(this.PageNoLabel);
            this.Controls.Add(this.DetailsButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DataGridPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SuperHeroList";
            this.Text = "SuperheroRegistry";
            this.DataGridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SuperheroListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DataGridPanel;
        private System.Windows.Forms.DataGridView SuperheroListDataGridView;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button DetailsButton;
        private System.Windows.Forms.Label PageNoLabel;
        private System.Windows.Forms.Label of;
        private System.Windows.Forms.Label TotalPagesLabel;
        private System.Windows.Forms.Button PrevPage;
        private System.Windows.Forms.Button NextPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TotalRecords;
    }
}