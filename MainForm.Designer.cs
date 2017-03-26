namespace Yatagarasu_v2
{
    partial class Yatagarasu
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTierOneLeft = new System.Windows.Forms.TableLayoutPanel();
            this.pGame = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCurrentGame = new System.Windows.Forms.Label();
            this.pFamilies = new System.Windows.Forms.Panel();
            this.tlpMain.SuspendLayout();
            this.tlpTierOneLeft.SuspendLayout();
            this.pGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpTierOneLeft, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1299, 715);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpTierOneLeft
            // 
            this.tlpTierOneLeft.ColumnCount = 1;
            this.tlpTierOneLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTierOneLeft.Controls.Add(this.pGame, 0, 0);
            this.tlpTierOneLeft.Controls.Add(this.pFamilies, 0, 1);
            this.tlpTierOneLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTierOneLeft.Location = new System.Drawing.Point(3, 3);
            this.tlpTierOneLeft.Name = "tlpTierOneLeft";
            this.tlpTierOneLeft.RowCount = 2;
            this.tlpTierOneLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpTierOneLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTierOneLeft.Size = new System.Drawing.Size(294, 709);
            this.tlpTierOneLeft.TabIndex = 0;
            // 
            // pGame
            // 
            this.pGame.Controls.Add(this.lbCurrentGame);
            this.pGame.Controls.Add(this.label1);
            this.pGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGame.Location = new System.Drawing.Point(3, 3);
            this.pGame.Name = "pGame";
            this.pGame.Size = new System.Drawing.Size(288, 74);
            this.pGame.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current game:";
            // 
            // lbCurrentGame
            // 
            this.lbCurrentGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentGame.Location = new System.Drawing.Point(1, 23);
            this.lbCurrentGame.Name = "lbCurrentGame";
            this.lbCurrentGame.Size = new System.Drawing.Size(282, 50);
            this.lbCurrentGame.TabIndex = 1;
            this.lbCurrentGame.Text = "$lbCurrentGame";
            this.lbCurrentGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pFamilies
            // 
            this.pFamilies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pFamilies.Location = new System.Drawing.Point(3, 83);
            this.pFamilies.Name = "pFamilies";
            this.pFamilies.Size = new System.Drawing.Size(288, 623);
            this.pFamilies.TabIndex = 1;
            // 
            // Yatagarasu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 715);
            this.Controls.Add(this.tlpMain);
            this.Name = "Yatagarasu";
            this.Text = "Yatagarasu_v2";
            this.tlpMain.ResumeLayout(false);
            this.tlpTierOneLeft.ResumeLayout(false);
            this.pGame.ResumeLayout(false);
            this.pGame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpTierOneLeft;
        private System.Windows.Forms.Panel pGame;
        private System.Windows.Forms.Label lbCurrentGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pFamilies;
    }
}

