namespace PROCESSES._MULTITHREADING_AND_ASYNCHRONY
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBoxFrom = new TextBox();
            textBoxTo = new TextBox();
            buttonFileFrom = new Button();
            buttonFileTo = new Button();
            progressBar = new ProgressBar();
            buttonCopy = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 27);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 0;
            label1.Text = "From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 99);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 1;
            label2.Text = "To";
            // 
            // textBoxFrom
            // 
            textBoxFrom.Location = new Point(135, 27);
            textBoxFrom.Name = "textBoxFrom";
            textBoxFrom.Size = new Size(472, 27);
            textBoxFrom.TabIndex = 2;
            // 
            // textBoxTo
            // 
            textBoxTo.Location = new Point(135, 96);
            textBoxTo.Name = "textBoxTo";
            textBoxTo.Size = new Size(472, 27);
            textBoxTo.TabIndex = 3;
            // 
            // buttonFileFrom
            // 
            buttonFileFrom.Location = new Point(645, 27);
            buttonFileFrom.Name = "buttonFileFrom";
            buttonFileFrom.Size = new Size(94, 29);
            buttonFileFrom.TabIndex = 4;
            buttonFileFrom.Text = "File";
            buttonFileFrom.UseVisualStyleBackColor = true;
            buttonFileFrom.Click += buttonFileFrom_Click;
            // 
            // buttonFileTo
            // 
            buttonFileTo.Location = new Point(645, 96);
            buttonFileTo.Name = "buttonFileTo";
            buttonFileTo.Size = new Size(94, 29);
            buttonFileTo.TabIndex = 5;
            buttonFileTo.Text = "File";
            buttonFileTo.UseVisualStyleBackColor = true;
            buttonFileTo.Click += buttonFileTo_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(57, 162);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(550, 29);
            progressBar.TabIndex = 6;
            // 
            // buttonCopy
            // 
            buttonCopy.Location = new Point(645, 162);
            buttonCopy.Name = "buttonCopy";
            buttonCopy.Size = new Size(94, 29);
            buttonCopy.TabIndex = 7;
            buttonCopy.Text = "Copy";
            buttonCopy.UseVisualStyleBackColor = true;
            buttonCopy.Click += buttonCopy_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 216);
            Controls.Add(buttonCopy);
            Controls.Add(progressBar);
            Controls.Add(buttonFileTo);
            Controls.Add(buttonFileFrom);
            Controls.Add(textBoxTo);
            Controls.Add(textBoxFrom);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxFrom;
        private TextBox textBoxTo;
        private Button buttonFileFrom;
        private Button buttonFileTo;
        private ProgressBar progressBar;
        private Button buttonCopy;
    }
}
