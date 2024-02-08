namespace tcg_tiling
{
    partial class TCGTiler
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
            components = new System.ComponentModel.Container();
            FindCardFolder = new Button();
            FolderName = new TextBox();
            YGORadio = new RadioButton();
            MTGRadio = new RadioButton();
            CustomCardRadio = new RadioButton();
            cardHeight = new TextBox();
            cardWidth = new TextBox();
            size = new Label();
            label2 = new Label();
            CardSizeBox = new GroupBox();
            PageSizeBox = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            pageWidth = new TextBox();
            CustomPageRadio = new RadioButton();
            pageHeight = new TextBox();
            A0Radio = new RadioButton();
            A1Radio = new RadioButton();
            A2Radio = new RadioButton();
            A4Radio = new RadioButton();
            A7Radio = new RadioButton();
            A5Radio = new RadioButton();
            A6Radio = new RadioButton();
            A3Radio = new RadioButton();
            label1 = new Label();
            label5 = new Label();
            BatchName = new TextBox();
            linkLabel1 = new LinkLabel();
            GenButton = new Button();
            GenProgress = new ProgressBar();
            CardSizeToolTip = new ToolTip(components);
            PageSizeToolTip = new ToolTip(components);
            CardSizeBox.SuspendLayout();
            PageSizeBox.SuspendLayout();
            SuspendLayout();
            // 
            // FindCardFolder
            // 
            FindCardFolder.Location = new Point(12, 41);
            FindCardFolder.Name = "FindCardFolder";
            FindCardFolder.Size = new Size(110, 23);
            FindCardFolder.TabIndex = 0;
            FindCardFolder.Text = "Select card folder";
            FindCardFolder.UseVisualStyleBackColor = true;
            FindCardFolder.Click += FindCardFolder_Click;
            // 
            // FolderName
            // 
            FolderName.Location = new Point(128, 41);
            FolderName.Name = "FolderName";
            FolderName.Size = new Size(244, 23);
            FolderName.TabIndex = 1;
            // 
            // YGORadio
            // 
            YGORadio.AutoSize = true;
            YGORadio.Location = new Point(61, 22);
            YGORadio.Name = "YGORadio";
            YGORadio.Size = new Size(49, 19);
            YGORadio.TabIndex = 2;
            YGORadio.TabStop = true;
            YGORadio.Text = "YGO";
            CardSizeToolTip.SetToolTip(YGORadio, "3.25in by 2.25in\r\n82.6mm by 57.2mm\r\n975px by 675px");
            YGORadio.UseVisualStyleBackColor = true;
            // 
            // MTGRadio
            // 
            MTGRadio.AutoSize = true;
            MTGRadio.Location = new Point(6, 22);
            MTGRadio.Name = "MTGRadio";
            MTGRadio.Size = new Size(49, 19);
            MTGRadio.TabIndex = 3;
            MTGRadio.TabStop = true;
            MTGRadio.Text = "MTG";
            CardSizeToolTip.SetToolTip(MTGRadio, "3.5in by 2.5in\r\n88.9mm by 63.5mm\r\n1050px by 750px");
            MTGRadio.Checked= true;
            MTGRadio.UseVisualStyleBackColor = true;
            // 
            // CustomCardRadio
            // 
            CustomCardRadio.AutoSize = true;
            CustomCardRadio.Location = new Point(6, 47);
            CustomCardRadio.Name = "CustomCardRadio";
            CustomCardRadio.Size = new Size(67, 19);
            CustomCardRadio.TabIndex = 4;
            CustomCardRadio.TabStop = true;
            CustomCardRadio.Text = "Custom";
            CardSizeToolTip.SetToolTip(CustomCardRadio, "Provide measurements in pixels");
            CustomCardRadio.UseVisualStyleBackColor = true;
            // 
            // cardHeight
            // 
            cardHeight.Location = new Point(101, 46);
            cardHeight.Name = "cardHeight";
            cardHeight.Size = new Size(100, 23);
            cardHeight.TabIndex = 5;
            // 
            // cardWidth
            // 
            cardWidth.Location = new Point(234, 46);
            cardWidth.Name = "cardWidth";
            cardWidth.Size = new Size(100, 23);
            cardWidth.TabIndex = 6;
            // 
            // size
            // 
            size.AutoSize = true;
            size.Location = new Point(76, 49);
            size.Name = "size";
            size.Size = new Size(19, 15);
            size.TabIndex = 10;
            size.Text = "H:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 49);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 11;
            label2.Text = "W:";
            // 
            // CardSizeBox
            // 
            CardSizeBox.Controls.Add(label2);
            CardSizeBox.Controls.Add(MTGRadio);
            CardSizeBox.Controls.Add(CustomCardRadio);
            CardSizeBox.Controls.Add(cardWidth);
            CardSizeBox.Controls.Add(YGORadio);
            CardSizeBox.Controls.Add(size);
            CardSizeBox.Controls.Add(cardHeight);
            CardSizeBox.Location = new Point(12, 70);
            CardSizeBox.Name = "CardSizeBox";
            CardSizeBox.Size = new Size(360, 82);
            CardSizeBox.TabIndex = 12;
            CardSizeBox.TabStop = false;
            CardSizeBox.Text = "Card Size";
            // 
            // PageSizeBox
            // 
            PageSizeBox.Controls.Add(label4);
            PageSizeBox.Controls.Add(label3);
            PageSizeBox.Controls.Add(pageWidth);
            PageSizeBox.Controls.Add(CustomPageRadio);
            PageSizeBox.Controls.Add(pageHeight);
            PageSizeBox.Controls.Add(A0Radio);
            PageSizeBox.Controls.Add(A1Radio);
            PageSizeBox.Controls.Add(A2Radio);
            PageSizeBox.Controls.Add(A4Radio);
            PageSizeBox.Controls.Add(A7Radio);
            PageSizeBox.Controls.Add(A5Radio);
            PageSizeBox.Controls.Add(A6Radio);
            PageSizeBox.Controls.Add(A3Radio);
            PageSizeBox.Location = new Point(12, 158);
            PageSizeBox.Name = "PageSizeBox";
            PageSizeBox.Size = new Size(360, 111);
            PageSizeBox.TabIndex = 13;
            PageSizeBox.TabStop = false;
            PageSizeBox.Text = "Page Size";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(210, 74);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 13;
            label4.Text = "W:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 75);
            label3.Name = "label3";
            label3.Size = new Size(19, 15);
            label3.TabIndex = 13;
            label3.Text = "H:";
            // 
            // pageWidth
            // 
            pageWidth.Location = new Point(237, 71);
            pageWidth.Name = "pageWidth";
            pageWidth.Size = new Size(100, 23);
            pageWidth.TabIndex = 12;
            // 
            // CustomPageRadio
            // 
            CustomPageRadio.AutoSize = true;
            CustomPageRadio.Location = new Point(6, 72);
            CustomPageRadio.Name = "CustomPageRadio";
            CustomPageRadio.Size = new Size(67, 19);
            CustomPageRadio.TabIndex = 12;
            CustomPageRadio.TabStop = true;
            CustomPageRadio.Text = "Custom";
            PageSizeToolTip.SetToolTip(CustomPageRadio, "Provide measurements in pixels");
            CustomPageRadio.UseVisualStyleBackColor = true;
            // 
            // pageHeight
            // 
            pageHeight.Location = new Point(101, 72);
            pageHeight.Name = "pageHeight";
            pageHeight.Size = new Size(100, 23);
            pageHeight.TabIndex = 12;
            // 
            // A0Radio
            // 
            A0Radio.AutoSize = true;
            A0Radio.Location = new Point(141, 47);
            A0Radio.Name = "A0Radio";
            A0Radio.Size = new Size(39, 19);
            A0Radio.TabIndex = 15;
            A0Radio.TabStop = true;
            A0Radio.Text = "A0";
            PageSizeToolTip.SetToolTip(A0Radio, "46.8in by 33.1in\r\n1189mm by 841mm\r\n14043px by 9933px\r\n");
            A0Radio.UseVisualStyleBackColor = true;
            // 
            // A1Radio
            // 
            A1Radio.AutoSize = true;
            A1Radio.Location = new Point(96, 47);
            A1Radio.Name = "A1Radio";
            A1Radio.Size = new Size(39, 19);
            A1Radio.TabIndex = 6;
            A1Radio.TabStop = true;
            A1Radio.Text = "A1";
            PageSizeToolTip.SetToolTip(A1Radio, "33.1in by 23.4in\r\n841mm by 594mm\r\n9933px by 7016px");
            A1Radio.UseVisualStyleBackColor = true;
            // 
            // A2Radio
            // 
            A2Radio.AutoSize = true;
            A2Radio.Location = new Point(51, 47);
            A2Radio.Name = "A2Radio";
            A2Radio.Size = new Size(39, 19);
            A2Radio.TabIndex = 5;
            A2Radio.TabStop = true;
            A2Radio.Text = "A2";
            PageSizeToolTip.SetToolTip(A2Radio, "23.4in by 16.5in\r\n594mm by 420mm\r\n7016px by 4960px");
            A2Radio.UseVisualStyleBackColor = true;
            // 
            // A4Radio
            // 
            A4Radio.AutoSize = true;
            A4Radio.Location = new Point(141, 22);
            A4Radio.Name = "A4Radio";
            A4Radio.Size = new Size(39, 19);
            A4Radio.TabIndex = 14;
            A4Radio.TabStop = true;
            A4Radio.Text = "A4";
            PageSizeToolTip.SetToolTip(A4Radio, "11.7in by 8.3in\r\n297mm by 210mm\r\n3508px by 2480px\r\n");
            A4Radio.UseVisualStyleBackColor = true;
            // 
            // A7Radio
            // 
            A7Radio.AutoSize = true;
            A7Radio.Location = new Point(6, 22);
            A7Radio.Name = "A7Radio";
            A7Radio.Size = new Size(39, 19);
            A7Radio.TabIndex = 3;
            A7Radio.TabStop = true;
            A7Radio.Text = "A7";
            PageSizeToolTip.SetToolTip(A7Radio, "4.1in by 2.9in\r\n105mm by 74mm\r\n1240px by 874px");
            A7Radio.Checked = true;
            A7Radio.UseVisualStyleBackColor = true;
            // 
            // A5Radio
            // 
            A5Radio.AutoSize = true;
            A5Radio.Location = new Point(96, 22);
            A5Radio.Name = "A5Radio";
            A5Radio.Size = new Size(39, 19);
            A5Radio.TabIndex = 1;
            A5Radio.TabStop = true;
            A5Radio.Text = "A5";
            PageSizeToolTip.SetToolTip(A5Radio, "8.3in by 5.8in\r\n210mm by 148.5mm\r\n2480px by 1748px\r\n");
            A5Radio.UseVisualStyleBackColor = true;
            // 
            // A6Radio
            // 
            A6Radio.AutoSize = true;
            A6Radio.Location = new Point(51, 22);
            A6Radio.Name = "A6Radio";
            A6Radio.Size = new Size(39, 19);
            A6Radio.TabIndex = 4;
            A6Radio.TabStop = true;
            A6Radio.Text = "A6";
            PageSizeToolTip.SetToolTip(A6Radio, "5.8in by 4.1in\r\n148.5mm by 105mm\r\n1748px by 1240px\r\n");
            A6Radio.UseVisualStyleBackColor = true;
            // 
            // A3Radio
            // 
            A3Radio.AutoSize = true;
            A3Radio.Location = new Point(6, 47);
            A3Radio.Name = "A3Radio";
            A3Radio.Size = new Size(39, 19);
            A3Radio.TabIndex = 2;
            A3Radio.TabStop = true;
            A3Radio.Text = "A3";
            PageSizeToolTip.SetToolTip(A3Radio, "16.5in by 11.7in\r\n420mm by 297mm\r\n4960px by 3508px");
            A3Radio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 322);
            label1.Name = "label1";
            label1.Size = new Size(258, 15);
            label1.TabIndex = 14;
            label1.Text = "Made by Arisu-Sensei licensed under GNU-GPL.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 15);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 15;
            label5.Text = "Batch name:";
            // 
            // BatchName
            // 
            BatchName.Location = new Point(88, 12);
            BatchName.Name = "BatchName";
            BatchName.Size = new Size(284, 23);
            BatchName.TabIndex = 16;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(149, 337);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(91, 15);
            linkLabel1.TabIndex = 17;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Code repository";
            // 
            // GenButton
            // 
            GenButton.Location = new Point(12, 275);
            GenButton.Name = "GenButton";
            GenButton.Size = new Size(75, 44);
            GenButton.TabIndex = 18;
            GenButton.Text = "Generate";
            GenButton.UseVisualStyleBackColor = true;
            GenButton.Click += GenButton_Click;
            // 
            // GenProgress
            // 
            GenProgress.Location = new Point(93, 275);
            GenProgress.Name = "GenProgress";
            GenProgress.Size = new Size(279, 44);
            GenProgress.TabIndex = 19;
            GenProgress.Value = 0;
            GenProgress.Step = 1;
            GenProgress.Visible = true;
            // 
            // TCGTiler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(GenProgress);
            Controls.Add(GenButton);
            Controls.Add(linkLabel1);
            Controls.Add(BatchName);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(PageSizeBox);
            Controls.Add(CardSizeBox);
            Controls.Add(FolderName);
            Controls.Add(FindCardFolder);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TCGTiler";
            Text = "TCG Tiler";
            CardSizeBox.ResumeLayout(false);
            CardSizeBox.PerformLayout();
            PageSizeBox.ResumeLayout(false);
            PageSizeBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button FindCardFolder;
        private TextBox FolderName;
        private RadioButton YGORadio;
        private RadioButton MTGRadio;
        private RadioButton CustomCardRadio;
        private TextBox cardHeight;
        private TextBox cardWidth;
        private Label Label;
        private Label size;
        private Label label2;
        private GroupBox CardSizeBox;
        private GroupBox PageSizeBox;
        private RadioButton A7Radio;
        private RadioButton A5Radio;
        private RadioButton A6Radio;
        private RadioButton A3Radio;
        private RadioButton A2Radio;
        private RadioButton A1Radio;
        private RadioButton A4Radio;
        private Label label4;
        private Label label3;
        private TextBox pageWidth;
        private RadioButton CustomPageRadio;
        private TextBox pageHeight;
        private RadioButton A0Radio;
        private Label label1;
        private Label label5;
        private TextBox BatchName;
        private LinkLabel linkLabel1;
        private Button GenButton;
        private ProgressBar GenProgress;
        private ToolTip CardSizeToolTip;
        private ToolTip PageSizeToolTip;
    }
}