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

        //PdfReader reader = new PdfReader(_path);

        //for (int page = 1; page <= reader.NumberOfPages; page++)
        //{
        //  GetFileInfo(PdfTextExtractor.GetTextFromPage(reader, page), _culture);
        //}

        //.Close();

        Console.WriteLine("Finalizado com sucesso!");
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
        Console.Read();
        throw;
      }
    }

    



  }
}
