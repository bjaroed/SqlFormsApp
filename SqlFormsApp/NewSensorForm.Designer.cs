namespace SqlFormsApp
{
    partial class NewSensorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewSensorForm));
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxUnit = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelUnit = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxEngLow = new System.Windows.Forms.TextBox();
            this.textBoxEngHigh = new System.Windows.Forms.TextBox();
            this.labelEngLow = new System.Windows.Forms.Label();
            this.labelEngHigh = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(32, 44);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 16);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(30, 70);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(317, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(30, 127);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(317, 22);
            this.textBoxDescription.TabIndex = 2;
            // 
            // textBoxUnit
            // 
            this.textBoxUnit.Location = new System.Drawing.Point(30, 184);
            this.textBoxUnit.Name = "textBoxUnit";
            this.textBoxUnit.Size = new System.Drawing.Size(317, 22);
            this.textBoxUnit.TabIndex = 3;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(32, 102);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(75, 16);
            this.labelDescription.TabIndex = 4;
            this.labelDescription.Text = "Description";
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Location = new System.Drawing.Point(32, 160);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(30, 16);
            this.labelUnit.TabIndex = 5;
            this.labelUnit.Text = "Unit";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(57, 338);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(120, 35);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(183, 338);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 35);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // textBoxEngLow
            // 
            this.textBoxEngLow.Location = new System.Drawing.Point(30, 241);
            this.textBoxEngLow.Name = "textBoxEngLow";
            this.textBoxEngLow.Size = new System.Drawing.Size(317, 22);
            this.textBoxEngLow.TabIndex = 4;
            // 
            // textBoxEngHigh
            // 
            this.textBoxEngHigh.Location = new System.Drawing.Point(30, 298);
            this.textBoxEngHigh.Name = "textBoxEngHigh";
            this.textBoxEngHigh.Size = new System.Drawing.Size(317, 22);
            this.textBoxEngHigh.TabIndex = 5;
            // 
            // labelEngLow
            // 
            this.labelEngLow.AutoSize = true;
            this.labelEngLow.Location = new System.Drawing.Point(32, 218);
            this.labelEngLow.Name = "labelEngLow";
            this.labelEngLow.Size = new System.Drawing.Size(55, 16);
            this.labelEngLow.TabIndex = 10;
            this.labelEngLow.Text = "EngLow";
            // 
            // labelEngHigh
            // 
            this.labelEngHigh.AutoSize = true;
            this.labelEngHigh.Location = new System.Drawing.Point(32, 276);
            this.labelEngHigh.Name = "labelEngHigh";
            this.labelEngHigh.Size = new System.Drawing.Size(59, 16);
            this.labelEngHigh.TabIndex = 11;
            this.labelEngHigh.Text = "EngHigh";
            // 
            // NewSensorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(359, 386);
            this.Controls.Add(this.labelEngHigh);
            this.Controls.Add(this.labelEngLow);
            this.Controls.Add(this.textBoxEngHigh);
            this.Controls.Add(this.textBoxEngLow);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelUnit);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxUnit);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewSensorForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Add New Sensor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxUnit;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxEngLow;
        private System.Windows.Forms.TextBox textBoxEngHigh;
        private System.Windows.Forms.Label labelEngLow;
        private System.Windows.Forms.Label labelEngHigh;
    }
}