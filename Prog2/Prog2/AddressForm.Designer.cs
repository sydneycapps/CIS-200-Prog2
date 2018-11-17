namespace UPVApp
{
    partial class AddressForm
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
            this.components = new System.ComponentModel.Container();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressBox2 = new System.Windows.Forms.TextBox();
            this.addressBox1 = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.stateBox = new System.Windows.Forms.ComboBox();
            this.zipBox = new System.Windows.Forms.TextBox();
            this.okayButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(105, 30);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(121, 20);
            this.nameBox.TabIndex = 5;
            this.nameBox.Validating += new System.ComponentModel.CancelEventHandler(this.nameBox_Validating);
            this.nameBox.Validated += new System.EventHandler(this.nameBox_Validated);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(51, 33);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(51, 56);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(48, 13);
            this.addressLabel.TabIndex = 1;
            this.addressLabel.Text = "Address:";
            // 
            // addressBox2
            // 
            this.addressBox2.Location = new System.Drawing.Point(105, 82);
            this.addressBox2.Name = "addressBox2";
            this.addressBox2.Size = new System.Drawing.Size(121, 20);
            this.addressBox2.TabIndex = 7;
            // 
            // addressBox1
            // 
            this.addressBox1.Location = new System.Drawing.Point(105, 56);
            this.addressBox1.Name = "addressBox1";
            this.addressBox1.Size = new System.Drawing.Size(121, 20);
            this.addressBox1.TabIndex = 6;
            this.addressBox1.Validating += new System.ComponentModel.CancelEventHandler(this.addressBox1_Validating);
            this.addressBox1.Validated += new System.EventHandler(this.addressBox1_Validated);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(51, 114);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 2;
            this.cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(51, 140);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(35, 13);
            this.stateLabel.TabIndex = 3;
            this.stateLabel.Text = "State:";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(51, 167);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(25, 13);
            this.zipLabel.TabIndex = 4;
            this.zipLabel.Text = "Zip:";
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(105, 111);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(121, 20);
            this.cityBox.TabIndex = 8;
            this.cityBox.Validating += new System.ComponentModel.CancelEventHandler(this.cityBox_Validating);
            this.cityBox.Validated += new System.EventHandler(this.cityBox_Validated);
            // 
            // stateBox
            // 
            this.stateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateBox.FormattingEnabled = true;
            this.stateBox.Location = new System.Drawing.Point(105, 137);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(121, 21);
            this.stateBox.TabIndex = 9;
            this.stateBox.Validating += new System.ComponentModel.CancelEventHandler(this.stateBox_Validating);
            this.stateBox.Validated += new System.EventHandler(this.stateBox_Validated);
            // 
            // zipBox
            // 
            this.zipBox.Location = new System.Drawing.Point(105, 164);
            this.zipBox.Name = "zipBox";
            this.zipBox.Size = new System.Drawing.Size(121, 20);
            this.zipBox.TabIndex = 10;
            this.zipBox.Validating += new System.ComponentModel.CancelEventHandler(this.zipBox_Validating);
            this.zipBox.Validated += new System.EventHandler(this.zipBox_Validated);
            // 
            // okayButton
            // 
            this.okayButton.Location = new System.Drawing.Point(54, 221);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(75, 23);
            this.okayButton.TabIndex = 11;
            this.okayButton.Text = "OK";
            this.okayButton.UseVisualStyleBackColor = true;
            this.okayButton.Click += new System.EventHandler(this.okayButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(151, 221);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelButton_MouseDown);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 272);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okayButton);
            this.Controls.Add(this.zipBox);
            this.Controls.Add(this.stateBox);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.addressBox1);
            this.Controls.Add(this.addressBox2);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameBox);
            this.Name = "AddressForm";
            this.Text = "Address";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressBox2;
        private System.Windows.Forms.TextBox addressBox1;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.ComboBox stateBox;
        private System.Windows.Forms.TextBox zipBox;
        private System.Windows.Forms.Button okayButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}