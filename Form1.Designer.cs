namespace StopWatch
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
            this.Title = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.초기화ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stat = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.Start = new System.Windows.Forms.Button();
            this.tb = new System.Windows.Forms.Label();
            this.printtext = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("카페24 써라운드 에어 ", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Title.Location = new System.Drawing.Point(98, 101);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(200, 45);
            this.Title.TabIndex = 0;
            this.Title.Tag = "Title";
            this.Title.Text = "KIM MINA";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(388, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.초기화ToolStripMenuItem,
            this.끝내기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Font = new System.Drawing.Font("카페24 심플해", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 초기화ToolStripMenuItem
            // 
            this.초기화ToolStripMenuItem.Name = "초기화ToolStripMenuItem";
            this.초기화ToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.초기화ToolStripMenuItem.Text = "초기화";
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.끝내기ToolStripMenuItem.Text = "끝내기";
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.Font = new System.Drawing.Font("카페24 심플해", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stat,
            this.ProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(388, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // stat
            // 
            this.stat.Font = new System.Drawing.Font("카페24 심플해", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.stat.Name = "stat";
            this.stat.Size = new System.Drawing.Size(115, 20);
            this.stat.Tag = "stat";
            this.stat.Text = "오늘도 좋은 하루";
            this.stat.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.AutoToolTip = true;
            this.ProgressBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(5);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(100, 16);
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.ProgressBar.Tag = "ProgressBar";
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.White;
            this.Start.Font = new System.Drawing.Font("카페24 써라운드 에어 ", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Start.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Start.Location = new System.Drawing.Point(101, 195);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(197, 76);
            this.Start.TabIndex = 3;
            this.Start.Tag = "Start";
            this.Start.Text = "시작";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // tb
            // 
            this.tb.AutoSize = true;
            this.tb.Font = new System.Drawing.Font("카페24 심플해", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb.Location = new System.Drawing.Point(98, 298);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(35, 15);
            this.tb.TabIndex = 4;
            this.tb.Text = "출력";
            // 
            // printtext
            // 
            this.printtext.BackColor = System.Drawing.Color.White;
            this.printtext.Location = new System.Drawing.Point(101, 316);
            this.printtext.Multiline = true;
            this.printtext.Name = "printtext";
            this.printtext.ReadOnly = true;
            this.printtext.Size = new System.Drawing.Size(197, 25);
            this.printtext.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(388, 450);
            this.Controls.Add(this.printtext);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "STOPWATCH";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stat;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label tb;
        private System.Windows.Forms.TextBox printtext;
        private System.Windows.Forms.ToolStripMenuItem 초기화ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

