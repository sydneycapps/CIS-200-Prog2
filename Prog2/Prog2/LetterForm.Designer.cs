namespace UPVApp
{
    partial class LetterForm
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
            this.origAddressLabel = new System.Windows.Forms.Label();
            this.destAddressLabel = new System.Windows.Forms.Label();
            this.fixedCostLabel = new System.Windows.Forms.Label();
            this.destAddressBox = new System.Windows.Forms.ComboBox();
            this.originAddressBox = new System.Windows.Forms.ComboBox();
            this.fixedCostBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // origAddressLabel
            // 
            this.origAddressLabel.AutoSize = true;
            this.origAddressLabel.Location = new System.Drawing.Point(79, 42);
            this.origAddressLabel.Name = "origAddressLabel";
            this.origAddressLabel.Size = new System.Drawing.Size(78, 13);
            this.origAddressLabel.TabIndex = 0;
            this.origAddressLabel.Text = "Origin Address:";
            // 
            // destAddressLabel
            // 
            this.destAddressLabel.AutoSize = true;
            this.destAddressLabel.Location = new System.Drawing.Point(53, 69);
            this.destAddressLabel.Name = "destAddressLabel";
            this.destAddressLabel.Size = new System.Drawing.Size(104, 13);
            this.destAddressLabel.TabIndex = 1;
            this.destAddressLabel.Text = "Destination Address:";
            // 
            // fixedCostLabel
            // 
            this.fixedCostLabel.AutoSize = true;
            this.fixedCostLabel.Location = new System.Drawing.Point(98, 96);
            this.fixedCostLabel.Name = "fixedCostLabel";
            this.fixedCostLabel.Size = new System.Drawing.Size(59, 13);
            this.fixedCostLabel.TabIndex = 2;
            this.fixedCostLabel.Text = "Fixed Cost:";
            // 
            // destAddressBox
            // 
            this.destAddressBox.DisplayMember = "Name";
            this.destAddressBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destAddressBox.FormattingEnabled = true;
            this.destAddressBox.Location = new System.Drawing.Point(163, 66);
            this.destAddressBox.Name = "destAddressBox";
            this.destAddressBox.Size = new System.Drawing.Size(121, 21);
            this.destAddressBox.TabIndex = 4;
            this.destAddressBox.Validating += new System.ComponentModel.CancelEventHandler(this.destAddressBox_Validating);
            this.destAddressBox.Validated += new System.EventHandler(this.destAddressBox_Validated);
            // 
            // originAddressBox
            // 
            this.originAddressBox.DisplayMember = "Name";
            this.originAddressBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.originAddressBox.FormattingEnabled = true;
            this.originAddressBox.Location = new System.Drawing.Point(163, 39);
            this.originAddressBox.Name = "originAddressBox";
            this.originAddressBox.Size = new System.Drawing.Size(121, 21);
            this.originAddressBox.TabIndex = 3;
            this.originAddressBox.Validating += new System.ComponentModel.CancelEventHandler(this.originAddressBox_Validating);
            this.originAddressBox.Validated += new System.EventHandler(this.originAddressBox_Validated);
            // 
            // fixedCostBox
            // 
            this.fixedCostBox.Location = new System.Drawing.Point(163, 93);
            this.fixedCostBox.Name = "fixedCostBox";
            this.fixedCostBox.Size = new System.Drawing.Size(121, 20);
            this.fixedCostBox.TabIndex = 5;
            this.fixedCostBox.Validating += new System.ComponentModel.CancelEventHandler(this.fixedCostBox_Validating);
            this.fixedCostBox.Validated += new System.EventHandler(this.fixedCostBox_Validated);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(56, 136);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(209, 136);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelButton_MouseDown);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LetterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 188);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.fixedCostBox);
            this.Controls.Add(this.originAddressBox);
            this.Controls.Add(this.destAddressBox);
            this.Controls.Add(this.fixedCostLabel);
            this.Controls.Add(this.destAddressLabel);
            this.Controls.Add(this.origAddressLabel);
            this.Name = "LetterForm";
            this.Text = "Letter";
            this.Load += new System.EventHandler(this.LetterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label origAddressLabel;
        private System.Windows.Forms.Label destAddressLabel;
        private System.Windows.Forms.Label fixedCostLabel;
        private System.Windows.Forms.ComboBox destAddressBox;
        private System.Windows.Forms.ComboBox originAddressBox;
        private System.Windows.Forms.TextBox fixedCostBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}