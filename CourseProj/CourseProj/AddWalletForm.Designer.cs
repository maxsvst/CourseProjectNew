namespace CourseProj
{
    partial class AddWalletForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWalletForm));
            this.addIncomeButton = new System.Windows.Forms.Button();
            this.IncomeImage = new System.Windows.Forms.PictureBox();
            this.cardCheck = new System.Windows.Forms.CheckBox();
            this.cashCheck = new System.Windows.Forms.CheckBox();
            this.walletNameField = new System.Windows.Forms.TextBox();
            this.sumField = new System.Windows.Forms.TextBox();
            this.backToWalletForm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // addIncomeButton
            // 
            this.addIncomeButton.BackColor = System.Drawing.Color.AliceBlue;
            this.addIncomeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addIncomeButton.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.addIncomeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.addIncomeButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addIncomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addIncomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addIncomeButton.ForeColor = System.Drawing.Color.Black;
            this.addIncomeButton.Location = new System.Drawing.Point(124, 592);
            this.addIncomeButton.Name = "addIncomeButton";
            this.addIncomeButton.Size = new System.Drawing.Size(355, 80);
            this.addIncomeButton.TabIndex = 1;
            this.addIncomeButton.Text = "Добавить кошелёк";
            this.addIncomeButton.UseVisualStyleBackColor = false;
            this.addIncomeButton.Click += new System.EventHandler(this.addIncomeButton_Click);
            // 
            // IncomeImage
            // 
            this.IncomeImage.Image = ((System.Drawing.Image)(resources.GetObject("IncomeImage.Image")));
            this.IncomeImage.Location = new System.Drawing.Point(139, 12);
            this.IncomeImage.Name = "IncomeImage";
            this.IncomeImage.Size = new System.Drawing.Size(323, 182);
            this.IncomeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IncomeImage.TabIndex = 13;
            this.IncomeImage.TabStop = false;
            // 
            // cardCheck
            // 
            this.cardCheck.AutoSize = true;
            this.cardCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cardCheck.ForeColor = System.Drawing.Color.Black;
            this.cardCheck.Location = new System.Drawing.Point(300, 468);
            this.cardCheck.Name = "cardCheck";
            this.cardCheck.Size = new System.Drawing.Size(179, 33);
            this.cardCheck.TabIndex = 20;
            this.cardCheck.Text = "Безаличные";
            this.cardCheck.UseVisualStyleBackColor = true;
            this.cardCheck.CheckedChanged += new System.EventHandler(this.cardCheck_CheckedChanged);
            // 
            // cashCheck
            // 
            this.cashCheck.AutoSize = true;
            this.cashCheck.Checked = true;
            this.cashCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cashCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cashCheck.Location = new System.Drawing.Point(139, 468);
            this.cashCheck.Name = "cashCheck";
            this.cashCheck.Size = new System.Drawing.Size(154, 33);
            this.cashCheck.TabIndex = 19;
            this.cashCheck.Text = "Наличные";
            this.cashCheck.UseVisualStyleBackColor = true;
            this.cashCheck.CheckedChanged += new System.EventHandler(this.cashCheck_CheckedChanged);
            // 
            // walletNameField
            // 
            this.walletNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.walletNameField.ForeColor = System.Drawing.Color.Black;
            this.walletNameField.Location = new System.Drawing.Point(139, 251);
            this.walletNameField.Margin = new System.Windows.Forms.Padding(6);
            this.walletNameField.Name = "walletNameField";
            this.walletNameField.Size = new System.Drawing.Size(337, 45);
            this.walletNameField.TabIndex = 18;
            this.walletNameField.Text = "Название кошелька";
            this.walletNameField.Enter += new System.EventHandler(this.walletNameField_Enter);
            this.walletNameField.Leave += new System.EventHandler(this.walletNameField_Leave);
            // 
            // sumField
            // 
            this.sumField.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumField.ForeColor = System.Drawing.Color.Black;
            this.sumField.Location = new System.Drawing.Point(139, 342);
            this.sumField.Margin = new System.Windows.Forms.Padding(6);
            this.sumField.Name = "sumField";
            this.sumField.Size = new System.Drawing.Size(337, 45);
            this.sumField.TabIndex = 16;
            this.sumField.Text = "Сумма";
            this.sumField.Enter += new System.EventHandler(this.sumField_Enter);
            this.sumField.Leave += new System.EventHandler(this.sumField_Leave);
            // 
            // backToWalletForm
            // 
            this.backToWalletForm.AutoSize = true;
            this.backToWalletForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToWalletForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backToWalletForm.ForeColor = System.Drawing.SystemColors.GrayText;
            this.backToWalletForm.Location = new System.Drawing.Point(200, 708);
            this.backToWalletForm.Name = "backToWalletForm";
            this.backToWalletForm.Size = new System.Drawing.Size(199, 24);
            this.backToWalletForm.TabIndex = 21;
            this.backToWalletForm.Text = "Вернуться в меню →";
            this.backToWalletForm.Click += new System.EventHandler(this.backToWalletForm_Click);
            // 
            // AddWalletForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 739);
            this.Controls.Add(this.backToWalletForm);
            this.Controls.Add(this.cardCheck);
            this.Controls.Add(this.cashCheck);
            this.Controls.Add(this.walletNameField);
            this.Controls.Add(this.sumField);
            this.Controls.Add(this.IncomeImage);
            this.Controls.Add(this.addIncomeButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(632, 786);
            this.MinimumSize = new System.Drawing.Size(632, 786);
            this.Name = "AddWalletForm";
            this.Text = "Добавить кошелёк";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddWalletForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.IncomeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addIncomeButton;
        private System.Windows.Forms.PictureBox IncomeImage;
        private System.Windows.Forms.CheckBox cardCheck;
        private System.Windows.Forms.CheckBox cashCheck;
        private System.Windows.Forms.TextBox walletNameField;
        private System.Windows.Forms.TextBox sumField;
        private System.Windows.Forms.Label backToWalletForm;
    }
}