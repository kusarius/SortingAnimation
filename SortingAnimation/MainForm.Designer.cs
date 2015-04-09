namespace SortingAnimation {
    partial class MainForm {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.canvasPanel = new System.Windows.Forms.Panel();
            this.qsortRadioButton = new System.Windows.Forms.RadioButton();
            this.mergesortRadioButton = new System.Windows.Forms.RadioButton();
            this.heapsortRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.funiqueRadioButton = new System.Windows.Forms.RadioButton();
            this.randomRadioButton = new System.Windows.Forms.RadioButton();
            this.reversedRadioButton = new System.Windows.Forms.RadioButton();
            this.nsortedRadioButton = new System.Windows.Forms.RadioButton();
            this.genArrayButton = new System.Windows.Forms.Button();
            this.startAlgoButton = new System.Windows.Forms.Button();
            this.clearCanvasButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.animSpeedTrackBar = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animSpeedTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // canvasPanel
            // 
            this.canvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvasPanel.Location = new System.Drawing.Point(-1, -1);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(631, 564);
            this.canvasPanel.TabIndex = 0;
            this.canvasPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.canvasPanel_Paint);
            // 
            // qsortRadioButton
            // 
            this.qsortRadioButton.AutoSize = true;
            this.qsortRadioButton.Checked = true;
            this.qsortRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qsortRadioButton.Location = new System.Drawing.Point(12, 25);
            this.qsortRadioButton.Name = "qsortRadioButton";
            this.qsortRadioButton.Size = new System.Drawing.Size(86, 21);
            this.qsortRadioButton.TabIndex = 1;
            this.qsortRadioButton.TabStop = true;
            this.qsortRadioButton.Text = "Quick Sort";
            this.qsortRadioButton.UseVisualStyleBackColor = true;
            // 
            // mergesortRadioButton
            // 
            this.mergesortRadioButton.AutoSize = true;
            this.mergesortRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mergesortRadioButton.Location = new System.Drawing.Point(12, 48);
            this.mergesortRadioButton.Name = "mergesortRadioButton";
            this.mergesortRadioButton.Size = new System.Drawing.Size(93, 21);
            this.mergesortRadioButton.TabIndex = 3;
            this.mergesortRadioButton.Text = "Merge Sort";
            this.mergesortRadioButton.UseVisualStyleBackColor = true;
            // 
            // heapsortRadioButton
            // 
            this.heapsortRadioButton.AutoSize = true;
            this.heapsortRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heapsortRadioButton.Location = new System.Drawing.Point(12, 71);
            this.heapsortRadioButton.Name = "heapsortRadioButton";
            this.heapsortRadioButton.Size = new System.Drawing.Size(85, 21);
            this.heapsortRadioButton.TabIndex = 4;
            this.heapsortRadioButton.Text = "Heap Sort";
            this.heapsortRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.qsortRadioButton);
            this.groupBox1.Controls.Add(this.heapsortRadioButton);
            this.groupBox1.Controls.Add(this.mergesortRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox1.Location = new System.Drawing.Point(639, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 102);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sorting algorithm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.funiqueRadioButton);
            this.groupBox2.Controls.Add(this.randomRadioButton);
            this.groupBox2.Controls.Add(this.reversedRadioButton);
            this.groupBox2.Controls.Add(this.nsortedRadioButton);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox2.Location = new System.Drawing.Point(639, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 125);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Initial condition";
            // 
            // funiqueRadioButton
            // 
            this.funiqueRadioButton.AutoSize = true;
            this.funiqueRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.funiqueRadioButton.Location = new System.Drawing.Point(12, 95);
            this.funiqueRadioButton.Name = "funiqueRadioButton";
            this.funiqueRadioButton.Size = new System.Drawing.Size(93, 21);
            this.funiqueRadioButton.TabIndex = 5;
            this.funiqueRadioButton.Text = "Few Unique";
            this.funiqueRadioButton.UseVisualStyleBackColor = true;
            // 
            // randomRadioButton
            // 
            this.randomRadioButton.AutoSize = true;
            this.randomRadioButton.Checked = true;
            this.randomRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.randomRadioButton.Location = new System.Drawing.Point(12, 25);
            this.randomRadioButton.Name = "randomRadioButton";
            this.randomRadioButton.Size = new System.Drawing.Size(75, 21);
            this.randomRadioButton.TabIndex = 1;
            this.randomRadioButton.TabStop = true;
            this.randomRadioButton.Text = "Random";
            this.randomRadioButton.UseVisualStyleBackColor = true;
            // 
            // reversedRadioButton
            // 
            this.reversedRadioButton.AutoSize = true;
            this.reversedRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reversedRadioButton.Location = new System.Drawing.Point(12, 71);
            this.reversedRadioButton.Name = "reversedRadioButton";
            this.reversedRadioButton.Size = new System.Drawing.Size(80, 21);
            this.reversedRadioButton.TabIndex = 4;
            this.reversedRadioButton.Text = "Reversed";
            this.reversedRadioButton.UseVisualStyleBackColor = true;
            // 
            // nsortedRadioButton
            // 
            this.nsortedRadioButton.AutoSize = true;
            this.nsortedRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nsortedRadioButton.Location = new System.Drawing.Point(12, 48);
            this.nsortedRadioButton.Name = "nsortedRadioButton";
            this.nsortedRadioButton.Size = new System.Drawing.Size(107, 21);
            this.nsortedRadioButton.TabIndex = 3;
            this.nsortedRadioButton.Text = "Nearly Sorted";
            this.nsortedRadioButton.UseVisualStyleBackColor = true;
            // 
            // genArrayButton
            // 
            this.genArrayButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.genArrayButton.Location = new System.Drawing.Point(639, 315);
            this.genArrayButton.Name = "genArrayButton";
            this.genArrayButton.Size = new System.Drawing.Size(136, 28);
            this.genArrayButton.TabIndex = 7;
            this.genArrayButton.Text = "Generate array";
            this.genArrayButton.UseVisualStyleBackColor = true;
            this.genArrayButton.Click += new System.EventHandler(this.genArrayButton_Click);
            // 
            // startAlgoButton
            // 
            this.startAlgoButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.startAlgoButton.Location = new System.Drawing.Point(639, 349);
            this.startAlgoButton.Name = "startAlgoButton";
            this.startAlgoButton.Size = new System.Drawing.Size(136, 28);
            this.startAlgoButton.TabIndex = 8;
            this.startAlgoButton.Text = "Start algorithm";
            this.startAlgoButton.UseVisualStyleBackColor = true;
            this.startAlgoButton.Click += new System.EventHandler(this.startAlgoButton_Click);
            // 
            // clearCanvasButton
            // 
            this.clearCanvasButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.clearCanvasButton.Location = new System.Drawing.Point(639, 383);
            this.clearCanvasButton.Name = "clearCanvasButton";
            this.clearCanvasButton.Size = new System.Drawing.Size(136, 28);
            this.clearCanvasButton.TabIndex = 9;
            this.clearCanvasButton.Text = "Clear canvas";
            this.clearCanvasButton.UseVisualStyleBackColor = true;
            this.clearCanvasButton.Click += new System.EventHandler(this.clearCanvasButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.animSpeedTrackBar);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox3.Location = new System.Drawing.Point(639, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(136, 62);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Animation speed";
            // 
            // animSpeedTrackBar
            // 
            this.animSpeedTrackBar.AutoSize = false;
            this.animSpeedTrackBar.LargeChange = 50;
            this.animSpeedTrackBar.Location = new System.Drawing.Point(6, 24);
            this.animSpeedTrackBar.Maximum = 200;
            this.animSpeedTrackBar.Minimum = 1;
            this.animSpeedTrackBar.Name = "animSpeedTrackBar";
            this.animSpeedTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.animSpeedTrackBar.RightToLeftLayout = true;
            this.animSpeedTrackBar.Size = new System.Drawing.Size(124, 30);
            this.animSpeedTrackBar.SmallChange = 10;
            this.animSpeedTrackBar.TabIndex = 0;
            this.animSpeedTrackBar.TickFrequency = 40;
            this.animSpeedTrackBar.Value = 50;
            //this.animSpeedTrackBar.Scroll += new System.EventHandler(this.animSpeedTrackBar_Scroll);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.clearCanvasButton);
            this.Controls.Add(this.startAlgoButton);
            this.Controls.Add(this.genArrayButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.canvasPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "SortingAnimation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.animSpeedTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel canvasPanel;
        private System.Windows.Forms.RadioButton qsortRadioButton;
        private System.Windows.Forms.RadioButton mergesortRadioButton;
        private System.Windows.Forms.RadioButton heapsortRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton funiqueRadioButton;
        private System.Windows.Forms.RadioButton randomRadioButton;
        private System.Windows.Forms.RadioButton reversedRadioButton;
        private System.Windows.Forms.RadioButton nsortedRadioButton;
        private System.Windows.Forms.Button genArrayButton;
        private System.Windows.Forms.Button startAlgoButton;
        private System.Windows.Forms.Button clearCanvasButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar animSpeedTrackBar;
    }
}

