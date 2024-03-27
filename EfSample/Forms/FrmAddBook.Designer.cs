namespace EfSample.Forms;

partial class FrmAddBook
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
        label1 = new Label();
        txtName = new TextBox();
        txtWriter = new TextBox();
        label2 = new Label();
        btnAdd = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 11F);
        label1.Location = new Point(51, 41);
        label1.Name = "label1";
        label1.Size = new Size(71, 30);
        label1.TabIndex = 0;
        label1.Text = "Name";
        // 
        // txtName
        // 
        txtName.Font = new Font("Segoe UI", 11F);
        txtName.Location = new Point(141, 34);
        txtName.Name = "txtName";
        txtName.Size = new Size(150, 37);
        txtName.TabIndex = 1;
        // 
        // txtWriter
        // 
        txtWriter.Font = new Font("Segoe UI", 11F);
        txtWriter.Location = new Point(141, 106);
        txtWriter.Name = "txtWriter";
        txtWriter.Size = new Size(150, 37);
        txtWriter.TabIndex = 3;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 11F);
        label2.Location = new Point(51, 109);
        label2.Name = "label2";
        label2.Size = new Size(74, 30);
        label2.TabIndex = 2;
        label2.Text = "Writer";
        // 
        // btnAdd
        // 
        btnAdd.Font = new Font("Segoe UI", 11F);
        btnAdd.Location = new Point(179, 188);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(112, 34);
        btnAdd.TabIndex = 4;
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // FrmAddBook
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btnAdd);
        Controls.Add(txtWriter);
        Controls.Add(label2);
        Controls.Add(txtName);
        Controls.Add(label1);
        Name = "FrmAddBook";
        Text = "FrmAddBook";
        Load += FrmAddBook_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox txtName;
    private TextBox txtWriter;
    private Label label2;
    private Button btnAdd;
}