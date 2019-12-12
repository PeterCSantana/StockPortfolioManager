using IronPdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TradingManager.Domain.Functions
{
  public class BrokerageNoteReader
  {
    public void ProcessBrokerageNote(string _path)
    {
      string _processType = string.Empty;

      while (string.IsNullOrEmpty(_processType))
      {
        Console.Clear();
        Console.WriteLine("Informe o caminho do arquivo ou pasta a processada: ");
        _path = "C:\\Users\\peter\\OneDrive\\Finance\\Investimentos\\Notas Corretagem\\Bovespa";// Console.ReadLine();

        if (File.Exists(_path))
        {
          _processType = "file";
        }
        else if (Directory.Exists(_path))
        {
          _processType = "directory";
        }
      }

      StartProcess(_processType == "file", _path);
    }

    private void StartProcess(bool _processType, string _path)
    {
      if (_processType) //File
      {
        FileProcess(_path, _path.Split('\\').Last().Substring(8, 5));
      }
      else //Directory
      {
        DirectoryProcess(_path);
      }
    }

    private static void DirectoryProcess(string _path)
    {
      List<string> _pathFiles = Directory.GetFiles(_path).ToList();

      for (int i = 0; i < _pathFiles.Count; i++)
      {
        Console.WriteLine("Processando arquivo: " + _pathFiles[i].Split('\\').Last());
        FileProcess(_pathFiles[i], _pathFiles[i].Split('\\').Last().Substring(8, 5));
      }
    }

    private static void FileProcess(string _path, string _culture)
    {
      try
      {
        PdfDocument PDF = PdfDocument.FromFile(_path);
        string AllText = PDF.ExtractAllText();

        for (int page = 1; page <= PDF.PageCount; page++)
        {
          GetFileInfo(PDF.ExtractTextFromPage(page), _culture);
        }

        Console.WriteLine("Finalizado com sucesso!");
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
        Console.Read();
        throw;
      }
    }

    private static void GetFileInfo(string _pageText, string _culture)
    {
      List<string> _lines = _pageText.Split('\n').ToList();
      //List<Order> Orders = new List<Order>();
      DateTime _date = DateTime.MinValue;
      decimal _liquidacaoFee = 0;
      decimal _brokerageFee = 0;
      decimal _emoluendFee = 0;

      for (int i = 0; i < _lines.Count; i++)
      {

        if (i == 1)
        {
          //_date = DateTime.ParseExact(_lines[1].Substring(_lines[1].Length - 10), "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }

        if ((!string.IsNullOrEmpty(_lines[i].Trim())) && (_lines[i].Contains("Negociação")))
        {
          i++;
          while (!string.IsNullOrEmpty(_lines[i].Trim()))
          {
            string[] _curLine = _lines[i].Replace(" ", " ").Split(' ');
            int _amountPos = 0;
            int _stockPos = 0;

            for (int _pos = 0; _pos < _curLine.Length; _pos++)
            {
              if ((_stockPos == 0) && ((char.IsLetter(_curLine[_pos][0])) && ((char.IsNumber(_curLine[_pos][_curLine[_pos].Length - 1])) || (_curLine[_pos][_curLine[_pos].Length - 1] == 'F'))))
              {
                _stockPos = _pos;
              }

              //if ((_amountPos == 0) && (_stockPos != 0) && (decimal.TryParse(_curLine[_pos], NumberStyles.Any, CultureInfo.CreateSpecificCulture(_culture), out decimal ret)))
              //{
              //  _amountPos = _pos;
              //}
            }

            //Orders.Add
            //(
              //new Order()
              //{
              //  OrderType = _curLine[2],
              //  Stock = (_curLine[_stockPos].Last().ToString().ToUpper() == "F" ? _curLine[_stockPos].Trim().Substring(0, _curLine[_stockPos].Length - 1) : _curLine[_stockPos].Trim()),
              //  Amount = int.Parse(_curLine[_amountPos], NumberStyles.Any, CultureInfo.CreateSpecificCulture(_culture)),
              //  Price = decimal.Parse(_curLine[_amountPos + 1], CultureInfo.CreateSpecificCulture(_culture))
              //}
            //);

            i++;
          }
        }

        if ((!string.IsNullOrEmpty(_lines[i].Trim())) && (_lines[i].Contains("Liquidação")) && (_liquidacaoFee == 0))
        {
          //_liquidacaoFee = decimal.Parse(_lines[i - 1].Trim().Split()[1].Trim(), CultureInfo.CreateSpecificCulture(_culture));
        }

        if ((!string.IsNullOrEmpty(_lines[i].Trim())) && (_lines[i].Contains("Emolumentos")) && (_emoluendFee == 0))
        {
          //_emoluendFee = decimal.Parse(_lines[i].Trim().Split()[1].Trim(), CultureInfo.CreateSpecificCulture(_culture));
        }

        if ((!string.IsNullOrEmpty(_lines[i].Trim())) && (_lines[i].Contains("Corretagem")) && (_brokerageFee == 0) && (!string.IsNullOrEmpty(_lines[i - 1].Trim())))
        {
          //_brokerageFee = decimal.Parse(_lines[i - 1].Trim().Split()[0].Trim(), CultureInfo.CreateSpecificCulture(_culture));
        }
      }

      //BrokerageNotes.Add(new BrokerageNote { Orders = Orders, Date = _date, BrokerageFee = _brokerageFee, EmoluendFee = _emoluendFee, LiquidacaoFee = _liquidacaoFee });
    }





  }
}
