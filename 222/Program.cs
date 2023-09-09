using System;
using System.IO;
using System.IO.Compression;

class Program
{
    static void Main()
    {
        // Исходный путь 
        string sourcePath = @"D:\music";

        // Путь к папке для сохранения резервных копий
        string backupPath = @"D:\резерв музык";

        try
        {
            // Создание папки для хранения резервных копий, если она не существует
            if (!Directory.Exists(backupPath))
            {
                Directory.CreateDirectory(backupPath);
            }

            // Создание имени файла для резервной копии
            string backupFileName = $"ааа{DateTime.Now:yyyyMMdd_HHmmss}.zip";
            string backupFilePath = Path.Combine(backupPath, backupFileName);

            // Создание архива 
            ZipFile.CreateFromDirectory(sourcePath, backupFilePath);

            Console.WriteLine("Резервное копирование успешно завершено.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Возникла ошибка при выполнении резервного копирования: {ex.Message}");
        }
    }
}