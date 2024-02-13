namespace AutomobileWinApp
{
    partial class frmCarDetails
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
            lbCarID = new System.Windows.Forms.Label();
            lbCarName = new System.Windows.Forms.Label();
            lbManufacturer = new System.Windows.Forms.Label();
            lbPrice = new System.Windows.Forms.Label();
            lbReleasedYear = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            txtCarID = new System.Windows.Forms.TextBox();
            txtCarName = new System.Windows.Forms.TextBox();
            cboManufacturer = new System.Windows.Forms.ComboBox();
            txtPrice = new System.Windows.Forms.MaskedTextBox();
            txtReleaseYear = new System.Windows.Forms.MaskedTextBox();
            SuspendLayout();
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new System.Drawing.Point(44, 49);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new System.Drawing.Size(50, 20);
            lbCarID.TabIndex = 0;
            lbCarID.Text = "Car ID";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new System.Drawing.Point(44, 88);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new System.Drawing.Size(75, 20);
            lbCarName.TabIndex = 1;
            lbCarName.Text = "Car Name";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new System.Drawing.Point(44, 123);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new System.Drawing.Size(97, 20);
            lbManufacturer.TabIndex = 2;
            lbManufacturer.Text = "Manufacturer";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new System.Drawing.Point(44, 157);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new System.Drawing.Size(41, 20);
            lbPrice.TabIndex = 3;
            lbPrice.Text = "Price";
            // 
            // lbReleasedYear
            // 
            lbReleasedYear.AutoSize = true;
            lbReleasedYear.Location = new System.Drawing.Point(44, 193);
            lbReleasedYear.Name = "lbReleasedYear";
            lbReleasedYear.Size = new System.Drawing.Size(101, 20);
            lbReleasedYear.TabIndex = 4;
            lbReleasedYear.Text = "Released Year";
            // 
            // btnSave
            // 
            btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSave.Location = new System.Drawing.Point(152, 241);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(94, 29);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(289, 243);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 29);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtCarID
            // 
            txtCarID.Location = new System.Drawing.Point(152, 47);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new System.Drawing.Size(231, 27);
            txtCarID.TabIndex = 7;
            // 
            // txtCarName
            // 
            txtCarName.Location = new System.Drawing.Point(152, 84);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new System.Drawing.Size(231, 27);
            txtCarName.TabIndex = 8;
            // 
            // cboManufacturer
            // 
            cboManufacturer.FormattingEnabled = true;
            cboManufacturer.Items.AddRange(new object[] { "Audi", "BMW", "Ford", "Honda", "Hyundai", "Kia", "Suzuki", "Toyota" });
            cboManufacturer.Location = new System.Drawing.Point(152, 121);
            cboManufacturer.Name = "cboManufacturer";
            cboManufacturer.Size = new System.Drawing.Size(231, 28);
            cboManufacturer.TabIndex = 9;
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(152, 157);
            txtPrice.Mask = "000000000";
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(231, 27);
            txtPrice.TabIndex = 10;
            txtPrice.Text = "0";
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new System.Drawing.Point(152, 193);
            txtReleaseYear.Mask = "0000";
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new System.Drawing.Size(231, 27);
            txtReleaseYear.TabIndex = 11;
            txtReleaseYear.Text = "0";
            // 
            // frmCarDetails
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(442, 314);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(cboManufacturer);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lbReleasedYear);
            Controls.Add(lbPrice);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Name = "frmCarDetails";
            Text = "frmCarDetails";
            Load += frmCarDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbCarID;
        private System.Windows.Forms.Label lbCarName;
        private System.Windows.Forms.Label lbManufacturer;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbReleasedYear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.ComboBox cboManufacturer;
        private System.Windows.Forms.MaskedTextBox txtPrice;
        private System.Windows.Forms.MaskedTextBox txtReleaseYear;
    }
}