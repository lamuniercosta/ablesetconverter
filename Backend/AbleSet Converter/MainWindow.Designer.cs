namespace AbleSet_Converter
{
    partial class MainWindow
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
            saveFileDialog1 = new SaveFileDialog();
            btnGenerate = new Button();
            fileDialogAbleSet = new OpenFileDialog();
            label1 = new Label();
            lblAbleset = new Label();
            btnAbleSet = new Button();
            btnBandHelper = new Button();
            label2 = new Label();
            lblBandHelper = new Label();
            fileDialogBandHelper = new OpenFileDialog();
            SuspendLayout();
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(302, 314);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(210, 72);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 41);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 1;
            label1.Text = "AbleSet";
            // 
            // lblAbleset
            // 
            lblAbleset.AutoSize = true;
            lblAbleset.Location = new Point(170, 41);
            lblAbleset.Name = "lblAbleset";
            lblAbleset.Size = new Size(0, 25);
            lblAbleset.TabIndex = 2;
            // 
            // btnAbleSet
            // 
            btnAbleSet.Location = new Point(91, 82);
            btnAbleSet.Name = "btnAbleSet";
            btnAbleSet.Size = new Size(112, 34);
            btnAbleSet.TabIndex = 3;
            btnAbleSet.Text = "Browse";
            btnAbleSet.UseVisualStyleBackColor = true;
            btnAbleSet.Click += btnAbleSet_Click;
            // 
            // btnBandHelper
            // 
            btnBandHelper.Location = new Point(91, 210);
            btnBandHelper.Name = "btnBandHelper";
            btnBandHelper.Size = new Size(112, 34);
            btnBandHelper.TabIndex = 4;
            btnBandHelper.Text = "Browse";
            btnBandHelper.UseVisualStyleBackColor = true;
            btnBandHelper.Click += btnBandHelper_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 170);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 5;
            label2.Text = "BandHelper";
            // 
            // lblBandHelper
            // 
            lblBandHelper.AutoSize = true;
            lblBandHelper.Location = new Point(201, 170);
            lblBandHelper.Name = "lblBandHelper";
            lblBandHelper.Size = new Size(0, 25);
            lblBandHelper.TabIndex = 6;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblBandHelper);
            Controls.Add(label2);
            Controls.Add(btnBandHelper);
            Controls.Add(btnAbleSet);
            Controls.Add(lblAbleset);
            Controls.Add(label1);
            Controls.Add(btnGenerate);
            Name = "MainWindow";
            Text = "MainWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SaveFileDialog saveFileDialog1;
        private Button btnGenerate;
        private OpenFileDialog fileDialogAbleSet;
        private Label label1;
        private Label lblAbleset;
        private Button btnAbleSet;
        private Button btnBandHelper;
        private Label label2;
        private Label lblBandHelper;
        private OpenFileDialog fileDialogBandHelper;
    }
}