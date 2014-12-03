using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Homework_DS//my second commit
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        int[] G = new int[0]; // вектор связей
        int[] P = new int[0]; // вектор разделителей
        int[] С = new int[0]; // вектор весов дуг
        bool Graf_Correct = false; // признак ввода графа

        static int Min_N = 1; // минимальное количсетво вершин
        static int Max_N = 20; // максимальное количество вершин
        static int Min_M = 0; // минимальное количество связей
        static int Max_M = 75; // максимальное количество связей
        static int Min_С = 1; // минимальное значение веса дуги 
        static int Max_С = 100; // максимальное значение веса дуги

        // ввод корректных символов в TextBox
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(char.IsControl(ch) || char.IsNumber(ch) || char.IsWhiteSpace(ch)))
                e.KeyChar = '\0';
        }

        private void Button_Input_Click(object sender, EventArgs e)
        {
            // ввод графа с экрана
            if (Radio_Screen.Checked)
            {
                Graf_Correct =
                    MFO_Read_Screen((int)Numeric_N.Value, (int)Numeric_M.Value, TextBox_G.Text,
                    TextBox_L.Text, TextBox_P.Text, ref G, ref С, ref P);
            }
            // ввод графа с файла
            else
            {
                if (OpenFile.ShowDialog() == DialogResult.OK)
                    Graf_Correct = MFO_Read_File(OpenFile.FileName, ref G, ref С, ref P); 
            }
            // если граф введён, то изменяем максимальное значение
            // в выборе стартовой и конечной вершин
            if (Graf_Correct)
            {
                Numeric_Start.Maximum = P.Length;
                Numeric_End.Maximum = P.Length;
            }
        }

        private void Button_Find_Way_Click(object sender, EventArgs e)
        {
            // если граф введён
            if (Graf_Correct)
            {
                try
                {
                    int[][] MS = new int[0][]; // матрица смежности
                    MFO_Convert(G, P, С, ref MS);
                    // стартовая вершина
                    int start_point = (int)Numeric_Start.Value - 1;
                    if (start_point >= MS.Length)
                        throw new FormatException("Не корректная стартовая вершина!");
                    // конечная вершина
                    int end_point = (int)Numeric_End.Value - 1;
                    if (end_point >= MS.Length)
                        throw new FormatException("Не корректная конечная вершина!");                    
                    // вектор вершин прадерева кратчайших путей из вершины start_point
                    // показывает, из какой вершины выходит дуга в данную
                    int[] Points_of_Tree = new int[MS.Length];
                    RichTextBox_Show_Way.Text = ""; // очистка поля вывода                
                    // длина кратчайшего пути из стартовой в конечную
                    int len = Min_Way_Find(MS, ref Points_of_Tree, start_point, end_point);
                    if (len != -1)
                    {
                        
                        RichTextBox_Show_Way.Text += string.Format("Длина кратчайшего пути из вершины X{0} в вершину X{1} - {2}\n",
                            start_point + 1, end_point + 1, len);
                        RichTextBox_Show_Way.Text += "Путь: ";
                        string[] res = new string[0];
                        Show_Way(Points_of_Tree, start_point, end_point, ref res);
                        for (int i = res.Length - 1; i >= 0; i--)
                        {
                            RichTextBox_Show_Way.Text += res[i];
                            if (i > 0)
                                RichTextBox_Show_Way.Text += " - ";
                        }                        
                    }
                    else
                        RichTextBox_Show_Way.Text = string.Format
                            ("Не существует пути из вершины X{0} в вершину X{1}!", start_point + 1, end_point + 1);

                }
                catch (FormatException exc)
                {
                    MessageBox.Show(exc.Message, "Домашнее задание", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
                MessageBox.Show("Граф не введён!", "Домашнее задание", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        // функция считывания орграфа в MFO-формате с экрана
        private static bool MFO_Read_Screen
        (int points, int connecters, string G_str, string L_str, string P_str, ref int[] G, ref int[] L, ref int[] P)
        {
            try
            {
                if (connecters != 0)
                {
                    Array_InPut(G_str, ref G); // считывание вектора связей
                    Array_InPut(L_str, ref L); // считывание вектора весов дуг
                    // если длины векторов не совпадают с указанным количеством связей                    
                    if (G.Length != connecters)
                        throw new FormatException("Количество элементов массива связей не допустимо!");
                    if (L.Length != connecters)
                        throw new FormatException("Количество элементов массива длин дуг не допустимо!");
                    for (int i = 0; i < G.Length; i++)
                    {                        
                        if ((G[i] < Min_N) || (G[i] > points))
                            throw new FormatException("Элемент массива связей не допустим!");
                        if ((L[i] < Min_С) || (L[i] > Max_С))
                            throw new FormatException("Элемент массива длин дуг не допустим!");
                    }
                }
                else
                {
                    if (!((G_str == "") || (G_str == null)))
                        throw new FormatException("Количество элементов массива связей не допустимо!");
                    if (!((L_str == "") || (L_str == null)))
                        throw new FormatException("Количество элементов массива весов дуг не допустимо!");
                }
            }
            catch (FormatException exc)
            {
                MessageBox.Show(exc.Message, "Домашнее задание", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            try
            {
                Array_InPut(P_str, ref P); // считывание вектора разделителей
                if (P.Length != points)
                    throw new FormatException("Количество элементов массива разделителей не допустимо!");
                for (int i = 0; i < P.Length; i++)
                {
                    if ((P[i] < 0) || (P[i] > connecters))
                        throw new FormatException("Элемент массива разделителей не допустим!");
                    if ((i > 0) && (P[i] < P[i - 1]))
                        throw new FormatException("Элементы массива разделителей не упорядочены!");
                }
            }
            catch (FormatException exc)
            {
                MessageBox.Show(exc.Message, "Домашнее задание", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            // граф введен корректно
            MessageBox.Show("Граф введён!", "Домашнее задание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        // функция считывания орграфа в MFO-формате с файла
        private static bool MFO_Read_File(string NameFile, ref int[] G, ref int[] L, ref int[] P)
        {
            // создание потока на чтение
            StreamReader F_IN = new StreamReader(NameFile);
            // количество вершин, связей
            int n, m;
            try
            {
                string str_n = F_IN.ReadLine();  // считывание количества вершин              
                // проверка строки
                String_Check(str_n);
                Char_Check(str_n);
                n = int.Parse(str_n); // количество вершин
                // проверка количества вершин
                if ((n < Min_N) || (n > Max_N))
                    throw new FormatException("Ошибка ввода количества вершин!");

                string str_m = F_IN.ReadLine(); // считывание количества связей
                // проверка строки
                String_Check(str_m);
                Char_Check(str_m);
                m = int.Parse(str_m); // количество связей
                // проверка количества связей
                if ( (m < Min_M) || (m > Max_M))
                    throw new FormatException("Ошибка ввода количества связей!");
                // если есть связи
                if (m != 0)
                {
                    string str_G = F_IN.ReadLine(); // считывание строки, содержащей вектор связей
                    String_Check(str_G);
                    string str_L = F_IN.ReadLine(); // считывание строки, содержащей вектор весов дуг
                    Array_InPut(str_G, ref G);
                    Array_InPut(str_L, ref L);
                    if (G.Length !=  m)
                        throw new FormatException("Количество элементов массива связей не допустимо!");
                    if (L.Length != m)
                        throw new FormatException("Количество элементов массива весов дуг не допустимо!");
                    for (int i = 0; i < G.Length; i++)
                    {
                        if ((G[i] < 1) || (G[i] > n))
                            throw new FormatException("Элемент массива связей не допустим!");
                        if ((L[i] < Min_С) || (L[i] > Max_С))
                            throw new FormatException("Элемент массива связей не допустим!");
                    }
                }
                string str_P = F_IN.ReadLine();
                String_Check(str_P);
                Array_InPut(str_P, ref P);
                if (P.Length != n)
                    throw new FormatException("Количество элементов массива разделителей не допустимо!");
                for (int i = 0; i < P.Length; i++)
                {
                    if ((P[i] < 0) || (P[i] > 2 * m))
                        throw new FormatException("Элемент массива разделителей не допустим!");
                    if ((i > 0) && (P[i] < P[i - 1]))
                        throw new FormatException("Элементы массива разделителей не упорядочены!");
                }
            }
            catch (FormatException exc)
            {
                MessageBox.Show(exc.Message, "Домашнее задание", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                F_IN.Close();
                return false;
            }
            F_IN.Close();
            MessageBox.Show("Граф введён!", "Домашнее задание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        // функция проверки строки, на наличие символов
        private static void String_Check(string s)
        {
            if ((s == null) || (s == ""))
                throw new FormatException("Обнаружена пустая строка");
        }

        // функция проверки строки на наличие только цифр
        private static void Char_Check(string s)
        {
            s = s.Trim();
            for (int i = 0; i < s.Length; i++)
                // проверка на наличие только цифр
                if (((int)s[i] < 48) || ((int)s[i] > 57))
                    throw new FormatException("Обнаружены не корректные символы!");
        }

        // функция считывания вектора из строки
        static void Array_InPut(string str, ref int[] arr)
        {
            String_Check(str);
            str = str.Trim(); // удаление с конца и начала пробелов
            int index = str.IndexOf("  ");
            // удаление между элементами лишних пробелов
            while (index != -1)
            {
                str = str.Remove(index, 1);
                index = str.IndexOf("  ");
            }
            // создание строкового вектора из элементов, разъединенных между собой одним пробелом
            string[] nums = str.Split(new char[] { ' ' });
            Array.Resize(ref arr, nums.Length); // изменение длины вектора            
            for (int i = 0; i < nums.Length; i++)
            {
                // проверка на наличие не корректных символов
                Char_Check(nums[i]);
                arr[i] = int.Parse(nums[i]); // запись
            }
        }

        // перевод MFO-формата в матрицу смежности орграфа, в котором на дугах определена числовая функция
        private static void MFO_Convert(int[] G, int[] P, int[] С, ref int[][] matr)
        {
            Array.Resize(ref matr, P.Length);
            for (int i = 0; i < matr.Length; i++)            
                matr[i] = new int[matr.Length];
            
            // стартовый индекс вектора связей для считывания
            int start = 0;            
            for (int i = 0; i < matr.Length; i++)
            {
                // идем по элементам вектора G
                // пока индекс вектора G меньше значения элемента Р               
                for (int j = start; j < P[i]; j++)
                {
                    matr[i][G[j] - 1] = С[j];                   
                }               
                start = P[i]; // новый индекс
            }            
        }

        // поиск минимального пути
        // MS - матрица смежности графа с числовой функцией на дугах
        // Tree_Points - вектор вершин, из какой вершины будет дуга 
        // в данную в прадереве кратчайших маршрутов 
        // start_point - стартовая вершина
        // finish_point - конечная вершина        
        private static int Min_Way_Find(int[][] MS, ref int[] Tree_Points, int start_point, int finish_point)
        {
            // если стартовая и конечная вершина совпадают
            if (start_point == finish_point)
                return 0;            
            // вектор меток: 1 - временная метка, 0 - постоянная метка
            int[] W_Points = new int[MS.Length];
            // вектор кратчайших расстояний из стартовой вершины
            int[] L_Points = new int[MS.Length];
            for (int i = 0; i < MS.Length; i++)
            {
                W_Points[i] = 1;
                L_Points[i] = -1;
                Tree_Points[i] = -1;
            }
            W_Points[start_point] = 0; // метку в стартовой вершине помечаем как постоянную
            L_Points[start_point] = 0; // длина кратчайшего пути из вершины в саму себя равна 0
            int p_point = start_point; // текущая постоянная метка            
            do
            {
                // обновление кратчайших путей
                for (int i = 0; i < W_Points.Length; i++)
                {
                    // если вершине присвоена временная метка
                    if (W_Points[i] == 1)
                    {
                        // сумма длин путей в текущую постоянную метку
                        // и дуги из текущей метки в вершину i
                        int num = L_Points[p_point] + MS[p_point][i];

                        // если дуги не существует
                        // переходим к другой временной метке
                        if (num == L_Points[p_point])
                            continue;
                        // если раньше не существовало кратчайшего пути
                        // или найден новый кратчайший путь
                        if ( (L_Points[i] == -1) || (num < L_Points[i]) )
                        {
                            // нашли кратчайший путь
                            L_Points[i] = num;
                            // запись из какой вершины
                            Tree_Points[i] = p_point;
                        }                        
                    }
                }
                // поиск не помеченной вершины, до которой путь минимален
                int min_w = -1; // временная метка с минимальным значением кратчайшего пути
                int min_w_l = -1; // минимальное значение кратчайшего пути                
                for (int i = 0; i < W_Points.Length; i++)
                {
                    // если существует кратчайший путь до временной метки
                    if ((W_Points[i] == 1) && (L_Points[i] != -1))
                    {
                        // начальная инициализация
                        // поиск минимума
                        if ((min_w == -1) || (L_Points[i] < min_w_l))
                        {
                            min_w = i;
                            min_w_l = L_Points[i];
                        }                        
                    }
                }
                // если нет меток, до которых существует путь
                if (min_w == -1)
                    return -1;
                // новая постоянная метка
                W_Points[min_w] = 0;
                p_point = min_w;
            }
            while (p_point != finish_point);
            // если выход по невозможности обновить метки            
            return L_Points[finish_point];
        }


        // вывод вершин, через котороый проходит кратчайший путь из 
        // вершины start_point в вершину end_point
        private static void Show_Way(int[] Points, int start_point, int end_point, ref string[] way)
        {
            int i = end_point;
            Array.Resize(ref way, 1);
            // если стартовая и конечная вершина совпадают
            if (start_point == end_point)
            {
                way[0] = "X" + (start_point + 1).ToString();
                return;
            }
            way[0] = "X" + (end_point + 1).ToString();            
            for (int j = 1; i != start_point; j++ )
            {              
                Array.Resize(ref way, j + 1);    
                way[j] = "X" + (Points[i] + 1).ToString();
                i = Points[i];
            }                        
        }
    }
}
