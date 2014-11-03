namespace LabelingTool
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
            this.TweetTextBox = new System.Windows.Forms.RichTextBox();
            this.Next = new System.Windows.Forms.Button();
            this.Previous = new System.Windows.Forms.Button();
            this.RelevantRadio = new System.Windows.Forms.RadioButton();
            this.IrrelevantRadio = new System.Windows.Forms.RadioButton();
            this.relevanceGroupBox = new System.Windows.Forms.GroupBox();
            this.SentimentComboBox = new System.Windows.Forms.GroupBox();
            this.NegativeRadio = new System.Windows.Forms.RadioButton();
            this.PositiveRadio = new System.Windows.Forms.RadioButton();
            this.NeutralRadio = new System.Windows.Forms.RadioButton();
            this.LoadFile = new System.Windows.Forms.Button();
            this.SaveFile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.relevanceGroupBox.SuspendLayout();
            this.SentimentComboBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TweetTextBox
            // 
            this.TweetTextBox.Location = new System.Drawing.Point(61, 35);
            this.TweetTextBox.Name = "TweetTextBox";
            this.TweetTextBox.ReadOnly = true;
            this.TweetTextBox.Size = new System.Drawing.Size(838, 200);
            this.TweetTextBox.TabIndex = 0;
            this.TweetTextBox.Text = "";
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(807, 454);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(70, 22);
            this.Next.TabIndex = 1;
            this.Next.Text = ">>";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.button1_Click);
            // 
            // Previous
            // 
            this.Previous.Location = new System.Drawing.Point(699, 454);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(70, 22);
            this.Previous.TabIndex = 2;
            this.Previous.Text = "<<";
            this.Previous.UseVisualStyleBackColor = true;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // RelevantRadio
            // 
            this.RelevantRadio.AutoSize = true;
            this.RelevantRadio.Location = new System.Drawing.Point(19, 14);
            this.RelevantRadio.Name = "RelevantRadio";
            this.RelevantRadio.Size = new System.Drawing.Size(68, 17);
            this.RelevantRadio.TabIndex = 7;
            this.RelevantRadio.TabStop = true;
            this.RelevantRadio.Text = "Relevant";
            this.RelevantRadio.UseVisualStyleBackColor = true;
            this.RelevantRadio.CheckedChanged += new System.EventHandler(this.RelevantRadio_CheckedChanged);
            // 
            // IrrelevantRadio
            // 
            this.IrrelevantRadio.AutoSize = true;
            this.IrrelevantRadio.Location = new System.Drawing.Point(19, 37);
            this.IrrelevantRadio.Name = "IrrelevantRadio";
            this.IrrelevantRadio.Size = new System.Drawing.Size(69, 17);
            this.IrrelevantRadio.TabIndex = 8;
            this.IrrelevantRadio.TabStop = true;
            this.IrrelevantRadio.Text = "Irrelevant";
            this.IrrelevantRadio.UseVisualStyleBackColor = true;
            this.IrrelevantRadio.CheckedChanged += new System.EventHandler(this.IrrelevantRadio_CheckedChanged);
            // 
            // relevanceGroupBox
            // 
            this.relevanceGroupBox.Controls.Add(this.IrrelevantRadio);
            this.relevanceGroupBox.Controls.Add(this.RelevantRadio);
            this.relevanceGroupBox.Location = new System.Drawing.Point(61, 241);
            this.relevanceGroupBox.Name = "relevanceGroupBox";
            this.relevanceGroupBox.Size = new System.Drawing.Size(175, 69);
            this.relevanceGroupBox.TabIndex = 9;
            this.relevanceGroupBox.TabStop = false;
            this.relevanceGroupBox.Text = "Relevane label";
            this.relevanceGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // SentimentComboBox
            // 
            this.SentimentComboBox.Controls.Add(this.NeutralRadio);
            this.SentimentComboBox.Controls.Add(this.NegativeRadio);
            this.SentimentComboBox.Controls.Add(this.PositiveRadio);
            this.SentimentComboBox.Location = new System.Drawing.Point(61, 328);
            this.SentimentComboBox.Name = "SentimentComboBox";
            this.SentimentComboBox.Size = new System.Drawing.Size(186, 106);
            this.SentimentComboBox.TabIndex = 10;
            this.SentimentComboBox.TabStop = false;
            this.SentimentComboBox.Text = "Sentiment label";
            // 
            // NegativeRadio
            // 
            this.NegativeRadio.AutoSize = true;
            this.NegativeRadio.Location = new System.Drawing.Point(19, 37);
            this.NegativeRadio.Name = "NegativeRadio";
            this.NegativeRadio.Size = new System.Drawing.Size(68, 17);
            this.NegativeRadio.TabIndex = 8;
            this.NegativeRadio.TabStop = true;
            this.NegativeRadio.Text = "Negative";
            this.NegativeRadio.UseVisualStyleBackColor = true;
            this.NegativeRadio.CheckedChanged += new System.EventHandler(this.NegativeRadio_CheckedChanged);
            // 
            // PositiveRadio
            // 
            this.PositiveRadio.AutoSize = true;
            this.PositiveRadio.Location = new System.Drawing.Point(19, 14);
            this.PositiveRadio.Name = "PositiveRadio";
            this.PositiveRadio.Size = new System.Drawing.Size(62, 17);
            this.PositiveRadio.TabIndex = 7;
            this.PositiveRadio.TabStop = true;
            this.PositiveRadio.Text = "Positive";
            this.PositiveRadio.UseVisualStyleBackColor = true;
            this.PositiveRadio.CheckedChanged += new System.EventHandler(this.PositiveRadio_CheckedChanged);
            // 
            // NeutralRadio
            // 
            this.NeutralRadio.AutoSize = true;
            this.NeutralRadio.Location = new System.Drawing.Point(19, 60);
            this.NeutralRadio.Name = "NeutralRadio";
            this.NeutralRadio.Size = new System.Drawing.Size(59, 17);
            this.NeutralRadio.TabIndex = 9;
            this.NeutralRadio.TabStop = true;
            this.NeutralRadio.Text = "Neutral";
            this.NeutralRadio.UseVisualStyleBackColor = true;
            this.NeutralRadio.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // LoadFile
            // 
            this.LoadFile.Location = new System.Drawing.Point(662, 241);
            this.LoadFile.Name = "LoadFile";
            this.LoadFile.Size = new System.Drawing.Size(75, 23);
            this.LoadFile.TabIndex = 11;
            this.LoadFile.Text = "Load..";
            this.LoadFile.UseVisualStyleBackColor = true;
            this.LoadFile.Click += new System.EventHandler(this.LoadFile_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.Location = new System.Drawing.Point(743, 241);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(75, 23);
            this.SaveFile.TabIndex = 12;
            this.SaveFile.Text = "Save..";
            this.SaveFile.UseVisualStyleBackColor = true;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(824, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "SaveAs..";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 496);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.LoadFile);
            this.Controls.Add(this.SentimentComboBox);
            this.Controls.Add(this.relevanceGroupBox);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.TweetTextBox);
            this.Name = "Form1";
            this.Text = "TweetLabel";
            this.relevanceGroupBox.ResumeLayout(false);
            this.relevanceGroupBox.PerformLayout();
            this.SentimentComboBox.ResumeLayout(false);
            this.SentimentComboBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TweetTextBox;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.RadioButton RelevantRadio;
        private System.Windows.Forms.RadioButton IrrelevantRadio;
        private System.Windows.Forms.GroupBox relevanceGroupBox;
        private System.Windows.Forms.GroupBox SentimentComboBox;
        private System.Windows.Forms.RadioButton NeutralRadio;
        private System.Windows.Forms.RadioButton NegativeRadio;
        private System.Windows.Forms.RadioButton PositiveRadio;
        private System.Windows.Forms.Button LoadFile;
        private System.Windows.Forms.Button SaveFile;
        private System.Windows.Forms.Button button1;
    }
}

