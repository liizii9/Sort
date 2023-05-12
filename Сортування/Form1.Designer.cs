namespace Сортування
{
    partial class frmBubbleSort
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMass = new System.Windows.Forms.DataGridView();
            this.btGenerate = new System.Windows.Forms.Button();
            this.txtArray = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btBubbleSort = new System.Windows.Forms.Button();
            this.txtBubbleSort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMass)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMass);
            this.groupBox1.Controls.Add(this.btGenerate);
            this.groupBox1.Controls.Add(this.txtArray);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(98, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Генерація масиву";
            // 
            // dgvMass
            // 
            this.dgvMass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMass.Location = new System.Drawing.Point(167, 21);
            this.dgvMass.Name = "dgvMass";
            this.dgvMass.RowHeadersWidth = 51;
            this.dgvMass.RowTemplate.Height = 24;
            this.dgvMass.Size = new System.Drawing.Size(389, 138);
            this.dgvMass.TabIndex = 3;
            // 
            // btGenerate
            // 
            this.btGenerate.Location = new System.Drawing.Point(138, 165);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(274, 42);
            this.btGenerate.TabIndex = 2;
            this.btGenerate.Text = "Згенерувати порожній масив";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // txtArray
            // 
            this.txtArray.Location = new System.Drawing.Point(48, 88);
            this.txtArray.Name = "txtArray";
            this.txtArray.Size = new System.Drawing.Size(100, 22);
            this.txtArray.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть кількість \r\nелементів";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btBubbleSort);
            this.groupBox2.Controls.Add(this.txtBubbleSort);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(98, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(584, 121);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "«Бульбашкова» сортування";
            // 
            // btBubbleSort
            // 
            this.btBubbleSort.Location = new System.Drawing.Point(9, 63);
            this.btBubbleSort.Name = "btBubbleSort";
            this.btBubbleSort.Size = new System.Drawing.Size(136, 38);
            this.btBubbleSort.TabIndex = 2;
            this.btBubbleSort.Text = "Сортувати";
            this.btBubbleSort.UseVisualStyleBackColor = true;
            this.btBubbleSort.Click += new System.EventHandler(this.btBubbleSort_Click);
            // 
            // txtBubbleSort
            // 
            this.txtBubbleSort.Location = new System.Drawing.Point(163, 71);
            this.txtBubbleSort.Name = "txtBubbleSort";
            this.txtBubbleSort.Size = new System.Drawing.Size(334, 22);
            this.txtBubbleSort.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Масив після сортування:";
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(261, 391);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(150, 38);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "Вихід";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // frmBubbleSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBubbleSort";
            this.Text = "Сортування «бульбашкою»";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMass)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMass;
        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.TextBox txtArray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btBubbleSort;
        private System.Windows.Forms.TextBox txtBubbleSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btExit;
    }
}

