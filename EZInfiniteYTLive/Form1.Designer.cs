namespace EZInfiniteYTLive
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.RMTPUrl = new System.Windows.Forms.TextBox();
            this.StreamKey = new System.Windows.Forms.TextBox();
            this.ChooseVideosButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.ForceStopButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.ShuffleRadio = new System.Windows.Forms.RadioButton();
            this.AlphabeticOrderRadio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // RMTPUrl
            // 
            this.RMTPUrl.Location = new System.Drawing.Point(13, 13);
            this.RMTPUrl.Name = "RMTPUrl";
            this.RMTPUrl.Size = new System.Drawing.Size(203, 20);
            this.RMTPUrl.TabIndex = 0;
            this.RMTPUrl.Text = "rtmp://a.rtmp.youtube.com/live2";
            // 
            // StreamKey
            // 
            this.StreamKey.Location = new System.Drawing.Point(222, 12);
            this.StreamKey.Name = "StreamKey";
            this.StreamKey.PasswordChar = '*';
            this.StreamKey.Size = new System.Drawing.Size(248, 20);
            this.StreamKey.TabIndex = 1;
            // 
            // ChooseVideosButton
            // 
            this.ChooseVideosButton.Location = new System.Drawing.Point(13, 40);
            this.ChooseVideosButton.Name = "ChooseVideosButton";
            this.ChooseVideosButton.Size = new System.Drawing.Size(102, 23);
            this.ChooseVideosButton.TabIndex = 2;
            this.ChooseVideosButton.Text = "Choose Videos";
            this.ChooseVideosButton.UseVisualStyleBackColor = true;
            this.ChooseVideosButton.Click += new System.EventHandler(this.ChooseVideosButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(122, 40);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(58, 23);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ForceStopButton
            // 
            this.ForceStopButton.Location = new System.Drawing.Point(186, 42);
            this.ForceStopButton.Name = "ForceStopButton";
            this.ForceStopButton.Size = new System.Drawing.Size(75, 21);
            this.ForceStopButton.TabIndex = 4;
            this.ForceStopButton.Text = "STOP";
            this.ForceStopButton.UseVisualStyleBackColor = true;
            this.ForceStopButton.Click += new System.EventHandler(this.ForceStopButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(356, 40);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(35, 13);
            this.StatusLabel.TabIndex = 5;
            this.StatusLabel.Text = "label1";
            // 
            // ShuffleRadio
            // 
            this.ShuffleRadio.AutoSize = true;
            this.ShuffleRadio.Location = new System.Drawing.Point(267, 38);
            this.ShuffleRadio.Name = "ShuffleRadio";
            this.ShuffleRadio.Size = new System.Drawing.Size(83, 17);
            this.ShuffleRadio.TabIndex = 6;
            this.ShuffleRadio.TabStop = true;
            this.ShuffleRadio.Text = "RandOrder?";
            this.ShuffleRadio.UseVisualStyleBackColor = true;
            this.ShuffleRadio.CheckedChanged += new System.EventHandler(this.ShuffleRadio_CheckedChanged);
            // 
            // AlphabeticOrderRadio
            // 
            this.AlphabeticOrderRadio.AutoSize = true;
            this.AlphabeticOrderRadio.Location = new System.Drawing.Point(267, 57);
            this.AlphabeticOrderRadio.Name = "AlphabeticOrderRadio";
            this.AlphabeticOrderRadio.Size = new System.Drawing.Size(107, 17);
            this.AlphabeticOrderRadio.TabIndex = 7;
            this.AlphabeticOrderRadio.TabStop = true;
            this.AlphabeticOrderRadio.Text = "AlphabeticOrder?";
            this.AlphabeticOrderRadio.UseVisualStyleBackColor = true;
            this.AlphabeticOrderRadio.CheckedChanged += new System.EventHandler(this.AlphabeticOrderRadio_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 83);
            this.Controls.Add(this.AlphabeticOrderRadio);
            this.Controls.Add(this.ShuffleRadio);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ForceStopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ChooseVideosButton);
            this.Controls.Add(this.StreamKey);
            this.Controls.Add(this.RMTPUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RMTPUrl;
        private System.Windows.Forms.TextBox StreamKey;
        private System.Windows.Forms.Button ChooseVideosButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ForceStopButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.RadioButton ShuffleRadio;
        private System.Windows.Forms.RadioButton AlphabeticOrderRadio;
    }
}

