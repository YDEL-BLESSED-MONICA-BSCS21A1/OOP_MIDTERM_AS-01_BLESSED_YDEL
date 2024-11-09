namespace WinFormsApp1
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            nameBox = new TextBox();
            idBox = new TextBox();
            saveButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 81);
            label1.Name = "label1";
            label1.Size = new Size(104, 37);
            label1.TabIndex = 0;
            label1.Text = "NAME:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 165);
            label2.Name = "label2";
            label2.Size = new Size(53, 37);
            label2.TabIndex = 1;
            label2.Text = "ID:";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(171, 91);
            nameBox.Margin = new Padding(3, 4, 3, 4);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(271, 27);
            nameBox.TabIndex = 2;
            nameBox.TextChanged += nameBox_TextChanged;
            // 
            // idBox
            // 
            idBox.Location = new Point(171, 175);
            idBox.Margin = new Padding(3, 4, 3, 4);
            idBox.Name = "idBox";
            idBox.Size = new Size(271, 27);
            idBox.TabIndex = 3;
            idBox.TextChanged += idBox_TextChanged;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(328, 295);
            saveButton.Margin = new Padding(3, 4, 3, 4);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(115, 45);
            saveButton.TabIndex = 4;
            saveButton.Text = "SAVE";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(490, 295);
            cancelButton.Margin = new Padding(3, 4, 3, 4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(115, 45);
            cancelButton.TabIndex = 5;
            cancelButton.Text = "CANCEL";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 421);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(idBox);
            Controls.Add(nameBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nameBox;
        private TextBox idBox;
        private Button saveButton;
        private Button cancelButton;
    }
}