namespace AllowanceManager
{
    partial class AllowanceManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllowanceManager));
            this.label1 = new System.Windows.Forms.Label();
            this.AddMoney = new System.Windows.Forms.Label();
            this.UseMoney = new System.Windows.Forms.Label();
            this.UseList = new System.Windows.Forms.Label();
            this.Quit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(195, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "용돈 관리 프로그램";
            // 
            // AddMoney
            // 
            this.AddMoney.AutoSize = true;
            this.AddMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddMoney.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AddMoney.ForeColor = System.Drawing.SystemColors.Control;
            this.AddMoney.Location = new System.Drawing.Point(435, 264);
            this.AddMoney.Name = "AddMoney";
            this.AddMoney.Size = new System.Drawing.Size(94, 24);
            this.AddMoney.TabIndex = 1;
            this.AddMoney.Text = "돈 추가";
            this.AddMoney.Click += new System.EventHandler(this.AddMoney_Click);
            // 
            // UseMoney
            // 
            this.UseMoney.AutoSize = true;
            this.UseMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UseMoney.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UseMoney.ForeColor = System.Drawing.SystemColors.Control;
            this.UseMoney.Location = new System.Drawing.Point(435, 319);
            this.UseMoney.Name = "UseMoney";
            this.UseMoney.Size = new System.Drawing.Size(94, 24);
            this.UseMoney.TabIndex = 2;
            this.UseMoney.Text = "돈 사용";
            this.UseMoney.Click += new System.EventHandler(this.UseMoney_Click);
            // 
            // UseList
            // 
            this.UseList.AutoSize = true;
            this.UseList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UseList.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UseList.ForeColor = System.Drawing.SystemColors.Control;
            this.UseList.Location = new System.Drawing.Point(424, 384);
            this.UseList.Name = "UseList";
            this.UseList.Size = new System.Drawing.Size(119, 24);
            this.UseList.TabIndex = 3;
            this.UseList.Text = "사용 이력";
            this.UseList.Click += new System.EventHandler(this.UseList_Click);
            // 
            // Quit
            // 
            this.Quit.AutoSize = true;
            this.Quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Quit.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Quit.ForeColor = System.Drawing.SystemColors.Control;
            this.Quit.Location = new System.Drawing.Point(449, 454);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(60, 24);
            this.Quit.TabIndex = 4;
            this.Quit.Text = "종료";
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // AllowanceManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.UseList);
            this.Controls.Add(this.UseMoney);
            this.Controls.Add(this.AddMoney);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AllowanceManager";
            this.Text = "Allowance Manager";
            this.Load += new System.EventHandler(this.AllowanceManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AddMoney;
        private System.Windows.Forms.Label UseMoney;
        private System.Windows.Forms.Label UseList;
        private System.Windows.Forms.Label Quit;
    }
}

