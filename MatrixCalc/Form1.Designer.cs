
namespace MatrixCalc
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CB1_M1 = new System.Windows.Forms.ComboBox();
            this.CB2_M1 = new System.Windows.Forms.ComboBox();
            this.Clear_button = new System.Windows.Forms.Button();
            this.transpose_M1 = new System.Windows.Forms.Button();
            this.multiply_M1 = new System.Windows.Forms.Button();
            this.textBox_M1 = new System.Windows.Forms.TextBox();
            this.deter_M1 = new System.Windows.Forms.Button();
            this.inverse_M1 = new System.Windows.Forms.Button();
            this.inverse_M2 = new System.Windows.Forms.Button();
            this.deter_M2 = new System.Windows.Forms.Button();
            this.textBox_M2 = new System.Windows.Forms.TextBox();
            this.multiply_M2 = new System.Windows.Forms.Button();
            this.transpose_M2 = new System.Windows.Forms.Button();
            this.Clear_button_M2 = new System.Windows.Forms.Button();
            this.CB2_M2 = new System.Windows.Forms.ComboBox();
            this.CB1_M2 = new System.Windows.Forms.ComboBox();
            this.sum_button = new System.Windows.Forms.Button();
            this.subtract_button = new System.Windows.Forms.Button();
            this.multiply_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.copy_M1 = new System.Windows.Forms.Button();
            this.copy_M2 = new System.Windows.Forms.Button();
            this.label_M2 = new System.Windows.Forms.Label();
            this.label_M1 = new System.Windows.Forms.Label();
            this.division_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // CB1_M1
            // 
            this.CB1_M1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CB1_M1.FormattingEnabled = true;
            this.CB1_M1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.CB1_M1.Location = new System.Drawing.Point(178, 353);
            this.CB1_M1.Margin = new System.Windows.Forms.Padding(2);
            this.CB1_M1.Name = "CB1_M1";
            this.CB1_M1.Size = new System.Drawing.Size(42, 24);
            this.CB1_M1.TabIndex = 6;
            this.CB1_M1.SelectedIndexChanged += new System.EventHandler(this.CB1_M1_SelectedIndexChanged);
            // 
            // CB2_M1
            // 
            this.CB2_M1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CB2_M1.FormattingEnabled = true;
            this.CB2_M1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.CB2_M1.Location = new System.Drawing.Point(249, 353);
            this.CB2_M1.Margin = new System.Windows.Forms.Padding(2);
            this.CB2_M1.Name = "CB2_M1";
            this.CB2_M1.Size = new System.Drawing.Size(42, 24);
            this.CB2_M1.TabIndex = 7;
            this.CB2_M1.SelectedIndexChanged += new System.EventHandler(this.CB1_M1_SelectedIndexChanged);
            // 
            // Clear_button
            // 
            this.Clear_button.Location = new System.Drawing.Point(48, 353);
            this.Clear_button.Margin = new System.Windows.Forms.Padding(2);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(112, 24);
            this.Clear_button.TabIndex = 8;
            this.Clear_button.Text = "Очистить";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_M1_Click);
            // 
            // transpose_M1
            // 
            this.transpose_M1.Location = new System.Drawing.Point(48, 390);
            this.transpose_M1.Margin = new System.Windows.Forms.Padding(2);
            this.transpose_M1.Name = "transpose_M1";
            this.transpose_M1.Size = new System.Drawing.Size(112, 24);
            this.transpose_M1.TabIndex = 9;
            this.transpose_M1.Text = "Транспонировать";
            this.transpose_M1.UseVisualStyleBackColor = true;
            this.transpose_M1.Click += new System.EventHandler(this.transpose_M1_Click);
            // 
            // multiply_M1
            // 
            this.multiply_M1.Location = new System.Drawing.Point(176, 390);
            this.multiply_M1.Margin = new System.Windows.Forms.Padding(2);
            this.multiply_M1.Name = "multiply_M1";
            this.multiply_M1.Size = new System.Drawing.Size(79, 24);
            this.multiply_M1.TabIndex = 10;
            this.multiply_M1.Text = "Умножить на";
            this.multiply_M1.UseVisualStyleBackColor = true;
            this.multiply_M1.Click += new System.EventHandler(this.multiply_M1_Click);
            // 
            // textBox_M1
            // 
            this.textBox_M1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_M1.Location = new System.Drawing.Point(260, 390);
            this.textBox_M1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_M1.Name = "textBox_M1";
            this.textBox_M1.Size = new System.Drawing.Size(32, 24);
            this.textBox_M1.TabIndex = 11;
            this.textBox_M1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_M1_KeyPress);
            // 
            // deter_M1
            // 
            this.deter_M1.Location = new System.Drawing.Point(48, 429);
            this.deter_M1.Margin = new System.Windows.Forms.Padding(2);
            this.deter_M1.Name = "deter_M1";
            this.deter_M1.Size = new System.Drawing.Size(112, 24);
            this.deter_M1.TabIndex = 12;
            this.deter_M1.Text = "Определитель";
            this.deter_M1.UseVisualStyleBackColor = true;
            this.deter_M1.Click += new System.EventHandler(this.deter_M1_Click);
            // 
            // inverse_M1
            // 
            this.inverse_M1.Location = new System.Drawing.Point(178, 429);
            this.inverse_M1.Margin = new System.Windows.Forms.Padding(2);
            this.inverse_M1.Name = "inverse_M1";
            this.inverse_M1.Size = new System.Drawing.Size(112, 24);
            this.inverse_M1.TabIndex = 13;
            this.inverse_M1.Text = "Обратная матрица";
            this.inverse_M1.UseVisualStyleBackColor = true;
            this.inverse_M1.Click += new System.EventHandler(this.inverse_M1_Click);
            // 
            // inverse_M2
            // 
            this.inverse_M2.Location = new System.Drawing.Point(604, 429);
            this.inverse_M2.Margin = new System.Windows.Forms.Padding(2);
            this.inverse_M2.Name = "inverse_M2";
            this.inverse_M2.Size = new System.Drawing.Size(112, 24);
            this.inverse_M2.TabIndex = 21;
            this.inverse_M2.Text = "Обратная матрица";
            this.inverse_M2.UseVisualStyleBackColor = true;
            this.inverse_M2.Click += new System.EventHandler(this.inverse_M2_Click);
            // 
            // deter_M2
            // 
            this.deter_M2.Location = new System.Drawing.Point(475, 429);
            this.deter_M2.Margin = new System.Windows.Forms.Padding(2);
            this.deter_M2.Name = "deter_M2";
            this.deter_M2.Size = new System.Drawing.Size(112, 24);
            this.deter_M2.TabIndex = 20;
            this.deter_M2.Text = "Определитель";
            this.deter_M2.UseVisualStyleBackColor = true;
            this.deter_M2.Click += new System.EventHandler(this.deter_M2_Click);
            // 
            // textBox_M2
            // 
            this.textBox_M2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_M2.Location = new System.Drawing.Point(686, 390);
            this.textBox_M2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_M2.Name = "textBox_M2";
            this.textBox_M2.Size = new System.Drawing.Size(32, 24);
            this.textBox_M2.TabIndex = 19;
            this.textBox_M2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_M1_KeyPress);
            // 
            // multiply_M2
            // 
            this.multiply_M2.Location = new System.Drawing.Point(603, 390);
            this.multiply_M2.Margin = new System.Windows.Forms.Padding(2);
            this.multiply_M2.Name = "multiply_M2";
            this.multiply_M2.Size = new System.Drawing.Size(79, 24);
            this.multiply_M2.TabIndex = 18;
            this.multiply_M2.Text = "Умножить на";
            this.multiply_M2.UseVisualStyleBackColor = true;
            this.multiply_M2.Click += new System.EventHandler(this.multiply_M2_Click);
            // 
            // transpose_M2
            // 
            this.transpose_M2.Location = new System.Drawing.Point(475, 390);
            this.transpose_M2.Margin = new System.Windows.Forms.Padding(2);
            this.transpose_M2.Name = "transpose_M2";
            this.transpose_M2.Size = new System.Drawing.Size(112, 24);
            this.transpose_M2.TabIndex = 17;
            this.transpose_M2.Text = "Транспонировать";
            this.transpose_M2.UseVisualStyleBackColor = true;
            this.transpose_M2.Click += new System.EventHandler(this.transpose_M1_Click);
            // 
            // Clear_button_M2
            // 
            this.Clear_button_M2.Location = new System.Drawing.Point(475, 353);
            this.Clear_button_M2.Margin = new System.Windows.Forms.Padding(2);
            this.Clear_button_M2.Name = "Clear_button_M2";
            this.Clear_button_M2.Size = new System.Drawing.Size(112, 24);
            this.Clear_button_M2.TabIndex = 16;
            this.Clear_button_M2.Text = "Очистить";
            this.Clear_button_M2.UseVisualStyleBackColor = true;
            this.Clear_button_M2.Click += new System.EventHandler(this.Clear_button_M2_Click);
            // 
            // CB2_M2
            // 
            this.CB2_M2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CB2_M2.FormattingEnabled = true;
            this.CB2_M2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.CB2_M2.Location = new System.Drawing.Point(676, 353);
            this.CB2_M2.Margin = new System.Windows.Forms.Padding(2);
            this.CB2_M2.Name = "CB2_M2";
            this.CB2_M2.Size = new System.Drawing.Size(42, 24);
            this.CB2_M2.TabIndex = 15;
            this.CB2_M2.SelectedIndexChanged += new System.EventHandler(this.CB1_M1_SelectedIndexChanged);
            // 
            // CB1_M2
            // 
            this.CB1_M2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CB1_M2.FormattingEnabled = true;
            this.CB1_M2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.CB1_M2.Location = new System.Drawing.Point(604, 353);
            this.CB1_M2.Margin = new System.Windows.Forms.Padding(2);
            this.CB1_M2.Name = "CB1_M2";
            this.CB1_M2.Size = new System.Drawing.Size(42, 24);
            this.CB1_M2.TabIndex = 14;
            this.CB1_M2.SelectedIndexChanged += new System.EventHandler(this.CB1_M1_SelectedIndexChanged);
            // 
            // sum_button
            // 
            this.sum_button.Location = new System.Drawing.Point(346, 201);
            this.sum_button.Margin = new System.Windows.Forms.Padding(2);
            this.sum_button.Name = "sum_button";
            this.sum_button.Size = new System.Drawing.Size(75, 24);
            this.sum_button.TabIndex = 22;
            this.sum_button.Text = "А + В";
            this.sum_button.UseVisualStyleBackColor = true;
            this.sum_button.Click += new System.EventHandler(this.sum_button_Click);
            // 
            // subtract_button
            // 
            this.subtract_button.Location = new System.Drawing.Point(346, 238);
            this.subtract_button.Margin = new System.Windows.Forms.Padding(2);
            this.subtract_button.Name = "subtract_button";
            this.subtract_button.Size = new System.Drawing.Size(75, 24);
            this.subtract_button.TabIndex = 23;
            this.subtract_button.Text = "A - B";
            this.subtract_button.UseVisualStyleBackColor = true;
            this.subtract_button.Click += new System.EventHandler(this.subtract_button_Click);
            // 
            // multiply_button
            // 
            this.multiply_button.Location = new System.Drawing.Point(346, 274);
            this.multiply_button.Margin = new System.Windows.Forms.Padding(2);
            this.multiply_button.Name = "multiply_button";
            this.multiply_button.Size = new System.Drawing.Size(75, 24);
            this.multiply_button.TabIndex = 24;
            this.multiply_button.Text = "A * B";
            this.multiply_button.UseVisualStyleBackColor = true;
            this.multiply_button.Click += new System.EventHandler(this.multiply_button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(10, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 329);
            this.panel1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 20;
            this.dataGridView1.Size = new System.Drawing.Size(322, 329);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Location = new System.Drawing.Point(436, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 329);
            this.panel2.TabIndex = 6;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 20;
            this.dataGridView2.Size = new System.Drawing.Size(322, 329);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView3);
            this.panel3.Location = new System.Drawing.Point(10, 470);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(322, 329);
            this.panel3.TabIndex = 7;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.ColumnHeadersVisible = false;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(176)))));
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 20;
            this.dataGridView3.Size = new System.Drawing.Size(322, 329);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(436, 486);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 489);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Определитель:";
            // 
            // copy_M1
            // 
            this.copy_M1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.copy_M1.Location = new System.Drawing.Point(353, 524);
            this.copy_M1.Name = "copy_M1";
            this.copy_M1.Size = new System.Drawing.Size(200, 23);
            this.copy_M1.TabIndex = 27;
            this.copy_M1.Text = "Cкопировать в первую матрицу";
            this.copy_M1.UseVisualStyleBackColor = false;
            this.copy_M1.Click += new System.EventHandler(this.copy_M1_Click);
            // 
            // copy_M2
            // 
            this.copy_M2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.copy_M2.Location = new System.Drawing.Point(353, 554);
            this.copy_M2.Name = "copy_M2";
            this.copy_M2.Size = new System.Drawing.Size(200, 23);
            this.copy_M2.TabIndex = 28;
            this.copy_M2.Text = "Cкопировать во вторую матрицу";
            this.copy_M2.UseVisualStyleBackColor = false;
            this.copy_M2.Click += new System.EventHandler(this.copy_M2_Click);
            // 
            // label_M2
            // 
            this.label_M2.AutoSize = true;
            this.label_M2.Location = new System.Drawing.Point(763, 11);
            this.label_M2.Name = "label_M2";
            this.label_M2.Size = new System.Drawing.Size(14, 13);
            this.label_M2.TabIndex = 1;
            this.label_M2.Text = "B";
            // 
            // label_M1
            // 
            this.label_M1.AutoSize = true;
            this.label_M1.Location = new System.Drawing.Point(337, 11);
            this.label_M1.Name = "label_M1";
            this.label_M1.Size = new System.Drawing.Size(14, 13);
            this.label_M1.TabIndex = 1;
            this.label_M1.Text = "A";
            // 
            // division_button
            // 
            this.division_button.Location = new System.Drawing.Point(346, 316);
            this.division_button.Margin = new System.Windows.Forms.Padding(2);
            this.division_button.Name = "division_button";
            this.division_button.Size = new System.Drawing.Size(75, 24);
            this.division_button.TabIndex = 29;
            this.division_button.Text = "A / B";
            this.division_button.UseVisualStyleBackColor = true;
            this.division_button.Click += new System.EventHandler(this.division_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(790, 749);
            this.Controls.Add(this.division_button);
            this.Controls.Add(this.label_M1);
            this.Controls.Add(this.label_M2);
            this.Controls.Add(this.copy_M2);
            this.Controls.Add(this.copy_M1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.multiply_button);
            this.Controls.Add(this.subtract_button);
            this.Controls.Add(this.sum_button);
            this.Controls.Add(this.inverse_M2);
            this.Controls.Add(this.deter_M2);
            this.Controls.Add(this.textBox_M2);
            this.Controls.Add(this.multiply_M2);
            this.Controls.Add(this.transpose_M2);
            this.Controls.Add(this.Clear_button_M2);
            this.Controls.Add(this.CB2_M2);
            this.Controls.Add(this.CB1_M2);
            this.Controls.Add(this.inverse_M1);
            this.Controls.Add(this.deter_M1);
            this.Controls.Add(this.textBox_M1);
            this.Controls.Add(this.multiply_M1);
            this.Controls.Add(this.transpose_M1);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.CB2_M1);
            this.Controls.Add(this.CB1_M1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CB1_M1;
        private System.Windows.Forms.ComboBox CB2_M1;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Button transpose_M1;
        private System.Windows.Forms.Button multiply_M1;
        private System.Windows.Forms.TextBox textBox_M1;
        private System.Windows.Forms.Button deter_M1;
        private System.Windows.Forms.Button inverse_M1;
        private System.Windows.Forms.Button inverse_M2;
        private System.Windows.Forms.Button deter_M2;
        private System.Windows.Forms.TextBox textBox_M2;
        private System.Windows.Forms.Button multiply_M2;
        private System.Windows.Forms.Button transpose_M2;
        private System.Windows.Forms.Button Clear_button_M2;
        private System.Windows.Forms.ComboBox CB2_M2;
        private System.Windows.Forms.ComboBox CB1_M2;
        private System.Windows.Forms.Button sum_button;
        private System.Windows.Forms.Button subtract_button;
        private System.Windows.Forms.Button multiply_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button copy_M1;
        private System.Windows.Forms.Button copy_M2;
        private System.Windows.Forms.Label label_M2;
        private System.Windows.Forms.Label label_M1;
        private System.Windows.Forms.Button division_button;
    }
}

