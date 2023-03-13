namespace OrderPayment
{
    partial class FormMain
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
            ordersGroupBox = new GroupBox();
            payButton = new Button();
            ordersLabel = new Label();
            ordersGridView = new DataGridView();
            moneyArrivalLabel = new Label();
            moneyArrivalGridView = new DataGridView();
            refreshDataButton = new Button();
            paymentsGridView = new DataGridView();
            paymentsLabel = new Label();
            ordersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ordersGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)moneyArrivalGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)paymentsGridView).BeginInit();
            SuspendLayout();
            // 
            // ordersGroupBox
            // 
            ordersGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ordersGroupBox.Controls.Add(payButton);
            ordersGroupBox.Controls.Add(ordersLabel);
            ordersGroupBox.Controls.Add(ordersGridView);
            ordersGroupBox.Controls.Add(moneyArrivalLabel);
            ordersGroupBox.Controls.Add(moneyArrivalGridView);
            ordersGroupBox.Location = new Point(12, 37);
            ordersGroupBox.Name = "ordersGroupBox";
            ordersGroupBox.Size = new Size(776, 226);
            ordersGroupBox.TabIndex = 0;
            ordersGroupBox.TabStop = false;
            ordersGroupBox.Text = "Распределение приходов по заказам";
            // 
            // payButton
            // 
            payButton.Anchor = AnchorStyles.Top;
            payButton.Location = new Point(350, 104);
            payButton.Name = "payButton";
            payButton.Size = new Size(76, 53);
            payButton.TabIndex = 4;
            payButton.Text = "Оплатить\r\n->";
            payButton.UseVisualStyleBackColor = true;
            payButton.Click += payButton_Click;
            // 
            // ordersLabel
            // 
            ordersLabel.Anchor = AnchorStyles.Top;
            ordersLabel.AutoSize = true;
            ordersLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ordersLabel.Location = new Point(432, 28);
            ordersLabel.Name = "ordersLabel";
            ordersLabel.Size = new Size(54, 19);
            ordersLabel.TabIndex = 3;
            ordersLabel.Text = "Заказы";
            // 
            // ordersGridView
            // 
            ordersGridView.AllowUserToAddRows = false;
            ordersGridView.AllowUserToDeleteRows = false;
            ordersGridView.Anchor = AnchorStyles.Top;
            ordersGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ordersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersGridView.Location = new Point(432, 50);
            ordersGridView.MultiSelect = false;
            ordersGridView.Name = "ordersGridView";
            ordersGridView.ReadOnly = true;
            ordersGridView.RowHeadersVisible = false;
            ordersGridView.RowTemplate.Height = 25;
            ordersGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ordersGridView.Size = new Size(338, 168);
            ordersGridView.TabIndex = 2;
            // 
            // moneyArrivalLabel
            // 
            moneyArrivalLabel.Anchor = AnchorStyles.Top;
            moneyArrivalLabel.AutoSize = true;
            moneyArrivalLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            moneyArrivalLabel.Location = new Point(6, 28);
            moneyArrivalLabel.Name = "moneyArrivalLabel";
            moneyArrivalLabel.Size = new Size(106, 19);
            moneyArrivalLabel.TabIndex = 1;
            moneyArrivalLabel.Text = "Приходы денег";
            // 
            // moneyArrivalGridView
            // 
            moneyArrivalGridView.AllowUserToAddRows = false;
            moneyArrivalGridView.AllowUserToDeleteRows = false;
            moneyArrivalGridView.Anchor = AnchorStyles.Top;
            moneyArrivalGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            moneyArrivalGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            moneyArrivalGridView.Location = new Point(6, 50);
            moneyArrivalGridView.MultiSelect = false;
            moneyArrivalGridView.Name = "moneyArrivalGridView";
            moneyArrivalGridView.ReadOnly = true;
            moneyArrivalGridView.RowHeadersVisible = false;
            moneyArrivalGridView.RowTemplate.Height = 25;
            moneyArrivalGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            moneyArrivalGridView.Size = new Size(338, 168);
            moneyArrivalGridView.TabIndex = 0;
            // 
            // refreshDataButton
            // 
            refreshDataButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            refreshDataButton.Location = new Point(670, 8);
            refreshDataButton.Name = "refreshDataButton";
            refreshDataButton.Size = new Size(118, 23);
            refreshDataButton.TabIndex = 1;
            refreshDataButton.Text = "Обновить данные";
            refreshDataButton.UseVisualStyleBackColor = true;
            refreshDataButton.Click += refreshDataButton_Click;
            // 
            // paymentsGridView
            // 
            paymentsGridView.AllowUserToAddRows = false;
            paymentsGridView.AllowUserToDeleteRows = false;
            paymentsGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            paymentsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            paymentsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            paymentsGridView.Location = new Point(12, 304);
            paymentsGridView.MultiSelect = false;
            paymentsGridView.Name = "paymentsGridView";
            paymentsGridView.ReadOnly = true;
            paymentsGridView.RowHeadersVisible = false;
            paymentsGridView.RowTemplate.Height = 25;
            paymentsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            paymentsGridView.Size = new Size(776, 217);
            paymentsGridView.TabIndex = 5;
            // 
            // paymentsLabel
            // 
            paymentsLabel.AutoSize = true;
            paymentsLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            paymentsLabel.Location = new Point(12, 282);
            paymentsLabel.Name = "paymentsLabel";
            paymentsLabel.Size = new Size(64, 19);
            paymentsLabel.TabIndex = 5;
            paymentsLabel.Text = "Платежи";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 533);
            Controls.Add(paymentsLabel);
            Controls.Add(paymentsGridView);
            Controls.Add(refreshDataButton);
            Controls.Add(ordersGroupBox);
            MinimumSize = new Size(816, 525);
            Name = "FormMain";
            Text = "Платежи и заказы";
            ordersGroupBox.ResumeLayout(false);
            ordersGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ordersGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)moneyArrivalGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)paymentsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox ordersGroupBox;
        private Button payButton;
        private Label ordersLabel;
        private DataGridView ordersGridView;
        private Label moneyArrivalLabel;
        private DataGridView moneyArrivalGridView;
        private Button refreshDataButton;
        private DataGridView paymentsGridView;
        private Label paymentsLabel;
    }
}