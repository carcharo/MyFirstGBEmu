namespace MyFirstGBEmu
{
    partial class MainScreen
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
            this.loadROMBtn = new System.Windows.Forms.Button();
            this.messagesText = new System.Windows.Forms.TextBox();
            this.cpuInstrucList = new System.Windows.Forms.ListBox();
            this.zeroFlagBox = new System.Windows.Forms.CheckBox();
            this.underFlowBox = new System.Windows.Forms.CheckBox();
            this.nibbleOverBox = new System.Windows.Forms.CheckBox();
            this.fullOverBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AFRegText = new System.Windows.Forms.TextBox();
            this.BCRegText = new System.Windows.Forms.TextBox();
            this.DERegText = new System.Windows.Forms.TextBox();
            this.HLRegText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pcBox = new System.Windows.Forms.TextBox();
            this.spBox = new System.Windows.Forms.TextBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.stepOneBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadROMBtn
            // 
            this.loadROMBtn.Location = new System.Drawing.Point(12, 12);
            this.loadROMBtn.Name = "loadROMBtn";
            this.loadROMBtn.Size = new System.Drawing.Size(215, 36);
            this.loadROMBtn.TabIndex = 0;
            this.loadROMBtn.Text = "Load ROM";
            this.loadROMBtn.UseVisualStyleBackColor = true;
            // 
            // messagesText
            // 
            this.messagesText.Location = new System.Drawing.Point(18, 357);
            this.messagesText.Multiline = true;
            this.messagesText.Name = "messagesText";
            this.messagesText.ReadOnly = true;
            this.messagesText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.messagesText.Size = new System.Drawing.Size(1164, 124);
            this.messagesText.TabIndex = 1;
            // 
            // cpuInstrucList
            // 
            this.cpuInstrucList.FormattingEnabled = true;
            this.cpuInstrucList.Location = new System.Drawing.Point(686, 8);
            this.cpuInstrucList.MultiColumn = true;
            this.cpuInstrucList.Name = "cpuInstrucList";
            this.cpuInstrucList.Size = new System.Drawing.Size(316, 329);
            this.cpuInstrucList.TabIndex = 2;
            // 
            // zeroFlagBox
            // 
            this.zeroFlagBox.AutoSize = true;
            this.zeroFlagBox.Location = new System.Drawing.Point(1032, 8);
            this.zeroFlagBox.Name = "zeroFlagBox";
            this.zeroFlagBox.Size = new System.Drawing.Size(71, 17);
            this.zeroFlagBox.TabIndex = 3;
            this.zeroFlagBox.Text = "Zero Flag";
            this.zeroFlagBox.UseVisualStyleBackColor = true;
            // 
            // underFlowBox
            // 
            this.underFlowBox.AutoSize = true;
            this.underFlowBox.Location = new System.Drawing.Point(1032, 31);
            this.underFlowBox.Name = "underFlowBox";
            this.underFlowBox.Size = new System.Drawing.Size(97, 17);
            this.underFlowBox.TabIndex = 4;
            this.underFlowBox.Text = "Underflow Flag";
            this.underFlowBox.UseVisualStyleBackColor = true;
            // 
            // nibbleOverBox
            // 
            this.nibbleOverBox.AutoSize = true;
            this.nibbleOverBox.Location = new System.Drawing.Point(1032, 54);
            this.nibbleOverBox.Name = "nibbleOverBox";
            this.nibbleOverBox.Size = new System.Drawing.Size(124, 17);
            this.nibbleOverBox.TabIndex = 5;
            this.nibbleOverBox.Text = "Nibble Overflow Flag";
            this.nibbleOverBox.UseVisualStyleBackColor = true;
            // 
            // fullOverBox
            // 
            this.fullOverBox.AutoSize = true;
            this.fullOverBox.Location = new System.Drawing.Point(1032, 77);
            this.fullOverBox.Name = "fullOverBox";
            this.fullOverBox.Size = new System.Drawing.Size(110, 17);
            this.fullOverBox.TabIndex = 6;
            this.fullOverBox.Text = "Full Overflow Flag";
            this.fullOverBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1032, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "AF Register";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1031, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "BC Register";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1030, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "DE Register";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1031, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "HL Register";
            // 
            // AFRegText
            // 
            this.AFRegText.Location = new System.Drawing.Point(1111, 118);
            this.AFRegText.Name = "AFRegText";
            this.AFRegText.ReadOnly = true;
            this.AFRegText.Size = new System.Drawing.Size(45, 20);
            this.AFRegText.TabIndex = 11;
            // 
            // BCRegText
            // 
            this.BCRegText.Location = new System.Drawing.Point(1111, 137);
            this.BCRegText.Name = "BCRegText";
            this.BCRegText.ReadOnly = true;
            this.BCRegText.Size = new System.Drawing.Size(45, 20);
            this.BCRegText.TabIndex = 12;
            // 
            // DERegText
            // 
            this.DERegText.Location = new System.Drawing.Point(1111, 156);
            this.DERegText.Name = "DERegText";
            this.DERegText.ReadOnly = true;
            this.DERegText.Size = new System.Drawing.Size(45, 20);
            this.DERegText.TabIndex = 13;
            // 
            // HLRegText
            // 
            this.HLRegText.Location = new System.Drawing.Point(1111, 175);
            this.HLRegText.Name = "HLRegText";
            this.HLRegText.ReadOnly = true;
            this.HLRegText.Size = new System.Drawing.Size(45, 20);
            this.HLRegText.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1029, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Stack Pointer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1014, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Program Counter";
            // 
            // pcBox
            // 
            this.pcBox.Location = new System.Drawing.Point(1111, 225);
            this.pcBox.Name = "pcBox";
            this.pcBox.ReadOnly = true;
            this.pcBox.Size = new System.Drawing.Size(45, 20);
            this.pcBox.TabIndex = 18;
            // 
            // spBox
            // 
            this.spBox.Location = new System.Drawing.Point(1111, 206);
            this.spBox.Name = "spBox";
            this.spBox.ReadOnly = true;
            this.spBox.Size = new System.Drawing.Size(45, 20);
            this.spBox.TabIndex = 17;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(12, 58);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(215, 36);
            this.resetBtn.TabIndex = 20;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            // 
            // stepOneBtn
            // 
            this.stepOneBtn.Location = new System.Drawing.Point(12, 109);
            this.stepOneBtn.Name = "stepOneBtn";
            this.stepOneBtn.Size = new System.Drawing.Size(215, 36);
            this.stepOneBtn.TabIndex = 21;
            this.stepOneBtn.Text = "Step Instruction";
            this.stepOneBtn.UseVisualStyleBackColor = true;
            this.stepOneBtn.Click += new System.EventHandler(this.stepOneBtn_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 490);
            this.Controls.Add(this.stepOneBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.pcBox);
            this.Controls.Add(this.spBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.HLRegText);
            this.Controls.Add(this.DERegText);
            this.Controls.Add(this.BCRegText);
            this.Controls.Add(this.AFRegText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fullOverBox);
            this.Controls.Add(this.nibbleOverBox);
            this.Controls.Add(this.underFlowBox);
            this.Controls.Add(this.zeroFlagBox);
            this.Controls.Add(this.cpuInstrucList);
            this.Controls.Add(this.messagesText);
            this.Controls.Add(this.loadROMBtn);
            this.Name = "MainScreen";
            this.Text = "My First GB Emulator";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadROMBtn;
        private System.Windows.Forms.TextBox messagesText;
        private System.Windows.Forms.ListBox cpuInstrucList;
        private System.Windows.Forms.CheckBox zeroFlagBox;
        private System.Windows.Forms.CheckBox underFlowBox;
        private System.Windows.Forms.CheckBox nibbleOverBox;
        private System.Windows.Forms.CheckBox fullOverBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AFRegText;
        private System.Windows.Forms.TextBox BCRegText;
        private System.Windows.Forms.TextBox DERegText;
        private System.Windows.Forms.TextBox HLRegText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pcBox;
        private System.Windows.Forms.TextBox spBox;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button stepOneBtn;
    }
}

