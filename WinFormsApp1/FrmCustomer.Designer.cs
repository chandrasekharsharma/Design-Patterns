namespace WinFormsCustomer
{
    partial class FrmCustomer
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
            ddlCustomerType = new ComboBox();
            lblCustomerType = new Label();
            lblBillAmount = new Label();
            lblCustomerName = new Label();
            lblBillDate = new Label();
            lblPhoneNumber = new Label();
            lblAddress = new Label();
            txtBillAmount = new TextBox();
            txtCustomerName = new TextBox();
            txtBillDate = new TextBox();
            txtPhoneNumber = new TextBox();
            txtAddress = new TextBox();
            ddlDAL = new ComboBox();
            dataGridView1 = new DataGridView();
            btnValidate = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ddlCustomerType
            // 
            ddlCustomerType.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlCustomerType.FormattingEnabled = true;
            ddlCustomerType.Items.AddRange(new object[] { "Lead", "Customer" });
            ddlCustomerType.Location = new Point(210, 14);
            ddlCustomerType.Margin = new Padding(4);
            ddlCustomerType.Name = "ddlCustomerType";
            ddlCustomerType.Size = new Size(292, 38);
            ddlCustomerType.TabIndex = 0;
            ddlCustomerType.SelectedIndexChanged += ddlCustomerType_SelectedIndexChanged;
            // 
            // lblCustomerType
            // 
            lblCustomerType.AutoSize = true;
            lblCustomerType.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomerType.Location = new Point(31, 18);
            lblCustomerType.Margin = new Padding(4, 0, 4, 0);
            lblCustomerType.Name = "lblCustomerType";
            lblCustomerType.Size = new Size(160, 30);
            lblCustomerType.TabIndex = 1;
            lblCustomerType.Text = "Customer Type";
            // 
            // lblBillAmount
            // 
            lblBillAmount.AutoSize = true;
            lblBillAmount.Font = new Font("Segoe UI", 11F);
            lblBillAmount.Location = new Point(522, 14);
            lblBillAmount.Margin = new Padding(4, 0, 4, 0);
            lblBillAmount.Name = "lblBillAmount";
            lblBillAmount.Size = new Size(124, 30);
            lblBillAmount.TabIndex = 2;
            lblBillAmount.Text = "Bill Amount";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI", 11F);
            lblCustomerName.Location = new Point(32, 80);
            lblCustomerName.Margin = new Padding(4, 0, 4, 0);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(171, 30);
            lblCustomerName.TabIndex = 3;
            lblCustomerName.Text = "Customer Name";
            // 
            // lblBillDate
            // 
            lblBillDate.AutoSize = true;
            lblBillDate.Font = new Font("Segoe UI", 11F);
            lblBillDate.Location = new Point(522, 80);
            lblBillDate.Margin = new Padding(4, 0, 4, 0);
            lblBillDate.Name = "lblBillDate";
            lblBillDate.Size = new Size(92, 30);
            lblBillDate.TabIndex = 4;
            lblBillDate.Text = "Bill Date";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 11F);
            lblPhoneNumber.Location = new Point(32, 134);
            lblPhoneNumber.Margin = new Padding(4, 0, 4, 0);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(160, 30);
            lblPhoneNumber.TabIndex = 5;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 11F);
            lblAddress.Location = new Point(534, 142);
            lblAddress.Margin = new Padding(4, 0, 4, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(91, 30);
            lblAddress.TabIndex = 6;
            lblAddress.Text = "Address";
            // 
            // txtBillAmount
            // 
            txtBillAmount.Location = new Point(688, 18);
            txtBillAmount.Margin = new Padding(4);
            txtBillAmount.Name = "txtBillAmount";
            txtBillAmount.Size = new Size(368, 37);
            txtBillAmount.TabIndex = 7;
            txtBillAmount.Text = "0";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(210, 80);
            txtCustomerName.Margin = new Padding(4);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(282, 37);
            txtCustomerName.TabIndex = 8;
            // 
            // txtBillDate
            // 
            txtBillDate.Location = new Point(688, 80);
            txtBillDate.Margin = new Padding(4);
            txtBillDate.Name = "txtBillDate";
            txtBillDate.Size = new Size(368, 37);
            txtBillDate.TabIndex = 9;
            txtBillDate.Text = "1/1/2020";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(210, 134);
            txtPhoneNumber.Margin = new Padding(4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(282, 37);
            txtPhoneNumber.TabIndex = 10;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(688, 142);
            txtAddress.Margin = new Padding(4);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(368, 149);
            txtAddress.TabIndex = 11;
            // 
            // ddlDAL
            // 
            ddlDAL.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlDAL.FormattingEnabled = true;
            ddlDAL.Items.AddRange(new object[] { "Lead", "Customer" });
            ddlDAL.Location = new Point(1082, 18);
            ddlDAL.Margin = new Padding(4);
            ddlDAL.Name = "ddlDAL";
            ddlDAL.Size = new Size(323, 38);
            ddlDAL.TabIndex = 12;
            ddlDAL.SelectedIndexChanged += ddlDAL_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 421);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1375, 270);
            dataGridView1.TabIndex = 13;
            // 
            // btnValidate
            // 
            btnValidate.Font = new Font("Segoe UI", 11F);
            btnValidate.Location = new Point(32, 335);
            btnValidate.Margin = new Padding(4);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(156, 41);
            btnValidate.TabIndex = 14;
            btnValidate.Text = "Validate";
            btnValidate.UseVisualStyleBackColor = true;
            btnValidate.Click += btnValidate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 11F);
            btnAdd.Location = new Point(210, 335);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(134, 41);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1603, 761);
            Controls.Add(btnAdd);
            Controls.Add(btnValidate);
            Controls.Add(dataGridView1);
            Controls.Add(ddlDAL);
            Controls.Add(txtAddress);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtBillDate);
            Controls.Add(txtCustomerName);
            Controls.Add(txtBillAmount);
            Controls.Add(lblAddress);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblBillDate);
            Controls.Add(lblCustomerName);
            Controls.Add(lblBillAmount);
            Controls.Add(lblCustomerType);
            Controls.Add(ddlCustomerType);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ddlCustomerType;
        private Label lblCustomerType;
        private Label lblBillAmount;
        private Label lblCustomerName;
        private Label lblBillDate;
        private Label lblPhoneNumber;
        private Label lblAddress;
        private TextBox txtBillAmount;
        private TextBox txtCustomerName;
        private TextBox txtBillDate;
        private TextBox txtPhoneNumber;
        private TextBox txtAddress;
        private ComboBox ddlDAL;
        private DataGridView dataGridView1;
        private Button btnValidate;
        private Button btnAdd;
    }
}
