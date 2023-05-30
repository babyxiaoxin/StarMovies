namespace WindowsFormsApp1
{
    partial class Down
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Down));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("苏新诗卵石体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(318, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 117);
            this.button1.TabIndex = 0;
            this.button1.Text = "用户界面";
            this.toolTip1.SetToolTip(this.button1, "用户界面");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("苏新诗卵石体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(964, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(274, 117);
            this.button2.TabIndex = 1;
            this.button2.Text = "管理员界面";
            this.toolTip2.SetToolTip(this.button2, "管理员界面");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.星光;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("苏新诗卵石体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 71);
            this.button3.TabIndex = 2;
            this.button3.Text = "退出";
            this.toolTip3.SetToolTip(this.button3, "点击退出程序");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 100;
            // 
            // toolTip2
            // 
            this.toolTip2.AutomaticDelay = 100;
            // 
            // toolTip3
            // 
            this.toolTip3.AutomaticDelay = 100;
            // 
            // Down
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1478, 803);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "Down";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录选择界面";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
    }
}