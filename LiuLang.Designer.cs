using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class LiuLang
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.流浪地球;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 675);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.toolTip2.SetToolTip(this.pictureBox1, "流浪地球");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(695, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "电影名字：流浪地球";
            this.toolTip2.SetToolTip(this.label1, "流浪地球");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "返回";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(743, 541);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 60);
            this.button1.TabIndex = 3;
            this.button1.Text = "立即购票";
            this.toolTip1.SetToolTip(this.button1, "立即购票");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Active = false;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            // 
            // toolTip2
            // 
            this.toolTip2.AutomaticDelay = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文行楷", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(458, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(769, 174);
            this.label3.TabIndex = 4;
            this.label3.Text = "         《流浪地球》是由郭帆执导，吴京特别出演、屈楚萧、\r\n赵今麦、李光洁、吴孟达等领衔主演的科幻冒险电影。影片\r\n根据刘慈欣的同名小说改编，故事背景设" +
    "定在2075年，讲\r\n述了太阳即将毁灭，毁灭之后的太阳系已经不适合人类生存，\r\n而面对绝境，人类将开启“流浪地球”计划，试图带着地球\r\n一起逃离太阳系，寻找人类" +
    "新家园的故事";
            // 
            // LiuLang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1227, 752);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LiuLang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "影片详情";
            this.Load += new System.EventHandler(this.LiuLang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private Label label3;
    }
}