using Core.Interfaces;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using UI.Services;

namespace UI
{
    public partial class MainForm : Form
    {
        private readonly IPerceptron _perceptron;
        private readonly MapperService _mapperService = new MapperService();
        private readonly Size normalizedSize = new Size(100, 100);

        public MainForm(IPerceptron perceptron)
        {
            _perceptron = perceptron;
            InitializeComponent();
        }

        private void check_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(elementName1.Text) || string.IsNullOrWhiteSpace(elementName2.Text))
            {
                MessageBox.Show("Наименования не устновлены", "Ошибка");
                return;
            }

            try
            {
                var bitmap = NormalizeBitmap(paintingControl.GetData());
                var input = _mapperService.ToInputData(bitmap);

                var value = _perceptron.Check(input);

                var result = value[0] == 0 ? elementName1.Text : elementName2.Text;
                MessageBox.Show(result, "Результат");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Произошла ошибка");
            }
        }

        private void train_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(source1.Text) || string.IsNullOrWhiteSpace(source2.Text))
                {
                    MessageBox.Show("Источники не устновлены", "Ошибка");
                    return;
                }

                var files1 = Directory.GetFiles(source1.Text);
                var files2 = Directory.GetFiles(source2.Text);

                var data = new List<TrtrainingData>();

                foreach (var file in files1)
                {
                    var bitmap = NormalizeBitmap((Bitmap)Bitmap.FromFile(file));
                    var input = _mapperService.ToInputData(bitmap);
                    data.Add(new TrtrainingData()
                    {
                        Input = input,
                        Expected = new double[] { 0 }
                    });
                }

                foreach (var file in files2)
                {
                    var bitmap = NormalizeBitmap((Bitmap)Bitmap.FromFile(file));
                    var input = _mapperService.ToInputData(bitmap);
                    data.Add(new TrtrainingData()
                    {
                        Input = input,
                        Expected = new double[] { 1 }
                    });
                }

                var epoch = _perceptron.Train(data.ToArray());
                MessageBox.Show($"Обучение завершено. Эпох {epoch} ");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Произошла ошибка");
            }
        }

        private void loadWeights_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "Text File|*.txt";
                dialog.Title = "Загрузить матрицу весов";
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.FileName))
                {
                    var text = File.ReadAllText(dialog.FileName);

                    try
                    {
                        var data = _mapperService.ParseWeights(text);
                        _perceptron.SetWeigths(data);
                        MessageBox.Show("Веса загружены");
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.ToString(), "Произошла ошибка");
                    }
                }
            }
        }

        private void downloadWeights_Click(object sender, EventArgs e)
        {
            var weights = _perceptron.GetWeigths();
            if (weights.GetLength(0) == 0)
            {
                MessageBox.Show("Веса не установлены", "Ошибка");
                return;
            }

            using (var dialog = new SaveFileDialog())
            {
                dialog.Filter = "Text File|*.txt";
                dialog.Title = "Сохранить матрицу весов";
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.FileName))
                {
                    using (var fs = (FileStream)dialog.OpenFile())
                    {
                        using (var writer = new StreamWriter(fs))
                        {
                            var text = _mapperService.SerializeWeights(weights);
                            writer.Write(text);
                        }
                    }
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            paintingControl.Clear();
        }

        private void select1_Click(object sender, EventArgs e)
        {
            SelectPath(source1);
        }

        private void select2_Click(object sender, EventArgs e)
        {
            SelectPath(source2);
        }

        private void saveImage_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog())
            {
                dialog.Filter = "Png Image|*.png|JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
                dialog.Title = "Сохранить рисунок";
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.FileName))
                {
                    using (var fs = (FileStream)dialog.OpenFile())
                    {
                        var bitmap = NormalizeBitmap(paintingControl.GetData());
                        paintingControl.SetData(bitmap);
                        switch (dialog.FilterIndex)
                        {
                            case 1:
                            default:
                                bitmap.Save(fs,
                                  System.Drawing.Imaging.ImageFormat.Png);
                                break;

                            case 2:
                                bitmap.Save(fs,
                                  System.Drawing.Imaging.ImageFormat.Jpeg);
                                break;

                            case 3:
                                bitmap.Save(fs,
                                  System.Drawing.Imaging.ImageFormat.Bmp);
                                break;

                            case 4:
                                bitmap.Save(fs,
                                  System.Drawing.Imaging.ImageFormat.Gif);
                                break;
                        }
                    }
                }
            }
        }

        private void loadImage_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "Png Image|*.png|JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
                dialog.Title = "Загрузить рисунок";
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.FileName))
                {
                    using (var fs = (FileStream)dialog.OpenFile())
                    {
                        var bitmap = (Bitmap)Bitmap.FromStream(fs);
                        paintingControl.SetData(bitmap);
                    }
                }
            }
        }

        private void SelectPath(TextBox target)
        {
            const string initDir =
                    "D:\\Учеба магистратура\\2 курс 1 семестр\\Современные нейронные сети\\Лаба 1\\Perceptron\\Data";
            using (var dialog = new CommonOpenFileDialog())
            {
                dialog.InitialDirectory = initDir;
                dialog.IsFolderPicker = true;
                var result = dialog.ShowDialog();

                if (result == CommonFileDialogResult.Ok && !string.IsNullOrWhiteSpace(dialog.FileName))
                {
                    target.Text = dialog.FileName;
                }
            }
        }

        private Bitmap NormalizeBitmap(Bitmap bitmap)
        {
            return new Bitmap(bitmap, normalizedSize);
        }
    }
}
