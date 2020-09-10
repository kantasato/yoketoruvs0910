namespace yoketoruvs0910
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.titlelabel1 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hiLabel = new System.Windows.Forms.Label();
            this.clearLabel = new System.Windows.Forms.Label();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // titlelabel1
            // 
            this.titlelabel1.AutoSize = true;
            this.titlelabel1.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelabel1.Location = new System.Drawing.Point(244, 165);
            this.titlelabel1.Name = "titlelabel1";
            this.titlelabel1.Size = new System.Drawing.Size(301, 67);
            this.titlelabel1.TabIndex = 0;
            this.titlelabel1.Text = "ヨケトル";
            this.titlelabel1.Click += new System.EventHandler(this.label1_Click);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Stencil Std", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(286, 302);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(210, 88);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.copyrightLabel.Location = new System.Drawing.Point(647, 464);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(120, 27);
            this.copyrightLabel.TabIndex = 2;
            this.copyrightLabel.Text = "佐藤寛太";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 40);
            this.label3.TabIndex = 3;
            this.label3.Text = "Time 100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(655, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 34);
            this.label4.TabIndex = 4;
            this.label4.Text = "★:10";
            // 
            // hiLabel
            // 
            this.hiLabel.AutoSize = true;
            this.hiLabel.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.hiLabel.Location = new System.Drawing.Point(306, 259);
            this.hiLabel.Name = "hiLabel";
            this.hiLabel.Size = new System.Drawing.Size(175, 27);
            this.hiLabel.TabIndex = 5;
            this.hiLabel.Text = "ハイスコア　100";
            this.hiLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // clearLabel
            // 
            this.clearLabel.AutoSize = true;
            this.clearLabel.Font = new System.Drawing.Font("Rosewood Std Regular", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearLabel.Location = new System.Drawing.Point(161, 236);
            this.clearLabel.Name = "clearLabel";
            this.clearLabel.Size = new System.Drawing.Size(180, 62);
            this.clearLabel.TabIndex = 6;
            this.clearLabel.Text = "CLEAR";
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.Font = new System.Drawing.Font("Rosewood Std Regular", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.Location = new System.Drawing.Point(440, 247);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(271, 62);
            this.gameOverLabel.TabIndex = 7;
            this.gameOverLabel.Text = "GAMEOVER";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 500);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.clearLabel);
            this.Controls.Add(this.hiLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.titlelabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlelabel1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label hiLabel;
        private System.Windows.Forms.Label clearLabel;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

