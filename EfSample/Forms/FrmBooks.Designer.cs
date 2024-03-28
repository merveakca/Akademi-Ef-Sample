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
        txtSearch.Location = new Point(816, 75);
        txtSearch.Name = "txtSearch";
        txtSearch.Size = new Size(311, 31);
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
        label2.Location = new Point(746, 75);
        label2.Name = "label2";
        label2.Size = new Size(64, 25);
        label2.TabIndex = 5;
        label2.Text = "Arama";
        // 
        // FrmBooks
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1439, 740);
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
}