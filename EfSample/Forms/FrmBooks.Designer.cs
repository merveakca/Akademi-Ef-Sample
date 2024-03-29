namespace EfSample.Forms;

partial class FrmBooks
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
        dataGridView1 = new DataGridView();
        btnOrderByName = new Button();
        btnOrderByDescName = new Button();
        txtSearch = new TextBox();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        txtMinPrice = new TextBox();
        label5 = new Label();
        label6 = new Label();
        txtMaxPrice = new TextBox();
        btnSearchByPrice = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(153, 235);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 62;
        dataGridView1.Size = new Size(1164, 450);
        dataGridView1.TabIndex = 0;
        dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        // 
        // btnOrderByName
        // 
        btnOrderByName.Location = new Point(162, 75);
        btnOrderByName.Name = "btnOrderByName";
        btnOrderByName.Size = new Size(216, 114);
        btnOrderByName.TabIndex = 1;
        btnOrderByName.Text = "Ada Göre Sırala";
        btnOrderByName.UseVisualStyleBackColor = true;
        btnOrderByName.Click += btnOrderByName_Click;
        // 
        // btnOrderByDescName
        // 
        btnOrderByDescName.Location = new Point(396, 75);
        btnOrderByDescName.Name = "btnOrderByDescName";
        btnOrderByDescName.Size = new Size(216, 114);
        btnOrderByDescName.TabIndex = 2;
        btnOrderByDescName.Text = "Ada Göre Tersten Sırala";
        btnOrderByDescName.UseVisualStyleBackColor = true;
        // 
        // txtSearch
        // 
        txtSearch.Location = new Point(715, 78);
        txtSearch.Name = "txtSearch";
        txtSearch.Size = new Size(186, 31);
        txtSearch.TabIndex = 3;
        txtSearch.TextChanged += txtSearch_TextChanged;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(654, 78);
        label1.Name = "label1";
        label1.Size = new Size(17, 25);
        label1.TabIndex = 4;
        label1.Text = " ";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(645, 78);
        label2.Name = "label2";
        label2.Size = new Size(64, 25);
        label2.TabIndex = 5;
        label2.Text = "Arama";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(645, 136);
        label3.Name = "label3";
        label3.Size = new Size(42, 25);
        label3.TabIndex = 8;
        label3.Text = "Min";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(654, 136);
        label4.Name = "label4";
        label4.Size = new Size(17, 25);
        label4.TabIndex = 7;
        label4.Text = " ";
        // 
        // txtMinPrice
        // 
        txtMinPrice.Location = new Point(693, 136);
        txtMinPrice.Name = "txtMinPrice";
        txtMinPrice.Size = new Size(186, 31);
        txtMinPrice.TabIndex = 6;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(909, 136);
        label5.Name = "label5";
        label5.Size = new Size(45, 25);
        label5.TabIndex = 11;
        label5.Text = "Max";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(918, 136);
        label6.Name = "label6";
        label6.Size = new Size(17, 25);
        label6.TabIndex = 10;
        label6.Text = " ";
        // 
        // txtMaxPrice
        // 
        txtMaxPrice.Location = new Point(960, 136);
        txtMaxPrice.Name = "txtMaxPrice";
        txtMaxPrice.Size = new Size(186, 31);
        txtMaxPrice.TabIndex = 9;
        // 
        // btnSearchByPrice
        // 
        btnSearchByPrice.Location = new Point(1205, 136);
        btnSearchByPrice.Name = "btnSearchByPrice";
        btnSearchByPrice.Size = new Size(112, 34);
        btnSearchByPrice.TabIndex = 12;
        btnSearchByPrice.Text = "Search";
        btnSearchByPrice.UseVisualStyleBackColor = true;
        btnSearchByPrice.Click += btnSearchByPrice_Click;
        // 
        // FrmBooks
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1439, 740);
        Controls.Add(btnSearchByPrice);
        Controls.Add(label5);
        Controls.Add(label6);
        Controls.Add(txtMaxPrice);
        Controls.Add(label3);
        Controls.Add(label4);
        Controls.Add(txtMinPrice);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(txtSearch);
        Controls.Add(btnOrderByDescName);
        Controls.Add(btnOrderByName);
        Controls.Add(dataGridView1);
        Name = "FrmBooks";
        Text = "FrmBooks";
        Load += FrmBooks_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView dataGridView1;
    private Button btnOrderByName;
    private Button btnOrderByDescName;
    private TextBox txtSearch;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private TextBox txtMinPrice;
    private Label label5;
    private Label label6;
    private TextBox txtMaxPrice;
    private Button btnSearchByPrice;
}