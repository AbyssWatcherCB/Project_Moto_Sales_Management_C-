
namespace MotoSalesManagement
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_passeword = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_x = new System.Windows.Forms.Label();
            this.txt_user = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_passeword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_hider = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_hideshow = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(54, 233);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 89);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_username.Location = new System.Drawing.Point(179, 80);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(56, 13);
            this.lbl_username.TabIndex = 3;
            this.lbl_username.Text = "user name";
            // 
            // lbl_passeword
            // 
            this.lbl_passeword.AutoSize = true;
            this.lbl_passeword.BackColor = System.Drawing.Color.Transparent;
            this.lbl_passeword.Location = new System.Drawing.Point(179, 233);
            this.lbl_passeword.Name = "lbl_passeword";
            this.lbl_passeword.Size = new System.Drawing.Size(58, 13);
            this.lbl_passeword.TabIndex = 4;
            this.lbl_passeword.Text = "passeword";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_login.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_login.ForeColor = System.Drawing.Color.Black;
            this.btn_login.Location = new System.Drawing.Point(108, 370);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(97, 38);
            this.btn_login.TabIndex = 7;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_clear.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.Location = new System.Drawing.Point(285, 370);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(97, 38);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(169, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "User name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(169, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // lbl_x
            // 
            this.lbl_x.AutoSize = true;
            this.lbl_x.BackColor = System.Drawing.Color.Transparent;
            this.lbl_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbl_x.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_x.Location = new System.Drawing.Point(400, 9);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(47, 46);
            this.lbl_x.TabIndex = 9;
            this.lbl_x.Text = "X";
            this.lbl_x.Click += new System.EventHandler(this.lbl_x_Click);
            // 
            // txt_user
            // 
            this.txt_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_user.DefaultText = "";
            this.txt_user.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_user.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_user.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_user.DisabledState.Parent = this.txt_user;
            this.txt_user.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_user.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_user.FocusedState.Parent = this.txt_user;
            this.txt_user.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txt_user.ForeColor = System.Drawing.Color.Black;
            this.txt_user.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_user.HoverState.Parent = this.txt_user;
            this.txt_user.Location = new System.Drawing.Point(182, 134);
            this.txt_user.Name = "txt_user";
            this.txt_user.PasswordChar = '\0';
            this.txt_user.PlaceholderText = "";
            this.txt_user.SelectedText = "";
            this.txt_user.ShadowDecoration.Parent = this.txt_user;
            this.txt_user.Size = new System.Drawing.Size(200, 36);
            this.txt_user.TabIndex = 10;
            // 
            // txt_passeword
            // 
            this.txt_passeword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_passeword.DefaultText = "";
            this.txt_passeword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_passeword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_passeword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_passeword.DisabledState.Parent = this.txt_passeword;
            this.txt_passeword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_passeword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_passeword.FocusedState.Parent = this.txt_passeword;
            this.txt_passeword.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txt_passeword.ForeColor = System.Drawing.Color.Black;
            this.txt_passeword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_passeword.HoverState.Parent = this.txt_passeword;
            this.txt_passeword.Location = new System.Drawing.Point(182, 285);
            this.txt_passeword.Name = "txt_passeword";
            this.txt_passeword.PasswordChar = '\0';
            this.txt_passeword.PlaceholderText = "";
            this.txt_passeword.SelectedText = "";
            this.txt_passeword.ShadowDecoration.Parent = this.txt_passeword;
            this.txt_passeword.Size = new System.Drawing.Size(200, 36);
            this.txt_passeword.TabIndex = 11;
            // 
            // txt_hider
            // 
            this.txt_hider.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_hider.DefaultText = "";
            this.txt_hider.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_hider.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_hider.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_hider.DisabledState.Parent = this.txt_hider;
            this.txt_hider.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_hider.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_hider.FocusedState.Parent = this.txt_hider;
            this.txt_hider.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txt_hider.ForeColor = System.Drawing.Color.Black;
            this.txt_hider.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_hider.HoverState.Parent = this.txt_hider;
            this.txt_hider.Location = new System.Drawing.Point(182, 285);
            this.txt_hider.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_hider.Name = "txt_hider";
            this.txt_hider.PasswordChar = '*';
            this.txt_hider.PlaceholderText = "";
            this.txt_hider.SelectedText = "";
            this.txt_hider.ShadowDecoration.Parent = this.txt_hider;
            this.txt_hider.Size = new System.Drawing.Size(200, 36);
            this.txt_hider.TabIndex = 12;
            // 
            // btn_hideshow
            // 
            this.btn_hideshow.BackColor = System.Drawing.Color.Gray;
            this.btn_hideshow.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btn_hideshow.ForeColor = System.Drawing.Color.Black;
            this.btn_hideshow.Location = new System.Drawing.Point(285, 245);
            this.btn_hideshow.Name = "btn_hideshow";
            this.btn_hideshow.Size = new System.Drawing.Size(100, 35);
            this.btn_hideshow.TabIndex = 13;
            this.btn_hideshow.Text = "Show/Hide";
            this.btn_hideshow.UseVisualStyleBackColor = false;
            this.btn_hideshow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_hideshow_MouseDown);
            this.btn_hideshow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_hideshow_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(447, 450);
            this.Controls.Add(this.btn_hideshow);
            this.Controls.Add(this.txt_hider);
            this.Controls.Add(this.txt_passeword);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.lbl_x);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_passeword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_passeword;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_x;
        private Guna.UI2.WinForms.Guna2TextBox txt_user;
        private Guna.UI2.WinForms.Guna2TextBox txt_passeword;
        private Guna.UI2.WinForms.Guna2TextBox txt_hider;
        private System.Windows.Forms.Button btn_hideshow;
        private System.Windows.Forms.Timer timer1;
    }
}