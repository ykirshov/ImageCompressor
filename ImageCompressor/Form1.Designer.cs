namespace ImageCompressor
{
    partial class Form1
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
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Panel = new System.Windows.Forms.TableLayoutPanel();
            this.PictureNew = new System.Windows.Forms.PictureBox();
            this.PictureOld = new System.Windows.Forms.PictureBox();
            this.Group = new System.Windows.Forms.GroupBox();
            this.PanelGroup = new System.Windows.Forms.TableLayoutPanel();
            this.LabelMaxSize = new System.Windows.Forms.Label();
            this.MaxSize = new System.Windows.Forms.NumericUpDown();
            this.ButtonOpen = new System.Windows.Forms.Button();
            this.ButtonCompress = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OriginalSize = new System.Windows.Forms.TextBox();
            this.ActualLevel = new System.Windows.Forms.TextBox();
            this.ActualSize = new System.Windows.Forms.TextBox();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureOld)).BeginInit();
            this.Group.SuspendLayout();
            this.PanelGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxSize)).BeginInit();
            this.SuspendLayout();
            // 
            // FileDialog
            // 
            this.FileDialog.FileName = "openFileDialog1";
            // 
            // Panel
            // 
            this.Panel.ColumnCount = 3;
            this.Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Panel.Controls.Add(this.PictureNew, 1, 0);
            this.Panel.Controls.Add(this.PictureOld, 0, 0);
            this.Panel.Controls.Add(this.Group, 2, 0);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.RowCount = 1;
            this.Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel.Size = new System.Drawing.Size(1000, 530);
            this.Panel.TabIndex = 1;
            // 
            // PictureNew
            // 
            this.PictureNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureNew.Location = new System.Drawing.Point(403, 3);
            this.PictureNew.Name = "PictureNew";
            this.PictureNew.Size = new System.Drawing.Size(394, 524);
            this.PictureNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureNew.TabIndex = 4;
            this.PictureNew.TabStop = false;
            // 
            // PictureOld
            // 
            this.PictureOld.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureOld.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureOld.Location = new System.Drawing.Point(3, 3);
            this.PictureOld.Name = "PictureOld";
            this.PictureOld.Size = new System.Drawing.Size(394, 524);
            this.PictureOld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureOld.TabIndex = 3;
            this.PictureOld.TabStop = false;
            // 
            // Group
            // 
            this.Group.Controls.Add(this.PanelGroup);
            this.Group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Group.Location = new System.Drawing.Point(803, 3);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(194, 524);
            this.Group.TabIndex = 5;
            this.Group.TabStop = false;
            this.Group.Text = "Actions";
            // 
            // PanelGroup
            // 
            this.PanelGroup.ColumnCount = 2;
            this.PanelGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelGroup.Controls.Add(this.LabelMaxSize, 0, 0);
            this.PanelGroup.Controls.Add(this.MaxSize, 1, 0);
            this.PanelGroup.Controls.Add(this.ButtonOpen, 0, 1);
            this.PanelGroup.Controls.Add(this.ButtonCompress, 0, 2);
            this.PanelGroup.Controls.Add(this.label2, 0, 3);
            this.PanelGroup.Controls.Add(this.label3, 0, 4);
            this.PanelGroup.Controls.Add(this.label4, 0, 5);
            this.PanelGroup.Controls.Add(this.OriginalSize, 1, 3);
            this.PanelGroup.Controls.Add(this.ActualLevel, 1, 4);
            this.PanelGroup.Controls.Add(this.ActualSize, 1, 5);
            this.PanelGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelGroup.Location = new System.Drawing.Point(3, 16);
            this.PanelGroup.Name = "PanelGroup";
            this.PanelGroup.RowCount = 7;
            this.PanelGroup.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PanelGroup.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PanelGroup.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PanelGroup.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PanelGroup.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PanelGroup.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PanelGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PanelGroup.Size = new System.Drawing.Size(188, 505);
            this.PanelGroup.TabIndex = 0;
            // 
            // LabelMaxSize
            // 
            this.LabelMaxSize.AutoSize = true;
            this.LabelMaxSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelMaxSize.Location = new System.Drawing.Point(3, 0);
            this.LabelMaxSize.Name = "LabelMaxSize";
            this.LabelMaxSize.Size = new System.Drawing.Size(88, 26);
            this.LabelMaxSize.TabIndex = 0;
            this.LabelMaxSize.Text = "Max Size(Kb)";
            this.LabelMaxSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MaxSize
            // 
            this.MaxSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaxSize.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MaxSize.Location = new System.Drawing.Point(97, 3);
            this.MaxSize.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.MaxSize.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MaxSize.Name = "MaxSize";
            this.MaxSize.Size = new System.Drawing.Size(88, 20);
            this.MaxSize.TabIndex = 1;
            this.MaxSize.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // ButtonOpen
            // 
            this.PanelGroup.SetColumnSpan(this.ButtonOpen, 2);
            this.ButtonOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonOpen.Location = new System.Drawing.Point(3, 29);
            this.ButtonOpen.Name = "ButtonOpen";
            this.ButtonOpen.Size = new System.Drawing.Size(182, 30);
            this.ButtonOpen.TabIndex = 2;
            this.ButtonOpen.Text = "Open";
            this.ButtonOpen.UseVisualStyleBackColor = true;
            this.ButtonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // ButtonCompress
            // 
            this.PanelGroup.SetColumnSpan(this.ButtonCompress, 2);
            this.ButtonCompress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonCompress.Location = new System.Drawing.Point(3, 65);
            this.ButtonCompress.Name = "ButtonCompress";
            this.ButtonCompress.Size = new System.Drawing.Size(182, 30);
            this.ButtonCompress.TabIndex = 3;
            this.ButtonCompress.Text = "Compress";
            this.ButtonCompress.UseVisualStyleBackColor = true;
            this.ButtonCompress.Click += new System.EventHandler(this.ButtonCompress_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 26);
            this.label2.TabIndex = 49;
            this.label2.Text = "Original Size:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 26);
            this.label3.TabIndex = 53;
            this.label3.Text = "Compression Level:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 26);
            this.label4.TabIndex = 54;
            this.label4.Text = "New Size:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OriginalSize
            // 
            this.OriginalSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OriginalSize.Location = new System.Drawing.Point(97, 101);
            this.OriginalSize.Name = "OriginalSize";
            this.OriginalSize.ReadOnly = true;
            this.OriginalSize.Size = new System.Drawing.Size(88, 20);
            this.OriginalSize.TabIndex = 55;
            this.OriginalSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ActualLevel
            // 
            this.ActualLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActualLevel.Location = new System.Drawing.Point(97, 127);
            this.ActualLevel.Name = "ActualLevel";
            this.ActualLevel.ReadOnly = true;
            this.ActualLevel.Size = new System.Drawing.Size(88, 20);
            this.ActualLevel.TabIndex = 56;
            this.ActualLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ActualSize
            // 
            this.ActualSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActualSize.Location = new System.Drawing.Point(97, 153);
            this.ActualSize.Name = "ActualSize";
            this.ActualSize.ReadOnly = true;
            this.ActualSize.Size = new System.Drawing.Size(88, 20);
            this.ActualSize.TabIndex = 57;
            this.ActualSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 530);
            this.Controls.Add(this.Panel);
            this.Name = "Form1";
            this.Text = "ImageCompressor";
            this.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureOld)).EndInit();
            this.Group.ResumeLayout(false);
            this.PanelGroup.ResumeLayout(false);
            this.PanelGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.TableLayoutPanel Panel;
        private System.Windows.Forms.PictureBox PictureNew;
        private System.Windows.Forms.PictureBox PictureOld;
        private System.Windows.Forms.GroupBox Group;
        private System.Windows.Forms.TableLayoutPanel PanelGroup;
        private System.Windows.Forms.Label LabelMaxSize;
        private System.Windows.Forms.Button ButtonOpen;
        private System.Windows.Forms.Button ButtonCompress;
        private System.Windows.Forms.NumericUpDown MaxSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OriginalSize;
        private System.Windows.Forms.TextBox ActualLevel;
        private System.Windows.Forms.TextBox ActualSize;
    }
}

