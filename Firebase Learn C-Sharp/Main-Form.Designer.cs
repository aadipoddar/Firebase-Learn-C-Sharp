namespace Firebase_Learn_C_Sharp
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
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.insertButton = new System.Windows.Forms.Button();
            this.retrieveButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.deleteAllButton = new System.Windows.Forms.Button();
            this.getCounetrDataButton = new System.Windows.Forms.Button();
            this.exportToDataGridViewButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.insertPictureButton = new System.Windows.Forms.Button();
            this.retrievePictureButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(331, 64);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(229, 23);
            this.idTextBox.TabIndex = 0;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(331, 120);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(229, 23);
            this.nameTextBox.TabIndex = 1;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(331, 176);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(229, 23);
            this.addressTextBox.TabIndex = 2;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(331, 232);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(229, 23);
            this.ageTextBox.TabIndex = 3;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(57, 67);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 15);
            this.idLabel.TabIndex = 4;
            this.idLabel.Text = "ID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(57, 123);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 15);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(57, 179);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(49, 15);
            this.addressLabel.TabIndex = 6;
            this.addressLabel.Text = "Address";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(57, 235);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(28, 15);
            this.ageLabel.TabIndex = 7;
            this.ageLabel.Text = "Age";
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(14, 294);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 23);
            this.insertButton.TabIndex = 8;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // retrieveButton
            // 
            this.retrieveButton.Location = new System.Drawing.Point(148, 294);
            this.retrieveButton.Name = "retrieveButton";
            this.retrieveButton.Size = new System.Drawing.Size(75, 23);
            this.retrieveButton.TabIndex = 9;
            this.retrieveButton.Text = "Retrieve";
            this.retrieveButton.UseVisualStyleBackColor = true;
            this.retrieveButton.Click += new System.EventHandler(this.retrieveButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(282, 294);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(416, 294);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // deleteAllButton
            // 
            this.deleteAllButton.Location = new System.Drawing.Point(550, 293);
            this.deleteAllButton.Name = "deleteAllButton";
            this.deleteAllButton.Size = new System.Drawing.Size(84, 25);
            this.deleteAllButton.TabIndex = 12;
            this.deleteAllButton.Text = "Delete All";
            this.deleteAllButton.UseVisualStyleBackColor = true;
            this.deleteAllButton.Click += new System.EventHandler(this.deleteAllButton_Click);
            // 
            // getCounetrDataButton
            // 
            this.getCounetrDataButton.Location = new System.Drawing.Point(14, 363);
            this.getCounetrDataButton.Name = "getCounetrDataButton";
            this.getCounetrDataButton.Size = new System.Drawing.Size(136, 29);
            this.getCounetrDataButton.TabIndex = 13;
            this.getCounetrDataButton.Text = "Get Counter Data";
            this.getCounetrDataButton.UseVisualStyleBackColor = true;
            this.getCounetrDataButton.Click += new System.EventHandler(this.getCounetrDataButton_Click);
            // 
            // exportToDataGridViewButton
            // 
            this.exportToDataGridViewButton.Location = new System.Drawing.Point(214, 366);
            this.exportToDataGridViewButton.Name = "exportToDataGridViewButton";
            this.exportToDataGridViewButton.Size = new System.Drawing.Size(172, 26);
            this.exportToDataGridViewButton.TabIndex = 14;
            this.exportToDataGridViewButton.Text = "Export to Data Grid View";
            this.exportToDataGridViewButton.UseVisualStyleBackColor = true;
            this.exportToDataGridViewButton.Click += new System.EventHandler(this.exportToDataGridViewButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(712, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(478, 328);
            this.dataGridView1.TabIndex = 15;
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(712, 436);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(478, 301);
            this.imageBox.TabIndex = 16;
            this.imageBox.TabStop = false;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(266, 527);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 17;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // insertPictureButton
            // 
            this.insertPictureButton.Location = new System.Drawing.Point(394, 527);
            this.insertPictureButton.Name = "insertPictureButton";
            this.insertPictureButton.Size = new System.Drawing.Size(110, 23);
            this.insertPictureButton.TabIndex = 18;
            this.insertPictureButton.Text = "Insert Picture";
            this.insertPictureButton.UseVisualStyleBackColor = true;
            this.insertPictureButton.Click += new System.EventHandler(this.insertPictureButton_Click);
            // 
            // retrievePictureButton
            // 
            this.retrievePictureButton.Location = new System.Drawing.Point(557, 527);
            this.retrievePictureButton.Name = "retrievePictureButton";
            this.retrievePictureButton.Size = new System.Drawing.Size(75, 23);
            this.retrievePictureButton.TabIndex = 19;
            this.retrievePictureButton.Text = "Retrieve Picture";
            this.retrievePictureButton.UseVisualStyleBackColor = true;
            this.retrievePictureButton.Click += new System.EventHandler(this.retrievePictureButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 749);
            this.Controls.Add(this.retrievePictureButton);
            this.Controls.Add(this.insertPictureButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exportToDataGridViewButton);
            this.Controls.Add(this.getCounetrDataButton);
            this.Controls.Add(this.deleteAllButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.retrieveButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox idTextBox;
        private TextBox nameTextBox;
        private TextBox addressTextBox;
        private TextBox ageTextBox;
        private Label idLabel;
        private Label nameLabel;
        private Label addressLabel;
        private Label ageLabel;
        private Button insertButton;
        private Button retrieveButton;
        private Button updateButton;
        private Button deleteButton;
        private Button deleteAllButton;
        private Button getCounetrDataButton;
        private Button exportToDataGridViewButton;
        private DataGridView dataGridView1;
        private PictureBox imageBox;
        private Button browseButton;
        private Button insertPictureButton;
        private Button retrievePictureButton;
    }
}