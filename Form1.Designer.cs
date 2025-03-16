namespace Repo;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        lb_lfsr = new System.Windows.Forms.Label();
        tb_lfsr = new System.Windows.Forms.TextBox();
        btn_openFile = new System.Windows.Forms.Button();
        p_topBar = new System.Windows.Forms.Panel();
        tb_count = new System.Windows.Forms.TextBox();
        P_bottomBar = new System.Windows.Forms.Panel();
        lb_key = new System.Windows.Forms.Label();
        tb_key = new System.Windows.Forms.TextBox();
        lb_result = new System.Windows.Forms.Label();
        btn_saveFile = new System.Windows.Forms.Button();
        tb_result = new System.Windows.Forms.TextBox();
        p_center = new System.Windows.Forms.Panel();
        btn_execute = new System.Windows.Forms.Button();
        tb_sourceText = new System.Windows.Forms.TextBox();
        lb_sourceText = new System.Windows.Forms.Label();
        p_topBar.SuspendLayout();
        P_bottomBar.SuspendLayout();
        p_center.SuspendLayout();
        SuspendLayout();
        // 
        // lb_lfsr
        // 
        lb_lfsr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        lb_lfsr.Location = new System.Drawing.Point(12, 8);
        lb_lfsr.Name = "lb_lfsr";
        lb_lfsr.Size = new System.Drawing.Size(269, 41);
        lb_lfsr.TabIndex = 0;
        lb_lfsr.Text = "Введите начальное состояние LFSR";
        lb_lfsr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // tb_lfsr
        // 
        tb_lfsr.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        tb_lfsr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        tb_lfsr.Location = new System.Drawing.Point(12, 52);
        tb_lfsr.Name = "tb_lfsr";
        tb_lfsr.PlaceholderText = "0000000000000000000000000000000000000";
        tb_lfsr.Size = new System.Drawing.Size(364, 29);
        tb_lfsr.TabIndex = 1;
        tb_lfsr.TextChanged += tb_lfsr_TextChanged;
        // 
        // btn_openFile
        // 
        btn_openFile.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btn_openFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        btn_openFile.Location = new System.Drawing.Point(486, 37);
        btn_openFile.Name = "btn_openFile";
        btn_openFile.Size = new System.Drawing.Size(141, 44);
        btn_openFile.TabIndex = 2;
        btn_openFile.Text = "Открыть файл";
        btn_openFile.UseVisualStyleBackColor = true;
        btn_openFile.Click += btn_openFile_Click;
        // 
        // p_topBar
        // 
        p_topBar.Controls.Add(tb_count);
        p_topBar.Controls.Add(lb_lfsr);
        p_topBar.Controls.Add(btn_openFile);
        p_topBar.Controls.Add(tb_lfsr);
        p_topBar.Dock = System.Windows.Forms.DockStyle.Top;
        p_topBar.Location = new System.Drawing.Point(0, 0);
        p_topBar.Name = "p_topBar";
        p_topBar.Size = new System.Drawing.Size(635, 89);
        p_topBar.TabIndex = 3;
        // 
        // tb_count
        // 
        tb_count.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        tb_count.Location = new System.Drawing.Point(412, 52);
        tb_count.Name = "tb_count";
        tb_count.ReadOnly = true;
        tb_count.Size = new System.Drawing.Size(44, 29);
        tb_count.TabIndex = 3;
        // 
        // P_bottomBar
        // 
        P_bottomBar.Controls.Add(lb_key);
        P_bottomBar.Controls.Add(tb_key);
        P_bottomBar.Controls.Add(lb_result);
        P_bottomBar.Controls.Add(btn_saveFile);
        P_bottomBar.Controls.Add(tb_result);
        P_bottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
        P_bottomBar.Location = new System.Drawing.Point(0, 274);
        P_bottomBar.Name = "P_bottomBar";
        P_bottomBar.Size = new System.Drawing.Size(635, 316);
        P_bottomBar.TabIndex = 4;
        // 
        // lb_key
        // 
        lb_key.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        lb_key.Location = new System.Drawing.Point(12, 3);
        lb_key.Name = "lb_key";
        lb_key.Size = new System.Drawing.Size(214, 25);
        lb_key.TabIndex = 4;
        lb_key.Text = "Ключ";
        // 
        // tb_key
        // 
        tb_key.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        tb_key.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        tb_key.Location = new System.Drawing.Point(12, 31);
        tb_key.Multiline = true;
        tb_key.Name = "tb_key";
        tb_key.ReadOnly = true;
        tb_key.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        tb_key.Size = new System.Drawing.Size(615, 93);
        tb_key.TabIndex = 3;
        // 
        // lb_result
        // 
        lb_result.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        lb_result.Location = new System.Drawing.Point(12, 127);
        lb_result.Name = "lb_result";
        lb_result.Size = new System.Drawing.Size(214, 29);
        lb_result.TabIndex = 2;
        lb_result.Text = "Результат";
        // 
        // btn_saveFile
        // 
        btn_saveFile.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        btn_saveFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        btn_saveFile.Location = new System.Drawing.Point(12, 259);
        btn_saveFile.Name = "btn_saveFile";
        btn_saveFile.Size = new System.Drawing.Size(167, 45);
        btn_saveFile.TabIndex = 1;
        btn_saveFile.Text = "Сохранить в файл";
        btn_saveFile.UseVisualStyleBackColor = true;
        btn_saveFile.Click += btn_saveFile_Click;
        // 
        // tb_result
        // 
        tb_result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        tb_result.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        tb_result.Location = new System.Drawing.Point(12, 159);
        tb_result.Multiline = true;
        tb_result.Name = "tb_result";
        tb_result.ReadOnly = true;
        tb_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        tb_result.Size = new System.Drawing.Size(615, 93);
        tb_result.TabIndex = 0;
        // 
        // p_center
        // 
        p_center.Controls.Add(btn_execute);
        p_center.Controls.Add(tb_sourceText);
        p_center.Controls.Add(lb_sourceText);
        p_center.Dock = System.Windows.Forms.DockStyle.Fill;
        p_center.Location = new System.Drawing.Point(0, 89);
        p_center.Name = "p_center";
        p_center.Size = new System.Drawing.Size(635, 185);
        p_center.TabIndex = 5;
        // 
        // btn_execute
        // 
        btn_execute.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        btn_execute.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        btn_execute.Location = new System.Drawing.Point(12, 137);
        btn_execute.Name = "btn_execute";
        btn_execute.Size = new System.Drawing.Size(167, 42);
        btn_execute.TabIndex = 5;
        btn_execute.Text = "Выполнить";
        btn_execute.UseVisualStyleBackColor = true;
        btn_execute.Click += btn_execute_Click;
        // 
        // tb_sourceText
        // 
        tb_sourceText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        tb_sourceText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        tb_sourceText.Location = new System.Drawing.Point(12, 34);
        tb_sourceText.Multiline = true;
        tb_sourceText.Name = "tb_sourceText";
        tb_sourceText.ReadOnly = true;
        tb_sourceText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        tb_sourceText.Size = new System.Drawing.Size(615, 93);
        tb_sourceText.TabIndex = 4;
        // 
        // lb_sourceText
        // 
        lb_sourceText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        lb_sourceText.Location = new System.Drawing.Point(12, 3);
        lb_sourceText.Name = "lb_sourceText";
        lb_sourceText.Size = new System.Drawing.Size(263, 28);
        lb_sourceText.TabIndex = 0;
        lb_sourceText.Text = "Исходник";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(635, 590);
        Controls.Add(p_center);
        Controls.Add(P_bottomBar);
        Controls.Add(p_topBar);
        MinimumSize = new System.Drawing.Size(651, 629);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Form1";
        p_topBar.ResumeLayout(false);
        p_topBar.PerformLayout();
        P_bottomBar.ResumeLayout(false);
        P_bottomBar.PerformLayout();
        p_center.ResumeLayout(false);
        p_center.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.TextBox tb_count;

    private System.Windows.Forms.TextBox tb_sourceText;
    private System.Windows.Forms.Button btn_execute;

    private System.Windows.Forms.Label lb_sourceText;

    private System.Windows.Forms.Label lb_result;

    private System.Windows.Forms.TextBox tb_key;

    private System.Windows.Forms.Panel P_bottomBar;
    private System.Windows.Forms.Label lb_key;

    private System.Windows.Forms.Button btn_saveFile;

    private System.Windows.Forms.TextBox tb_result;

    private System.Windows.Forms.Panel p_center;

    private System.Windows.Forms.Panel p_topBar;

    private System.Windows.Forms.Button btn_openFile;

    private System.Windows.Forms.TextBox tb_lfsr;

    private System.Windows.Forms.Label lb_lfsr;

    #endregion
}