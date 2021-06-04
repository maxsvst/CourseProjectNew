namespace CourseProj
{
    partial class ExpenceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpenceForm));
            this.cardCheck = new System.Windows.Forms.CheckBox();
            this.cashCheck = new System.Windows.Forms.CheckBox();
            this.addExpenceButton = new System.Windows.Forms.Button();
            this.sourceField = new System.Windows.Forms.ComboBox();
            this.walletField = new System.Windows.Forms.ComboBox();
            this.dateField = new System.Windows.Forms.DateTimePicker();
            this.commentField = new System.Windows.Forms.TextBox();
            this.sumField = new System.Windows.Forms.TextBox();
            this.backToMenuFromExpences = new System.Windows.Forms.Label();
            this.ExpenceImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenceImage)).BeginInit();
            this.SuspendLayout();
            // 
            // cardCheck
            // 
            this.cardCheck.AutoSize = true;
            this.cardCheck.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cardCheck.ForeColor = System.Drawing.Color.Black;
            this.cardCheck.Location = new System.Drawing.Point(327, 233);
            this.cardCheck.Name = "cardCheck";
            this.cardCheck.Size = new System.Drawing.Size(143, 26);
            this.cardCheck.TabIndex = 23;
            this.cardCheck.Text = "Безаличные";
            this.cardCheck.UseVisualStyleBackColor = true;
            this.cardCheck.CheckedChanged += new System.EventHandler(this.cardCheck_CheckedChanged);
            // 
            // cashCheck
            // 
            this.cashCheck.AutoSize = true;
            this.cashCheck.Checked = true;
            this.cashCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cashCheck.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cashCheck.Location = new System.Drawing.Point(145, 233);
            this.cashCheck.Name = "cashCheck";
            this.cashCheck.Size = new System.Drawing.Size(125, 26);
            this.cashCheck.TabIndex = 22;
            this.cashCheck.Text = "Наличные";
            this.cashCheck.UseVisualStyleBackColor = true;
            this.cashCheck.CheckedChanged += new System.EventHandler(this.cashCheck_CheckedChanged);
            // 
            // addExpenceButton
            // 
            this.addExpenceButton.BackColor = System.Drawing.Color.AliceBlue;
            this.addExpenceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addExpenceButton.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.addExpenceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.addExpenceButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addExpenceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addExpenceButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addExpenceButton.ForeColor = System.Drawing.Color.Black;
            this.addExpenceButton.Location = new System.Drawing.Point(124, 592);
            this.addExpenceButton.Name = "addExpenceButton";
            this.addExpenceButton.Size = new System.Drawing.Size(355, 80);
            this.addExpenceButton.TabIndex = 15;
            this.addExpenceButton.Text = "Добавить расход";
            this.addExpenceButton.UseVisualStyleBackColor = false;
            this.addExpenceButton.Click += new System.EventHandler(this.addExpenceButton_Click);
            // 
            // sourceField
            // 
            this.sourceField.Font = new System.Drawing.Font("Century Gothic", 19.8F);
            this.sourceField.ForeColor = System.Drawing.Color.Black;
            this.sourceField.FormattingEnabled = true;
            this.sourceField.Location = new System.Drawing.Point(133, 273);
            this.sourceField.Name = "sourceField";
            this.sourceField.Size = new System.Drawing.Size(337, 48);
            this.sourceField.TabIndex = 17;
            this.sourceField.Text = "Категория";
            this.sourceField.Enter += new System.EventHandler(this.sourceField_Enter);
            this.sourceField.Leave += new System.EventHandler(this.sourceField_Leave);
            // 
            // walletField
            // 
            this.walletField.BackColor = System.Drawing.Color.White;
            this.walletField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.walletField.Font = new System.Drawing.Font("Century Gothic", 19.8F);
            this.walletField.ForeColor = System.Drawing.Color.Black;
            this.walletField.FormattingEnabled = true;
            this.walletField.Items.AddRange(new object[] {
            "Кошелёк"});
            this.walletField.Location = new System.Drawing.Point(133, 169);
            this.walletField.Name = "walletField";
            this.walletField.Size = new System.Drawing.Size(337, 48);
            this.walletField.TabIndex = 16;
            // 
            // dateField
            // 
            this.dateField.Font = new System.Drawing.Font("Century Gothic", 19.8F);
            this.dateField.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateField.Location = new System.Drawing.Point(133, 418);
            this.dateField.MaxDate = new System.DateTime(2055, 5, 18, 0, 0, 0, 0);
            this.dateField.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateField.Name = "dateField";
            this.dateField.Size = new System.Drawing.Size(337, 48);
            this.dateField.TabIndex = 19;
            this.dateField.Value = new System.DateTime(2021, 5, 18, 0, 0, 0, 0);
            // 
            // commentField
            // 
            this.commentField.Font = new System.Drawing.Font("Century Gothic", 19.8F);
            this.commentField.ForeColor = System.Drawing.Color.Black;
            this.commentField.Location = new System.Drawing.Point(133, 492);
            this.commentField.Margin = new System.Windows.Forms.Padding(6);
            this.commentField.Name = "commentField";
            this.commentField.Size = new System.Drawing.Size(337, 48);
            this.commentField.TabIndex = 20;
            this.commentField.Text = "Комментарий";
            this.commentField.Enter += new System.EventHandler(this.commentField_Enter);
            this.commentField.Leave += new System.EventHandler(this.commentField_Leave);
            // 
            // sumField
            // 
            this.sumField.Font = new System.Drawing.Font("Century Gothic", 19.8F);
            this.sumField.ForeColor = System.Drawing.Color.Black;
            this.sumField.Location = new System.Drawing.Point(133, 345);
            this.sumField.Margin = new System.Windows.Forms.Padding(6);
            this.sumField.Name = "sumField";
            this.sumField.Size = new System.Drawing.Size(337, 48);
            this.sumField.TabIndex = 18;
            this.sumField.Text = "Сумма";
            this.sumField.Enter += new System.EventHandler(this.sumField_Enter);
            this.sumField.Leave += new System.EventHandler(this.sumField_Leave);
            // 
            // backToMenuFromExpences
            // 
            this.backToMenuFromExpences.AutoSize = true;
            this.backToMenuFromExpences.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToMenuFromExpences.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backToMenuFromExpences.ForeColor = System.Drawing.SystemColors.GrayText;
            this.backToMenuFromExpences.Location = new System.Drawing.Point(199, 708);
            this.backToMenuFromExpences.Name = "backToMenuFromExpences";
            this.backToMenuFromExpences.Size = new System.Drawing.Size(203, 22);
            this.backToMenuFromExpences.TabIndex = 24;
            this.backToMenuFromExpences.Text = "Вернуться в меню →";
            this.backToMenuFromExpences.Click += new System.EventHandler(this.backToMenuFromExpences_Click);
            this.backToMenuFromExpences.MouseEnter += new System.EventHandler(this.backToMenuFromExpences_MouseEnter);
            this.backToMenuFromExpences.MouseLeave += new System.EventHandler(this.backToMenuFromExpences_MouseLeave);
            // 
            // ExpenceImage
            // 
            this.ExpenceImage.Image = ((System.Drawing.Image)(resources.GetObject("ExpenceImage.Image")));
            this.ExpenceImage.Location = new System.Drawing.Point(133, -19);
            this.ExpenceImage.Name = "ExpenceImage";
            this.ExpenceImage.Size = new System.Drawing.Size(323, 182);
            this.ExpenceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExpenceImage.TabIndex = 21;
            this.ExpenceImage.TabStop = false;
            // 
            // ExpenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 739);
            this.Controls.Add(this.backToMenuFromExpences);
            this.Controls.Add(this.cardCheck);
            this.Controls.Add(this.cashCheck);
            this.Controls.Add(this.ExpenceImage);
            this.Controls.Add(this.addExpenceButton);
            this.Controls.Add(this.sourceField);
            this.Controls.Add(this.walletField);
            this.Controls.Add(this.dateField);
            this.Controls.Add(this.commentField);
            this.Controls.Add(this.sumField);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(632, 786);
            this.MinimumSize = new System.Drawing.Size(632, 786);
            this.Name = "ExpenceForm";
            this.Text = "Добавление расхода";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExpenceForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ExpenceImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cardCheck;
        private System.Windows.Forms.CheckBox cashCheck;
        private System.Windows.Forms.PictureBox ExpenceImage;
        private System.Windows.Forms.Button addExpenceButton;
        private System.Windows.Forms.ComboBox sourceField;
        private System.Windows.Forms.ComboBox walletField;
        private System.Windows.Forms.DateTimePicker dateField;
        private System.Windows.Forms.TextBox commentField;
        private System.Windows.Forms.TextBox sumField;
        private System.Windows.Forms.Label backToMenuFromExpences;
    }
}