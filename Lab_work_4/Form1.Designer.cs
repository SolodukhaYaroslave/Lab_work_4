namespace Lab_work_4
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
            this.label1 = new System.Windows.Forms.Label();
            this.btGenerate = new System.Windows.Forms.Button();
            this.lbArray = new System.Windows.Forms.ListBox();
            this.btSort = new System.Windows.Forms.Button();
            this.UpDownNumber = new System.Windows.Forms.NumericUpDown();
            this.labSize = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSearchItem = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер в журналі: ";
            // 
            // btGenerate
            // 
            this.btGenerate.Location = new System.Drawing.Point(17, 77);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(285, 32);
            this.btGenerate.TabIndex = 2;
            this.btGenerate.Text = "Створити";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // lbArray
            // 
            this.lbArray.FormattingEnabled = true;
            this.lbArray.ItemHeight = 26;
            this.lbArray.Location = new System.Drawing.Point(334, 30);
            this.lbArray.Name = "lbArray";
            this.lbArray.Size = new System.Drawing.Size(170, 186);
            this.lbArray.TabIndex = 3;
            // 
            // btSort
            // 
            this.btSort.Location = new System.Drawing.Point(17, 168);
            this.btSort.Name = "btSort";
            this.btSort.Size = new System.Drawing.Size(285, 48);
            this.btSort.TabIndex = 4;
            this.btSort.Text = "Відсортувати";
            this.btSort.UseVisualStyleBackColor = true;
            this.btSort.Click += new System.EventHandler(this.btSort_Click);
            // 
            // UpDownNumber
            // 
            this.UpDownNumber.Location = new System.Drawing.Point(215, 28);
            this.UpDownNumber.Name = "UpDownNumber";
            this.UpDownNumber.Size = new System.Drawing.Size(87, 32);
            this.UpDownNumber.TabIndex = 5;
            this.UpDownNumber.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // labSize
            // 
            this.labSize.AutoSize = true;
            this.labSize.Location = new System.Drawing.Point(12, 123);
            this.labSize.Name = "labSize";
            this.labSize.Size = new System.Drawing.Size(184, 26);
            this.labSize.TabIndex = 6;
            this.labSize.Text = "розмір масиву: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Знайти елемент:";
            // 
            // tbSearchItem
            // 
            this.tbSearchItem.Location = new System.Drawing.Point(215, 238);
            this.tbSearchItem.Name = "tbSearchItem";
            this.tbSearchItem.Size = new System.Drawing.Size(87, 32);
            this.tbSearchItem.TabIndex = 8;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(334, 235);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(170, 32);
            this.btSearch.TabIndex = 9;
            this.btSearch.Text = "Пошук";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 292);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.tbSearchItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labSize);
            this.Controls.Add(this.UpDownNumber);
            this.Controls.Add(this.btSort);
            this.Controls.Add(this.lbArray);
            this.Controls.Add(this.btGenerate);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Сортування та пошук";
            ((System.ComponentModel.ISupportInitialize)(this.UpDownNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.ListBox lbArray;
        private System.Windows.Forms.Button btSort;
        private System.Windows.Forms.NumericUpDown UpDownNumber;
        private System.Windows.Forms.Label labSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSearchItem;
        private System.Windows.Forms.Button btSearch;
    }
}

