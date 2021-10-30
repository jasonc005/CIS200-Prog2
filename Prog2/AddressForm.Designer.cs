
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAddress1 = new System.Windows.Forms.TextBox();
            this.tbAddress2 = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.tbZip = new System.Windows.Forms.TextBox();
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
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "State";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Zip";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(74, 10);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(220, 20);
            this.tbName.TabIndex = 6;
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.stringField_Validating);
            this.tbName.Validated += new System.EventHandler(this.control_Validated);
            // 
            // tbAddress1
            // 
            this.tbAddress1.Location = new System.Drawing.Point(74, 31);
            this.tbAddress1.Name = "tbAddress1";
            this.tbAddress1.Size = new System.Drawing.Size(220, 20);
            this.tbAddress1.TabIndex = 7;
            this.tbAddress1.Validating += new System.ComponentModel.CancelEventHandler(this.stringField_Validating);
            this.tbAddress1.Validated += new System.EventHandler(this.control_Validated);
            // 
            // tbAddress2
            // 
            this.tbAddress2.Location = new System.Drawing.Point(74, 53);
            this.tbAddress2.Name = "tbAddress2";
            this.tbAddress2.Size = new System.Drawing.Size(220, 20);
            this.tbAddress2.TabIndex = 8;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(74, 75);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(220, 20);
            this.tbCity.TabIndex = 9;
            this.tbCity.Validating += new System.ComponentModel.CancelEventHandler(this.stringField_Validating);
            this.tbCity.Validated += new System.EventHandler(this.control_Validated);
            // 
            // cbState
            // 
            this.cbState.FormattingEnabled = true;
            this.cbState.Location = new System.Drawing.Point(74, 97);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(220, 21);
            this.cbState.TabIndex = 10;
            this.cbState.Validating += new System.ComponentModel.CancelEventHandler(this.cbState_Validating);
            this.cbState.Validated += new System.EventHandler(this.control_Validated);
            // 
            // tbZip
            // 
            this.tbZip.Location = new System.Drawing.Point(74, 120);
            this.tbZip.Name = "tbZip";
            this.tbZip.Size = new System.Drawing.Size(220, 20);
            this.tbZip.TabIndex = 11;
            this.tbZip.Validating += new System.ComponentModel.CancelEventHandler(this.tbZip_Validating);
            this.tbZip.Validated += new System.EventHandler(this.control_Validated);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(74, 156);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(165, 156);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCancel_MouseDown);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 191);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbZip);
            this.Controls.Add(this.cbState);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbAddress2);
            this.Controls.Add(this.tbAddress1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddressForm";
            this.Text = "Add Address";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAddress1;
        private System.Windows.Forms.TextBox tbAddress2;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.TextBox tbZip;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}