using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;

namespace Somov_Pract_23
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        private System.Drawing.Color col = System.Drawing.Color.FromName("White");

        private void Draw_Click(object sender, RoutedEventArgs e)
        {
            #region Рамка
            System.Windows.Shapes.Rectangle rect = new System.Windows.Shapes.Rectangle();
            rect.Height = 200;
            rect.Width = 540;
            rect.Stroke = System.Windows.Media.Brushes.Red;
            rect.StrokeThickness = 3;
            canvas1.Children.Add(rect);
            Canvas.SetLeft(rect, 10);
            Canvas.SetTop(rect, 30);
            #endregion
            #region Буква Ш
            Polygon polygonSH = new Polygon();
            polygonSH.StrokeThickness = 3;
            polygonSH.Stroke = System.Windows.Media.Brushes.Black;
            polygonSH.Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(col.A, col.R, col.G, col.B));

            polygonSH.Points.Add(new System.Windows.Point(20, 40));
            polygonSH.Points.Add(new System.Windows.Point(50, 40));
            polygonSH.Points.Add(new System.Windows.Point(50, 145));
            polygonSH.Points.Add(new System.Windows.Point(80, 145));
            polygonSH.Points.Add(new System.Windows.Point(80, 40));
            polygonSH.Points.Add(new System.Windows.Point(110, 40));
            polygonSH.Points.Add(new System.Windows.Point(110, 145));
            polygonSH.Points.Add(new System.Windows.Point(140, 145));
            polygonSH.Points.Add(new System.Windows.Point(140, 40));
            polygonSH.Points.Add(new System.Windows.Point(170, 40));
            polygonSH.Points.Add(new System.Windows.Point(170, 170));
            polygonSH.Points.Add(new System.Windows.Point(20, 170));

            canvas1.Children.Add(polygonSH);
            Canvas.SetLeft(polygonSH, 10);
            Canvas.SetTop(polygonSH, 30);
            #endregion
            #region Буква К
            Polygon polygonK = new Polygon();
            polygonK.StrokeThickness = 3;
            polygonK.Stroke = System.Windows.Media.Brushes.Black;
            polygonK.Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(col.A, col.R, col.G, col.B));

            polygonK.Points.Add(new System.Windows.Point(90, 40));
            polygonK.Points.Add(new System.Windows.Point(120, 40));
            polygonK.Points.Add(new System.Windows.Point(120, 85));
            polygonK.Points.Add(new System.Windows.Point(140, 40));
            polygonK.Points.Add(new System.Windows.Point(170, 40));
            polygonK.Points.Add(new System.Windows.Point(140, 100));
            polygonK.Points.Add(new System.Windows.Point(170, 170));
            polygonK.Points.Add(new System.Windows.Point(140, 170));
            polygonK.Points.Add(new System.Windows.Point(120, 120));
            polygonK.Points.Add(new System.Windows.Point(120, 170));
            polygonK.Points.Add(new System.Windows.Point(90, 170));

            canvas1.Children.Add(polygonK);
            Canvas.SetLeft(polygonK, 120);
            Canvas.SetTop(polygonK, 30);
            #endregion
            #region Буква А
            Polygon polygonA = new Polygon();
            Polygon polygonAA = new Polygon();

            polygonA.StrokeThickness = 3;
            polygonA.Stroke = System.Windows.Media.Brushes.Black;
            polygonA.Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(col.A, col.R, col.G, col.B));
            polygonA.Points.Add(new System.Windows.Point(0, 130));
            polygonA.Points.Add(new System.Windows.Point(50, 0));
            polygonA.Points.Add(new System.Windows.Point(80, 0));
            polygonA.Points.Add(new System.Windows.Point(130, 130));
            polygonA.Points.Add(new System.Windows.Point(100, 130));
            polygonA.Points.Add(new System.Windows.Point(70, 25));
            polygonA.Points.Add(new System.Windows.Point(60, 25));
            polygonA.Points.Add(new System.Windows.Point(30, 130));

            canvas1.Children.Add(polygonA);
            Canvas.SetLeft(polygonA, 300);
            Canvas.SetTop(polygonA, 70);

            polygonAA.StrokeThickness = 3;
            polygonAA.Stroke = System.Windows.Media.Brushes.Black;
            polygonAA.Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(col.A, col.R, col.G, col.B));

            polygonAA.Points.Add(new System.Windows.Point(77, 115));
            polygonAA.Points.Add(new System.Windows.Point(23, 115));
            polygonAA.Points.Add(new System.Windows.Point(30, 95));
            polygonAA.Points.Add(new System.Windows.Point(70, 95));

            canvas1.Children.Add(polygonAA);
            Canvas.SetLeft(polygonAA, 315);
            Canvas.SetTop(polygonAA, 55);
            #endregion
            #region Буква Ф
            Polygon polygonF = new Polygon();
            polygonF.StrokeThickness = 3;
            polygonF.Stroke = System.Windows.Media.Brushes.Black;
            polygonF.Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(col.A, col.R, col.G, col.B));

            polygonF.Points.Add(new System.Windows.Point(0, 40));
            polygonF.Points.Add(new System.Windows.Point(80, 40));
            polygonF.Points.Add(new System.Windows.Point(80, 60));
            polygonF.Points.Add(new System.Windows.Point(30, 60));
            polygonF.Points.Add(new System.Windows.Point(30, 90));
            polygonF.Points.Add(new System.Windows.Point(60, 90));
            polygonF.Points.Add(new System.Windows.Point(60, 110));
            polygonF.Points.Add(new System.Windows.Point(30, 110));
            polygonF.Points.Add(new System.Windows.Point(30, 170));
            polygonF.Points.Add(new System.Windows.Point(0, 170));

            canvas1.Children.Add(polygonF);
            Canvas.SetLeft(polygonF, 450);
            Canvas.SetTop(polygonF, 30);
            #endregion
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            canvas1.Children.Clear();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите выйти?", "Выход", MessageBoxButton.YesNo, MessageBoxImage.Information);
            if (result == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик - Сомов Михаил\nПрактическая работа №23. Вариант 25\n\nНарисовать слово ШКАФ. Вывод слова осуществлять при нажатии на кнопку «Рисовать». Реализовать изменение цвета слова. Предусмотреть в программе кнопки «Стереть», «Выход» и «О программе».", "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnColor_Click(object sender, RoutedEventArgs e)
        {           
            string colorSt = color.Text;
            colorSt = colorSt.Replace("Цвет заливки (англ) - ", "");
            colorSt = colorSt.Substring(0, 1).ToUpper() + colorSt.Remove(0, 1).ToLower();
            col = System.Drawing.Color.FromName(colorSt);
            if ( col.R == 255 && col.G == 255 && col.B == 255 && colorSt != "White")
            {
                MessageBox.Show("Не удалось найти введенный цвет. Обратите внимание, что название цвета указывается на английском языке. Например - red", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (col.R == 0 && col.G == 0 && col.B == 0 && colorSt != "Black")
            {
                MessageBox.Show("Не удалось найти введенный цвет. Обратите внимание, что название цвета указывается на английском языке. Например - red", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            #region Рамка
            System.Windows.Shapes.Rectangle rect = new System.Windows.Shapes.Rectangle();
            rect.Height = 200;
            rect.Width = 540;
            rect.Stroke = System.Windows.Media.Brushes.Red;
            rect.StrokeThickness = 3;
            canvas1.Children.Add(rect);
            Canvas.SetLeft(rect, 10);
            Canvas.SetTop(rect, 30);
            #endregion
            #region Буква Ш
            Polygon polygonSH = new Polygon();
            polygonSH.StrokeThickness = 3;
            polygonSH.Stroke = System.Windows.Media.Brushes.Black;
            polygonSH.Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(col.A, col.R, col.G, col.B));

            polygonSH.Points.Add(new System.Windows.Point(20, 40));
            polygonSH.Points.Add(new System.Windows.Point(50, 40));
            polygonSH.Points.Add(new System.Windows.Point(50, 145));
            polygonSH.Points.Add(new System.Windows.Point(80, 145));
            polygonSH.Points.Add(new System.Windows.Point(80, 40));
            polygonSH.Points.Add(new System.Windows.Point(110, 40));
            polygonSH.Points.Add(new System.Windows.Point(110, 145));
            polygonSH.Points.Add(new System.Windows.Point(140, 145));
            polygonSH.Points.Add(new System.Windows.Point(140, 40));
            polygonSH.Points.Add(new System.Windows.Point(170, 40));
            polygonSH.Points.Add(new System.Windows.Point(170, 170));
            polygonSH.Points.Add(new System.Windows.Point(20, 170));

            canvas1.Children.Add(polygonSH);
            Canvas.SetLeft(polygonSH, 10);
            Canvas.SetTop(polygonSH, 30);
            #endregion
            #region Буква К
            Polygon polygonK = new Polygon();
            polygonK.StrokeThickness = 3;
            polygonK.Stroke = System.Windows.Media.Brushes.Black;
            polygonK.Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(col.A, col.R, col.G, col.B));

            polygonK.Points.Add(new System.Windows.Point(90, 40));
            polygonK.Points.Add(new System.Windows.Point(120, 40));
            polygonK.Points.Add(new System.Windows.Point(120, 85));
            polygonK.Points.Add(new System.Windows.Point(140, 40));
            polygonK.Points.Add(new System.Windows.Point(170, 40));
            polygonK.Points.Add(new System.Windows.Point(140, 100));
            polygonK.Points.Add(new System.Windows.Point(170, 170));
            polygonK.Points.Add(new System.Windows.Point(140, 170));
            polygonK.Points.Add(new System.Windows.Point(120, 120));
            polygonK.Points.Add(new System.Windows.Point(120, 170));
            polygonK.Points.Add(new System.Windows.Point(90, 170));

            canvas1.Children.Add(polygonK);
            Canvas.SetLeft(polygonK, 120);
            Canvas.SetTop(polygonK, 30);
            #endregion
            #region Буква А
            Polygon polygonA = new Polygon();
            Polygon polygonAA = new Polygon();

            polygonA.StrokeThickness = 3;
            polygonA.Stroke = System.Windows.Media.Brushes.Black;
            polygonA.Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(col.A, col.R, col.G, col.B));
            polygonA.Points.Add(new System.Windows.Point(0, 130));
            polygonA.Points.Add(new System.Windows.Point(50, 0));
            polygonA.Points.Add(new System.Windows.Point(80, 0));
            polygonA.Points.Add(new System.Windows.Point(130, 130));
            polygonA.Points.Add(new System.Windows.Point(100, 130));
            polygonA.Points.Add(new System.Windows.Point(70, 25));
            polygonA.Points.Add(new System.Windows.Point(60, 25));
            polygonA.Points.Add(new System.Windows.Point(30, 130));

            canvas1.Children.Add(polygonA);
            Canvas.SetLeft(polygonA, 300);
            Canvas.SetTop(polygonA, 70);

            polygonAA.StrokeThickness = 3;
            polygonAA.Stroke = System.Windows.Media.Brushes.Black;
            polygonAA.Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(col.A, col.R, col.G, col.B));

            polygonAA.Points.Add(new System.Windows.Point(77, 115));
            polygonAA.Points.Add(new System.Windows.Point(23, 115));
            polygonAA.Points.Add(new System.Windows.Point(30, 95));
            polygonAA.Points.Add(new System.Windows.Point(70, 95));

            canvas1.Children.Add(polygonAA);
            Canvas.SetLeft(polygonAA, 315);
            Canvas.SetTop(polygonAA, 55);
            #endregion
            #region Буква Ф
            Polygon polygonF = new Polygon();
            polygonF.StrokeThickness = 3;
            polygonF.Stroke = System.Windows.Media.Brushes.Black;
            polygonF.Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(col.A, col.R, col.G, col.B));

            polygonF.Points.Add(new System.Windows.Point(0, 40));
            polygonF.Points.Add(new System.Windows.Point(80, 40));
            polygonF.Points.Add(new System.Windows.Point(80, 60));
            polygonF.Points.Add(new System.Windows.Point(30, 60));
            polygonF.Points.Add(new System.Windows.Point(30, 90));
            polygonF.Points.Add(new System.Windows.Point(60, 90));
            polygonF.Points.Add(new System.Windows.Point(60, 110));
            polygonF.Points.Add(new System.Windows.Point(30, 110));
            polygonF.Points.Add(new System.Windows.Point(30, 170));
            polygonF.Points.Add(new System.Windows.Point(0, 170));

            canvas1.Children.Add(polygonF);
            Canvas.SetLeft(polygonF, 450);
            Canvas.SetTop(polygonF, 30);
            #endregion           
        }
        private void ProwerkaText(object sender, TextCompositionEventArgs e)
        {
            char[] keys = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            if (e.Text.IndexOfAny(keys) != -1)
            {
                e.Handled = true;
            }
        }
    }
}
