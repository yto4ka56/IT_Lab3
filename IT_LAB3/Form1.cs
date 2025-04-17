using System.Numerics;
using System.Text;

namespace IT_LAB3;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }


    private void ResultButtonClick(object sender, EventArgs e)
    {
        string errorText = GetMistake();
        if (errorText != "")
        {
            MessageBox.Show(errorText, "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        Cipher.p = BigInteger.Parse(PTextBox.Text);
        Cipher.q = BigInteger.Parse(QTextBox.Text);
        Cipher.b = BigInteger.Parse(BTextBox.Text);

        if (EncryptRadioButton.Checked)
        {
            Cipher.Encrypt();
            SavePlainTextButton.Enabled = false;
            SaveCipherTextButton.Enabled = true;
        } 
        else
        {
            Cipher.Decrypt();
            SavePlainTextButton.Enabled = true;
            SaveCipherTextButton.Enabled = false;
        }

        CipherTextBox.Text = Algorithms.BigIntegersToString(Cipher.ciphertext); 
    }
    
    private string GetMistake()
    {
        string errorText = "";

        if (!BigInteger.TryParse(PTextBox.Text, out BigInteger p) || !BigInteger.TryParse(QTextBox.Text, out BigInteger q) || !BigInteger.TryParse(BTextBox.Text, out BigInteger b) || p < 1 || q < 1 || b < 1)
        {
            errorText += "Числа не натуральные!";
            return errorText;
        }

        if (!Algorithms.IsPrime(p))
        {
            errorText += "Число p составное!" + Environment.NewLine;
        }
        if (p % 4 != 3)
        {
            errorText += "Число p при делении на 4 не дает остаток 3!" + Environment.NewLine;
        }
        if (!Algorithms.IsPrime(q))
        {
            errorText += "Число q составное!" + Environment.NewLine;
        }
        if (q % 4 != 3)
        {
            errorText += "Число q при делении на 4 не дает остаток 3!" + Environment.NewLine;
        }
        if (b >= p * q)
        {
            errorText += "Число b должно быть меньше p * q!" + Environment.NewLine;
        }

        return errorText;
    }


    private void OpenPlainFileClick(object sender, EventArgs e)
    {
        if (OpenPlainFileDialog.ShowDialog() == DialogResult.OK)
        {
            using (FileStream fs = new FileStream(OpenPlainFileDialog.FileName, FileMode.Open, FileAccess.Read))
            {
                List<BigInteger> plaintextBytes = new List<BigInteger>();
                StringBuilder plaintextString = new StringBuilder();
                while (fs.Position < fs.Length)
                {
                    int symbol = fs.ReadByte();
                    plaintextBytes.Add(symbol);
                    plaintextString.Append(symbol.ToString() + " ");
                }
                Cipher.plaintext = plaintextBytes.ToArray();
                PlainTextBox.Text = plaintextString.ToString();
            }

            Cipher.ciphertext = null;
            CipherTextBox.Text = "";
            SavePlainTextButton.Enabled = false;
            SaveCipherTextButton.Enabled = false;
        }
    }

    private void OpenCipherFileClick(object sender, EventArgs e)
    {
        string errorText = GetMistake();
            if (errorText != "")
            {
                MessageBox.Show(errorText, "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (OpenCipherFileDialog.ShowDialog() == DialogResult.OK)
            {
                int size = 0;
                BigInteger n = BigInteger.Parse(PTextBox.Text) * BigInteger.Parse(QTextBox.Text);
                while (n > 0)
                {
                    n /= 255;
                    size++;
                }

                using (FileStream fs = new FileStream(OpenCipherFileDialog.FileName, FileMode.Open, FileAccess.Read))
                {
                    if (fs.Length % size != 0)
                    {
                        MessageBox.Show("Длина файла не подходит для расшифровки", "Некорректное содержимое", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    List<BigInteger> plaintextBytes = new List<BigInteger>();
                    StringBuilder plaintextString = new StringBuilder();
                    while (fs.Position < fs.Length)
                    {
                        BigInteger plainNumber = 0;
                        BigInteger multiplier = 1;
                        for (int i = 0; i < size; i++)
                        {
                            plainNumber += fs.ReadByte() * multiplier;
                            multiplier *= 255;
                        }                       
                        plaintextBytes.Add(plainNumber);
                        plaintextString.Append(plainNumber.ToString() + " ");
                    }
                    Cipher.plaintext = plaintextBytes.ToArray();
                    PlainTextBox.Text = plaintextString.ToString();
                }

                Cipher.ciphertext = null;
                CipherTextBox.Text = "";
                SavePlainTextButton.Enabled = false;
                SaveCipherTextButton.Enabled = false;
            }
    }

    private void SavePlainText(object sender, EventArgs e)
    {
        if (SavePlainFileDialog.ShowDialog() == DialogResult.OK)
        {
            for (int i = 0; i < Cipher.ciphertext.Length; i++)
            {
                if (Cipher.ciphertext[i] < 0 || Cipher.ciphertext[i] > 255)
                {
                    MessageBox.Show("Выход за пределы байта", "Некорректное содержимое", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            using (FileStream fs = new FileStream(SavePlainFileDialog.FileName, FileMode.Truncate, FileAccess.Write))
            {  
                for (int i = 0; i < Cipher.ciphertext.Length; i++)
                {
                    fs.WriteByte((byte)Cipher.ciphertext[i]);
                }
            }
        }
    }

    private void SaveCipherText(object sender, EventArgs e)
    {
        if (SaveCipherFileDialog.ShowDialog() == DialogResult.OK)
        {
            int size = 0;
            BigInteger n = Cipher.p * Cipher.q;
            while (n > 0)
            {
                n /= 255;
                size++;
            }

            using (FileStream fs = new FileStream(SaveCipherFileDialog.FileName, FileMode.Truncate, FileAccess.Write))
            {
                for (int i = 0; i < Cipher.ciphertext.Length; i++)
                {
                    BigInteger cipherNumber = Cipher.ciphertext[i];
                    for (int j = 0; j < size; j++)
                    {                          
                        fs.WriteByte((byte)(cipherNumber % 255));
                        cipherNumber /= 255;
                    }
                }
            }
        }
    }

    private void CLearClick(object sender, EventArgs e)
    {
        PTextBox.Clear();
        QTextBox.Clear();
        BTextBox.Clear();
        PlainTextBox.Clear();
        CipherTextBox.Clear();
    }
}