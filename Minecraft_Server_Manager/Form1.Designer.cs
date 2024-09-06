namespace Minecraft_Server_Manager
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTable = new System.Windows.Forms.TableLayoutPanel();
            this.pTL = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.roundedButton1 = new Minecraft_Server_Manager.RoundedButton();
            this.roundedButton2 = new Minecraft_Server_Manager.RoundedButton();
            this.roundedButton3 = new Minecraft_Server_Manager.RoundedButton();
            this.roundedButton4 = new Minecraft_Server_Manager.RoundedButton();
            this.pTR = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pBL = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.serverView1 = new Minecraft_Server_Manager.ServerView();
            this.pBR = new System.Windows.Forms.Panel();
            this.roundedButton9 = new Minecraft_Server_Manager.RoundedButton();
            this.roundedButton8 = new Minecraft_Server_Manager.RoundedButton();
            this.roundedButton7 = new Minecraft_Server_Manager.RoundedButton();
            this.roundedButton6 = new Minecraft_Server_Manager.RoundedButton();
            this.roundedButton5 = new Minecraft_Server_Manager.RoundedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainTable.SuspendLayout();
            this.pTL.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.pTR.SuspendLayout();
            this.pBL.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pBR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTable
            // 
            this.mainTable.ColumnCount = 2;
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.mainTable.Controls.Add(this.pTL, 0, 0);
            this.mainTable.Controls.Add(this.pTR, 1, 0);
            this.mainTable.Controls.Add(this.pBL, 0, 1);
            this.mainTable.Controls.Add(this.pBR, 1, 1);
            this.mainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTable.Location = new System.Drawing.Point(0, 0);
            this.mainTable.Name = "mainTable";
            this.mainTable.RowCount = 2;
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTable.Size = new System.Drawing.Size(704, 441);
            this.mainTable.TabIndex = 0;
            // 
            // pTL
            // 
            this.pTL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.pTL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pTL.Controls.Add(this.flowLayoutPanel2);
            this.pTL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTL.Location = new System.Drawing.Point(0, 0);
            this.pTL.Margin = new System.Windows.Forms.Padding(0);
            this.pTL.Name = "pTL";
            this.pTL.Size = new System.Drawing.Size(504, 55);
            this.pTL.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.roundedButton1);
            this.flowLayoutPanel2.Controls.Add(this.roundedButton2);
            this.flowLayoutPanel2.Controls.Add(this.roundedButton3);
            this.flowLayoutPanel2.Controls.Add(this.roundedButton4);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(502, 53);
            this.flowLayoutPanel2.TabIndex = 0;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // roundedButton1
            // 
            this.roundedButton1.AutoSize = true;
            this.roundedButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(76)))), ((int)(((byte)(81)))));
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(3, 3);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(107, 45);
            this.roundedButton1.TabIndex = 0;
            this.roundedButton1.Text = "New Server";
            this.roundedButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton1.UseVisualStyleBackColor = true;
            this.roundedButton1.Click += new System.EventHandler(this.newServerClick);
            // 
            // roundedButton2
            // 
            this.roundedButton2.AutoSize = true;
            this.roundedButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(76)))), ((int)(((byte)(81)))));
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton2.ForeColor = System.Drawing.Color.White;
            this.roundedButton2.Location = new System.Drawing.Point(116, 3);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Size = new System.Drawing.Size(81, 45);
            this.roundedButton2.TabIndex = 1;
            this.roundedButton2.Text = "Backup";
            this.roundedButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton2.UseVisualStyleBackColor = true;
            this.roundedButton2.Click += new System.EventHandler(this.backupClick);
            // 
            // roundedButton3
            // 
            this.roundedButton3.AutoSize = true;
            this.roundedButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(76)))), ((int)(((byte)(81)))));
            this.roundedButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton3.ForeColor = System.Drawing.Color.White;
            this.roundedButton3.Location = new System.Drawing.Point(203, 3);
            this.roundedButton3.Name = "roundedButton3";
            this.roundedButton3.Size = new System.Drawing.Size(71, 45);
            this.roundedButton3.TabIndex = 2;
            this.roundedButton3.Text = "Import";
            this.roundedButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton3.UseVisualStyleBackColor = true;
            this.roundedButton3.Click += new System.EventHandler(this.importClick);
            // 
            // roundedButton4
            // 
            this.roundedButton4.AutoSize = true;
            this.roundedButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(76)))), ((int)(((byte)(81)))));
            this.roundedButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton4.ForeColor = System.Drawing.Color.White;
            this.roundedButton4.Location = new System.Drawing.Point(280, 3);
            this.roundedButton4.Name = "roundedButton4";
            this.roundedButton4.Size = new System.Drawing.Size(25, 45);
            this.roundedButton4.TabIndex = 3;
            this.roundedButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton4.UseVisualStyleBackColor = true;
            this.roundedButton4.Click += new System.EventHandler(this.helpClick);
            // 
            // pTR
            // 
            this.pTR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.pTR.Controls.Add(this.label1);
            this.pTR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTR.Location = new System.Drawing.Point(504, 0);
            this.pTR.Margin = new System.Windows.Forms.Padding(0);
            this.pTR.Name = "pTR";
            this.pTR.Size = new System.Drawing.Size(200, 55);
            this.pTR.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "MC Server Manager";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pBL
            // 
            this.pBL.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBL.Controls.Add(this.flowLayoutPanel1);
            this.pBL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBL.Location = new System.Drawing.Point(0, 55);
            this.pBL.Margin = new System.Windows.Forms.Padding(0);
            this.pBL.Name = "pBL";
            this.pBL.Size = new System.Drawing.Size(504, 386);
            this.pBL.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.flowLayoutPanel1.Controls.Add(this.serverView1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(502, 384);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // serverView1
            // 
            this.serverView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.serverView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serverView1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverView1.Location = new System.Drawing.Point(3, 3);
            this.serverView1.Name = "serverView1";
            this.serverView1.Size = new System.Drawing.Size(298, 148);
            this.serverView1.TabIndex = 0;
            // 
            // pBR
            // 
            this.pBR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.pBR.Controls.Add(this.roundedButton9);
            this.pBR.Controls.Add(this.roundedButton8);
            this.pBR.Controls.Add(this.roundedButton7);
            this.pBR.Controls.Add(this.roundedButton6);
            this.pBR.Controls.Add(this.roundedButton5);
            this.pBR.Controls.Add(this.label2);
            this.pBR.Controls.Add(this.pictureBox1);
            this.pBR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBR.Location = new System.Drawing.Point(504, 55);
            this.pBR.Margin = new System.Windows.Forms.Padding(0);
            this.pBR.Name = "pBR";
            this.pBR.Size = new System.Drawing.Size(200, 386);
            this.pBR.TabIndex = 3;
            // 
            // roundedButton9
            // 
            this.roundedButton9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedButton9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(76)))), ((int)(((byte)(81)))));
            this.roundedButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton9.ForeColor = System.Drawing.Color.White;
            this.roundedButton9.Location = new System.Drawing.Point(10, 304);
            this.roundedButton9.Name = "roundedButton9";
            this.roundedButton9.Size = new System.Drawing.Size(180, 30);
            this.roundedButton9.TabIndex = 6;
            this.roundedButton9.Text = "Server Settings";
            this.roundedButton9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton9.UseVisualStyleBackColor = true;
            // 
            // roundedButton8
            // 
            this.roundedButton8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedButton8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(76)))), ((int)(((byte)(81)))));
            this.roundedButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton8.ForeColor = System.Drawing.Color.White;
            this.roundedButton8.Location = new System.Drawing.Point(10, 268);
            this.roundedButton8.Name = "roundedButton8";
            this.roundedButton8.Size = new System.Drawing.Size(180, 30);
            this.roundedButton8.TabIndex = 5;
            this.roundedButton8.Text = "Delete";
            this.roundedButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton8.UseVisualStyleBackColor = true;
            // 
            // roundedButton7
            // 
            this.roundedButton7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedButton7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(76)))), ((int)(((byte)(81)))));
            this.roundedButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton7.ForeColor = System.Drawing.Color.White;
            this.roundedButton7.Location = new System.Drawing.Point(10, 232);
            this.roundedButton7.Name = "roundedButton7";
            this.roundedButton7.Size = new System.Drawing.Size(180, 30);
            this.roundedButton7.TabIndex = 4;
            this.roundedButton7.Text = "Export";
            this.roundedButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton7.UseVisualStyleBackColor = true;
            // 
            // roundedButton6
            // 
            this.roundedButton6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedButton6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(76)))), ((int)(((byte)(81)))));
            this.roundedButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton6.ForeColor = System.Drawing.Color.White;
            this.roundedButton6.Location = new System.Drawing.Point(10, 196);
            this.roundedButton6.Name = "roundedButton6";
            this.roundedButton6.Size = new System.Drawing.Size(180, 30);
            this.roundedButton6.TabIndex = 3;
            this.roundedButton6.Text = "Open folder";
            this.roundedButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton6.UseVisualStyleBackColor = true;
            // 
            // roundedButton5
            // 
            this.roundedButton5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(76)))), ((int)(((byte)(81)))));
            this.roundedButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton5.ForeColor = System.Drawing.Color.White;
            this.roundedButton5.Location = new System.Drawing.Point(10, 160);
            this.roundedButton5.Name = "roundedButton5";
            this.roundedButton5.Size = new System.Drawing.Size(180, 30);
            this.roundedButton5.TabIndex = 2;
            this.roundedButton5.Text = "Start Server";
            this.roundedButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "SERVER";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(50, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.mainTable);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(720, 480);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minecraft Server Manager";
            this.mainTable.ResumeLayout(false);
            this.pTL.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.pTR.ResumeLayout(false);
            this.pBL.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pBR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTable;
        private System.Windows.Forms.Panel pTL;
        private System.Windows.Forms.Panel pTR;
        private System.Windows.Forms.Panel pBL;
        private System.Windows.Forms.Panel pBR;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private RoundedButton roundedButton2;
        private RoundedButton roundedButton3;
        private RoundedButton roundedButton4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private RoundedButton roundedButton1;
        private RoundedButton roundedButton9;
        private RoundedButton roundedButton8;
        private RoundedButton roundedButton7;
        private RoundedButton roundedButton6;
        private RoundedButton roundedButton5;
        private ServerView serverView1;
    }
}

