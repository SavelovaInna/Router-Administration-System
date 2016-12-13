namespace lab3
{
    partial class FormRoutingRecord
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
            this.textBoxDest = new lab3.TextBoxValidating();
            this.textBoxMask = new lab3.TextBoxValidating();
            this.textBoxGateway = new lab3.TextBoxValidating();
            this.textBoxMetric = new lab3.TextBoxValidating();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonОк = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDest
            // 
            this.textBoxDest.Location = new System.Drawing.Point(150, 34);
            this.textBoxDest.Name = "textBoxDest";
            this.textBoxDest.Size = new System.Drawing.Size(135, 22);
            this.textBoxDest.TabIndex = 0;
            // 
            // textBoxMask
            // 
            this.textBoxMask.Location = new System.Drawing.Point(150, 75);
            this.textBoxMask.Name = "textBoxMask";
            this.textBoxMask.Size = new System.Drawing.Size(135, 22);
            this.textBoxMask.TabIndex = 1;
            // 
            // textBoxGateway
            // 
            this.textBoxGateway.Location = new System.Drawing.Point(150, 127);
            this.textBoxGateway.Name = "textBoxGateway";
            this.textBoxGateway.Size = new System.Drawing.Size(135, 22);
            this.textBoxGateway.TabIndex = 2;
            // 
            // textBoxMetric
            // 
            this.textBoxMetric.Location = new System.Drawing.Point(150, 175);
            this.textBoxMetric.Name = "textBoxMetric";
            this.textBoxMetric.Size = new System.Drawing.Size(135, 22);
            this.textBoxMetric.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Адрес назначения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Маска";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Шлюз";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Метрика";
            // 
            // buttonОк
            // 
            this.buttonОк.Location = new System.Drawing.Point(16, 229);
            this.buttonОк.Name = "buttonОк";
            this.buttonОк.Size = new System.Drawing.Size(83, 32);
            this.buttonОк.TabIndex = 8;
            this.buttonОк.Text = "ОК";
            this.buttonОк.UseVisualStyleBackColor = true;
            this.buttonОк.Click += new System.EventHandler(this.buttonОк_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(172, 229);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(83, 32);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormRoutingRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 284);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonОк);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMetric);
            this.Controls.Add(this.textBoxGateway);
            this.Controls.Add(this.textBoxMask);
            this.Controls.Add(this.textBoxDest);
            this.Name = "FormRoutingRecord";
            this.Text = "FormRoutingRecord";
            this.Load += new System.EventHandler(this.FormRoutingRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBoxValidating textBoxDest;
        private TextBoxValidating textBoxMask;
        private TextBoxValidating textBoxGateway;
        private TextBoxValidating textBoxMetric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonОк;
        private System.Windows.Forms.Button buttonCancel;
    }
}