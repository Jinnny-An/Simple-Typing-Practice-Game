namespace TeamProject2
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BossPicture = new System.Windows.Forms.PictureBox();
            this.Soldier5 = new System.Windows.Forms.PictureBox();
            this.Soldier3 = new System.Windows.Forms.PictureBox();
            this.Soldier2 = new System.Windows.Forms.PictureBox();
            this.Soldier1 = new System.Windows.Forms.PictureBox();
            this.Soldier4 = new System.Windows.Forms.PictureBox();
            this.GLife5 = new System.Windows.Forms.PictureBox();
            this.GLife4 = new System.Windows.Forms.PictureBox();
            this.GLife3 = new System.Windows.Forms.PictureBox();
            this.GLife2 = new System.Windows.Forms.PictureBox();
            this.GLife1 = new System.Windows.Forms.PictureBox();
            this.BLife1 = new System.Windows.Forms.PictureBox();
            this.BLife2 = new System.Windows.Forms.PictureBox();
            this.BLife3 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BossPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Soldier5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Soldier3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Soldier2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Soldier1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Soldier4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GLife5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GLife4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GLife3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GLife2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GLife1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BLife1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BLife2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BLife3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BossPicture
            // 
            this.BossPicture.Image = ((System.Drawing.Image)(resources.GetObject("BossPicture.Image")));
            this.BossPicture.Location = new System.Drawing.Point(570, 137);
            this.BossPicture.Name = "BossPicture";
            this.BossPicture.Size = new System.Drawing.Size(146, 153);
            this.BossPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BossPicture.TabIndex = 1;
            this.BossPicture.TabStop = false;
            this.BossPicture.Visible = false;
            // 
            // Soldier5
            // 
            this.Soldier5.Image = ((System.Drawing.Image)(resources.GetObject("Soldier5.Image")));
            this.Soldier5.Location = new System.Drawing.Point(558, 12);
            this.Soldier5.Name = "Soldier5";
            this.Soldier5.Size = new System.Drawing.Size(76, 74);
            this.Soldier5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Soldier5.TabIndex = 6;
            this.Soldier5.TabStop = false;
            // 
            // Soldier3
            // 
            this.Soldier3.Image = ((System.Drawing.Image)(resources.GetObject("Soldier3.Image")));
            this.Soldier3.Location = new System.Drawing.Point(371, 166);
            this.Soldier3.Name = "Soldier3";
            this.Soldier3.Size = new System.Drawing.Size(76, 74);
            this.Soldier3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Soldier3.TabIndex = 7;
            this.Soldier3.TabStop = false;
            // 
            // Soldier2
            // 
            this.Soldier2.Image = ((System.Drawing.Image)(resources.GetObject("Soldier2.Image")));
            this.Soldier2.Location = new System.Drawing.Point(457, 245);
            this.Soldier2.Name = "Soldier2";
            this.Soldier2.Size = new System.Drawing.Size(76, 74);
            this.Soldier2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Soldier2.TabIndex = 8;
            this.Soldier2.TabStop = false;
            // 
            // Soldier1
            // 
            this.Soldier1.Image = ((System.Drawing.Image)(resources.GetObject("Soldier1.Image")));
            this.Soldier1.Location = new System.Drawing.Point(558, 325);
            this.Soldier1.Name = "Soldier1";
            this.Soldier1.Size = new System.Drawing.Size(76, 74);
            this.Soldier1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Soldier1.TabIndex = 9;
            this.Soldier1.TabStop = false;
            // 
            // Soldier4
            // 
            this.Soldier4.Image = ((System.Drawing.Image)(resources.GetObject("Soldier4.Image")));
            this.Soldier4.Location = new System.Drawing.Point(457, 90);
            this.Soldier4.Name = "Soldier4";
            this.Soldier4.Size = new System.Drawing.Size(76, 74);
            this.Soldier4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Soldier4.TabIndex = 10;
            this.Soldier4.TabStop = false;
            // 
            // GLife5
            // 
            this.GLife5.Image = ((System.Drawing.Image)(resources.GetObject("GLife5.Image")));
            this.GLife5.Location = new System.Drawing.Point(12, 446);
            this.GLife5.Name = "GLife5";
            this.GLife5.Size = new System.Drawing.Size(35, 30);
            this.GLife5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GLife5.TabIndex = 11;
            this.GLife5.TabStop = false;
            // 
            // GLife4
            // 
            this.GLife4.Image = ((System.Drawing.Image)(resources.GetObject("GLife4.Image")));
            this.GLife4.Location = new System.Drawing.Point(53, 446);
            this.GLife4.Name = "GLife4";
            this.GLife4.Size = new System.Drawing.Size(35, 30);
            this.GLife4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GLife4.TabIndex = 12;
            this.GLife4.TabStop = false;
            // 
            // GLife3
            // 
            this.GLife3.Image = ((System.Drawing.Image)(resources.GetObject("GLife3.Image")));
            this.GLife3.Location = new System.Drawing.Point(94, 446);
            this.GLife3.Name = "GLife3";
            this.GLife3.Size = new System.Drawing.Size(35, 30);
            this.GLife3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GLife3.TabIndex = 13;
            this.GLife3.TabStop = false;
            // 
            // GLife2
            // 
            this.GLife2.Image = ((System.Drawing.Image)(resources.GetObject("GLife2.Image")));
            this.GLife2.Location = new System.Drawing.Point(135, 446);
            this.GLife2.Name = "GLife2";
            this.GLife2.Size = new System.Drawing.Size(35, 30);
            this.GLife2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GLife2.TabIndex = 14;
            this.GLife2.TabStop = false;
            // 
            // GLife1
            // 
            this.GLife1.Image = ((System.Drawing.Image)(resources.GetObject("GLife1.Image")));
            this.GLife1.Location = new System.Drawing.Point(176, 446);
            this.GLife1.Name = "GLife1";
            this.GLife1.Size = new System.Drawing.Size(35, 30);
            this.GLife1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GLife1.TabIndex = 15;
            this.GLife1.TabStop = false;
            // 
            // BLife1
            // 
            this.BLife1.Image = ((System.Drawing.Image)(resources.GetObject("BLife1.Image")));
            this.BLife1.Location = new System.Drawing.Point(599, 446);
            this.BLife1.Name = "BLife1";
            this.BLife1.Size = new System.Drawing.Size(35, 30);
            this.BLife1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BLife1.TabIndex = 16;
            this.BLife1.TabStop = false;
            this.BLife1.Visible = false;
            // 
            // BLife2
            // 
            this.BLife2.Image = ((System.Drawing.Image)(resources.GetObject("BLife2.Image")));
            this.BLife2.Location = new System.Drawing.Point(640, 446);
            this.BLife2.Name = "BLife2";
            this.BLife2.Size = new System.Drawing.Size(35, 30);
            this.BLife2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BLife2.TabIndex = 17;
            this.BLife2.TabStop = false;
            this.BLife2.Visible = false;
            // 
            // BLife3
            // 
            this.BLife3.Image = ((System.Drawing.Image)(resources.GetObject("BLife3.Image")));
            this.BLife3.Location = new System.Drawing.Point(681, 446);
            this.BLife3.Name = "BLife3";
            this.BLife3.Size = new System.Drawing.Size(35, 30);
            this.BLife3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BLife3.TabIndex = 18;
            this.BLife3.TabStop = false;
            this.BLife3.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("굴림", 30F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 50;
            this.listBox1.Location = new System.Drawing.Point(841, 29);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(400, 154);
            this.listBox1.TabIndex = 19;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("굴림", 30F);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 50;
            this.listBox2.Location = new System.Drawing.Point(978, 215);
            this.listBox2.MultiColumn = true;
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(125, 104);
            this.listBox2.TabIndex = 20;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("돋움", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(836, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("돋움", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(836, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("돋움", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(836, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 488);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BLife3);
            this.Controls.Add(this.BLife2);
            this.Controls.Add(this.BLife1);
            this.Controls.Add(this.GLife1);
            this.Controls.Add(this.GLife2);
            this.Controls.Add(this.GLife3);
            this.Controls.Add(this.GLife4);
            this.Controls.Add(this.GLife5);
            this.Controls.Add(this.Soldier4);
            this.Controls.Add(this.Soldier1);
            this.Controls.Add(this.Soldier2);
            this.Controls.Add(this.Soldier3);
            this.Controls.Add(this.Soldier5);
            this.Controls.Add(this.BossPicture);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BossPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Soldier5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Soldier3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Soldier2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Soldier1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Soldier4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GLife5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GLife4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GLife3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GLife2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GLife1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BLife1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BLife2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BLife3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox BossPicture;
        private System.Windows.Forms.PictureBox Soldier5;
        private System.Windows.Forms.PictureBox Soldier3;
        private System.Windows.Forms.PictureBox Soldier2;
        private System.Windows.Forms.PictureBox Soldier1;
        private System.Windows.Forms.PictureBox Soldier4;
        private System.Windows.Forms.PictureBox GLife5;
        private System.Windows.Forms.PictureBox GLife4;
        private System.Windows.Forms.PictureBox GLife3;
        private System.Windows.Forms.PictureBox GLife2;
        private System.Windows.Forms.PictureBox GLife1;
        private System.Windows.Forms.PictureBox BLife1;
        private System.Windows.Forms.PictureBox BLife2;
        private System.Windows.Forms.PictureBox BLife3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

