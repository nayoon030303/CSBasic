
namespace Chapter6_FormPx
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
            this.btnDialogBox1 = new System.Windows.Forms.Button();
            this.btnDialogBox3 = new System.Windows.Forms.Button();
            this.btnDialogBox2 = new System.Windows.Forms.Button();
            this.btnModeless = new System.Windows.Forms.Button();
            this.btnModal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDialogBox1
            // 
            this.btnDialogBox1.Location = new System.Drawing.Point(50, 58);
            this.btnDialogBox1.Name = "btnDialogBox1";
            this.btnDialogBox1.Size = new System.Drawing.Size(193, 57);
            this.btnDialogBox1.TabIndex = 0;
            this.btnDialogBox1.Text = "btnDialogBox1";
            this.btnDialogBox1.UseVisualStyleBackColor = true;
            this.btnDialogBox1.Click += new System.EventHandler(this.btnDialogBox1_Click);
            // 
            // btnDialogBox3
            // 
            this.btnDialogBox3.Location = new System.Drawing.Point(50, 261);
            this.btnDialogBox3.Name = "btnDialogBox3";
            this.btnDialogBox3.Size = new System.Drawing.Size(193, 57);
            this.btnDialogBox3.TabIndex = 1;
            this.btnDialogBox3.Text = "btnDialogBox3";
            this.btnDialogBox3.UseVisualStyleBackColor = true;
            this.btnDialogBox3.Click += new System.EventHandler(this.btnDialogBox1_Click);
            // 
            // btnDialogBox2
            // 
            this.btnDialogBox2.Location = new System.Drawing.Point(50, 158);
            this.btnDialogBox2.Name = "btnDialogBox2";
            this.btnDialogBox2.Size = new System.Drawing.Size(193, 57);
            this.btnDialogBox2.TabIndex = 2;
            this.btnDialogBox2.Text = "btnDialogBox2";
            this.btnDialogBox2.UseVisualStyleBackColor = true;
            this.btnDialogBox2.Click += new System.EventHandler(this.btnDialogBox1_Click);
            // 
            // btnModeless
            // 
            this.btnModeless.Location = new System.Drawing.Point(376, 58);
            this.btnModeless.Name = "btnModeless";
            this.btnModeless.Size = new System.Drawing.Size(259, 111);
            this.btnModeless.TabIndex = 3;
            this.btnModeless.Text = "모달리스 창 열기";
            this.btnModeless.UseVisualStyleBackColor = true;
            this.btnModeless.Click += new System.EventHandler(this.btnModeless_click);
            // 
            // btnModal
            // 
            this.btnModal.Location = new System.Drawing.Point(376, 209);
            this.btnModal.Name = "btnModal";
            this.btnModal.Size = new System.Drawing.Size(259, 109);
            this.btnModal.TabIndex = 4;
            this.btnModal.Text = "모달 창 열기";
            this.btnModal.UseVisualStyleBackColor = true;
            this.btnModal.Click += new System.EventHandler(this.btnModeless_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 409);
            this.Controls.Add(this.btnModal);
            this.Controls.Add(this.btnModeless);
            this.Controls.Add(this.btnDialogBox2);
            this.Controls.Add(this.btnDialogBox3);
            this.Controls.Add(this.btnDialogBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDialogBox1;
        private System.Windows.Forms.Button btnDialogBox3;
        private System.Windows.Forms.Button btnDialogBox2;
        private System.Windows.Forms.Button btnModeless;
        private System.Windows.Forms.Button btnModal;
    }
}

