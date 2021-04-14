namespace RESTRequestTool
{
    partial class RESTRequestTool
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
            this.txtRequest = new System.Windows.Forms.RichTextBox();
            this.txtResponse = new System.Windows.Forms.RichTextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblRequest = new System.Windows.Forms.Label();
            this.lblResponse = new System.Windows.Forms.Label();
            this.lblWaitTime = new System.Windows.Forms.Label();
            this.txtWaitTime = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRequest
            // 
            this.txtRequest.Location = new System.Drawing.Point(137, 116);
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.Size = new System.Drawing.Size(573, 118);
            this.txtRequest.TabIndex = 0;
            this.txtRequest.Text = "";
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(137, 317);
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(574, 104);
            this.txtResponse.TabIndex = 1;
            this.txtResponse.Text = "";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(53, 29);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(63, 13);
            this.lblUrl.TabIndex = 2;
            this.lblUrl.Text = "Request Url";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "GET",
            "POST"});
            this.cmbType.Location = new System.Drawing.Point(137, 55);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(85, 21);
            this.cmbType.TabIndex = 3;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(137, 29);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(573, 20);
            this.txtUrl.TabIndex = 4;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(53, 58);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(71, 13);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "RequestType";
            // 
            // lblRequest
            // 
            this.lblRequest.AutoSize = true;
            this.lblRequest.Location = new System.Drawing.Point(53, 116);
            this.lblRequest.Name = "lblRequest";
            this.lblRequest.Size = new System.Drawing.Size(72, 13);
            this.lblRequest.TabIndex = 8;
            this.lblRequest.Text = "Request Json";
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Location = new System.Drawing.Point(56, 326);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(80, 13);
            this.lblResponse.TabIndex = 9;
            this.lblResponse.Text = "Response Json";
            // 
            // lblWaitTime
            // 
            this.lblWaitTime.AutoSize = true;
            this.lblWaitTime.Location = new System.Drawing.Point(500, 61);
            this.lblWaitTime.Name = "lblWaitTime";
            this.lblWaitTime.Size = new System.Drawing.Size(88, 13);
            this.lblWaitTime.TabIndex = 10;
            this.lblWaitTime.Text = "Wait time (In min)";
            // 
            // txtWaitTime
            // 
            this.txtWaitTime.Location = new System.Drawing.Point(614, 56);
            this.txtWaitTime.Name = "txtWaitTime";
            this.txtWaitTime.Size = new System.Drawing.Size(97, 20);
            this.txtWaitTime.TabIndex = 11;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(388, 259);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(513, 258);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear Response";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // RESTRequestTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtWaitTime);
            this.Controls.Add(this.lblWaitTime);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.lblRequest);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.txtRequest);
            this.Name = "RESTRequestTool";
            this.Text = "RESTTool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtRequest;
        private System.Windows.Forms.RichTextBox txtResponse;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblRequest;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.Label lblWaitTime;
        private System.Windows.Forms.TextBox txtWaitTime;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
    }
}

