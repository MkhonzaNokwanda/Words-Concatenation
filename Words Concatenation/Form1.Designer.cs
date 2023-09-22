namespace Words_Concatenation
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
            this.lblNewWord = new System.Windows.Forms.Label();
            this.txtNewWord = new System.Windows.Forms.TextBox();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.comboBoxWord = new System.Windows.Forms.ComboBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.lblOR = new System.Windows.Forms.Label();
            this.lblSelectAnother = new System.Windows.Forms.Label();
            this.comboBoxAnother = new System.Windows.Forms.ComboBox();
            this.radioBtnWord = new System.Windows.Forms.RadioButton();
            this.radioBtnAnother = new System.Windows.Forms.RadioButton();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnConcatenate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNewWord
            // 
            this.lblNewWord.AutoSize = true;
            this.lblNewWord.Location = new System.Drawing.Point(313, 9);
            this.lblNewWord.Name = "lblNewWord";
            this.lblNewWord.Size = new System.Drawing.Size(136, 20);
            this.lblNewWord.TabIndex = 0;
            this.lblNewWord.Text = "Enter a new word:";
            this.lblNewWord.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNewWord
            // 
            this.txtNewWord.Location = new System.Drawing.Point(222, 44);
            this.txtNewWord.Name = "txtNewWord";
            this.txtNewWord.Size = new System.Drawing.Size(328, 26);
            this.txtNewWord.TabIndex = 1;
            // 
            // btnAddWord
            // 
            this.btnAddWord.Location = new System.Drawing.Point(287, 85);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(194, 29);
            this.btnAddWord.TabIndex = 2;
            this.btnAddWord.Text = "Add Word";
            this.btnAddWord.UseVisualStyleBackColor = true;
            this.btnAddWord.Click += new System.EventHandler(this.btnAddWord_Click);
            // 
            // comboBoxWord
            // 
            this.comboBoxWord.AllowDrop = true;
            this.comboBoxWord.FormattingEnabled = true;
            this.comboBoxWord.Location = new System.Drawing.Point(65, 206);
            this.comboBoxWord.Name = "comboBoxWord";
            this.comboBoxWord.Size = new System.Drawing.Size(259, 28);
            this.comboBoxWord.TabIndex = 3;
            this.comboBoxWord.SelectedIndexChanged += new System.EventHandler(this.comboBoxWord_SelectedIndexChanged);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(61, 173);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(109, 20);
            this.lblSelect.TabIndex = 4;
            this.lblSelect.Text = "Select a word:";
            // 
            // lblOR
            // 
            this.lblOR.AutoSize = true;
            this.lblOR.Location = new System.Drawing.Point(358, 148);
            this.lblOR.Name = "lblOR";
            this.lblOR.Size = new System.Drawing.Size(33, 20);
            this.lblOR.TabIndex = 5;
            this.lblOR.Text = "OR";
            // 
            // lblSelectAnother
            // 
            this.lblSelectAnother.AutoSize = true;
            this.lblSelectAnother.Location = new System.Drawing.Point(447, 173);
            this.lblSelectAnother.Name = "lblSelectAnother";
            this.lblSelectAnother.Size = new System.Drawing.Size(155, 20);
            this.lblSelectAnother.TabIndex = 6;
            this.lblSelectAnother.Text = "Select another word:";
            // 
            // comboBoxAnother
            // 
            this.comboBoxAnother.AllowDrop = true;
            this.comboBoxAnother.FormattingEnabled = true;
            this.comboBoxAnother.Location = new System.Drawing.Point(451, 206);
            this.comboBoxAnother.Name = "comboBoxAnother";
            this.comboBoxAnother.Size = new System.Drawing.Size(280, 28);
            this.comboBoxAnother.TabIndex = 7;
            // 
            // radioBtnWord
            // 
            this.radioBtnWord.AutoSize = true;
            this.radioBtnWord.Location = new System.Drawing.Point(65, 263);
            this.radioBtnWord.Name = "radioBtnWord";
            this.radioBtnWord.Size = new System.Drawing.Size(93, 24);
            this.radioBtnWord.TabIndex = 8;
            this.radioBtnWord.TabStop = true;
            this.radioBtnWord.Text = "Remove";
            this.radioBtnWord.UseVisualStyleBackColor = true;
            this.radioBtnWord.CheckedChanged += new System.EventHandler(this.radioBtnWord_CheckedChanged);
            // 
            // radioBtnAnother
            // 
            this.radioBtnAnother.AutoSize = true;
            this.radioBtnAnother.Location = new System.Drawing.Point(451, 263);
            this.radioBtnAnother.Name = "radioBtnAnother";
            this.radioBtnAnother.Size = new System.Drawing.Size(93, 24);
            this.radioBtnAnother.TabIndex = 9;
            this.radioBtnAnother.TabStop = true;
            this.radioBtnAnother.Text = "Remove";
            this.radioBtnAnother.UseVisualStyleBackColor = true;
            this.radioBtnAnother.CheckedChanged += new System.EventHandler(this.radioBtnAnother_CheckedChanged);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.BackColor = System.Drawing.SystemColors.Window;
            this.lblDisplay.Location = new System.Drawing.Point(340, 376);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(0, 20);
            this.lblDisplay.TabIndex = 10;
            // 
            // btnConcatenate
            // 
            this.btnConcatenate.Location = new System.Drawing.Point(287, 312);
            this.btnConcatenate.Name = "btnConcatenate";
            this.btnConcatenate.Size = new System.Drawing.Size(194, 33);
            this.btnConcatenate.TabIndex = 11;
            this.btnConcatenate.Text = "Concatenate";
            this.btnConcatenate.UseVisualStyleBackColor = true;
            this.btnConcatenate.Click += new System.EventHandler(this.btnConcatenate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConcatenate);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.radioBtnAnother);
            this.Controls.Add(this.radioBtnWord);
            this.Controls.Add(this.comboBoxAnother);
            this.Controls.Add(this.lblSelectAnother);
            this.Controls.Add(this.lblOR);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.comboBoxWord);
            this.Controls.Add(this.btnAddWord);
            this.Controls.Add(this.txtNewWord);
            this.Controls.Add(this.lblNewWord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewWord;
        private System.Windows.Forms.TextBox txtNewWord;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.ComboBox comboBoxWord;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label lblOR;
        private System.Windows.Forms.Label lblSelectAnother;
        private System.Windows.Forms.ComboBox comboBoxAnother;
        private System.Windows.Forms.RadioButton radioBtnWord;
        private System.Windows.Forms.RadioButton radioBtnAnother;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnConcatenate;
    }
}

