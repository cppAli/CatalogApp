namespace CatalogApp
{
    partial class Catalog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.category = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.textCategory = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(200, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(691, 267);
            this.dataGridView1.TabIndex = 0;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(207, 7);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(61, 25);
            this.name.TabIndex = 1;
            this.name.Text = "Name";
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textName.Location = new System.Drawing.Point(298, 4);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(593, 31);
            this.textName.TabIndex = 2;
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.category.Location = new System.Drawing.Point(207, 44);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(88, 25);
            this.category.TabIndex = 3;
            this.category.Text = "Category";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price.Location = new System.Drawing.Point(207, 81);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(53, 25);
            this.price.TabIndex = 4;
            this.price.Text = "Price";
            // 
            // textCategory
            // 
            this.textCategory.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textCategory.Location = new System.Drawing.Point(298, 41);
            this.textCategory.Name = "textCategory";
            this.textCategory.Size = new System.Drawing.Size(593, 31);
            this.textCategory.TabIndex = 5;
            // 
            // textPrice
            // 
            this.textPrice.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPrice.Location = new System.Drawing.Point(298, 78);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(593, 31);
            this.textPrice.TabIndex = 6;
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(796, 113);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(95, 31);
            this.Add.TabIndex = 7;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.Location = new System.Drawing.Point(796, 459);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 31);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Start off";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchText
            // 
            this.txtSearchText.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearchText.Location = new System.Drawing.Point(298, 422);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(593, 31);
            this.txtSearchText.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(207, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Search";
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(903, 502);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchText);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textCategory);
            this.Controls.Add(this.price);
            this.Controls.Add(this.category);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.name);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "Catalog";
            this.Text = "Table Fix";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.TextBox textCategory;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchText;
        private System.Windows.Forms.Label label2;
    }
}

