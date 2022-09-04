namespace Pandemonium_Classic___Mod_Manager
{
    partial class PCUEMOD
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
            this.optionListBox = new System.Windows.Forms.CheckedListBox();
            this.optionImageBox = new System.Windows.Forms.PictureBox();
            this.installStepLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.optionDescBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.optionImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // optionListBox
            // 
            this.optionListBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.optionListBox.FormattingEnabled = true;
            this.optionListBox.Location = new System.Drawing.Point(366, 52);
            this.optionListBox.Name = "optionListBox";
            this.optionListBox.Size = new System.Drawing.Size(241, 344);
            this.optionListBox.TabIndex = 0;
            this.optionListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.optionListBox_ItemCheck);
            // 
            // optionImageBox
            // 
            this.optionImageBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.optionImageBox.Location = new System.Drawing.Point(12, 12);
            this.optionImageBox.Name = "optionImageBox";
            this.optionImageBox.Size = new System.Drawing.Size(348, 232);
            this.optionImageBox.TabIndex = 1;
            this.optionImageBox.TabStop = false;
            // 
            // installStepLabel
            // 
            this.installStepLabel.AutoEllipsis = true;
            this.installStepLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.installStepLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.installStepLabel.Location = new System.Drawing.Point(366, 12);
            this.installStepLabel.Name = "installStepLabel";
            this.installStepLabel.Size = new System.Drawing.Size(241, 37);
            this.installStepLabel.TabIndex = 2;
            this.installStepLabel.Text = "Step Label";
            this.installStepLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nextButton.Location = new System.Drawing.Point(366, 404);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(241, 45);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = "NEXT";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // optionDescBox
            // 
            this.optionDescBox.Location = new System.Drawing.Point(12, 250);
            this.optionDescBox.Multiline = true;
            this.optionDescBox.Name = "optionDescBox";
            this.optionDescBox.PlaceholderText = "Option Description";
            this.optionDescBox.Size = new System.Drawing.Size(348, 199);
            this.optionDescBox.TabIndex = 4;
            // 
            // PCUEMOD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 461);
            this.Controls.Add(this.optionDescBox);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.installStepLabel);
            this.Controls.Add(this.optionImageBox);
            this.Controls.Add(this.optionListBox);
            this.Name = "PCUEMOD";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.optionImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CheckedListBox optionListBox;
        private PictureBox optionImageBox;
        private Label installStepLabel;
        private Button nextButton;
        private TextBox optionDescBox;
    }
}