
namespace Project_tebak_kata_Aurel_Cennia
{
    partial class FormPlay
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
            this.lblCoin = new System.Windows.Forms.Label();
            this.lblCoinName = new System.Windows.Forms.Label();
            this.txtAnswerr = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblCheckAnswer = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnHint = new System.Windows.Forms.Button();
            this.lblHint = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblDepan = new System.Windows.Forms.Label();
            this.lblBelakang = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCoin
            // 
            this.lblCoin.AutoSize = true;
            this.lblCoin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCoin.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoin.Location = new System.Drawing.Point(260, 73);
            this.lblCoin.Name = "lblCoin";
            this.lblCoin.Size = new System.Drawing.Size(42, 20);
            this.lblCoin.TabIndex = 1;
            this.lblCoin.Text = "100";
            // 
            // lblCoinName
            // 
            this.lblCoinName.AutoSize = true;
            this.lblCoinName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCoinName.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoinName.Location = new System.Drawing.Point(205, 73);
            this.lblCoinName.Name = "lblCoinName";
            this.lblCoinName.Size = new System.Drawing.Size(54, 20);
            this.lblCoinName.TabIndex = 2;
            this.lblCoinName.Text = "Coin:";
            // 
            // txtAnswerr
            // 
            this.txtAnswerr.BackColor = System.Drawing.Color.White;
            this.txtAnswerr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswerr.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtAnswerr.Location = new System.Drawing.Point(146, 214);
            this.txtAnswerr.Name = "txtAnswerr";
            this.txtAnswerr.Size = new System.Drawing.Size(56, 24);
            this.txtAnswerr.TabIndex = 3;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Thistle;
            this.btnCheck.Location = new System.Drawing.Point(136, 246);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(85, 32);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblCheckAnswer
            // 
            this.lblCheckAnswer.AutoSize = true;
            this.lblCheckAnswer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCheckAnswer.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckAnswer.Location = new System.Drawing.Point(80, 283);
            this.lblCheckAnswer.Name = "lblCheckAnswer";
            this.lblCheckAnswer.Size = new System.Drawing.Size(0, 17);
            this.lblCheckAnswer.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnBack.Location = new System.Drawing.Point(21, 404);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnNext.Location = new System.Drawing.Point(239, 404);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnHint
            // 
            this.btnHint.BackColor = System.Drawing.Color.Lavender;
            this.btnHint.Location = new System.Drawing.Point(239, 246);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(65, 32);
            this.btnHint.TabIndex = 8;
            this.btnHint.Text = "Hint";
            this.btnHint.UseVisualStyleBackColor = false;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHint.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint.Location = new System.Drawing.Point(80, 195);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(0, 16);
            this.lblHint.TabIndex = 9;
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQuestion.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(12, 107);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(342, 88);
            this.lblQuestion.TabIndex = 10;
            this.lblQuestion.Text = "question";
            // 
            // lblDepan
            // 
            this.lblDepan.AutoSize = true;
            this.lblDepan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDepan.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepan.Location = new System.Drawing.Point(129, 217);
            this.lblDepan.Name = "lblDepan";
            this.lblDepan.Size = new System.Drawing.Size(0, 20);
            this.lblDepan.TabIndex = 11;
            this.lblDepan.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblBelakang
            // 
            this.lblBelakang.AutoSize = true;
            this.lblBelakang.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBelakang.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBelakang.Location = new System.Drawing.Point(207, 217);
            this.lblBelakang.Name = "lblBelakang";
            this.lblBelakang.Size = new System.Drawing.Size(0, 20);
            this.lblBelakang.TabIndex = 12;
            // 
            // FormPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(366, 472);
            this.Controls.Add(this.lblBelakang);
            this.Controls.Add(this.lblDepan);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblCheckAnswer);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtAnswerr);
            this.Controls.Add(this.lblCoinName);
            this.Controls.Add(this.lblCoin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.FormPlay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCoin;
        private System.Windows.Forms.Label lblCoinName;
        private System.Windows.Forms.TextBox txtAnswerr;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblCheckAnswer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblDepan;
        private System.Windows.Forms.Label lblBelakang;
    }
}