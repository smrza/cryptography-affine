namespace Affine_Cipher
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.keyAUpDown = new System.Windows.Forms.NumericUpDown();
            this.keyBUpDown = new System.Windows.Forms.NumericUpDown();
            this.CipherButton = new System.Windows.Forms.Button();
            this.InputTextBox = new System.Windows.Forms.RichTextBox();
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.DecipherButton = new System.Windows.Forms.Button();
            this.labelKeyA = new System.Windows.Forms.Label();
            this.labelKeyB = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.listViewAlphabet = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelAlphabet = new System.Windows.Forms.Label();
            this.labelCipherAlphabet = new System.Windows.Forms.Label();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.parsedTextBox = new System.Windows.Forms.RichTextBox();
            this.parsedInput = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.infoPictureBox = new System.Windows.Forms.PictureBox();
            this.toolTipInfoPicture = new System.Windows.Forms.ToolTip(this.components);
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.keyAUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyBUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // keyAUpDown
            // 
            this.keyAUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyAUpDown.Location = new System.Drawing.Point(29, 92);
            this.keyAUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.keyAUpDown.Maximum = new decimal(new int[] {
            82595524,
            0,
            0,
            0});
            this.keyAUpDown.Minimum = new decimal(new int[] {
            82595524,
            0,
            0,
            -2147483648});
            this.keyAUpDown.Name = "keyAUpDown";
            this.keyAUpDown.Size = new System.Drawing.Size(105, 29);
            this.keyAUpDown.TabIndex = 0;
            this.toolTip1.SetToolTip(this.keyAUpDown, "Please enter your key A (preferably prime number).");
            this.keyAUpDown.Enter += new System.EventHandler(this.NumericUpDownA_Enter);
            // 
            // keyBUpDown
            // 
            this.keyBUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyBUpDown.Location = new System.Drawing.Point(29, 164);
            this.keyBUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.keyBUpDown.Maximum = new decimal(new int[] {
            82595524,
            0,
            0,
            0});
            this.keyBUpDown.Minimum = new decimal(new int[] {
            82595524,
            0,
            0,
            -2147483648});
            this.keyBUpDown.Name = "keyBUpDown";
            this.keyBUpDown.Size = new System.Drawing.Size(105, 29);
            this.keyBUpDown.TabIndex = 1;
            this.toolTip1.SetToolTip(this.keyBUpDown, "Please enter your key B.");
            this.keyBUpDown.Enter += new System.EventHandler(this.NumericUpDownB_Enter);
            // 
            // CipherButton
            // 
            this.CipherButton.BackColor = System.Drawing.Color.GreenYellow;
            this.CipherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CipherButton.Location = new System.Drawing.Point(29, 214);
            this.CipherButton.Margin = new System.Windows.Forms.Padding(2);
            this.CipherButton.Name = "CipherButton";
            this.CipherButton.Size = new System.Drawing.Size(105, 54);
            this.CipherButton.TabIndex = 2;
            this.CipherButton.Text = "Cipher";
            this.toolTip1.SetToolTip(this.CipherButton, "Button to cipher input.");
            this.CipherButton.UseVisualStyleBackColor = false;
            this.CipherButton.Click += new System.EventHandler(this.CipherButton_Click);
            // 
            // InputTextBox
            // 
            this.InputTextBox.BackColor = System.Drawing.Color.White;
            this.InputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTextBox.Location = new System.Drawing.Point(179, 46);
            this.InputTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(711, 179);
            this.InputTextBox.TabIndex = 0;
            this.InputTextBox.TabStop = false;
            this.InputTextBox.Text = "";
            this.toolTip1.SetToolTip(this.InputTextBox, "Please enter your input (encrypted/decrypted) and press on desired button.");
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OutputTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.OutputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.OutputTextBox.Location = new System.Drawing.Point(179, 469);
            this.OutputTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(711, 186);
            this.OutputTextBox.TabIndex = 0;
            this.OutputTextBox.TabStop = false;
            this.OutputTextBox.Text = "";
            this.toolTip1.SetToolTip(this.OutputTextBox, "This box shows decrypted/encrypted output.");
            // 
            // DecipherButton
            // 
            this.DecipherButton.BackColor = System.Drawing.Color.GreenYellow;
            this.DecipherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecipherButton.Location = new System.Drawing.Point(29, 294);
            this.DecipherButton.Margin = new System.Windows.Forms.Padding(2);
            this.DecipherButton.Name = "DecipherButton";
            this.DecipherButton.Size = new System.Drawing.Size(105, 54);
            this.DecipherButton.TabIndex = 3;
            this.DecipherButton.Text = "Decipher";
            this.toolTip1.SetToolTip(this.DecipherButton, "Button to decipher input");
            this.DecipherButton.UseVisualStyleBackColor = false;
            this.DecipherButton.Click += new System.EventHandler(this.DecipherButton_Click);
            // 
            // labelKeyA
            // 
            this.labelKeyA.AutoSize = true;
            this.labelKeyA.BackColor = System.Drawing.Color.Transparent;
            this.labelKeyA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKeyA.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelKeyA.Location = new System.Drawing.Point(25, 70);
            this.labelKeyA.Name = "labelKeyA";
            this.labelKeyA.Size = new System.Drawing.Size(55, 20);
            this.labelKeyA.TabIndex = 0;
            this.labelKeyA.Text = "Key A";
            // 
            // labelKeyB
            // 
            this.labelKeyB.AutoSize = true;
            this.labelKeyB.BackColor = System.Drawing.Color.Transparent;
            this.labelKeyB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKeyB.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelKeyB.Location = new System.Drawing.Point(25, 141);
            this.labelKeyB.Name = "labelKeyB";
            this.labelKeyB.Size = new System.Drawing.Size(55, 20);
            this.labelKeyB.TabIndex = 0;
            this.labelKeyB.Text = "Key B";
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(29, 523);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(105, 54);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Reset";
            this.toolTip1.SetToolTip(this.buttonReset, "Reset tool app.");
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // listViewAlphabet
            // 
            this.listViewAlphabet.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.listViewAlphabet.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listViewAlphabet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewAlphabet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewAlphabet.GridLines = true;
            this.listViewAlphabet.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewAlphabet.LabelWrap = false;
            this.listViewAlphabet.Location = new System.Drawing.Point(945, 24);
            this.listViewAlphabet.MultiSelect = false;
            this.listViewAlphabet.Name = "listViewAlphabet";
            this.listViewAlphabet.Scrollable = false;
            this.listViewAlphabet.Size = new System.Drawing.Size(66, 630);
            this.listViewAlphabet.TabIndex = 0;
            this.listViewAlphabet.TabStop = false;
            this.listViewAlphabet.TileSize = new System.Drawing.Size(100, 100);
            this.toolTip1.SetToolTip(this.listViewAlphabet, "Alphabet set on the left.");
            this.listViewAlphabet.UseCompatibleStateImageBehavior = false;
            this.listViewAlphabet.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 30;
            // 
            // labelAlphabet
            // 
            this.labelAlphabet.AutoSize = true;
            this.labelAlphabet.BackColor = System.Drawing.Color.Transparent;
            this.labelAlphabet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAlphabet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlphabet.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelAlphabet.Location = new System.Drawing.Point(915, 24);
            this.labelAlphabet.Name = "labelAlphabet";
            this.labelAlphabet.Size = new System.Drawing.Size(22, 160);
            this.labelAlphabet.TabIndex = 0;
            this.labelAlphabet.Text = "A\r\nL\r\nP\r\nH\r\nA\r\nB\r\nE\r\nT";
            this.labelAlphabet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCipherAlphabet
            // 
            this.labelCipherAlphabet.AutoSize = true;
            this.labelCipherAlphabet.BackColor = System.Drawing.Color.Transparent;
            this.labelCipherAlphabet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCipherAlphabet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCipherAlphabet.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelCipherAlphabet.Location = new System.Drawing.Point(1020, 24);
            this.labelCipherAlphabet.Name = "labelCipherAlphabet";
            this.labelCipherAlphabet.Size = new System.Drawing.Size(22, 300);
            this.labelCipherAlphabet.TabIndex = 0;
            this.labelCipherAlphabet.Text = "C\r\nI\r\nP\r\nH\r\nE\r\nR\r\n\r\nA\r\nL\r\nP\r\nH\r\nA\r\nB\r\nE\r\nT";
            this.labelCipherAlphabet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.BackColor = System.Drawing.Color.Transparent;
            this.labelInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInput.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelInput.Location = new System.Drawing.Point(175, 24);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(61, 20);
            this.labelInput.TabIndex = 0;
            this.labelInput.Text = "INPUT";
            this.labelInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.BackColor = System.Drawing.Color.Transparent;
            this.labelOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutput.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelOutput.Location = new System.Drawing.Point(175, 446);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(79, 20);
            this.labelOutput.TabIndex = 0;
            this.labelOutput.Text = "OUTPUT";
            this.labelOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parsedTextBox
            // 
            this.parsedTextBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.parsedTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.parsedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parsedTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.parsedTextBox.Location = new System.Drawing.Point(179, 260);
            this.parsedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.parsedTextBox.Name = "parsedTextBox";
            this.parsedTextBox.ReadOnly = true;
            this.parsedTextBox.Size = new System.Drawing.Size(711, 174);
            this.parsedTextBox.TabIndex = 0;
            this.parsedTextBox.TabStop = false;
            this.parsedTextBox.Text = "";
            this.toolTip1.SetToolTip(this.parsedTextBox, "This box shows parsed input ");
            // 
            // parsedInput
            // 
            this.parsedInput.AutoSize = true;
            this.parsedInput.BackColor = System.Drawing.Color.Transparent;
            this.parsedInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parsedInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parsedInput.ForeColor = System.Drawing.Color.GreenYellow;
            this.parsedInput.Location = new System.Drawing.Point(175, 234);
            this.parsedInput.Name = "parsedInput";
            this.parsedInput.Size = new System.Drawing.Size(139, 20);
            this.parsedInput.TabIndex = 0;
            this.parsedInput.Text = "PARSED INPUT";
            this.parsedInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoPictureBox
            // 
            this.infoPictureBox.BackColor = System.Drawing.Color.Black;
            this.infoPictureBox.BackgroundImage = global::Affine_Cipher.Properties.Resources.info;
            this.infoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.infoPictureBox.InitialImage = global::Affine_Cipher.Properties.Resources.info;
            this.infoPictureBox.Location = new System.Drawing.Point(2, 1);
            this.infoPictureBox.Name = "infoPictureBox";
            this.infoPictureBox.Size = new System.Drawing.Size(50, 50);
            this.infoPictureBox.TabIndex = 5;
            this.infoPictureBox.TabStop = false;
            this.toolTipInfoPicture.SetToolTip(this.infoPictureBox, resources.GetString("infoPictureBox.ToolTip"));
            // 
            // toolTipInfoPicture
            // 
            this.toolTipInfoPicture.AutoPopDelay = 600000;
            this.toolTipInfoPicture.InitialDelay = 500;
            this.toolTipInfoPicture.IsBalloon = true;
            this.toolTipInfoPicture.ReshowDelay = 100;
            this.toolTipInfoPicture.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipInfoPicture.ToolTipTitle = "Info";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(29, 601);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(105, 54);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.TabStop = false;
            this.buttonClose.Text = "Close";
            this.toolTip1.SetToolTip(this.buttonClose, "Closes the application.");
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Affine_Cipher.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1055, 680);
            this.Controls.Add(this.infoPictureBox);
            this.Controls.Add(this.labelCipherAlphabet);
            this.Controls.Add(this.parsedInput);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.labelAlphabet);
            this.Controls.Add(this.listViewAlphabet);
            this.Controls.Add(this.labelKeyB);
            this.Controls.Add(this.labelKeyA);
            this.Controls.Add(this.parsedTextBox);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.DecipherButton);
            this.Controls.Add(this.CipherButton);
            this.Controls.Add(this.keyBUpDown);
            this.Controls.Add(this.keyAUpDown);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Affine Cipher";
            ((System.ComponentModel.ISupportInitialize)(this.keyAUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyBUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown keyAUpDown;
        private System.Windows.Forms.NumericUpDown keyBUpDown;
        private System.Windows.Forms.Button CipherButton;
        private System.Windows.Forms.RichTextBox InputTextBox;
        private System.Windows.Forms.RichTextBox OutputTextBox;
        private System.Windows.Forms.Button DecipherButton;
        private System.Windows.Forms.Label labelKeyA;
        private System.Windows.Forms.Label labelKeyB;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ListView listViewAlphabet;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label labelAlphabet;
        private System.Windows.Forms.Label labelCipherAlphabet;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.RichTextBox parsedTextBox;
        private System.Windows.Forms.Label parsedInput;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox infoPictureBox;
        private System.Windows.Forms.ToolTip toolTipInfoPicture;
        private System.Windows.Forms.Button buttonClose;
    }
}

