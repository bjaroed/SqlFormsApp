namespace SqlFormsApp
{
    partial class EditSensorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSensorForm));
            this.labelEngHigh = new System.Windows.Forms.Label();
            this.labelEngLow = new System.Windows.Forms.Label();
            this.textBoxEngHigh = new System.Windows.Forms.TextBox();
            this.textBoxEngLow = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelUnit = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxUnit = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelEngHigh
            // 
            this.labelEngHigh.AutoSize = true;
            this.labelEngHigh.Location = new System.Drawing.Point(23, 250);
            this.labelEngHigh.Name = "labelEngHigh";
            this.labelEngHigh.Size = new System.Drawing.Size(59, 16);
            this.labelEngHigh.TabIndex = 23;
            this.labelEngHigh.Text = "EngHigh";
            // 
            // labelEngLow
            // 
            this.labelEngLow.AutoSize = true;
            this.labelEngLow.Location = new System.Drawing.Point(23, 192);
            this.labelEngLow.Name = "labelEngLow";
            this.labelEngLow.Size = new System.Drawing.Size(55, 16);
            this.labelEngLow.TabIndex = 22;
            this.labelEngLow.Text = "EngLow";
            // 
            // textBoxEngHigh
            // 
            this.textBoxEngHigh.Location = new System.Drawing.Point(21, 272);
            this.textBoxEngHigh.Name = "textBoxEngHigh";
            this.textBoxEngHigh.Size = new System.Drawing.Size(317, 22);
            this.textBoxEngHigh.TabIndex = 18;
            // 
            // textBoxEngLow
            // 
            this.textBoxEngLow.Location = new System.Drawing.Point(21, 215);
            this.textBoxEngLow.Name = "textBoxEngLow";
            this.textBoxEngLow.Size = new System.Drawing.Size(317, 22);
            this.textBoxEngLow.TabIndex = 16;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(174, 312);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 35);
            this.buttonCancel.TabIndex = 21;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(48, 312);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(120, 35);
            this.buttonEdit.TabIndex = 20;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Location = new System.Drawing.Point(23, 134);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(30, 16);
            this.labelUnit.TabIndex = 19;
            this.labelUnit.Text = "Unit";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(23, 76);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(75, 16);
            this.labelDescription.TabIndex = 17;
            this.labelDescription.Text = "Description";
            // 
            // textBoxUnit
            // 
            this.textBoxUnit.Location = new System.Drawing.Point(21, 158);
            this.textBoxUnit.Name = "textBoxUnit";
            this.textBoxUnit.Size = new System.Drawing.Size(317, 22);
            this.textBoxUnit.TabIndex = 15;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(21, 101);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(317, 22);
            this.textBoxDescription.TabIndex = 14;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(21, 44);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(317, 22);
            this.textBoxName.TabIndex = 13;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(23, 18);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 16);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "Name";
            // 
            // EditSensorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(359, 362);
            this.Controls.Add(this.labelEngHigh);
            this.Controls.Add(this.labelEngLow);
            this.Controls.Add(this.textBoxEngHigh);
            this.Controls.Add(this.textBoxEngLow);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelUnit);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxUnit);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditSensorForm";
            this.Text = "Edit Sensor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEngHigh;
        private System.Windows.Forms.Label labelEngLow;
        private System.Windows.Forms.TextBox textBoxEngHigh;
        private System.Windows.Forms.TextBox textBoxEngLow;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxUnit;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
    }
}