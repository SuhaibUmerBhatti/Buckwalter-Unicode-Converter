namespace ArabicUnicodeBuckwalterConverter
{
    partial class frmMain
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
            btnConvert = new Button();
            txtText = new TextBox();
            txtConversion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnConvert
            // 
            btnConvert.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnConvert.Location = new Point(915, 483);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(247, 46);
            btnConvert.TabIndex = 0;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // txtText
            // 
            txtText.Location = new Point(12, 44);
            txtText.Multiline = true;
            txtText.Name = "txtText";
            txtText.Size = new Size(1150, 188);
            txtText.TabIndex = 1;
            // 
            // txtConversion
            // 
            txtConversion.Location = new Point(12, 280);
            txtConversion.Multiline = true;
            txtConversion.Name = "txtConversion";
            txtConversion.Size = new Size(1150, 188);
            txtConversion.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(61, 32);
            label1.TabIndex = 3;
            label1.Text = "Text";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 245);
            label2.Name = "label2";
            label2.Size = new Size(142, 32);
            label2.TabIndex = 4;
            label2.Text = "Convertion";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 546);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtConversion);
            Controls.Add(txtText);
            Controls.Add(btnConvert);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConvert;
        private TextBox txtText;
        private TextBox txtConversion;
        private Label label1;
        private Label label2;
    }
}