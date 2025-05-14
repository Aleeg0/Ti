namespace Lab4;

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
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        tb_p = new System.Windows.Forms.TextBox();
        tb_q = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        tb_d = new System.Windows.Forms.TextBox();
        tb_hash = new System.Windows.Forms.TextBox();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        tb_singature = new System.Windows.Forms.TextBox();
        btn_calculate = new System.Windows.Forms.Button();
        btn_openFile = new System.Windows.Forms.Button();
        btn_saveSignatureFile = new System.Windows.Forms.Button();
        label6 = new System.Windows.Forms.Label();
        tb_e = new System.Windows.Forms.TextBox();
        label7 = new System.Windows.Forms.Label();
        tb_r = new System.Windows.Forms.TextBox();
        label8 = new System.Windows.Forms.Label();
        tb_fR = new System.Windows.Forms.TextBox();
        tb_text = new System.Windows.Forms.TextBox();
        label9 = new System.Windows.Forms.Label();
        rb_sign = new System.Windows.Forms.RadioButton();
        rb_verify = new System.Windows.Forms.RadioButton();
        lb_result = new System.Windows.Forms.Label();
        btn_openSignedFile = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        label1.Location = new System.Drawing.Point(21, 19);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(113, 35);
        label1.TabIndex = 0;
        label1.Text = "Введите p:";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        label2.Location = new System.Drawing.Point(21, 60);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(113, 35);
        label2.TabIndex = 1;
        label2.Text = "Введите q:";
        // 
        // tb_p
        // 
        tb_p.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        tb_p.Location = new System.Drawing.Point(132, 19);
        tb_p.Name = "tb_p";
        tb_p.Size = new System.Drawing.Size(161, 29);
        tb_p.TabIndex = 2;
        // 
        // tb_q
        // 
        tb_q.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        tb_q.Location = new System.Drawing.Point(132, 60);
        tb_q.Name = "tb_q";
        tb_q.Size = new System.Drawing.Size(161, 29);
        tb_q.TabIndex = 3;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        label3.Location = new System.Drawing.Point(21, 104);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(113, 35);
        label3.TabIndex = 4;
        label3.Text = "Введите d:";
        // 
        // tb_d
        // 
        tb_d.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        tb_d.Location = new System.Drawing.Point(132, 104);
        tb_d.Name = "tb_d";
        tb_d.Size = new System.Drawing.Size(161, 29);
        tb_d.TabIndex = 5;
        // 
        // tb_hash
        // 
        tb_hash.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        tb_hash.Location = new System.Drawing.Point(416, 315);
        tb_hash.Name = "tb_hash";
        tb_hash.ReadOnly = true;
        tb_hash.Size = new System.Drawing.Size(121, 29);
        tb_hash.TabIndex = 6;
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        label4.Location = new System.Drawing.Point(416, 286);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(102, 35);
        label4.TabIndex = 7;
        label4.Text = "Хеш-образ:";
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        label5.Location = new System.Drawing.Point(587, 286);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(56, 35);
        label5.TabIndex = 8;
        label5.Text = "ЭЦП:";
        // 
        // tb_singature
        // 
        tb_singature.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        tb_singature.Location = new System.Drawing.Point(587, 315);
        tb_singature.Name = "tb_singature";
        tb_singature.ReadOnly = true;
        tb_singature.Size = new System.Drawing.Size(121, 29);
        tb_singature.TabIndex = 9;
        // 
        // btn_calculate
        // 
        btn_calculate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        btn_calculate.Location = new System.Drawing.Point(21, 303);
        btn_calculate.Name = "btn_calculate";
        btn_calculate.Size = new System.Drawing.Size(138, 41);
        btn_calculate.TabIndex = 10;
        btn_calculate.Text = "Выполнить";
        btn_calculate.UseVisualStyleBackColor = true;
        btn_calculate.Click += btn_calculate_Click;
        // 
        // btn_openFile
        // 
        btn_openFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        btn_openFile.Location = new System.Drawing.Point(21, 142);
        btn_openFile.Name = "btn_openFile";
        btn_openFile.Size = new System.Drawing.Size(239, 41);
        btn_openFile.TabIndex = 11;
        btn_openFile.Text = "Открыть обычный файл";
        btn_openFile.UseVisualStyleBackColor = true;
        btn_openFile.Click += btn_openFile_Click;
        // 
        // btn_saveSignatureFile
        // 
        btn_saveSignatureFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        btn_saveSignatureFile.Location = new System.Drawing.Point(21, 380);
        btn_saveSignatureFile.Name = "btn_saveSignatureFile";
        btn_saveSignatureFile.Size = new System.Drawing.Size(239, 41);
        btn_saveSignatureFile.TabIndex = 12;
        btn_saveSignatureFile.Text = "Сохранить файл с подписью";
        btn_saveSignatureFile.UseVisualStyleBackColor = true;
        btn_saveSignatureFile.Click += btn_saveSignatureFile_Click;
        // 
        // label6
        // 
        label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        label6.Location = new System.Drawing.Point(414, 66);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(30, 35);
        label6.TabIndex = 14;
        label6.Text = "E:";
        // 
        // tb_e
        // 
        tb_e.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        tb_e.Location = new System.Drawing.Point(449, 66);
        tb_e.Name = "tb_e";
        tb_e.ReadOnly = true;
        tb_e.Size = new System.Drawing.Size(121, 29);
        tb_e.TabIndex = 15;
        // 
        // label7
        // 
        label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        label7.Location = new System.Drawing.Point(414, 19);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(30, 35);
        label7.TabIndex = 16;
        label7.Text = "R:";
        // 
        // tb_r
        // 
        tb_r.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        tb_r.Location = new System.Drawing.Point(449, 19);
        tb_r.Name = "tb_r";
        tb_r.ReadOnly = true;
        tb_r.Size = new System.Drawing.Size(121, 29);
        tb_r.TabIndex = 17;
        // 
        // label8
        // 
        label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        label8.Location = new System.Drawing.Point(597, 22);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(50, 35);
        label8.TabIndex = 18;
        label8.Text = "f(r):";
        // 
        // tb_fR
        // 
        tb_fR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        tb_fR.Location = new System.Drawing.Point(638, 19);
        tb_fR.Name = "tb_fR";
        tb_fR.ReadOnly = true;
        tb_fR.Size = new System.Drawing.Size(127, 29);
        tb_fR.TabIndex = 19;
        // 
        // tb_text
        // 
        tb_text.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        tb_text.Location = new System.Drawing.Point(414, 160);
        tb_text.Multiline = true;
        tb_text.Name = "tb_text";
        tb_text.ReadOnly = true;
        tb_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        tb_text.Size = new System.Drawing.Size(393, 109);
        tb_text.TabIndex = 20;
        // 
        // label9
        // 
        label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        label9.Location = new System.Drawing.Point(414, 122);
        label9.Name = "label9";
        label9.Size = new System.Drawing.Size(247, 35);
        label9.TabIndex = 21;
        label9.Text = "Содержимое файла:";
        // 
        // rb_sign
        // 
        rb_sign.Checked = true;
        rb_sign.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        rb_sign.Location = new System.Drawing.Point(21, 241);
        rb_sign.Name = "rb_sign";
        rb_sign.Size = new System.Drawing.Size(197, 25);
        rb_sign.TabIndex = 22;
        rb_sign.TabStop = true;
        rb_sign.Text = "создание цифровой подписи";
        rb_sign.UseVisualStyleBackColor = true;
        // 
        // rb_verify
        // 
        rb_verify.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        rb_verify.Location = new System.Drawing.Point(21, 272);
        rb_verify.Name = "rb_verify";
        rb_verify.Size = new System.Drawing.Size(210, 25);
        rb_verify.TabIndex = 23;
        rb_verify.Text = "проверка на подлиность";
        rb_verify.UseVisualStyleBackColor = true;
        // 
        // lb_result
        // 
        lb_result.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        lb_result.Location = new System.Drawing.Point(416, 360);
        lb_result.Name = "lb_result";
        lb_result.Size = new System.Drawing.Size(393, 100);
        lb_result.TabIndex = 24;
        // 
        // btn_openSignedFile
        // 
        btn_openSignedFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        btn_openSignedFile.Location = new System.Drawing.Point(21, 189);
        btn_openSignedFile.Name = "btn_openSignedFile";
        btn_openSignedFile.Size = new System.Drawing.Size(239, 41);
        btn_openSignedFile.TabIndex = 25;
        btn_openSignedFile.Text = "Открыть подписанный файл";
        btn_openSignedFile.UseVisualStyleBackColor = true;
        btn_openSignedFile.Click += btn_openSignedFile_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.ButtonShadow;
        ClientSize = new System.Drawing.Size(832, 470);
        Controls.Add(btn_openSignedFile);
        Controls.Add(lb_result);
        Controls.Add(rb_verify);
        Controls.Add(rb_sign);
        Controls.Add(tb_text);
        Controls.Add(label9);
        Controls.Add(tb_hash);
        Controls.Add(tb_fR);
        Controls.Add(label8);
        Controls.Add(tb_r);
        Controls.Add(label7);
        Controls.Add(tb_e);
        Controls.Add(label6);
        Controls.Add(btn_saveSignatureFile);
        Controls.Add(btn_openFile);
        Controls.Add(btn_calculate);
        Controls.Add(tb_singature);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(tb_d);
        Controls.Add(label3);
        Controls.Add(tb_q);
        Controls.Add(tb_p);
        Controls.Add(label2);
        Controls.Add(label1);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button btn_openSignedFile;

    private System.Windows.Forms.Label lb_result;

    private System.Windows.Forms.RadioButton rb_sign;
    private System.Windows.Forms.RadioButton rb_verify;

    private System.Windows.Forms.TextBox tb_text;
    private System.Windows.Forms.Label label9;

    private System.Windows.Forms.TextBox tb_e;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox tb_r;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox tb_fR;

    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.Button btn_openFile;

    private System.Windows.Forms.Button btn_calculate;

    private System.Windows.Forms.TextBox tb_singature;
    private System.Windows.Forms.Button btn_saveSignatureFile;

    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.TextBox tb_hash;
    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox tb_d;

    private System.Windows.Forms.TextBox tb_q;

    private System.Windows.Forms.TextBox tb_p;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    #endregion
}