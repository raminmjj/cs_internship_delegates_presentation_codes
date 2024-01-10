namespace EventsAndDelegatesSimplified
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
            this.btnRemoveDelegate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCountTo = new System.Windows.Forms.TextBox();
            this.txtReachable = new System.Windows.Forms.TextBox();
            this.cmdRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRemoveDelegate
            // 
            this.btnRemoveDelegate.Location = new System.Drawing.Point(22, 179);
            this.btnRemoveDelegate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRemoveDelegate.Name = "btnRemoveDelegate";
            this.btnRemoveDelegate.Size = new System.Drawing.Size(257, 42);
            this.btnRemoveDelegate.TabIndex = 11;
            this.btnRemoveDelegate.Text = "Remove second handler";
            this.btnRemoveDelegate.Click += new System.EventHandler(this.btnRemoveDelegate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Reach this number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Count To";
            // 
            // txtCountTo
            // 
            this.txtCountTo.Location = new System.Drawing.Point(216, 17);
            this.txtCountTo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCountTo.Name = "txtCountTo";
            this.txtCountTo.Size = new System.Drawing.Size(63, 29);
            this.txtCountTo.TabIndex = 6;
            this.txtCountTo.Text = "10";
            // 
            // txtReachable
            // 
            this.txtReachable.Location = new System.Drawing.Point(216, 61);
            this.txtReachable.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtReachable.Name = "txtReachable";
            this.txtReachable.Size = new System.Drawing.Size(63, 29);
            this.txtReachable.TabIndex = 7;
            this.txtReachable.Text = "6";
            // 
            // cmdRun
            // 
            this.cmdRun.Location = new System.Drawing.Point(22, 120);
            this.cmdRun.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmdRun.Name = "cmdRun";
            this.cmdRun.Size = new System.Drawing.Size(88, 42);
            this.cmdRun.TabIndex = 8;
            this.cmdRun.Text = "Run";
            this.cmdRun.Click += new System.EventHandler(this.cmdRun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 251);
            this.Controls.Add(this.btnRemoveDelegate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCountTo);
            this.Controls.Add(this.txtReachable);
            this.Controls.Add(this.cmdRun);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Events and Delegates Simplified";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveDelegate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCountTo;
        private System.Windows.Forms.TextBox txtReachable;
        private System.Windows.Forms.Button cmdRun;
    }
}

