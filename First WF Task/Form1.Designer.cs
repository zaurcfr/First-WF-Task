
namespace First_WF_Task
{
    partial class Form1
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
            this.BakuBtn = new System.Windows.Forms.Button();
            this.LondonBtn = new System.Windows.Forms.Button();
            this.timeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BakuBtn
            // 
            this.BakuBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.BakuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BakuBtn.Location = new System.Drawing.Point(12, 463);
            this.BakuBtn.Name = "BakuBtn";
            this.BakuBtn.Size = new System.Drawing.Size(360, 78);
            this.BakuBtn.TabIndex = 0;
            this.BakuBtn.Text = "Baku";
            this.BakuBtn.UseVisualStyleBackColor = false;
            this.BakuBtn.Click += new System.EventHandler(this.BakuBtn_Click);
            // 
            // LondonBtn
            // 
            this.LondonBtn.BackColor = System.Drawing.Color.Gray;
            this.LondonBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LondonBtn.Location = new System.Drawing.Point(410, 463);
            this.LondonBtn.Name = "LondonBtn";
            this.LondonBtn.Size = new System.Drawing.Size(360, 78);
            this.LondonBtn.TabIndex = 1;
            this.LondonBtn.Text = "London";
            this.LondonBtn.UseVisualStyleBackColor = false;
            this.LondonBtn.Click += new System.EventHandler(this.LondonBtn_Click);
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.BackColor = System.Drawing.Color.Transparent;
            this.timeLbl.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.Location = new System.Drawing.Point(84, 9);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(0, 39);
            this.timeLbl.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::First_WF_Task.Properties.Resources.baku;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.LondonBtn);
            this.Controls.Add(this.BakuBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BakuBtn;
        private System.Windows.Forms.Button LondonBtn;
        private System.Windows.Forms.Label timeLbl;
    }
}

