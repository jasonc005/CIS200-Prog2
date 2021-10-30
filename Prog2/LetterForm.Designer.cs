
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDestinationAddress = new System.Windows.Forms.ComboBox();
            this.cbOriginAddress = new System.Windows.Forms.ComboBox();
            this.tbFixedCost = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Origin Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Destination Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fixed Cost";
            // 
            // cbDestinationAddress
            // 
            this.cbDestinationAddress.FormattingEnabled = true;
            this.cbDestinationAddress.Location = new System.Drawing.Point(120, 37);
            this.cbDestinationAddress.Name = "cbDestinationAddress";
            this.cbDestinationAddress.Size = new System.Drawing.Size(206, 21);
            this.cbDestinationAddress.TabIndex = 1;
            this.cbDestinationAddress.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_Validating);
            this.cbDestinationAddress.Validated += new System.EventHandler(this.control_Validated);
            // 
            // cbOriginAddress
            // 
            this.cbOriginAddress.FormattingEnabled = true;
            this.cbOriginAddress.Location = new System.Drawing.Point(120, 10);
            this.cbOriginAddress.Name = "cbOriginAddress";
            this.cbOriginAddress.Size = new System.Drawing.Size(206, 21);
            this.cbOriginAddress.TabIndex = 0;
            this.cbOriginAddress.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_Validating);
            this.cbOriginAddress.Validated += new System.EventHandler(this.control_Validated);
            // 
            // tbFixedCost
            // 
            this.tbFixedCost.Location = new System.Drawing.Point(120, 65);
            this.tbFixedCost.Name = "tbFixedCost";
            this.tbFixedCost.Size = new System.Drawing.Size(206, 20);
            this.tbFixedCost.TabIndex = 2;
            this.tbFixedCost.Validating += new System.ComponentModel.CancelEventHandler(this.tbFixedCost_Validating);
            this.tbFixedCost.Validated += new System.EventHandler(this.control_Validated);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(89, 91);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(179, 91);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCancel_MouseDown);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LetterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 124);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbFixedCost);
            this.Controls.Add(this.cbOriginAddress);
            this.Controls.Add(this.cbDestinationAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LetterForm";
            this.Text = "Add Letter";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDestinationAddress;
        private System.Windows.Forms.ComboBox cbOriginAddress;
        private System.Windows.Forms.TextBox tbFixedCost;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}