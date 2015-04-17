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

            if (sortWork != null && sortWork.IsAlive) 
                sortWork.Abort();

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
            this.selectionSortRadioButton = new System.Windows.Forms.RadioButton();
            this.shakerSortRadioButton = new System.Windows.Forms.RadioButton();
            this.insertionSortRadioButton = new System.Windows.Forms.RadioButton();
            this.bubbleSortRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.elCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.funiqueRadioButton = new System.Windows.Forms.RadioButton();
            this.randomRadioButton = new System.Windows.Forms.RadioButton();
            this.reversedRadioButton = new System.Windows.Forms.RadioButton();
            this.nsortedRadioButton = new System.Windows.Forms.RadioButton();
            this.genArrayButton = new System.Windows.Forms.Button();
            this.startAlgoButton = new System.Windows.Forms.Button();
            this.clearCanvasButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.animSpeedTrackBar = new System.Windows.Forms.TrackBar();
            this.stomAlgoButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elCountNumericUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animSpeedTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // canvasPanel
            // 
            this.canvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvasPanel.Location = new System.Drawing.Point(-1, -1);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(632, 564);
            this.canvasPanel.TabIndex = 0;
            this.canvasPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.canvasPanel_Paint);
            // 
            // qsortRadioButton
            // 
            this.qsortRadioButton.AutoSize = true;
            this.qsortRadioButton.Checked = true;
            this.qsortRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qsortRadioButton.Location = new System.Drawing.Point(12, 23);
            this.qsortRadioButton.Name = "qsortRadioButton";
            this.qsortRadioButton.Size = new System.Drawing.Size(149, 21);
            this.qsortRadioButton.TabIndex = 1;
            this.qsortRadioButton.TabStop = true;
            this.qsortRadioButton.Text = "Быстрая сортировка";
            this.qsortRadioButton.UseVisualStyleBackColor = true;
            // 
            // mergesortRadioButton
            // 
            this.mergesortRadioButton.AutoSize = true;
            this.mergesortRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mergesortRadioButton.Location = new System.Drawing.Point(12, 46);
            this.mergesortRadioButton.Name = "mergesortRadioButton";
            this.mergesortRadioButton.Size = new System.Drawing.Size(159, 21);
            this.mergesortRadioButton.TabIndex = 3;
            this.mergesortRadioButton.Text = "Сортировка слиянием";
            this.mergesortRadioButton.UseVisualStyleBackColor = true;
            // 
            // heapsortRadioButton
            // 
            this.heapsortRadioButton.AutoSize = true;
            this.heapsortRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heapsortRadioButton.Location = new System.Drawing.Point(12, 69);
            this.heapsortRadioButton.Name = "heapsortRadioButton";
            this.heapsortRadioButton.Size = new System.Drawing.Size(196, 21);
            this.heapsortRadioButton.TabIndex = 4;
            this.heapsortRadioButton.Text = "Пирамидальная сортировка";
            this.heapsortRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.selectionSortRadioButton);
            this.groupBox1.Controls.Add(this.shakerSortRadioButton);
            this.groupBox1.Controls.Add(this.insertionSortRadioButton);
            this.groupBox1.Controls.Add(this.bubbleSortRadioButton);
            this.groupBox1.Controls.Add(this.qsortRadioButton);
            this.groupBox1.Controls.Add(this.heapsortRadioButton);
            this.groupBox1.Controls.Add(this.mergesortRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox1.Location = new System.Drawing.Point(639, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 189);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Алгоритм сортировки";
            // 
            // selectionSortRadioButton
            // 
            this.selectionSortRadioButton.AutoSize = true;
            this.selectionSortRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectionSortRadioButton.Location = new System.Drawing.Point(12, 161);
            this.selectionSortRadioButton.Name = "selectionSortRadioButton";
            this.selectionSortRadioButton.Size = new System.Drawing.Size(159, 21);
            this.selectionSortRadioButton.TabIndex = 8;
            this.selectionSortRadioButton.Text = "Сортировка выбором";
            this.selectionSortRadioButton.UseVisualStyleBackColor = true;
            // 
            // shakerSortRadioButton
            // 
            this.shakerSortRadioButton.AutoSize = true;
            this.shakerSortRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shakerSortRadioButton.Location = new System.Drawing.Point(12, 138);
            this.shakerSortRadioButton.Name = "shakerSortRadioButton";
            this.shakerSortRadioButton.Size = new System.Drawing.Size(169, 21);
            this.shakerSortRadioButton.TabIndex = 7;
            this.shakerSortRadioButton.Text = "Шейкерная сортировка";
            this.shakerSortRadioButton.UseVisualStyleBackColor = true;
            // 
            // insertionSortRadioButton
            // 
            this.insertionSortRadioButton.AutoSize = true;
            this.insertionSortRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insertionSortRadioButton.Location = new System.Drawing.Point(12, 115);
            this.insertionSortRadioButton.Name = "insertionSortRadioButton";
            this.insertionSortRadioButton.Size = new System.Drawing.Size(163, 21);
            this.insertionSortRadioButton.TabIndex = 6;
            this.insertionSortRadioButton.Text = "Сортировка вставками";
            this.insertionSortRadioButton.UseVisualStyleBackColor = true;
            // 
            // bubbleSortRadioButton
            // 
            this.bubbleSortRadioButton.AutoSize = true;
            this.bubbleSortRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bubbleSortRadioButton.Location = new System.Drawing.Point(12, 92);
            this.bubbleSortRadioButton.Name = "bubbleSortRadioButton";
            this.bubbleSortRadioButton.Size = new System.Drawing.Size(180, 21);
            this.bubbleSortRadioButton.TabIndex = 5;
            this.bubbleSortRadioButton.Text = "Пузырьковая сортировка";
            this.bubbleSortRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.elCountNumericUpDown);
            this.groupBox2.Controls.Add(this.funiqueRadioButton);
            this.groupBox2.Controls.Add(this.randomRadioButton);
            this.groupBox2.Controls.Add(this.reversedRadioButton);
            this.groupBox2.Controls.Add(this.nsortedRadioButton);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox2.Location = new System.Drawing.Point(639, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 126);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Начальное состояние";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(9, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Количество элементов:";
            this.label1.Visible = false;
            // 
            // elCountNumericUpDown
            // 
            this.elCountNumericUpDown.Enabled = false;
            this.elCountNumericUpDown.Location = new System.Drawing.Point(159, 129);
            this.elCountNumericUpDown.Maximum = new decimal(new int[] {
            63,
            0,
            0,
            0});
            this.elCountNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.elCountNumericUpDown.Name = "elCountNumericUpDown";
            this.elCountNumericUpDown.Size = new System.Drawing.Size(44, 25);
            this.elCountNumericUpDown.TabIndex = 10;
            this.elCountNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.elCountNumericUpDown.Visible = false;
            // 
            // funiqueRadioButton
            // 
            this.funiqueRadioButton.AutoSize = true;
            this.funiqueRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.funiqueRadioButton.Location = new System.Drawing.Point(12, 95);
            this.funiqueRadioButton.Name = "funiqueRadioButton";
            this.funiqueRadioButton.Size = new System.Drawing.Size(162, 21);
            this.funiqueRadioButton.TabIndex = 5;
            this.funiqueRadioButton.Text = "Одинаковые элементы";
            this.funiqueRadioButton.UseVisualStyleBackColor = true;
            // 
            // randomRadioButton
            // 
            this.randomRadioButton.AutoSize = true;
            this.randomRadioButton.Checked = true;
            this.randomRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.randomRadioButton.Location = new System.Drawing.Point(12, 25);
            this.randomRadioButton.Name = "randomRadioButton";
            this.randomRadioButton.Size = new System.Drawing.Size(120, 21);
            this.randomRadioButton.TabIndex = 1;
            this.randomRadioButton.TabStop = true;
            this.randomRadioButton.Text = "Перемешанное";
            this.randomRadioButton.UseVisualStyleBackColor = true;
            // 
            // reversedRadioButton
            // 
            this.reversedRadioButton.AutoSize = true;
            this.reversedRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reversedRadioButton.Location = new System.Drawing.Point(12, 71);
            this.reversedRadioButton.Name = "reversedRadioButton";
            this.reversedRadioButton.Size = new System.Drawing.Size(151, 21);
            this.reversedRadioButton.TabIndex = 4;
            this.reversedRadioButton.Text = "В обратном порядке";
            this.reversedRadioButton.UseVisualStyleBackColor = true;
            // 
            // nsortedRadioButton
            // 
            this.nsortedRadioButton.AutoSize = true;
            this.nsortedRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nsortedRadioButton.Location = new System.Drawing.Point(12, 48);
            this.nsortedRadioButton.Name = "nsortedRadioButton";
            this.nsortedRadioButton.Size = new System.Drawing.Size(172, 21);
            this.nsortedRadioButton.TabIndex = 3;
            this.nsortedRadioButton.Text = "Почти отсортированное";
            this.nsortedRadioButton.UseVisualStyleBackColor = true;
            // 
            // genArrayButton
            // 
            this.genArrayButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.genArrayButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.genArrayButton.Location = new System.Drawing.Point(639, 403);
            this.genArrayButton.Name = "genArrayButton";
            this.genArrayButton.Size = new System.Drawing.Size(216, 28);
            this.genArrayButton.TabIndex = 7;
            this.genArrayButton.Text = "Сгенерировать массив";
            this.genArrayButton.UseVisualStyleBackColor = true;
            this.genArrayButton.Click += new System.EventHandler(this.genArrayButton_Click);
            // 
            // startAlgoButton
            // 
            this.startAlgoButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startAlgoButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.startAlgoButton.Location = new System.Drawing.Point(639, 434);
            this.startAlgoButton.Name = "startAlgoButton";
            this.startAlgoButton.Size = new System.Drawing.Size(216, 28);
            this.startAlgoButton.TabIndex = 8;
            this.startAlgoButton.Text = "Запустить алгоритм";
            this.startAlgoButton.UseVisualStyleBackColor = true;
            this.startAlgoButton.Click += new System.EventHandler(this.startAlgoButton_Click);
            // 
            // clearCanvasButton
            // 
            this.clearCanvasButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clearCanvasButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.clearCanvasButton.Location = new System.Drawing.Point(639, 496);
            this.clearCanvasButton.Name = "clearCanvasButton";
            this.clearCanvasButton.Size = new System.Drawing.Size(216, 28);
            this.clearCanvasButton.TabIndex = 9;
            this.clearCanvasButton.Text = "Очистить поле";
            this.clearCanvasButton.UseVisualStyleBackColor = true;
            this.clearCanvasButton.Click += new System.EventHandler(this.clearCanvasButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.animSpeedTrackBar);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox3.Location = new System.Drawing.Point(639, 335);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(216, 62);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Скорость анимации";
            // 
            // animSpeedTrackBar
            // 
            this.animSpeedTrackBar.AutoSize = false;
            this.animSpeedTrackBar.LargeChange = 20;
            this.animSpeedTrackBar.Location = new System.Drawing.Point(6, 24);
            this.animSpeedTrackBar.Maximum = 200;
            this.animSpeedTrackBar.Name = "animSpeedTrackBar";
            this.animSpeedTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.animSpeedTrackBar.RightToLeftLayout = true;
            this.animSpeedTrackBar.Size = new System.Drawing.Size(203, 30);
            this.animSpeedTrackBar.SmallChange = 10;
            this.animSpeedTrackBar.TabIndex = 0;
            this.animSpeedTrackBar.TickFrequency = 20;
            this.animSpeedTrackBar.Value = 50;
            // 
            // stomAlgoButton
            // 
            this.stomAlgoButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stomAlgoButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.stomAlgoButton.Location = new System.Drawing.Point(639, 465);
            this.stomAlgoButton.Name = "stomAlgoButton";
            this.stomAlgoButton.Size = new System.Drawing.Size(216, 28);
            this.stomAlgoButton.TabIndex = 10;
            this.stomAlgoButton.Text = "Остановить алгоритм";
            this.stomAlgoButton.UseVisualStyleBackColor = true;
            this.stomAlgoButton.Click += new System.EventHandler(this.stopAlgoButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 562);
            this.Controls.Add(this.stomAlgoButton);
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
            ((System.ComponentModel.ISupportInitialize)(this.elCountNumericUpDown)).EndInit();
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
        private System.Windows.Forms.RadioButton insertionSortRadioButton;
        private System.Windows.Forms.RadioButton bubbleSortRadioButton;
        private System.Windows.Forms.RadioButton shakerSortRadioButton;
        private System.Windows.Forms.RadioButton selectionSortRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown elCountNumericUpDown;
        private System.Windows.Forms.Button stomAlgoButton;
    }
}

