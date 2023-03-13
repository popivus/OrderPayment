namespace OrderPayment.Forms
{
    partial class FormPay
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
            descriptionLabel = new Label();
            payBox = new NumericUpDown();
            payButton = new Button();
            ((System.ComponentModel.ISupportInitialize)payBox).BeginInit();
            SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(39, 26);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(225, 15);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Оплата заказа №0 из прихода денег №0";
            // 
            // payBox
            // 
            payBox.DecimalPlaces = 2;
            payBox.Location = new Point(39, 53);
            payBox.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            payBox.Name = "payBox";
            payBox.Size = new Size(225, 23);
            payBox.TabIndex = 1;
            payBox.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // payButton
            // 
            payButton.Location = new Point(112, 100);
            payButton.Name = "payButton";
            payButton.Size = new Size(75, 23);
            payButton.TabIndex = 2;
            payButton.Text = "Оплатить";
            payButton.UseVisualStyleBackColor = true;
            payButton.Click += payButton_Click;
            // 
            // FormPay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 135);
            Controls.Add(payButton);
            Controls.Add(payBox);
            Controls.Add(descriptionLabel);
            MaximumSize = new Size(322, 174);
            MinimumSize = new Size(322, 174);
            Name = "FormPay";
            Text = "Оплата заказа под номером ";
            ((System.ComponentModel.ISupportInitialize)payBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label descriptionLabel;
        private NumericUpDown payBox;
        private Button payButton;
    }
}