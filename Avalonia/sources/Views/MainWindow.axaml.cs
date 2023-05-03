using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection.Emit;
using System.Threading;
using System.Text;

namespace AvaloniaApplication1.Views;

public partial class MainWindow : Window
{
    public bool CheckBoxs = false;
    public int coreCount = Environment.ProcessorCount;
    static string a1, a2, a3, a4, a5;
    static int w = 0, w1, w2, w3, w4;
    static string[] list;
    static string subpath;

    public MainWindow()
    {
        InitializeComponent();
    }

    void Start(object sender, RoutedEventArgs e)
    {
        if (Folders1.Text == "" || Folders2.Text == "" || Authors.Text == "")
        { TextRes.Text = "Один из параметров пуст."; }
        else
        {
            TextRes.Text = "Начинаю. Я могу зависнуть, это нормально...";
            string path = Folders1.Text;
            int text = new DirectoryInfo(path).GetFileSystemInfos("*.mp3").Length;
            string[] files = Directory.Exists(path) ? Directory.GetFiles(path, "*.mp3") : new string[0];
            if (Int32.Parse(Nomers.Text) < 10)
            {
                subpath = "BOOK_00" + Nomers.Text;
            }
            else if (Int32.Parse(Nomers.Text) > 99)
            {
                subpath = "BOOK_" + Nomers.Text;
            }
            else
            {
                subpath = "BOOK_0" + Nomers.Text;
            }
            w = text;
            Thread t1 = new Thread(new ThreadStart(Thread1Proc));
            Thread t2 = new Thread(new ThreadStart(Thread2Proc));
            Thread t3 = new Thread(new ThreadStart(Thread3Proc));
            Thread t4 = new Thread(new ThreadStart(Thread4Proc));
            a1 = a2 = a3 = a4 = a5 = "";
            switch (CheckBoxs)
            {
                case true:
                    switch (coreCount)
                    {
                        case 1:
                            TextRes.Text = "Начинаю. Я могу зависнуть, это нормально...";
                            w1 = w;
                            text = new DirectoryInfo(path).GetFileSystemInfos("*.lkf").Length;
                            Directory.CreateDirectory($"{Folders2.Text}/{subpath}");
                            a1 = "#Title=" + Titles.Text + "\r\n#Author=" + Authors.Text + "\r\n#Announcer=" + Authors.Text + "\r\n#File_num=" + w + "\r\n#Total_size_KB=0\r\n#Total_length_SEC=0\r\n#Publish_date=2030\r\n#Publish_place=г. Москва\r\n#SubTitle=Книги изменившие человечество\r\n#RecordSource=М.: 1980\r\n";
                            list = files;
                            t1.Start();
                            t1.Join();
                            a1 = a1 + a2;
                            break;
                        case 2:
                            TextRes.Text = "Начинаю. Я могу зависнуть, это нормально...";
                            w1 = w/2;
                            w2 = w;
                            text = new DirectoryInfo(path).GetFileSystemInfos("*.lkf").Length;
                            Directory.CreateDirectory($"{Folders2.Text}/{subpath}");
                            a1 = "#Title=" + Titles.Text + "\r\n#Author=" + Authors.Text + "\r\n#Announcer=" + Authors.Text + "\r\n#File_num=" + w + "\r\n#Total_size_KB=0\r\n#Total_length_SEC=0\r\n#Publish_date=2030\r\n#Publish_place=г. Москва\r\n#SubTitle=Книги изменившие человечество\r\n#RecordSource=М.: 1980\r\n";
                            list = files;
                            t1.Start();
                            t2.Start();
                            t1.Join();
                            t2.Join();
                            a1 = a1 + a2 + a3;
                            break;
                        case 3:
                            TextRes.Text = "Начинаю. Я могу зависнуть, это нормально...";
                            w1 = w / 3;
                            w2 = w*2 / 3;
                            w3 = w;
                            text = new DirectoryInfo(path).GetFileSystemInfos("*.lkf").Length;
                            Directory.CreateDirectory($"{Folders2.Text}/{subpath}");
                            a1 = "#Title=" + Titles.Text + "\r\n#Author=" + Authors.Text + "\r\n#Announcer=" + Authors.Text + "\r\n#File_num=" + w + "\r\n#Total_size_KB=0\r\n#Total_length_SEC=0\r\n#Publish_date=2030\r\n#Publish_place=г. Москва\r\n#SubTitle=Книги изменившие человечество\r\n#RecordSource=М.: 1980\r\n";
                            list = files;
                            t1.Start();
                            t2.Start();
                            t3.Start();
                            t1.Join();
                            t2.Join();
                            t3.Join();
                            a1 = a1 + a2 + a3 + a4;
                            break;
                        case 4:
                            TextRes.Text = "Начинаю. Я могу зависнуть, это нормально...";
                            w1 = w / 4;
                            w2 = w * 2 / 4;
                            w3 = w * 3 / 4;
                            w4 = w;
                            text = new DirectoryInfo(path).GetFileSystemInfos("*.lkf").Length;
                            Directory.CreateDirectory($"{Folders2.Text}/{subpath}");
                            a1 = "#Title=" + Titles.Text + "\r\n#Author=" + Authors.Text + "\r\n#Announcer=" + Authors.Text + "\r\n#File_num=" + w + "\r\n#Total_size_KB=0\r\n#Total_length_SEC=0\r\n#Publish_date=2030\r\n#Publish_place=г. Москва\r\n#SubTitle=Книги изменившие человечество\r\n#RecordSource=М.: 1980\r\n";
                            list = files;
                            t1.Start();
                            t2.Start();
                            t3.Start();
                            t4.Start();
                            t1.Join();
                            t2.Join();
                            t3.Join();
                            t4.Join();
                            a1 = a1 + a2 + a3 + a4 + a5;
                            break;
                    }
                    break;
                case false:
                    w1 = w;
                    text = new DirectoryInfo(path).GetFileSystemInfos("*.lkf").Length;
                    Directory.CreateDirectory($"{Folders2.Text}/{subpath}");
                    a1 = "#Title=" + Titles.Text + "\r\n#Author=" + Authors.Text + "\r\n#Announcer=" + Authors.Text + "\r\n#File_num=" + w + "\r\n#Total_size_KB=0\r\n#Total_length_SEC=0\r\n#Publish_date=2030\r\n#Publish_place=г. Москва\r\n#SubTitle=Книги изменившие человечество\r\n#RecordSource=М.: 1980\r\n";
                    list = files;
                    t1.Start();
                    t1.Join();
                    a1 = a1 + a2;
                    break;
            }
            using (FileStream fstream = new FileStream($"{Folders2.Text}/{subpath}.lgk", FileMode.OpenOrCreate))
            {
                byte[] buffer = Encoding.Default.GetBytes(a1);
                fstream.Write(buffer, 0, buffer.Length);
            }
            TextRes.Text = $"Готово! {w} файлов обработано.";
        }
    }

    public async void DialodFolder1(object sender, RoutedEventArgs e)
    {
        var dialog = new OpenFolderDialog();
        var result = await dialog.ShowAsync(this);
        Folders1.Text = result;
    }
    public async void DialodFolder2(object sender, RoutedEventArgs e)
    {
        var dialog = new OpenFolderDialog();
        var result = await dialog.ShowAsync(this);
        Folders2.Text = result;
    }
    private void HandleCheck(object sender, RoutedEventArgs e)
    {
        CheckBoxs = true;
    }
    private void HandleUnchecked(object sender, RoutedEventArgs e)
    {
        CheckBoxs = false;
    }

    #region Потоки
    private void Thread1Proc()
    {
        for (int j = 0; j < w1; j++)
        {
            this.ConvertFileBack(list[j]);
            list[j] = list[j].Replace(".mp3", ".lkf");
            File.Move(list[j], $"{Folders2.Text}/{subpath}/{Path.GetFileName(list[j])}");
            a2 = a2 + subpath + @"\" + Path.GetFileName(list[j]) + "\n";
        }
    }
    private void Thread2Proc()
    {
        for (int j = w1; j < w2; j++)
        {
            this.ConvertFileBack(list[j]);
            list[j] = list[j].Replace(".mp3", ".lkf");
            File.Move(list[j], $"{Folders2.Text}/{subpath}/{Path.GetFileName(list[j])}");
            a3 = a3 + subpath + @"\" + Path.GetFileName(list[j]) + "\n";
        }
    }
    private void Thread3Proc()
    {
        for (int j = w2; j < w3; j++)
        {
            this.ConvertFileBack(list[j]);
            list[j] = list[j].Replace(".mp3", ".lkf");
            File.Move(list[j], $"{Folders2.Text}/{subpath}/{Path.GetFileName(list[j])}");
            a4 = a4 + subpath + @"\" + Path.GetFileName(list[j]) + "\n";
        }
    }
    private void Thread4Proc()
    {
        for (int j = w3; j < w4; j++)
        {
            this.ConvertFileBack(list[j]);
            list[j] = list[j].Replace(".mp3", ".lkf");
            File.Move(list[j], $"{Folders2.Text}/{subpath}/{Path.GetFileName(list[j])}");
            a5 = a5 + subpath + @"\" + Path.GetFileName(list[j]) + "\n";
        }
    }
    #endregion

    #region Алгоритм
    private uint[] fcuk = new uint[] { 0x8ac14c27, 0x42845ac1, 0x136506bb, 0x5d47c66 };

    private uint CalcKey(uint local1, uint local2, uint local3, uint local5)
    {
        uint num = (local3 >> 2) & 3;
        uint num2 = (local1 >> 5) ^ (local2 << 2);
        uint num3 = (local2 >> 3) ^ (local1 << 4);
        num2 += num3;
        num3 = local3 ^ local2;
        uint index = (local5 & 3) ^ num;
        uint num5 = this.fcuk[index] ^ local1;
        num5 += num3;
        return (num5 ^ num2);
    }
    private uint CalcLocal3(uint l)
    {
        uint num = 0x9e3779b9;
        uint tmp = num * l;
        return (num * l);
    }

    private void ConvertFileBack(string inputFileName)
    {
        string path = inputFileName.Replace(".mp3", ".lkf");
        BinaryReader reader = new BinaryReader(File.Open(inputFileName, FileMode.Open));
        BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create));
        FileInfo info = new FileInfo(inputFileName);
        uint[] numArray = new uint[0x80];
        for (int i = 0; i < ((info.Length / ((int)numArray.Length)) / 4); i++)
        {
            for (int k = 0; k < numArray.Length; k++)
            {
                numArray[k] = reader.ReadUInt32();
            }
            for (uint m = 1; m <= 3; m++)
            {
                numArray[0] += this.CalcKey(numArray[numArray.Length - 1], numArray[1], this.CalcLocal3(m), (uint)(0));
                for (int num5 = 1; num5 < numArray.Length - 1; num5++)
                {
                    numArray[num5] += this.CalcKey(numArray[num5 - 1], numArray[num5 + 1], this.CalcLocal3(m), (uint)num5);
                }
                numArray[numArray.Length - 1] += this.CalcKey(numArray[numArray.Length - 2], numArray[0], this.CalcLocal3(m), (uint)(numArray.Length - 1));
            }
            for (int n = 0; n < numArray.Length; n++)
            {
                writer.Write(numArray[n]);
            }
        }
        long num7 = info.Length - (info.Length / ((long)numArray.Length) / 4L * (numArray.Length * 4));
        for (int j = 0; j < num7; j++)
        {
            writer.Write(reader.ReadByte());
        }
        reader.Close();
        writer.Flush();
        writer.Close();
    }
    #endregion
}