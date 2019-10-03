namespace Message_Encryption
{
    partial class FrmMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMessage));
            this.txtBoxAliceKey = new System.Windows.Forms.TextBox();
            this.picBoxAlice = new System.Windows.Forms.PictureBox();
            this.lblAliceKey = new System.Windows.Forms.Label();
            this.lblMessageAlice = new System.Windows.Forms.Label();
            this.txtBoxMessageAlice = new System.Windows.Forms.TextBox();
            this.picBoxBob = new System.Windows.Forms.PictureBox();
            this.txtBoxBobKey = new System.Windows.Forms.TextBox();
            this.lblBobKey = new System.Windows.Forms.Label();
            this.lblMessageBob = new System.Windows.Forms.Label();
            this.txtBoxMessageBob = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picBoxMail = new System.Windows.Forms.PictureBox();
            this.lblMode = new System.Windows.Forms.Label();
            this.gBoxMode = new System.Windows.Forms.GroupBox();
            this.toolStripMode = new System.Windows.Forms.ToolStrip();
            this.btnAES = new System.Windows.Forms.ToolStripButton();
            this.btnDES = new System.Windows.Forms.ToolStripButton();
            this.btnDecryptAlice = new System.Windows.Forms.Button();
            this.btnSendBob = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAlice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMail)).BeginInit();
            this.gBoxMode.SuspendLayout();
            this.toolStripMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxAliceKey
            // 
            this.txtBoxAliceKey.Location = new System.Drawing.Point(522, 322);
            this.txtBoxAliceKey.MaxLength = 8;
            this.txtBoxAliceKey.Name = "txtBoxAliceKey";
            this.txtBoxAliceKey.Size = new System.Drawing.Size(150, 22);
            this.txtBoxAliceKey.TabIndex = 3;
            // 
            // picBoxAlice
            // 
            this.picBoxAlice.Image = ((System.Drawing.Image)(resources.GetObject("picBoxAlice.Image")));
            this.picBoxAlice.InitialImage = null;
            this.picBoxAlice.Location = new System.Drawing.Point(557, 129);
            this.picBoxAlice.Name = "picBoxAlice";
            this.picBoxAlice.Size = new System.Drawing.Size(100, 150);
            this.picBoxAlice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxAlice.TabIndex = 1;
            this.picBoxAlice.TabStop = false;
            // 
            // lblAliceKey
            // 
            this.lblAliceKey.AutoSize = true;
            this.lblAliceKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAliceKey.Location = new System.Drawing.Point(436, 324);
            this.lblAliceKey.Name = "lblAliceKey";
            this.lblAliceKey.Size = new System.Drawing.Size(51, 20);
            this.lblAliceKey.TabIndex = 4;
            this.lblAliceKey.Text = "KEY :";
            // 
            // lblMessageAlice
            // 
            this.lblMessageAlice.AutoSize = true;
            this.lblMessageAlice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageAlice.Location = new System.Drawing.Point(436, 364);
            this.lblMessageAlice.Name = "lblMessageAlice";
            this.lblMessageAlice.Size = new System.Drawing.Size(87, 20);
            this.lblMessageAlice.TabIndex = 4;
            this.lblMessageAlice.Text = "Message :";
            // 
            // txtBoxMessageAlice
            // 
            this.txtBoxMessageAlice.Location = new System.Drawing.Point(440, 387);
            this.txtBoxMessageAlice.Multiline = true;
            this.txtBoxMessageAlice.Name = "txtBoxMessageAlice";
            this.txtBoxMessageAlice.ReadOnly = true;
            this.txtBoxMessageAlice.Size = new System.Drawing.Size(325, 125);
            this.txtBoxMessageAlice.TabIndex = 5;
            // 
            // picBoxBob
            // 
            this.picBoxBob.Image = ((System.Drawing.Image)(resources.GetObject("picBoxBob.Image")));
            this.picBoxBob.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBoxBob.InitialImage")));
            this.picBoxBob.Location = new System.Drawing.Point(151, 129);
            this.picBoxBob.Name = "picBoxBob";
            this.picBoxBob.Size = new System.Drawing.Size(100, 150);
            this.picBoxBob.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxBob.TabIndex = 0;
            this.picBoxBob.TabStop = false;
            // 
            // txtBoxBobKey
            // 
            this.txtBoxBobKey.Location = new System.Drawing.Point(101, 322);
            this.txtBoxBobKey.MaxLength = 8;
            this.txtBoxBobKey.Name = "txtBoxBobKey";
            this.txtBoxBobKey.Size = new System.Drawing.Size(150, 22);
            this.txtBoxBobKey.TabIndex = 1;
            // 
            // lblBobKey
            // 
            this.lblBobKey.AutoSize = true;
            this.lblBobKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBobKey.Location = new System.Drawing.Point(26, 324);
            this.lblBobKey.Name = "lblBobKey";
            this.lblBobKey.Size = new System.Drawing.Size(51, 20);
            this.lblBobKey.TabIndex = 2;
            this.lblBobKey.Text = "KEY :";
            // 
            // lblMessageBob
            // 
            this.lblMessageBob.AutoSize = true;
            this.lblMessageBob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageBob.Location = new System.Drawing.Point(26, 364);
            this.lblMessageBob.Name = "lblMessageBob";
            this.lblMessageBob.Size = new System.Drawing.Size(87, 20);
            this.lblMessageBob.TabIndex = 3;
            this.lblMessageBob.Text = "Message :";
            // 
            // txtBoxMessageBob
            // 
            this.txtBoxMessageBob.Location = new System.Drawing.Point(30, 387);
            this.txtBoxMessageBob.Multiline = true;
            this.txtBoxMessageBob.Name = "txtBoxMessageBob";
            this.txtBoxMessageBob.Size = new System.Drawing.Size(325, 125);
            this.txtBoxMessageBob.TabIndex = 4;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lblTitle);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.picBoxMail);
            this.splitContainer2.Panel2.Controls.Add(this.lblMode);
            this.splitContainer2.Panel2.Controls.Add(this.gBoxMode);
            this.splitContainer2.Panel2.Controls.Add(this.btnDecryptAlice);
            this.splitContainer2.Panel2.Controls.Add(this.btnSendBob);
            this.splitContainer2.Panel2.Controls.Add(this.txtBoxMessageAlice);
            this.splitContainer2.Panel2.Controls.Add(this.lblMessageAlice);
            this.splitContainer2.Panel2.Controls.Add(this.txtBoxMessageBob);
            this.splitContainer2.Panel2.Controls.Add(this.lblAliceKey);
            this.splitContainer2.Panel2.Controls.Add(this.picBoxBob);
            this.splitContainer2.Panel2.Controls.Add(this.picBoxAlice);
            this.splitContainer2.Panel2.Controls.Add(this.txtBoxAliceKey);
            this.splitContainer2.Panel2.Controls.Add(this.lblMessageBob);
            this.splitContainer2.Panel2.Controls.Add(this.txtBoxBobKey);
            this.splitContainer2.Panel2.Controls.Add(this.lblBobKey);
            this.splitContainer2.Size = new System.Drawing.Size(802, 646);
            this.splitContainer2.SplitterDistance = 72;
            this.splitContainer2.TabIndex = 7;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(188, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(405, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "MESSAGE ENCRYPTION";
            // 
            // picBoxMail
            // 
            this.picBoxMail.Image = ((System.Drawing.Image)(resources.GetObject("picBoxMail.Image")));
            this.picBoxMail.Location = new System.Drawing.Point(357, 157);
            this.picBoxMail.Name = "picBoxMail";
            this.picBoxMail.Size = new System.Drawing.Size(100, 100);
            this.picBoxMail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxMail.TabIndex = 9;
            this.picBoxMail.TabStop = false;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.Location = new System.Drawing.Point(539, 37);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(117, 32);
            this.lblMode.TabIndex = 8;
            this.lblMode.Text = "Mode : -";
            // 
            // gBoxMode
            // 
            this.gBoxMode.Controls.Add(this.toolStripMode);
            this.gBoxMode.Location = new System.Drawing.Point(12, 3);
            this.gBoxMode.Name = "gBoxMode";
            this.gBoxMode.Size = new System.Drawing.Size(239, 120);
            this.gBoxMode.TabIndex = 7;
            this.gBoxMode.TabStop = false;
            this.gBoxMode.Text = "Mode";
            // 
            // toolStripMode
            // 
            this.toolStripMode.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripMode.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAES,
            this.btnDES});
            this.toolStripMode.Location = new System.Drawing.Point(3, 18);
            this.toolStripMode.Name = "toolStripMode";
            this.toolStripMode.Size = new System.Drawing.Size(163, 78);
            this.toolStripMode.TabIndex = 1;
            // 
            // btnAES
            // 
            this.btnAES.AutoSize = false;
            this.btnAES.BackColor = System.Drawing.SystemColors.Control;
            this.btnAES.Image = ((System.Drawing.Image)(resources.GetObject("btnAES.Image")));
            this.btnAES.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAES.Name = "btnAES";
            this.btnAES.Size = new System.Drawing.Size(75, 75);
            this.btnAES.Text = "AES";
            this.btnAES.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnAES.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAES.Click += new System.EventHandler(this.btnAES_Click);
            // 
            // btnDES
            // 
            this.btnDES.AutoSize = false;
            this.btnDES.BackColor = System.Drawing.SystemColors.Control;
            this.btnDES.Image = ((System.Drawing.Image)(resources.GetObject("btnDES.Image")));
            this.btnDES.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDES.Name = "btnDES";
            this.btnDES.Size = new System.Drawing.Size(75, 75);
            this.btnDES.Text = "DES";
            this.btnDES.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnDES.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDES.Click += new System.EventHandler(this.btnDES_Click);
            // 
            // btnDecryptAlice
            // 
            this.btnDecryptAlice.Location = new System.Drawing.Point(546, 525);
            this.btnDecryptAlice.Name = "btnDecryptAlice";
            this.btnDecryptAlice.Size = new System.Drawing.Size(126, 30);
            this.btnDecryptAlice.TabIndex = 6;
            this.btnDecryptAlice.Text = "Decrypt";
            this.btnDecryptAlice.UseVisualStyleBackColor = true;
            this.btnDecryptAlice.Click += new System.EventHandler(this.btnDecryptAlice_Click);
            // 
            // btnSendBob
            // 
            this.btnSendBob.Location = new System.Drawing.Point(137, 525);
            this.btnSendBob.Name = "btnSendBob";
            this.btnSendBob.Size = new System.Drawing.Size(126, 30);
            this.btnSendBob.TabIndex = 5;
            this.btnSendBob.Text = "Send && Encrypt";
            this.btnSendBob.UseVisualStyleBackColor = true;
            this.btnSendBob.Click += new System.EventHandler(this.btnSendBob_Click);
            // 
            // FrmMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 646);
            this.Controls.Add(this.splitContainer2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAlice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBob)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMail)).EndInit();
            this.gBoxMode.ResumeLayout(false);
            this.gBoxMode.PerformLayout();
            this.toolStripMode.ResumeLayout(false);
            this.toolStripMode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxAliceKey;
        private System.Windows.Forms.PictureBox picBoxAlice;
        private System.Windows.Forms.Label lblAliceKey;
        private System.Windows.Forms.Label lblMessageAlice;
        private System.Windows.Forms.TextBox txtBoxMessageAlice;
        private System.Windows.Forms.PictureBox picBoxBob;
        private System.Windows.Forms.TextBox txtBoxBobKey;
        private System.Windows.Forms.Label lblBobKey;
        private System.Windows.Forms.Label lblMessageBob;
        private System.Windows.Forms.TextBox txtBoxMessageBob;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDecryptAlice;
        private System.Windows.Forms.Button btnSendBob;
        private System.Windows.Forms.GroupBox gBoxMode;
        private System.Windows.Forms.ToolStrip toolStripMode;
        private System.Windows.Forms.ToolStripButton btnAES;
        private System.Windows.Forms.ToolStripButton btnDES;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.PictureBox picBoxMail;
    }
}

