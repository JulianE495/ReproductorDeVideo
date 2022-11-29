namespace TextPaint
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnLeftSide = new System.Windows.Forms.Panel();
            this.pnPaintTools = new System.Windows.Forms.Panel();
            this.btnColors = new System.Windows.Forms.Button();
            this.btnPaintMenu = new System.Windows.Forms.Button();
            this.pnTextTools = new System.Windows.Forms.Panel();
            this.btnTextTools = new System.Windows.Forms.Button();
            this.btnSaveDoc = new System.Windows.Forms.Button();
            this.btnOpenDoc = new System.Windows.Forms.Button();
            this.btnNewDoc = new System.Windows.Forms.Button();
            this.btnTextMenu = new System.Windows.Forms.Button();
            this.pnColorEdit = new System.Windows.Forms.Panel();
            this.pnTextEdit = new System.Windows.Forms.Panel();
            this.pnTools = new System.Windows.Forms.Panel();
            this.cbFontSize = new System.Windows.Forms.ComboBox();
            this.cbFont = new System.Windows.Forms.ComboBox();
            this.txtTextEdit = new System.Windows.Forms.RichTextBox();
            this.btnFont = new System.Windows.Forms.Button();
            this.txtColorEdit = new System.Windows.Forms.TextBox();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnLeftSide.SuspendLayout();
            this.pnPaintTools.SuspendLayout();
            this.pnTextTools.SuspendLayout();
            this.pnColorEdit.SuspendLayout();
            this.pnTextEdit.SuspendLayout();
            this.pnTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLeftSide
            // 
            this.pnLeftSide.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnLeftSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.pnLeftSide.Controls.Add(this.pnPaintTools);
            this.pnLeftSide.Controls.Add(this.btnPaintMenu);
            this.pnLeftSide.Controls.Add(this.pnTextTools);
            this.pnLeftSide.Controls.Add(this.btnTextMenu);
            this.pnLeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeftSide.Location = new System.Drawing.Point(0, 0);
            this.pnLeftSide.Margin = new System.Windows.Forms.Padding(2);
            this.pnLeftSide.Name = "pnLeftSide";
            this.pnLeftSide.Size = new System.Drawing.Size(184, 540);
            this.pnLeftSide.TabIndex = 1;
            // 
            // pnPaintTools
            // 
            this.pnPaintTools.Controls.Add(this.btnFont);
            this.pnPaintTools.Controls.Add(this.btnColors);
            this.pnPaintTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnPaintTools.Location = new System.Drawing.Point(0, 242);
            this.pnPaintTools.Name = "pnPaintTools";
            this.pnPaintTools.Size = new System.Drawing.Size(184, 82);
            this.pnPaintTools.TabIndex = 9;
            // 
            // btnColors
            // 
            this.btnColors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.btnColors.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnColors.FlatAppearance.BorderSize = 0;
            this.btnColors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColors.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColors.ForeColor = System.Drawing.Color.White;
            this.btnColors.Image = ((System.Drawing.Image)(resources.GetObject("btnColors.Image")));
            this.btnColors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnColors.Location = new System.Drawing.Point(0, 0);
            this.btnColors.Name = "btnColors";
            this.btnColors.Padding = new System.Windows.Forms.Padding(8);
            this.btnColors.Size = new System.Drawing.Size(184, 40);
            this.btnColors.TabIndex = 6;
            this.btnColors.Text = "Colores";
            this.btnColors.UseVisualStyleBackColor = false;
            this.btnColors.Click += new System.EventHandler(this.btnColors_Click);
            // 
            // btnPaintMenu
            // 
            this.btnPaintMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnPaintMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPaintMenu.FlatAppearance.BorderSize = 0;
            this.btnPaintMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaintMenu.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaintMenu.ForeColor = System.Drawing.Color.White;
            this.btnPaintMenu.Location = new System.Drawing.Point(0, 202);
            this.btnPaintMenu.Name = "btnPaintMenu";
            this.btnPaintMenu.Padding = new System.Windows.Forms.Padding(4, 8, 8, 8);
            this.btnPaintMenu.Size = new System.Drawing.Size(184, 40);
            this.btnPaintMenu.TabIndex = 8;
            this.btnPaintMenu.Text = "Paint";
            this.btnPaintMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaintMenu.UseVisualStyleBackColor = false;
            this.btnPaintMenu.Click += new System.EventHandler(this.btnPaintMenu_Click);
            // 
            // pnTextTools
            // 
            this.pnTextTools.Controls.Add(this.btnTextTools);
            this.pnTextTools.Controls.Add(this.btnSaveDoc);
            this.pnTextTools.Controls.Add(this.btnOpenDoc);
            this.pnTextTools.Controls.Add(this.btnNewDoc);
            this.pnTextTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTextTools.Location = new System.Drawing.Point(0, 40);
            this.pnTextTools.Name = "pnTextTools";
            this.pnTextTools.Size = new System.Drawing.Size(184, 162);
            this.pnTextTools.TabIndex = 7;
            // 
            // btnTextTools
            // 
            this.btnTextTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.btnTextTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTextTools.FlatAppearance.BorderSize = 0;
            this.btnTextTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTextTools.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTextTools.ForeColor = System.Drawing.Color.White;
            this.btnTextTools.Image = ((System.Drawing.Image)(resources.GetObject("btnTextTools.Image")));
            this.btnTextTools.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTextTools.Location = new System.Drawing.Point(0, 120);
            this.btnTextTools.Name = "btnTextTools";
            this.btnTextTools.Padding = new System.Windows.Forms.Padding(8);
            this.btnTextTools.Size = new System.Drawing.Size(184, 40);
            this.btnTextTools.TabIndex = 9;
            this.btnTextTools.Text = "Herramientas";
            this.btnTextTools.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTextTools.UseVisualStyleBackColor = false;
            this.btnTextTools.Click += new System.EventHandler(this.btnTextTools_Click);
            // 
            // btnSaveDoc
            // 
            this.btnSaveDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.btnSaveDoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSaveDoc.FlatAppearance.BorderSize = 0;
            this.btnSaveDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDoc.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDoc.ForeColor = System.Drawing.Color.White;
            this.btnSaveDoc.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveDoc.Image")));
            this.btnSaveDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveDoc.Location = new System.Drawing.Point(0, 80);
            this.btnSaveDoc.Name = "btnSaveDoc";
            this.btnSaveDoc.Padding = new System.Windows.Forms.Padding(8);
            this.btnSaveDoc.Size = new System.Drawing.Size(184, 40);
            this.btnSaveDoc.TabIndex = 7;
            this.btnSaveDoc.Text = "Guardar";
            this.btnSaveDoc.UseVisualStyleBackColor = false;
            this.btnSaveDoc.Click += new System.EventHandler(this.btnSaveDoc_Click);
            // 
            // btnOpenDoc
            // 
            this.btnOpenDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.btnOpenDoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenDoc.FlatAppearance.BorderSize = 0;
            this.btnOpenDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenDoc.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenDoc.ForeColor = System.Drawing.Color.White;
            this.btnOpenDoc.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenDoc.Image")));
            this.btnOpenDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenDoc.Location = new System.Drawing.Point(0, 40);
            this.btnOpenDoc.Name = "btnOpenDoc";
            this.btnOpenDoc.Padding = new System.Windows.Forms.Padding(8);
            this.btnOpenDoc.Size = new System.Drawing.Size(184, 40);
            this.btnOpenDoc.TabIndex = 6;
            this.btnOpenDoc.Text = "Abrir";
            this.btnOpenDoc.UseVisualStyleBackColor = false;
            this.btnOpenDoc.Click += new System.EventHandler(this.btnOpenDoc_Click);
            // 
            // btnNewDoc
            // 
            this.btnNewDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.btnNewDoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewDoc.FlatAppearance.BorderSize = 0;
            this.btnNewDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewDoc.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewDoc.ForeColor = System.Drawing.Color.White;
            this.btnNewDoc.Image = ((System.Drawing.Image)(resources.GetObject("btnNewDoc.Image")));
            this.btnNewDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewDoc.Location = new System.Drawing.Point(0, 0);
            this.btnNewDoc.Name = "btnNewDoc";
            this.btnNewDoc.Padding = new System.Windows.Forms.Padding(8);
            this.btnNewDoc.Size = new System.Drawing.Size(184, 40);
            this.btnNewDoc.TabIndex = 5;
            this.btnNewDoc.Text = "Nuevo";
            this.btnNewDoc.UseVisualStyleBackColor = false;
            this.btnNewDoc.Click += new System.EventHandler(this.btnNewDoc_Click);
            // 
            // btnTextMenu
            // 
            this.btnTextMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnTextMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTextMenu.FlatAppearance.BorderSize = 0;
            this.btnTextMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTextMenu.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTextMenu.ForeColor = System.Drawing.Color.White;
            this.btnTextMenu.Location = new System.Drawing.Point(0, 0);
            this.btnTextMenu.Name = "btnTextMenu";
            this.btnTextMenu.Padding = new System.Windows.Forms.Padding(4, 8, 8, 8);
            this.btnTextMenu.Size = new System.Drawing.Size(184, 40);
            this.btnTextMenu.TabIndex = 0;
            this.btnTextMenu.Text = "Editor de Texto";
            this.btnTextMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTextMenu.UseVisualStyleBackColor = false;
            this.btnTextMenu.Click += new System.EventHandler(this.btnTextMenu_Click);
            // 
            // pnColorEdit
            // 
            this.pnColorEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnColorEdit.BackColor = System.Drawing.Color.White;
            this.pnColorEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnColorEdit.Controls.Add(this.txtColorEdit);
            this.pnColorEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnColorEdit.Location = new System.Drawing.Point(184, 0);
            this.pnColorEdit.Margin = new System.Windows.Forms.Padding(2);
            this.pnColorEdit.Name = "pnColorEdit";
            this.pnColorEdit.Size = new System.Drawing.Size(616, 540);
            this.pnColorEdit.TabIndex = 2;
            // 
            // pnTextEdit
            // 
            this.pnTextEdit.BackColor = System.Drawing.Color.White;
            this.pnTextEdit.Controls.Add(this.txtTextEdit);
            this.pnTextEdit.Controls.Add(this.pnTools);
            this.pnTextEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTextEdit.Location = new System.Drawing.Point(184, 0);
            this.pnTextEdit.Name = "pnTextEdit";
            this.pnTextEdit.Size = new System.Drawing.Size(616, 540);
            this.pnTextEdit.TabIndex = 0;
            // 
            // pnTools
            // 
            this.pnTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.pnTools.Controls.Add(this.cbFontSize);
            this.pnTools.Controls.Add(this.cbFont);
            this.pnTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTools.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.pnTools.Location = new System.Drawing.Point(0, 0);
            this.pnTools.Name = "pnTools";
            this.pnTools.Size = new System.Drawing.Size(616, 40);
            this.pnTools.TabIndex = 1;
            // 
            // cbFontSize
            // 
            this.cbFontSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFontSize.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFontSize.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.cbFontSize.Location = new System.Drawing.Point(281, 6);
            this.cbFontSize.Name = "cbFontSize";
            this.cbFontSize.Size = new System.Drawing.Size(59, 28);
            this.cbFontSize.TabIndex = 1;
            this.cbFontSize.SelectedIndexChanged += new System.EventHandler(this.cbFontSize_SelectedIndexChanged);
            // 
            // cbFont
            // 
            this.cbFont.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFont.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFont.FormattingEnabled = true;
            this.cbFont.Location = new System.Drawing.Point(6, 6);
            this.cbFont.Name = "cbFont";
            this.cbFont.Size = new System.Drawing.Size(269, 28);
            this.cbFont.TabIndex = 0;
            this.cbFont.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbFont_DrawItem);
            this.cbFont.SelectedIndexChanged += new System.EventHandler(this.cbFont_SelectedIndexChanged);
            // 
            // txtTextEdit
            // 
            this.txtTextEdit.BackColor = System.Drawing.Color.White;
            this.txtTextEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTextEdit.Location = new System.Drawing.Point(0, 40);
            this.txtTextEdit.Name = "txtTextEdit";
            this.txtTextEdit.Size = new System.Drawing.Size(616, 500);
            this.txtTextEdit.TabIndex = 3;
            this.txtTextEdit.Text = "";
            // 
            // btnFont
            // 
            this.btnFont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.btnFont.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFont.FlatAppearance.BorderSize = 0;
            this.btnFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFont.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFont.ForeColor = System.Drawing.Color.White;
            this.btnFont.Image = ((System.Drawing.Image)(resources.GetObject("btnFont.Image")));
            this.btnFont.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFont.Location = new System.Drawing.Point(0, 40);
            this.btnFont.Name = "btnFont";
            this.btnFont.Padding = new System.Windows.Forms.Padding(8);
            this.btnFont.Size = new System.Drawing.Size(184, 40);
            this.btnFont.TabIndex = 7;
            this.btnFont.Text = "Estilo";
            this.btnFont.UseVisualStyleBackColor = false;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // txtColorEdit
            // 
            this.txtColorEdit.BackColor = System.Drawing.Color.White;
            this.txtColorEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtColorEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtColorEdit.Enabled = false;
            this.txtColorEdit.Font = new System.Drawing.Font("Cascadia Code", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColorEdit.Location = new System.Drawing.Point(0, 0);
            this.txtColorEdit.Multiline = true;
            this.txtColorEdit.Name = "txtColorEdit";
            this.txtColorEdit.Size = new System.Drawing.Size(616, 140);
            this.txtColorEdit.TabIndex = 0;
            this.txtColorEdit.Text = "Cambiar color en el boton \"Colores\".";
            this.txtColorEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnMain
            // 
            this.pnMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnMain.BackgroundImage")));
            this.pnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(184, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(616, 540);
            this.pnMain.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.pnTextEdit);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnColorEdit);
            this.Controls.Add(this.pnLeftSide);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(816, 579);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextPaint";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnLeftSide.ResumeLayout(false);
            this.pnPaintTools.ResumeLayout(false);
            this.pnTextTools.ResumeLayout(false);
            this.pnColorEdit.ResumeLayout(false);
            this.pnColorEdit.PerformLayout();
            this.pnTextEdit.ResumeLayout(false);
            this.pnTools.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnLeftSide;
        private System.Windows.Forms.Button btnTextMenu;
        private System.Windows.Forms.Panel pnPaintTools;
        private System.Windows.Forms.Button btnColors;
        private System.Windows.Forms.Button btnPaintMenu;
        private System.Windows.Forms.Panel pnTextTools;
        private System.Windows.Forms.Button btnSaveDoc;
        private System.Windows.Forms.Button btnOpenDoc;
        private System.Windows.Forms.Button btnNewDoc;
        private System.Windows.Forms.Button btnTextTools;
        private System.Windows.Forms.Panel pnColorEdit;
        private System.Windows.Forms.Panel pnTextEdit;
        private System.Windows.Forms.Panel pnTools;
        private System.Windows.Forms.ComboBox cbFontSize;
        private System.Windows.Forms.ComboBox cbFont;
        private System.Windows.Forms.RichTextBox txtTextEdit;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.TextBox txtColorEdit;
        private System.Windows.Forms.Panel pnMain;
    }
}

