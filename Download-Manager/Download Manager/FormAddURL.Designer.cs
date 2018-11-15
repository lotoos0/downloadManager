namespace Download_Manager
{
    partial class FormAddURL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddURL));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.CheckFileName = new System.Windows.Forms.CheckBox();
            this.SaveAsLabel = new System.Windows.Forms.Label();
            this.SaveAsBox = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.RadioBT3 = new System.Windows.Forms.RadioButton();
            this.RadioBT2 = new System.Windows.Forms.RadioButton();
            this.RadioBT1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.testBox = new System.Windows.Forms.RichTextBox();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "http://";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.Items.AddRange(new object[] {
            "Save file",
            "Open file",
            "Save file and open it"});
            this.comboBox1.Location = new System.Drawing.Point(162, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Tag = "";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Download Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Save to folder:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 144);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(269, 21);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.Text = "%sdrive%\\Downloads\\";
            // 
            // CheckFileName
            // 
            this.CheckFileName.AutoSize = true;
            this.CheckFileName.Checked = true;
            this.CheckFileName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckFileName.Location = new System.Drawing.Point(13, 181);
            this.CheckFileName.Name = "CheckFileName";
            this.CheckFileName.Size = new System.Drawing.Size(179, 17);
            this.CheckFileName.TabIndex = 6;
            this.CheckFileName.Text = "Generate file name automatically";
            this.CheckFileName.UseVisualStyleBackColor = true;
            this.CheckFileName.CheckedChanged += new System.EventHandler(this.CheckFileName_CheckedChanged);
            // 
            // SaveAsLabel
            // 
            this.SaveAsLabel.AutoSize = true;
            this.SaveAsLabel.Location = new System.Drawing.Point(12, 205);
            this.SaveAsLabel.Name = "SaveAsLabel";
            this.SaveAsLabel.Size = new System.Drawing.Size(49, 13);
            this.SaveAsLabel.TabIndex = 7;
            this.SaveAsLabel.Text = "Save as:";
            this.SaveAsLabel.Click += new System.EventHandler(this.SaveAsLabel_Click);
            // 
            // SaveAsBox
            // 
            this.SaveAsBox.Enabled = false;
            this.SaveAsBox.Location = new System.Drawing.Point(13, 221);
            this.SaveAsBox.Name = "SaveAsBox";
            this.SaveAsBox.Size = new System.Drawing.Size(179, 20);
            this.SaveAsBox.TabIndex = 8;
            this.SaveAsBox.TextChanged += new System.EventHandler(this.SaveAsBox_TextChanged);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.RadioBT3);
            this.groupBox.Controls.Add(this.RadioBT2);
            this.groupBox.Controls.Add(this.RadioBT1);
            this.groupBox.Location = new System.Drawing.Point(73, 247);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(208, 91);
            this.groupBox.TabIndex = 9;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Start";
            // 
            // RadioBT3
            // 
            this.RadioBT3.AutoSize = true;
            this.RadioBT3.Enabled = false;
            this.RadioBT3.Location = new System.Drawing.Point(6, 65);
            this.RadioBT3.Name = "RadioBT3";
            this.RadioBT3.Size = new System.Drawing.Size(70, 17);
            this.RadioBT3.TabIndex = 2;
            this.RadioBT3.TabStop = true;
            this.RadioBT3.Text = "Schedule";
            this.RadioBT3.UseVisualStyleBackColor = true;
            // 
            // RadioBT2
            // 
            this.RadioBT2.AutoSize = true;
            this.RadioBT2.Location = new System.Drawing.Point(6, 42);
            this.RadioBT2.Name = "RadioBT2";
            this.RadioBT2.Size = new System.Drawing.Size(67, 17);
            this.RadioBT2.TabIndex = 1;
            this.RadioBT2.TabStop = true;
            this.RadioBT2.Text = "Manually";
            this.RadioBT2.UseVisualStyleBackColor = true;
            // 
            // RadioBT1
            // 
            this.RadioBT1.AutoSize = true;
            this.RadioBT1.Location = new System.Drawing.Point(6, 19);
            this.RadioBT1.Name = "RadioBT1";
            this.RadioBT1.Size = new System.Drawing.Size(87, 17);
            this.RadioBT1.TabIndex = 0;
            this.RadioBT1.TabStop = true;
            this.RadioBT1.Text = "Automatically";
            this.RadioBT1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(273, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(12, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Advanced";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(79, 353);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(195, 17);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "Place download at the top of the list";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(12, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Group";
            // 
            // comboBox3
            // 
            this.comboBox3.Enabled = false;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(162, 85);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(186, 21);
            this.comboBox3.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.Image = global::Download_Manager.Properties.Resources.folder_icon;
            this.button4.Location = new System.Drawing.Point(287, 145);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(33, 20);
            this.button4.TabIndex = 16;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // testBox
            // 
            this.testBox.Location = new System.Drawing.Point(248, 171);
            this.testBox.Name = "testBox";
            this.testBox.ReadOnly = true;
            this.testBox.Size = new System.Drawing.Size(100, 76);
            this.testBox.TabIndex = 17;
            this.testBox.Text = "";
            this.testBox.Visible = false;
            // 
            // FormAddURL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 428);
            this.Controls.Add(this.testBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.SaveAsBox);
            this.Controls.Add(this.SaveAsLabel);
            this.Controls.Add(this.CheckFileName);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddURL";
            this.Text = "Add Download";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox CheckFileName;
        private System.Windows.Forms.Label SaveAsLabel;
        private System.Windows.Forms.TextBox SaveAsBox;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton RadioBT3;
        private System.Windows.Forms.RadioButton RadioBT2;
        private System.Windows.Forms.RadioButton RadioBT1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox testBox;
    }
}

