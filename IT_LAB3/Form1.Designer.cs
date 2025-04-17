namespace IT_LAB3;

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
        PTextBox = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        QTextBox = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        BTextBox = new System.Windows.Forms.TextBox();
        ResultButton = new System.Windows.Forms.Button();
        PlainTextBox = new System.Windows.Forms.TextBox();
        CipherTextBox = new System.Windows.Forms.TextBox();
        EncryptRadioButton = new System.Windows.Forms.RadioButton();
        DecryptRadioButton = new System.Windows.Forms.RadioButton();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
        menuStrip1 = new System.Windows.Forms.MenuStrip();
        файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        OpenPlainTextButton = new System.Windows.Forms.ToolStripMenuItem();
        OpenCipherTextButton = new System.Windows.Forms.ToolStripMenuItem();
        toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
        SavePlainTextButton = new System.Windows.Forms.ToolStripMenuItem();
        SaveCipherTextButton = new System.Windows.Forms.ToolStripMenuItem();
        ClearBoxesButton = new System.Windows.Forms.ToolStripMenuItem();
        OpenPlainFileDialog = new System.Windows.Forms.OpenFileDialog();
        OpenCipherFileDialog = new System.Windows.Forms.OpenFileDialog();
        SavePlainFileDialog = new System.Windows.Forms.SaveFileDialog();
        SaveCipherFileDialog = new System.Windows.Forms.SaveFileDialog();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // PTextBox
        // 
        PTextBox.Font = new System.Drawing.Font("Segoe UI", 15F);
        PTextBox.Location = new System.Drawing.Point(224, 76);
        PTextBox.Name = "PTextBox";
        PTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
        PTextBox.Size = new System.Drawing.Size(206, 61);
        PTextBox.TabIndex = 0;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 15F);
        label1.Location = new System.Drawing.Point(152, 79);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(66, 61);
        label1.TabIndex = 1;
        label1.Text = "p:";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 15F);
        label2.Location = new System.Drawing.Point(507, 79);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(66, 61);
        label2.TabIndex = 3;
        label2.Text = "q:";
        // 
        // QTextBox
        // 
        QTextBox.Font = new System.Drawing.Font("Segoe UI", 15F);
        QTextBox.Location = new System.Drawing.Point(593, 76);
        QTextBox.Name = "QTextBox";
        QTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
        QTextBox.Size = new System.Drawing.Size(213, 61);
        QTextBox.TabIndex = 2;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 15F);
        label3.Location = new System.Drawing.Point(868, 82);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(66, 61);
        label3.TabIndex = 5;
        label3.Text = "b:";
        // 
        // BTextBox
        // 
        BTextBox.Font = new System.Drawing.Font("Segoe UI", 15F);
        BTextBox.Location = new System.Drawing.Point(940, 79);
        BTextBox.Name = "BTextBox";
        BTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
        BTextBox.Size = new System.Drawing.Size(213, 61);
        BTextBox.TabIndex = 4;
        // 
        // ResultButton
        // 
        ResultButton.Font = new System.Drawing.Font("Segoe UI", 14F);
        ResultButton.Location = new System.Drawing.Point(711, 216);
        ResultButton.Name = "ResultButton";
        ResultButton.Size = new System.Drawing.Size(336, 88);
        ResultButton.TabIndex = 6;
        ResultButton.Text = "Преобразовать";
        ResultButton.UseVisualStyleBackColor = true;
        // 
        // PlainTextBox
        // 
        PlainTextBox.Location = new System.Drawing.Point(38, 433);
        PlainTextBox.Multiline = true;
        PlainTextBox.Name = "PlainTextBox";
        PlainTextBox.ReadOnly = true;
        PlainTextBox.Size = new System.Drawing.Size(565, 437);
        PlainTextBox.TabIndex = 7;
        // 
        // CipherTextBox
        // 
        CipherTextBox.Location = new System.Drawing.Point(722, 433);
        CipherTextBox.Multiline = true;
        CipherTextBox.Name = "CipherTextBox";
        CipherTextBox.ReadOnly = true;
        CipherTextBox.Size = new System.Drawing.Size(565, 437);
        CipherTextBox.TabIndex = 8;
        // 
        // EncryptRadioButton
        // 
        EncryptRadioButton.Checked = true;
        EncryptRadioButton.Font = new System.Drawing.Font("Segoe UI", 14F);
        EncryptRadioButton.Location = new System.Drawing.Point(194, 175);
        EncryptRadioButton.Name = "EncryptRadioButton";
        EncryptRadioButton.Size = new System.Drawing.Size(274, 73);
        EncryptRadioButton.TabIndex = 9;
        EncryptRadioButton.TabStop = true;
        EncryptRadioButton.Text = "Шифровать";
        EncryptRadioButton.UseVisualStyleBackColor = true;
        // 
        // DecryptRadioButton
        // 
        DecryptRadioButton.Font = new System.Drawing.Font("Segoe UI", 14F);
        DecryptRadioButton.Location = new System.Drawing.Point(194, 254);
        DecryptRadioButton.Name = "DecryptRadioButton";
        DecryptRadioButton.Size = new System.Drawing.Size(317, 76);
        DecryptRadioButton.TabIndex = 10;
        DecryptRadioButton.Text = "Дешифровать";
        DecryptRadioButton.UseVisualStyleBackColor = true;
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 14F);
        label4.Location = new System.Drawing.Point(38, 366);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(336, 64);
        label4.TabIndex = 11;
        label4.Text = "Исходный текст:";
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Segoe UI", 14F);
        label5.Location = new System.Drawing.Point(722, 366);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(431, 64);
        label5.TabIndex = 12;
        label5.Text = "Шифрованный текст:";
        // 
        // toolStripMenuItem1
        // 
        toolStripMenuItem1.Name = "toolStripMenuItem1";
        toolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
        // 
        // toolStripMenuItem2
        // 
        toolStripMenuItem2.Name = "toolStripMenuItem2";
        toolStripMenuItem2.Size = new System.Drawing.Size(32, 19);
        // 
        // toolStripMenuItem3
        // 
        toolStripMenuItem3.Name = "toolStripMenuItem3";
        toolStripMenuItem3.Size = new System.Drawing.Size(32, 19);
        // 
        // toolStripMenuItem4
        // 
        toolStripMenuItem4.Name = "toolStripMenuItem4";
        toolStripMenuItem4.Size = new System.Drawing.Size(32, 19);
        // 
        // toolStripMenuItem5
        // 
        toolStripMenuItem5.Name = "toolStripMenuItem5";
        toolStripMenuItem5.Size = new System.Drawing.Size(32, 19);
        // 
        // toolStripMenuItem6
        // 
        toolStripMenuItem6.Name = "toolStripMenuItem6";
        toolStripMenuItem6.Size = new System.Drawing.Size(32, 19);
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
        menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { файлToolStripMenuItem, ClearBoxesButton });
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new System.Drawing.Size(1328, 40);
        menuStrip1.TabIndex = 13;
        menuStrip1.Text = "menuStrip1";
        // 
        // файлToolStripMenuItem
        // 
        файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { OpenPlainTextButton, OpenCipherTextButton, toolStripSeparator, SavePlainTextButton, SaveCipherTextButton });
        файлToolStripMenuItem.Name = "файлToolStripMenuItem";
        файлToolStripMenuItem.Size = new System.Drawing.Size(90, 36);
        файлToolStripMenuItem.Text = "&Файл";
        // 
        // OpenPlainTextButton
        // 
        OpenPlainTextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        OpenPlainTextButton.Name = "OpenPlainTextButton";
        OpenPlainTextButton.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
        OpenPlainTextButton.ShowShortcutKeys = false;
        OpenPlainTextButton.Size = new System.Drawing.Size(503, 44);
        OpenPlainTextButton.Text = "Открыть исходный текст";
        // 
        // OpenCipherTextButton
        // 
        OpenCipherTextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        OpenCipherTextButton.Name = "OpenCipherTextButton";
        OpenCipherTextButton.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
        OpenCipherTextButton.ShowShortcutKeys = false;
        OpenCipherTextButton.Size = new System.Drawing.Size(503, 44);
        OpenCipherTextButton.Text = "Открыть зашифрованный текст";
        // 
        // toolStripSeparator
        // 
        toolStripSeparator.Name = "toolStripSeparator";
        toolStripSeparator.Size = new System.Drawing.Size(500, 6);
        // 
        // SavePlainTextButton
        // 
        SavePlainTextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        SavePlainTextButton.Name = "SavePlainTextButton";
        SavePlainTextButton.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
        SavePlainTextButton.ShowShortcutKeys = false;
        SavePlainTextButton.Size = new System.Drawing.Size(503, 44);
        SavePlainTextButton.Text = "Со&хранить исходный текст";
        // 
        // SaveCipherTextButton
        // 
        SaveCipherTextButton.Name = "SaveCipherTextButton";
        SaveCipherTextButton.ShowShortcutKeys = false;
        SaveCipherTextButton.Size = new System.Drawing.Size(503, 44);
        SaveCipherTextButton.Text = "Сохранить зашифрованный текст";
        // 
        // ClearBoxesButton
        // 
        ClearBoxesButton.Name = "ClearBoxesButton";
        ClearBoxesButton.Size = new System.Drawing.Size(197, 36);
        ClearBoxesButton.Text = "Очистить поля";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1328, 940);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(DecryptRadioButton);
        Controls.Add(EncryptRadioButton);
        Controls.Add(CipherTextBox);
        Controls.Add(PlainTextBox);
        Controls.Add(ResultButton);
        Controls.Add(label3);
        Controls.Add(BTextBox);
        Controls.Add(label2);
        Controls.Add(QTextBox);
        Controls.Add(label1);
        Controls.Add(PTextBox);
        Controls.Add(menuStrip1);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Алгоритм Рабина";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.OpenFileDialog OpenPlainFileDialog;
    private System.Windows.Forms.OpenFileDialog OpenCipherFileDialog;
    private System.Windows.Forms.SaveFileDialog SavePlainFileDialog;
    private System.Windows.Forms.SaveFileDialog SaveCipherFileDialog;

    private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem OpenPlainTextButton;
    private System.Windows.Forms.ToolStripMenuItem OpenCipherTextButton;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    private System.Windows.Forms.ToolStripMenuItem SavePlainTextButton;
    private System.Windows.Forms.ToolStripMenuItem SaveCipherTextButton;
    private System.Windows.Forms.ToolStripMenuItem ClearBoxesButton;

    private System.Windows.Forms.MenuStrip menuStrip1;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.RadioButton EncryptRadioButton;
    private System.Windows.Forms.RadioButton DecryptRadioButton;

    private System.Windows.Forms.TextBox CipherTextBox;

    private System.Windows.Forms.TextBox PlainTextBox;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox QTextBox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox BTextBox;
    private System.Windows.Forms.Button ResultButton;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TextBox PTextBox;

    #endregion
}