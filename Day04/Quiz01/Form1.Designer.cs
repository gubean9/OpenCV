namespace Quiz01
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BitwiseOR = new System.Windows.Forms.Button();
            this.BitwiseAND = new System.Windows.Forms.Button();
            this.BitwiseXOR = new System.Windows.Forms.Button();
            this.BitwiseNOT = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "image1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 63);
            this.button2.TabIndex = 1;
            this.button2.Text = "image2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BitwiseOR
            // 
            this.BitwiseOR.Location = new System.Drawing.Point(38, 159);
            this.BitwiseOR.Name = "BitwiseOR";
            this.BitwiseOR.Size = new System.Drawing.Size(175, 63);
            this.BitwiseOR.TabIndex = 2;
            this.BitwiseOR.Text = "Bitwise OR";
            this.BitwiseOR.UseVisualStyleBackColor = true;
            // 
            // BitwiseAND
            // 
            this.BitwiseAND.Location = new System.Drawing.Point(38, 228);
            this.BitwiseAND.Name = "BitwiseAND";
            this.BitwiseAND.Size = new System.Drawing.Size(175, 63);
            this.BitwiseAND.TabIndex = 3;
            this.BitwiseAND.Text = "Bitwise AND";
            this.BitwiseAND.UseVisualStyleBackColor = true;
            // 
            // BitwiseXOR
            // 
            this.BitwiseXOR.Location = new System.Drawing.Point(38, 297);
            this.BitwiseXOR.Name = "BitwiseXOR";
            this.BitwiseXOR.Size = new System.Drawing.Size(175, 63);
            this.BitwiseXOR.TabIndex = 4;
            this.BitwiseXOR.Text = "Bitwise XOR";
            this.BitwiseXOR.UseVisualStyleBackColor = true;
            // 
            // BitwiseNOT
            // 
            this.BitwiseNOT.Location = new System.Drawing.Point(38, 366);
            this.BitwiseNOT.Name = "BitwiseNOT";
            this.BitwiseNOT.Size = new System.Drawing.Size(175, 63);
            this.BitwiseNOT.TabIndex = 5;
            this.BitwiseNOT.Text = "Bitwise NOT";
            this.BitwiseNOT.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(246, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(523, 407);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BitwiseNOT);
            this.Controls.Add(this.BitwiseXOR);
            this.Controls.Add(this.BitwiseAND);
            this.Controls.Add(this.BitwiseOR);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BitwiseOR;
        private System.Windows.Forms.Button BitwiseAND;
        private System.Windows.Forms.Button BitwiseXOR;
        private System.Windows.Forms.Button BitwiseNOT;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

