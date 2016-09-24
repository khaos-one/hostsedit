namespace HostsEdit
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Host = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDull = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RawContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.reloadButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.mainToolStrip.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsActive,
            this.Ip,
            this.Host,
            this.IsDull,
            this.RawContent});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(511, 343);
            this.dataGridView.TabIndex = 0;
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.Frozen = true;
            this.IsActive.HeaderText = "Enabled";
            this.IsActive.Name = "IsActive";
            this.IsActive.Width = 50;
            // 
            // Ip
            // 
            this.Ip.DataPropertyName = "Ip";
            this.Ip.Frozen = true;
            this.Ip.HeaderText = "IP";
            this.Ip.Name = "Ip";
            // 
            // Host
            // 
            this.Host.DataPropertyName = "Host";
            this.Host.Frozen = true;
            this.Host.HeaderText = "Host";
            this.Host.Name = "Host";
            this.Host.Width = 250;
            // 
            // IsDull
            // 
            this.IsDull.DataPropertyName = "IsDull";
            this.IsDull.Frozen = true;
            this.IsDull.HeaderText = "IsDull";
            this.IsDull.Name = "IsDull";
            this.IsDull.Visible = false;
            // 
            // RawContent
            // 
            this.RawContent.DataPropertyName = "RawContent";
            this.RawContent.Frozen = true;
            this.RawContent.HeaderText = "Raw Content";
            this.RawContent.Name = "RawContent";
            this.RawContent.Visible = false;
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.mainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveButton,
            this.reloadButton});
            this.mainToolStrip.Location = new System.Drawing.Point(3, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(67, 35);
            this.mainToolStrip.TabIndex = 1;
            this.mainToolStrip.Text = "toolStrip1";
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.dataGridView);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(511, 343);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(511, 378);
            this.toolStripContainer.TabIndex = 2;
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.mainToolStrip);
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = false;
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButton.Image = global::HostsEdit.Properties.Resources.Save;
            this.saveButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(32, 32);
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // reloadButton
            // 
            this.reloadButton.AutoSize = false;
            this.reloadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.reloadButton.Image = global::HostsEdit.Properties.Resources.Refresh;
            this.reloadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(32, 32);
            this.reloadButton.Text = "Reload";
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 378);
            this.Controls.Add(this.toolStripContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "HostsEdit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripButton reloadButton;
        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Host;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsDull;
        private System.Windows.Forms.DataGridViewTextBoxColumn RawContent;
    }
}

