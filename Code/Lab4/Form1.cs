using System.Numerics;
using System.Text;

namespace Lab4;

public partial class Form1 : Form
{
    private BigInteger _p;
    private BigInteger _q;
    private BigInteger _d;
    private BigInteger _e;
    private BigInteger _r;
    private BigInteger _fR;
    private List<string>? _text = null;
    private BigInteger _sign;
    private BigInteger _hash;
    
    public Form1()
    {
        InitializeComponent();
    }

    private void btn_calculate_Click(object sender, EventArgs e)
    {
        var pInfo = Validator.ValidateArg(tb_p.Text, "p");
        if (!pInfo.isGood)
        {
            MessageBox.Show(pInfo.error);
            return;
        }

        var qInfo = Validator.ValidateArg(tb_q.Text, "q");
        if (!qInfo.isGood)
        {
            MessageBox.Show(qInfo.error);
            return;
        }

        _p = BigInteger.Parse(tb_p.Text);
        _q = BigInteger.Parse(tb_q.Text);

        _r = _p * _q;

        _fR = (_p - 1) * (_q - 1);
        var dInfo = Validator.ValidateD(tb_d.Text, _fR);
        if (!dInfo.isGood)
        {
            MessageBox.Show(dInfo.error);
            return;
        }
        
        _d = BigInteger.Parse(tb_d.Text);
        
        _e = Algorithms.EuclidExt(_fR, _d).y1;

        if (_e < 0)
            _e += _fR;

        if (_text is null)
        {
            MessageBox.Show("Ожидается файл!");
            return;
        }
        
        tb_e.Text = _e.ToString();
        tb_r.Text = _r.ToString();
        tb_fR.Text = _fR.ToString();

        if (rb_sign.Checked)
            Sign();
        else
            Verify();
    }

    private void Sign()
    {
        _hash = Algorithms.GetHashByText(_text, _r);
        _sign = Algorithms.Sign(_hash, _d, _r);
        tb_hash.Text = _hash.ToString();
        tb_singature.Text = _sign.ToString();
    }

    private void Verify()
    {
        var textHash = Algorithms.GetHashByText(_text, _r);
        _hash = Algorithms.GetHashBySign(_sign, _e, _r);
        tb_hash.Text = _hash.ToString();
        
        if (_hash != textHash)
        {
            lb_result.Text = $"Результат: Текст был изменен или не корректный ключ!Значение хеш-образа текста {textHash} не совпадает со значением хеш-образа полученного из ЭЦП {_hash}";
            MessageBox.Show(
            $"Результат: Текст был изменен или не корректный ключ!Значение хеш-образа текста {textHash} не совпадает со значением хеш-образа полученного из ЭЦП {_hash}"
            );
        }
        else
        {
            lb_result.Text = "Результат: Текст является валидным!";
            MessageBox.Show("Текст валидный!");
        }
    }

    private void btn_openFile_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog
        {
            Title = "Выберите файл",
            Filter = "Текстовые (*.*)|*.*"
        };

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            string filePath = openFileDialog.FileName;
            try
            {
                _text = FileService.ReadAllLines(filePath);

                StringBuilder stringBuilder = new();
                foreach (var line in _text)
                {
                    stringBuilder.AppendLine(line);
                }
                
                Clean();
                tb_text.Text = stringBuilder.ToString();
                
            }
            catch (ArgumentException ex)
            {
                _text = null;
                tb_text.Text = "";
                MessageBox.Show(ex.Message);
            }
            catch
            {
                _text = null;
                tb_text.Text = "";
                MessageBox.Show("При прочтении файла произошла ошибка!");
            }
        }
    }
    
    private void btn_openSignedFile_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog
        {
            Title = "Выберите файл",
            Filter = "Текстовые (*.*)|*.*"
        };

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            string filePath = openFileDialog.FileName;
            try
            {
                _text = FileService.ReadAllLines(filePath);
                if (!BigInteger.TryParse(_text[^1], out _sign))
                    throw new ArgumentException("ЭЦП не является числом!");
                
                _text.RemoveAt(_text.Count - 1);

                StringBuilder stringBuilder = new();
                foreach (var line in _text)
                {
                    stringBuilder.AppendLine(line);
                }

                Clean();
                tb_singature.Text = _sign.ToString();
                tb_text.Text = stringBuilder.ToString();
            }
            catch (ArgumentException ex)
            {
                _text = null;
                tb_text.Text = "";
                MessageBox.Show(ex.Message);
            }
            catch
            {
                _text = null;
                tb_text.Text = "";
                MessageBox.Show("При прочтении файла произошла ошибка!");
            }
        }
    }

    private void btn_saveSignatureFile_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog
        {
            Title = "Выберите файл",
            Filter = "Текстовые (*.*)|*.*"
        };

        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            string filePath = saveFileDialog.FileName;
            try
            {
                FileService.WriteToFile(filePath, _text, _sign);
                MessageBox.Show("Файл сохранен успешно!");
            }
            catch
            {
                MessageBox.Show("При сохранении в файл произошла ошибка!");
            }
        }
    }

    private void Clean()
    {
        tb_e.Text = string.Empty;
        tb_r.Text = string.Empty;
        tb_fR.Text = string.Empty;
        tb_hash.Text = string.Empty;
        tb_singature.Text = string.Empty;
        tb_text.Text = string.Empty;
        lb_result.Text = string.Empty;
    }
}