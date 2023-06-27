namespace POS.UI
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
            grpCustomer = new GroupBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnView = new Button();
            btnSave = new Button();
            txtAmount = new TextBox();
            lblAmount = new Label();
            txtMail = new TextBox();
            txtSeats = new TextBox();
            txtMoviename = new TextBox();
            txtNumber = new TextBox();
            txtName = new TextBox();
            lblMail = new Label();
            lblMobileNumber = new Label();
            lblMovieName = new Label();
            lblSeats = new Label();
            lblName = new Label();
            gvDetails = new DataGridView();
            grpCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvDetails).BeginInit();
            SuspendLayout();
            // 
            // grpCustomer
            // 
            grpCustomer.BackColor = Color.PaleVioletRed;
            grpCustomer.Controls.Add(btnDelete);
            grpCustomer.Controls.Add(btnUpdate);
            grpCustomer.Controls.Add(btnView);
            grpCustomer.Controls.Add(btnSave);
            grpCustomer.Controls.Add(txtAmount);
            grpCustomer.Controls.Add(lblAmount);
            grpCustomer.Controls.Add(txtMail);
            grpCustomer.Controls.Add(txtSeats);
            grpCustomer.Controls.Add(txtMoviename);
            grpCustomer.Controls.Add(txtNumber);
            grpCustomer.Controls.Add(txtName);
            grpCustomer.Controls.Add(lblMail);
            grpCustomer.Controls.Add(lblMobileNumber);
            grpCustomer.Controls.Add(lblMovieName);
            grpCustomer.Controls.Add(lblSeats);
            grpCustomer.Controls.Add(lblName);
            grpCustomer.Location = new Point(62, 47);
            grpCustomer.Name = "grpCustomer";
            grpCustomer.Size = new Size(632, 412);
            grpCustomer.TabIndex = 0;
            grpCustomer.TabStop = false;
            grpCustomer.Text = "Customer Information";
            grpCustomer.Enter += groupBox1_Enter;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(319, 342);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(109, 29);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(192, 342);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(109, 29);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += button2_Click_1;
            // 
            // btnView
            // 
            btnView.Location = new Point(68, 342);
            btnView.Name = "btnView";
            btnView.Size = new Size(109, 29);
            btnView.TabIndex = 13;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += button2_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(444, 342);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(109, 29);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += button1_Click;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(204, 279);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(349, 27);
            txtAmount.TabIndex = 11;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(63, 286);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(62, 20);
            lblAmount.TabIndex = 10;
            lblAmount.Text = "Amount";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(204, 92);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(349, 27);
            txtMail.TabIndex = 9;
            // 
            // txtSeats
            // 
            txtSeats.Location = new Point(204, 236);
            txtSeats.Name = "txtSeats";
            txtSeats.Size = new Size(349, 27);
            txtSeats.TabIndex = 8;
            // 
            // txtMoviename
            // 
            txtMoviename.Location = new Point(204, 190);
            txtMoviename.Name = "txtMoviename";
            txtMoviename.Size = new Size(349, 27);
            txtMoviename.TabIndex = 7;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(204, 140);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(349, 27);
            txtNumber.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(204, 48);
            txtName.Name = "txtName";
            txtName.Size = new Size(349, 27);
            txtName.TabIndex = 5;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(63, 94);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(46, 20);
            lblMail.TabIndex = 4;
            lblMail.Text = "Email";
            // 
            // lblMobileNumber
            // 
            lblMobileNumber.AutoSize = true;
            lblMobileNumber.Location = new Point(63, 142);
            lblMobileNumber.Name = "lblMobileNumber";
            lblMobileNumber.Size = new Size(114, 20);
            lblMobileNumber.TabIndex = 3;
            lblMobileNumber.Text = "Mobile Number";
            lblMobileNumber.Click += label4_Click;
            // 
            // lblMovieName
            // 
            lblMovieName.AutoSize = true;
            lblMovieName.Location = new Point(63, 192);
            lblMovieName.Name = "lblMovieName";
            lblMovieName.Size = new Size(94, 20);
            lblMovieName.TabIndex = 2;
            lblMovieName.Text = "Movie Name";
            // 
            // lblSeats
            // 
            lblSeats.AutoSize = true;
            lblSeats.Location = new Point(63, 241);
            lblSeats.Name = "lblSeats";
            lblSeats.Size = new Size(84, 20);
            lblSeats.TabIndex = 1;
            lblSeats.Text = "No of seats";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(63, 48);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            lblName.Click += label1_Click;
            // 
            // gvDetails
            // 
            gvDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvDetails.Location = new Point(791, 47);
            gvDetails.Name = "gvDetails";
            gvDetails.RowHeadersWidth = 51;
            gvDetails.RowTemplate.Height = 29;
            gvDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvDetails.Size = new Size(611, 412);
            gvDetails.TabIndex = 1;
            gvDetails.CellContentClick += gridViewDetails_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1470, 527);
            Controls.Add(gvDetails);
            Controls.Add(grpCustomer);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpCustomer.ResumeLayout(false);
            grpCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gvDetails).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpCustomer;
        private Label lblSeats;
        private Label lblName;
        private Label lblMail;
        private Label lblMobileNumber;
        private Label lblMovieName;
        private TextBox txtMail;
        private TextBox txtSeats;
        private TextBox txtMoviename;
        private TextBox txtNumber;
        private TextBox txtName;
        private Button btnSave;
        private TextBox txtAmount;
        private Label lblAmount;
        private DataGridView gvDetails;
        private Button btnView;
        private Button btnDelete;
        private Button btnUpdate;
    }
}