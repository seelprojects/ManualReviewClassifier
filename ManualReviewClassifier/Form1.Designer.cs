namespace ManualReviewClassifier
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.importReviewsButton = new System.Windows.Forms.Button();
            this.fileFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataListview = new System.Windows.Forms.ListView();
            this.previewTextbox = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.performanceCheckbox = new MaterialSkin.Controls.MaterialCheckBox();
            this.supportabilityCheckbox = new MaterialSkin.Controls.MaterialCheckBox();
            this.usabilityCheckbox = new MaterialSkin.Controls.MaterialCheckBox();
            this.miscellaneousCheckbox = new MaterialSkin.Controls.MaterialCheckBox();
            this.dependabilityCheckbox = new MaterialSkin.Controls.MaterialCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // importReviewsButton
            // 
            this.importReviewsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importReviewsButton.Location = new System.Drawing.Point(942, 38);
            this.importReviewsButton.Name = "importReviewsButton";
            this.importReviewsButton.Size = new System.Drawing.Size(186, 48);
            this.importReviewsButton.TabIndex = 5;
            this.importReviewsButton.Text = "Import Reviews";
            this.importReviewsButton.UseVisualStyleBackColor = true;
            this.importReviewsButton.Click += new System.EventHandler(this.importReviewsButton_Click);
            // 
            // fileFolder
            // 
            this.fileFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileFolder.Location = new System.Drawing.Point(373, 44);
            this.fileFolder.Multiline = true;
            this.fileFolder.Name = "fileFolder";
            this.fileFolder.Size = new System.Drawing.Size(521, 38);
            this.fileFolder.TabIndex = 4;
            this.fileFolder.Click += new System.EventHandler(this.inputFilePathTextBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input Folder Path";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataListview
            // 
            this.dataListview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataListview.FullRowSelect = true;
            this.dataListview.HideSelection = false;
            this.dataListview.Location = new System.Drawing.Point(85, 109);
            this.dataListview.Name = "dataListview";
            this.dataListview.Size = new System.Drawing.Size(1250, 239);
            this.dataListview.TabIndex = 6;
            this.dataListview.UseCompatibleStateImageBehavior = false;
            this.dataListview.SelectedIndexChanged += new System.EventHandler(this.dataListview_SelectedIndexChanged);
            // 
            // previewTextbox
            // 
            this.previewTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.previewTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewTextbox.Location = new System.Drawing.Point(85, 400);
            this.previewTextbox.Multiline = true;
            this.previewTextbox.Name = "previewTextbox";
            this.previewTextbox.Size = new System.Drawing.Size(1250, 144);
            this.previewTextbox.TabIndex = 25;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(1200, 557);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(135, 82);
            this.nextButton.TabIndex = 49;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // performanceCheckbox
            // 
            this.performanceCheckbox.AutoSize = true;
            this.performanceCheckbox.Depth = 0;
            this.performanceCheckbox.Font = new System.Drawing.Font("Roboto", 10F);
            this.performanceCheckbox.Location = new System.Drawing.Point(327, 582);
            this.performanceCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.performanceCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.performanceCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.performanceCheckbox.Name = "performanceCheckbox";
            this.performanceCheckbox.Ripple = true;
            this.performanceCheckbox.Size = new System.Drawing.Size(152, 30);
            this.performanceCheckbox.TabIndex = 52;
            this.performanceCheckbox.Text = "Performance";
            this.performanceCheckbox.UseVisualStyleBackColor = true;
            this.performanceCheckbox.Click += new System.EventHandler(this.performanceButton_Click);
            // 
            // supportabilityCheckbox
            // 
            this.supportabilityCheckbox.AutoSize = true;
            this.supportabilityCheckbox.Depth = 0;
            this.supportabilityCheckbox.Font = new System.Drawing.Font("Roboto", 10F);
            this.supportabilityCheckbox.Location = new System.Drawing.Point(547, 582);
            this.supportabilityCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.supportabilityCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.supportabilityCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.supportabilityCheckbox.Name = "supportabilityCheckbox";
            this.supportabilityCheckbox.Ripple = true;
            this.supportabilityCheckbox.Size = new System.Drawing.Size(160, 30);
            this.supportabilityCheckbox.TabIndex = 53;
            this.supportabilityCheckbox.Text = "Supportability";
            this.supportabilityCheckbox.UseVisualStyleBackColor = true;
            this.supportabilityCheckbox.Click += new System.EventHandler(this.supportabilityButton_Click);
            // 
            // usabilityCheckbox
            // 
            this.usabilityCheckbox.AutoSize = true;
            this.usabilityCheckbox.Depth = 0;
            this.usabilityCheckbox.Font = new System.Drawing.Font("Roboto", 10F);
            this.usabilityCheckbox.Location = new System.Drawing.Point(780, 582);
            this.usabilityCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.usabilityCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.usabilityCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.usabilityCheckbox.Name = "usabilityCheckbox";
            this.usabilityCheckbox.Ripple = true;
            this.usabilityCheckbox.Size = new System.Drawing.Size(112, 30);
            this.usabilityCheckbox.TabIndex = 54;
            this.usabilityCheckbox.Text = "Usability";
            this.usabilityCheckbox.UseVisualStyleBackColor = true;
            this.usabilityCheckbox.Click += new System.EventHandler(this.usabilityButton_Click);
            // 
            // miscellaneousCheckbox
            // 
            this.miscellaneousCheckbox.AutoSize = true;
            this.miscellaneousCheckbox.Depth = 0;
            this.miscellaneousCheckbox.Enabled = false;
            this.miscellaneousCheckbox.Font = new System.Drawing.Font("Roboto", 10F);
            this.miscellaneousCheckbox.Location = new System.Drawing.Point(962, 582);
            this.miscellaneousCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.miscellaneousCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.miscellaneousCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.miscellaneousCheckbox.Name = "miscellaneousCheckbox";
            this.miscellaneousCheckbox.Ripple = true;
            this.miscellaneousCheckbox.Size = new System.Drawing.Size(166, 30);
            this.miscellaneousCheckbox.TabIndex = 55;
            this.miscellaneousCheckbox.Text = "Miscellaneous";
            this.miscellaneousCheckbox.UseVisualStyleBackColor = true;
            // 
            // dependabilityCheckbox
            // 
            this.dependabilityCheckbox.AutoSize = true;
            this.dependabilityCheckbox.Depth = 0;
            this.dependabilityCheckbox.Font = new System.Drawing.Font("Roboto", 10F);
            this.dependabilityCheckbox.Location = new System.Drawing.Point(116, 582);
            this.dependabilityCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.dependabilityCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.dependabilityCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.dependabilityCheckbox.Name = "dependabilityCheckbox";
            this.dependabilityCheckbox.Ripple = true;
            this.dependabilityCheckbox.Size = new System.Drawing.Size(158, 30);
            this.dependabilityCheckbox.TabIndex = 51;
            this.dependabilityCheckbox.Text = "Dependability";
            this.dependabilityCheckbox.UseVisualStyleBackColor = true;
            this.dependabilityCheckbox.Click += new System.EventHandler(this.dependabilityButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 56;
            this.label2.Text = "Preview";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1153, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1405, 688);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.miscellaneousCheckbox);
            this.Controls.Add(this.usabilityCheckbox);
            this.Controls.Add(this.supportabilityCheckbox);
            this.Controls.Add(this.performanceCheckbox);
            this.Controls.Add(this.dependabilityCheckbox);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previewTextbox);
            this.Controls.Add(this.dataListview);
            this.Controls.Add(this.importReviewsButton);
            this.Controls.Add(this.fileFolder);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Manual Review Classifier";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button importReviewsButton;
        private System.Windows.Forms.TextBox fileFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListView dataListview;
        private System.Windows.Forms.TextBox previewTextbox;
        private System.Windows.Forms.Button nextButton;
        private MaterialSkin.Controls.MaterialCheckBox performanceCheckbox;
        private MaterialSkin.Controls.MaterialCheckBox supportabilityCheckbox;
        private MaterialSkin.Controls.MaterialCheckBox usabilityCheckbox;
        private MaterialSkin.Controls.MaterialCheckBox miscellaneousCheckbox;
        private MaterialSkin.Controls.MaterialCheckBox dependabilityCheckbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

