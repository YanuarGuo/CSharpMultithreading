namespace CSharpMultithreading
{
    partial class CSharpMultithreading
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LblThreading = new Label();
            BtnStart = new Button();
            SuspendLayout();
            // 
            // LblThreading
            // 
            LblThreading.AutoSize = true;
            LblThreading.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblThreading.Location = new Point(74, 33);
            LblThreading.Name = "LblThreading";
            LblThreading.Size = new Size(148, 20);
            LblThreading.TabIndex = 0;
            LblThreading.Text = "Start Multithreading";
            // 
            // BtnStart
            // 
            BtnStart.Location = new Point(112, 64);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(75, 23);
            BtnStart.TabIndex = 1;
            BtnStart.Text = "Start";
            BtnStart.UseVisualStyleBackColor = true;
            BtnStart.Click += BtnStart_Click;
            // 
            // CSharpMultithreading
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 112);
            Controls.Add(BtnStart);
            Controls.Add(LblThreading);
            Name = "CSharpMultithreading";
            Text = "CSharpMultithreading";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblThreading;
        private Button BtnStart;
    }
}
