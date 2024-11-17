namespace WinAsynchMethod
{
    partial class Form1
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
            btnRun = new Button();
            btnWork = new Button();
            lblB = new Label();
            lblA = new Label();
            txbA = new TextBox();
            txbB = new TextBox();
            SuspendLayout();
            // 
            // btnRun
            // 
            btnRun.Location = new Point(16, 64);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(94, 29);
            btnRun.TabIndex = 0;
            btnRun.Text = "Сумма";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // btnWork
            // 
            btnWork.Location = new Point(116, 64);
            btnWork.Name = "btnWork";
            btnWork.Size = new Size(94, 29);
            btnWork.TabIndex = 1;
            btnWork.Text = "Работа";
            btnWork.UseVisualStyleBackColor = true;
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(256, 24);
            lblB.Name = "lblB";
            lblB.Size = new Size(89, 20);
            lblB.TabIndex = 2;
            lblB.Text = "Значення В";
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(20, 24);
            lblA.Name = "lblA";
            lblA.Size = new Size(90, 20);
            lblA.TabIndex = 3;
            lblA.Text = "Значення А";
            lblA.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txbA
            // 
            txbA.Location = new Point(120, 21);
            txbA.Name = "txbA";
            txbA.Size = new Size(125, 27);
            txbA.TabIndex = 4;
            // 
            // txbB
            // 
            txbB.Location = new Point(351, 21);
            txbB.Name = "txbB";
            txbB.Size = new Size(125, 27);
            txbB.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 112);
            Controls.Add(txbB);
            Controls.Add(txbA);
            Controls.Add(lblA);
            Controls.Add(lblB);
            Controls.Add(btnWork);
            Controls.Add(btnRun);
            Name = "Form1";
            Text = "Асинхронний запуск";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRun;
        private Button btnWork;
        private Label lblB;
        private Label lblA;
        private TextBox txbA;
        private TextBox txbB;
    }
}
