using System.Text;
using System.Xml.XPath;

namespace Repo;

public partial class Form1 : Form
{
    private const int RegLen = 37;
    private const int BitsInByte = 8;
    // x37 + x12 + x10 + x2 + 1
    private readonly byte[] _bits = [2,10,12,37];
    private byte[] _fileBytes;
    private byte[] _result;
    
    public Form1()
    {
        _fileBytes = [];
        _result = [];
        InitializeComponent();
    }
    
    private void btn_openFile_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            // получаем имя файла через OpenDialog
            string filePath = openFileDialog.FileName;

            try
            {
                // Читаем файл побайтно
                _fileBytes = File.ReadAllBytes(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при чтении файла: " + ex.Message);
            }
            Console.WriteLine("Read file" + _fileBytes.Length);
            
            
            // Преобразуем в битовое представление
            string bits = BytesToBits(_fileBytes);
            Console.WriteLine("Convert file" + bits.Length);

            // Выводим пользователю
            tb_sourceText.Text = bits;
            
        }
    }
    
    private void btn_execute_Click(object sender, EventArgs e)
    {
        // очищаем lfsr инпут от мусора
        string validatedLfsr = ValidateLFSR(tb_lfsr.Text);
        tb_lfsr.Text = validatedLfsr;
        // проверяем количество символов
        if (validatedLfsr.Length != RegLen)
        {
            MessageBox.Show("Размер ключа должен быть 37!");
            return;
        }
        // генерируем ключ
        byte[] key = GenerateKey(validatedLfsr, _fileBytes.Length);
        Console.WriteLine("Generate key");
        // записываем ключ в input
        tb_key.Text = BytesToBits(key);
        // xor-им с source-файлом
        _result = Encrypt(_fileBytes, key);
        // записываем результат в input
        tb_result.Text = BytesToBits(_result);
    }
    
    private byte[] GenerateKey(string seed, int bytesLength)
    {
        byte[] curState = seed.Select(bit => (byte)(bit - '0')).ToArray();
        byte[] key = new byte[bytesLength];
        ulong bitsCount = (ulong)bytesLength * BitsInByte;
        StringBuilder sb = new StringBuilder(BitsInByte);
        
        Console.WriteLine($"Generateing {bitsCount} bits");
        for (ulong i = 0; i < bitsCount; i++)
        {
            // добавляем старший бит в результат
            sb.Append(curState[0]);
            
            // если 8 бит накопилось формируем 1 байт и сбрасываем накопитель 
            if (sb.Length == BitsInByte)
            {
                key[i / BitsInByte] = Convert.ToByte(sb.ToString(),2);
                sb.Clear();
            }
            
            // получаем бит, которые будет задвигать в начало
            byte newBit = 0;
            foreach (var bit in _bits)
            {
                newBit ^= curState[^bit];
            }
            
            // сдвигаем все кроме первого бит
            Array.Copy(curState, 1, curState, 0, curState.Length - 1);
            
            // сдвигаем последний бит
            curState[^1] = newBit;
        }
        return key;
    }

    private byte[] Encrypt(byte[] data, byte[] key)
    {
        byte[] result = new byte[data.Length];
        for (int i = 0; i < data.Length; i++)
        {
            result[i] = (byte)(data[i] ^ key[i]);
        }
        return result;
    }
    
    private string BytesToBits(byte[] buffer)
    {
        const int MaxBytesToShow = 256;
        const int ShowBits = RegLen * 2;
        const int ShowBytes = ShowBits / BitsInByte;
    
        // Если данных мало, конвертируем всё
        if (buffer.Length <= MaxBytesToShow)
        {
            return string.Concat(buffer.Select(b => Convert.ToString(b, 2).PadLeft(8, '0')));
        }

        StringBuilder bitString = new StringBuilder(ShowBits * 2 + 3);

        // Добавляем начальные биты
        for (int i = 0; i < ShowBytes; i++)
        {
            bitString.Append(Convert.ToString(buffer[i], 2).PadLeft(8, '0'));
        }

        // Если число битов не кратно 8, добавляем недостающие биты последнего байта
        int extraBits = ShowBits % BitsInByte;
        
        if (extraBits != 0)
        {
            bitString.Append(GetBitsFromByte(buffer[ShowBytes], extraBits, fromLeft: true));
        }

        // Добавляем "..."
        bitString.Append("...");

        // Если число битов не кратно 8, добавляем недостающие биты первого байта из конца
        if (extraBits != 0)
        {
            bitString.Append(GetBitsFromByte(buffer[^(ShowBytes + 1)], extraBits, fromLeft: false));
        }

        // Добавляем конечные биты
        for (int i = buffer.Length - ShowBytes; i < buffer.Length; i++)
        {
            bitString.Append(Convert.ToString(buffer[i], 2).PadLeft(8, '0'));
        }

        return bitString.ToString();
    }
    
    private string GetBitsFromByte(byte value, int bitCount, bool fromLeft)
    {
        return fromLeft
            ? Convert.ToString(value >> (BitsInByte - bitCount), 2).PadLeft(bitCount, '0')
            : Convert.ToString(value & ((1 << bitCount) - 1), 2).PadLeft(bitCount, '0');
    }


    private string ValidateLFSR(string lfsr)
    {
        return string.Concat(lfsr.Where(c => c == '0' || c == '1'));
    }

    private void btn_saveFile_Click(object sender, EventArgs e)
    {
        if (_result.Length == 0)
        {
            MessageBox.Show("Нет данных для сохранения!");
            return;
        }

        SaveFileDialog saveFileDialog = new SaveFileDialog();
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            try
            {
                File.WriteAllBytes(saveFileDialog.FileName, _result);
                MessageBox.Show("Файл успешно сохранен!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении файла: " + ex.Message);
            }
        }
    }

    private void tb_lfsr_TextChanged(object sender, EventArgs e)
    {
        tb_count.Text = tb_lfsr.Text.Length.ToString();
    }
}