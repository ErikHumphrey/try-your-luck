namespace HumphreyErik17TryYourLuck
{
    partial class frmTryYourLuck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTryYourLuck));
            this.lstGameLog = new System.Windows.Forms.ListBox();
            this.btnRollDice = new System.Windows.Forms.Button();
            this.lblCounterWins = new System.Windows.Forms.Label();
            this.lblCounterLosses = new System.Windows.Forms.Label();
            this.lblWinLossPercentage = new System.Windows.Forms.Label();
            this.btnResetGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstGameLog
            // 
            this.lstGameLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstGameLog.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGameLog.FormattingEnabled = true;
            this.lstGameLog.ItemHeight = 18;
            this.lstGameLog.Location = new System.Drawing.Point(0, 87);
            this.lstGameLog.Name = "lstGameLog";
            this.lstGameLog.Size = new System.Drawing.Size(398, 310);
            this.lstGameLog.TabIndex = 0;
            // 
            // btnRollDice
            // 
            this.btnRollDice.AutoSize = true;
            this.btnRollDice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRollDice.Font = new System.Drawing.Font("Myriad Web Pro", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollDice.Image = global::HumphreyErik17TryYourLuck.Properties.Resources.imgDieSmall;
            this.btnRollDice.Location = new System.Drawing.Point(12, 4);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(76, 79);
            this.btnRollDice.TabIndex = 1;
            this.btnRollDice.UseVisualStyleBackColor = true;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // lblCounterWins
            // 
            this.lblCounterWins.AutoSize = true;
            this.lblCounterWins.Font = new System.Drawing.Font("Myriad Web Pro Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounterWins.Location = new System.Drawing.Point(94, 19);
            this.lblCounterWins.Name = "lblCounterWins";
            this.lblCounterWins.Size = new System.Drawing.Size(89, 30);
            this.lblCounterWins.TabIndex = 2;
            this.lblCounterWins.Text = "Wins: 0";
            // 
            // lblCounterLosses
            // 
            this.lblCounterLosses.AutoSize = true;
            this.lblCounterLosses.Font = new System.Drawing.Font("Myriad Web Pro Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounterLosses.Location = new System.Drawing.Point(94, 49);
            this.lblCounterLosses.Name = "lblCounterLosses";
            this.lblCounterLosses.Size = new System.Drawing.Size(106, 30);
            this.lblCounterLosses.TabIndex = 4;
            this.lblCounterLosses.Text = "Losses: 0";
            // 
            // lblWinLossPercentage
            // 
            this.lblWinLossPercentage.AutoSize = true;
            this.lblWinLossPercentage.Font = new System.Drawing.Font("Myriad Web Pro Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinLossPercentage.Location = new System.Drawing.Point(259, 19);
            this.lblWinLossPercentage.Name = "lblWinLossPercentage";
            this.lblWinLossPercentage.Size = new System.Drawing.Size(111, 30);
            this.lblWinLossPercentage.TabIndex = 5;
            this.lblWinLossPercentage.Text = "W / L: 0%";
            // 
            // btnResetGame
            // 
            this.btnResetGame.Font = new System.Drawing.Font("Myriad Web Pro", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetGame.Location = new System.Drawing.Point(264, 49);
            this.btnResetGame.Name = "btnResetGame";
            this.btnResetGame.Size = new System.Drawing.Size(124, 30);
            this.btnResetGame.TabIndex = 6;
            this.btnResetGame.Text = "Reset game";
            this.btnResetGame.UseVisualStyleBackColor = true;
            this.btnResetGame.Click += new System.EventHandler(this.btnResetGame_Click);
            // 
            // frmTryYourLuck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 397);
            this.Controls.Add(this.btnResetGame);
            this.Controls.Add(this.lblWinLossPercentage);
            this.Controls.Add(this.lblCounterLosses);
            this.Controls.Add(this.lblCounterWins);
            this.Controls.Add(this.btnRollDice);
            this.Controls.Add(this.lstGameLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTryYourLuck";
            this.Text = "Try Your Luck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstGameLog;
        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.Label lblCounterWins;
        private System.Windows.Forms.Label lblCounterLosses;
        private System.Windows.Forms.Label lblWinLossPercentage;
        private System.Windows.Forms.Button btnResetGame;
    }
}

