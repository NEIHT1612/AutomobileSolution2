namespace AutomobileWinApp
{
    partial class frmCarManagement
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
            lbReleaseYear = new System.Windows.Forms.Label();
            dgvCarList = new System.Windows.Forms.DataGridView();
            btnLoad = new System.Windows.Forms.Button();
            btnNew = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            txtCarID = new System.Windows.Forms.TextBox();
            txtCarName = new System.Windows.Forms.TextBox();
            txtManufacturer = new System.Windows.Forms.TextBox();
            txtPrice = new System.Windows.Forms.TextBox();
            txtReleaseYear = new System.Windows.Forms.TextBox();
            btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new System.Drawing.Point(12, 9);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new System.Drawing.Size(50, 20);
            lbCarID.TabIndex = 0;
            lbCarID.Text = "Car ID";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new System.Drawing.Point(12, 47);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new System.Drawing.Size(75, 20);
            lbCarName.TabIndex = 1;
            lbCarName.Text = "Car Name";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new System.Drawing.Point(12, 87);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new System.Drawing.Size(97, 20);
            lbManufacturer.TabIndex = 2;
            lbManufacturer.Text = "Manufacturer";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new System.Drawing.Point(257, 13);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new System.Drawing.Size(41, 20);
            lbPrice.TabIndex = 3;
            lbPrice.Text = "Price";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new System.Drawing.Point(257, 47);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new System.Drawing.Size(101, 20);
            lbReleaseYear.TabIndex = 4;
            lbReleaseYear.Text = "Released Year";
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new System.Drawing.Point(12, 152);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.RowHeadersWidth = 51;
            dgvCarList.RowTemplate.Height = 29;
            dgvCarList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new System.Drawing.Size(490, 108);
            dgvCarList.TabIndex = 5;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(74, 117);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(94, 29);
            btnLoad.TabIndex = 6;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(218, 117);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(94, 29);
            btnNew.TabIndex = 7;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(352, 117);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(94, 29);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtCarID
            // 
            txtCarID.Location = new System.Drawing.Point(115, 6);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new System.Drawing.Size(125, 27);
            txtCarID.TabIndex = 9;
            // 
            // txtCarName
            // 
            txtCarName.Location = new System.Drawing.Point(115, 44);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new System.Drawing.Size(125, 27);
            txtCarName.TabIndex = 10;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new System.Drawing.Point(115, 84);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new System.Drawing.Size(125, 27);
            txtManufacturer.TabIndex = 11;
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(364, 6);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(125, 27);
            txtPrice.TabIndex = 12;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new System.Drawing.Point(364, 44);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new System.Drawing.Size(125, 27);
            txtReleaseYear.TabIndex = 13;
            // 
            // btnClose
            // 
            btnClose.Location = new System.Drawing.Point(218, 266);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(94, 29);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(514, 296);
            Controls.Add(btnClose);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(txtManufacturer);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(dgvCarList);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Name = "frmCarManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Car Management";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbCarID;
        private System.Windows.Forms.Label lbCarName;
        private System.Windows.Forms.Label lbManufacturer;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbReleaseYear;
        private System.Windows.Forms.DataGridView dgvCarList;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtReleaseYear;
        private System.Windows.Forms.Button btnClose;
    }
}