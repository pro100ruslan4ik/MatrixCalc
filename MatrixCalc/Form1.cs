using System;
using System.Linq;
using System.Windows.Forms;

namespace MatrixCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CB1_M1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CB2_M1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CB1_M2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CB2_M2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView3.AllowUserToAddRows = false;
        }
        private void MatrixCreation(DataGridView dataGridView, ComboBox cbM1, ComboBox cbM2)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            for (int i = 0; i < Convert.ToInt32(cbM1.SelectedItem); i++)
            {
                dataGridView.Columns.Add("Column" + i, "Column" + i);
                dataGridView.Columns[i].ValueType = typeof(double);
            }

            for (int i = 0; i < Convert.ToInt32(cbM2.SelectedItem); i++)
            {
                dataGridView.Rows.Add();
            }
        }

        private void Clear_button_M1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            CB1_M1.ResetText();
            CB2_M1.ResetText();
        }
        private void Clear_button_M2_Click(object sender, EventArgs e)
        {
            dataGridView2.Columns.Clear();
            CB1_M2.ResetText();
            CB2_M2.ResetText();
        }

        private void transpose_M1_Click(object sender, EventArgs e)
        {
            DataGridView dataGridView = null;
            if (sender == transpose_M1)
                dataGridView = dataGridView1;
            else if (sender == transpose_M2)
                dataGridView = dataGridView2;

            if (dataGridView == null)
                return;

            bool isEmpty = CheckForEmptyCells(dataGridView);
            if (isEmpty)
            {
                MessageBox.Show("Заполните все ячейки матрицы.");
                return;
            }

            TransposeMatrix(dataGridView);
        }

        private bool CheckForEmptyCells(DataGridView dataGridView)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                        return true;
                }
            }
            return false;
        }

        private void TransposeMatrix(DataGridView dataGridView)
        {
            dataGridView3.Rows.Clear();
            dataGridView3.Columns.Clear();

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                dataGridView3.Columns.Add("Column" + i, "Column" + i);
            }

            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView3.Rows.Add();
            }

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    dataGridView3.Rows[j].Cells[i].Value = dataGridView.Rows[i].Cells[j].Value;
                }
            }
        }

        private void CB1_M1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MatrixCreation();
            ComboBox comboBox = sender as ComboBox;
            if (comboBox == null) return;

            if (comboBox == CB1_M1 || comboBox == CB2_M1)
            {
                MatrixCreation(dataGridView1, CB1_M1, CB2_M1);
            }
            else if (comboBox == CB1_M2 || comboBox == CB2_M2)
            {
                MatrixCreation(dataGridView2, CB1_M2, CB2_M2);
            }

        }


        private static KeyPressEventHandler NumericCheckHandler = new KeyPressEventHandler(NumericCheck);
        //проверка на символьные значения
        private static void NumericCheck(object sender, KeyPressEventArgs e)
        {
            DataGridViewTextBoxEditingControl s = sender as DataGridViewTextBoxEditingControl;
            if (s != null && (e.KeyChar == '.' || e.KeyChar == ',') )
            {
                e.KeyChar = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
                e.Handled = s.Text.Contains(e.KeyChar);
            }

            else
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-';

        }
        //проверка что текст не больше 3 и это не бэкспейс ','
        private void Grid_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                //проверка на количество символов в ячейке
                if (textBox.Text.Length >= 10 && e.KeyChar != (char)Keys.Back && e.KeyChar != '-')
                {
                    e.Handled = true;
                    return;
                }
                if (e.KeyChar == '-' && textBox.SelectionStart!=0)
                {
                    e.Handled = true;
                    return;
                }
                //проверка чтобы нельзя было вводить больше одной запятой
                if (e.KeyChar == ',' && textBox.Text.Contains(','))
                {
                    e.Handled = true;
                    return;
                }
                if (e.KeyChar=='-'&& textBox.Text.Contains('-')) 
                {
                    e.Handled = true;
                    return;
                }
            }

        }
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= NumericCheckHandler;
            e.Control.KeyPress += NumericCheckHandler;
            e.Control.KeyPress -= Grid_KeyPress;
            e.Control.KeyPress += Grid_KeyPress;
        }

        private void multiply_M1_Click(object sender, EventArgs e)
        {
            DataGridView dataGridView = dataGridView1;
            bool isEmpty = CheckForEmptyCells(dataGridView);
            //проверка чтобы текстбокс был заполнен
            if (string.IsNullOrWhiteSpace(textBox_M1.Text))
            {
                MessageBox.Show("Введите число.");
                return;
            }
            if (isEmpty)
            {
                MessageBox.Show("Заполните все ячейки матрицы.");
                return;
            }
            double number;
            if (!double.TryParse(textBox_M1.Text, out number))
            {
                MessageBox.Show("Некрректное число.");
                return;
            }
            MultiplyMatrixByNumber(dataGridView, number);
        }

        private void multiply_M2_Click(object sender, EventArgs e)
        {
            DataGridView dataGridView = dataGridView2;
            bool isEmpty = CheckForEmptyCells(dataGridView);
            //проверка чтобы текстбокс был заполнен
            if (string.IsNullOrWhiteSpace(textBox_M2.Text))
            {
                MessageBox.Show("Введите число.");
                return;
            }
            if (isEmpty)
            {
                MessageBox.Show("Заполните все ячейки матрицы.");
                return;
            }
            double number;
            if (!double.TryParse(textBox_M2.Text, out number))
            {
                MessageBox.Show("Некоректное число.");
                return;
            }
            MultiplyMatrixByNumber(dataGridView, number);
        }
        private void MultiplyMatrixByNumber(DataGridView dataGridView, double number)
        {
            //очистка грида перед созданием
            dataGridView3.Rows.Clear();
            dataGridView3.Columns.Clear();
            //столбцы
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                dataGridView3.Columns.Add("Column" + i, "Column" + i);
            }

            //строки
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView3.Rows.Add();
            }

            //умножение
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    double value = Convert.ToDouble(dataGridView.Rows[i].Cells[j].Value);
                    dataGridView3.Rows[i].Cells[j].Value = value * number;
                }
            }
        }
        private void textBox_M1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox == null) return;

            //проверка на количество символов в текстбоксе
            if (textBox.Text.Length >= 10 && e.KeyChar != (char)Keys.Back && e.KeyChar !='-')
            {
                e.Handled = true;
                return;
            }

            //проверка чтобы нельзя было вводить больше одной запятой
            if (e.KeyChar == ',' && textBox.Text.Contains(','))
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == '-' && textBox.Text.Contains('-'))
            {
                e.Handled = true;
                return;
            }
            //ввод только цифр и запятой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '-')
            {
                e.Handled = true;
                return;
            }
        }

        private void deter_M1_Click(object sender, EventArgs e)
        {
            DataGridView dataGridView = dataGridView1;
            bool isEmpty = CheckForEmptyCells(dataGridView);
            if (isEmpty)
            {
                MessageBox.Show("Заполните все ячейки матрицы.");
                return;
            }

            // Вычисление определителя матрицы
            double deter = CalculateDeterminant(dataGridView);
            // Вывод определителя в textBox3
            textBox1.Text = deter.ToString();
        }
        private void deter_M2_Click(object sender, EventArgs e)
        {
            DataGridView dataGridView = dataGridView2;
            bool isEmpty = CheckForEmptyCells(dataGridView);
            if (isEmpty)
            {
                MessageBox.Show("Заполните все ячейки матрицы.");
                return;
            }

            //вычисление определителя
            double deter = CalculateDeterminant(dataGridView);
            //вывод
            textBox1.Text = deter.ToString();
        }
        private double CalculateDeterminant(DataGridView dataGridView)
        {
            //проверка наличия данных в гриде
            if (dataGridView.Rows.Count == 0 || dataGridView.Columns.Count == 0)
            {
                MessageBox.Show("Пустая матрица.");
                return 0;
            }

            //проверка что матрица квадратная
            if (dataGridView.Rows.Count != dataGridView.Columns.Count)
            {
                MessageBox.Show("Матрица должна быть квадратной!!!");
                return 0;
            }

            //массив для хранения значений матрицы
            double[,] matrix = new double[dataGridView.Rows.Count, dataGridView.Columns.Count];

            //заполняю массив
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    double value;
                    if (!double.TryParse(dataGridView.Rows[i].Cells[j].Value.ToString(), out value))
                    {
                        MessageBox.Show("Неверный формат данных. :(");
                        return 0;
                    }
                    matrix[i, j] = value;
                }
            }

            //вычисление
            double deter = Determinant(matrix);
            return deter;
        }
        private double Determinant(double[,] matrix)
        {
            int n = matrix.GetLength(0);
            double det = 0;

            if (n == 1)
            {
                det = matrix[0, 0];
            }
            else if (n == 2)
            {
                det = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    double[,] subMatrix = new double[n - 1, n - 1];
                    for (int j = 1; j < n; j++)
                    {
                        for (int k = 0; k < n; k++)
                        {
                            if (k < i)
                                subMatrix[j - 1, k] = matrix[j, k];
                            else if (k > i)
                                subMatrix[j - 1, k - 1] = matrix[j, k];
                        }
                    }
                    det += (i % 2 == 0 ? 1 : -1) * matrix[0, i] * Determinant(subMatrix);
                }
            }

            return det;
        }

        private void inverse_M1_Click(object sender, EventArgs e)
        {
            //DataGridView dataGridView = dataGridView1;
            bool isEmpty = CheckForEmptyCells(dataGridView1);
            if (isEmpty)
            {
                MessageBox.Show("Заполните все ячейки матрицы.");
                return;
            }

            //проверка что матрица квадратная
            if (dataGridView1.RowCount != dataGridView1.ColumnCount)
            {
                MessageBox.Show("Матрица должна быть квадратной.");
                return;
            }
            //проверка что обратная матрица существует
            if (CalculateDeterminant(dataGridView1) == 0)
            {
                MessageBox.Show("Не существует.");
                return;
            }
                        //вычисление
            int n = dataGridView1.RowCount;
            dataGridView3.RowCount = n;
            dataGridView3.ColumnCount = n;

            double[,] A = new double[n, n];

            //заполнение массива из грида
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value == null ||
                        !double.TryParse(dataGridView1.Rows[i].Cells[j].Value.ToString(), out A[i, j]))
                    {
                        MessageBox.Show("Введите корректные значения для матрицы A.");
                        return;
                    }
                }
            }

            double[,] inverseMatrix = InverseMatrix(A);

            //вывод
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridView3.Rows[i].Cells[j].Value = Math.Round(inverseMatrix[i, j], 3);
                }
            }
        }

        private void inverse_M2_Click(object sender, EventArgs e)
        {
            bool isEmpty = CheckForEmptyCells(dataGridView2);
            if (isEmpty)
            {
                MessageBox.Show("Заполните все ячейки матрицы.");
                return;
            }

            //проверка что матрица квадратная
            if (dataGridView2.RowCount != dataGridView2.ColumnCount)
            {
                MessageBox.Show("Матрица должна быть квадратной.");
                return;
            }
            //проверка что обратная матрица существует
            if (CalculateDeterminant(dataGridView2) == 0)
            {
                MessageBox.Show("Не существует.");
                return;
            }
                        //вычисление
            int n = dataGridView2.RowCount;
            dataGridView3.RowCount = n;
            dataGridView3.ColumnCount = n;

            double[,] A = new double[n, n];

            //заполнение массива из грида
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (dataGridView2.Rows[i].Cells[j].Value == null ||
                        !double.TryParse(dataGridView2.Rows[i].Cells[j].Value.ToString(), out A[i, j]))
                    {
                        MessageBox.Show("Введите корректные значения для матрицы.");
                        return;
                    }
                }
            }

            double[,] inverseMatrix = InverseMatrix(A);

            //вывод
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridView3.Rows[i].Cells[j].Value = Math.Round(inverseMatrix[i, j],3);
                }
            }
        }
        private double[,] InverseMatrix(double[,] matrix)
        {
            int n = matrix.GetLength(0);
            //единичная матрица
            double[,] L = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        L[i, j] = 1;
                    else
                        L[i, j] = 0;
                }
            }

            //метод гаусса
            for (int j = 0; j < n; j++)
            {
                //выбор ведущего элемента ниже элемента [j,j-1]:
                int m = j;
                for (int k = j + 1; k < n; k++)
                {
                    if (Math.Abs(matrix[k, j]) > Math.Abs(matrix[m, j]))
                        m = k;
                }

                //перестановка строк
                for (int z = 0; z < n; z++)
                {
                    double temp = matrix[j, z];
                    matrix[j, z] = matrix[m, z];
                    matrix[m, z] = temp;

                    temp = L[j, z];
                    L[j, z] = L[m, z];
                    L[m, z] = temp;
                }

                //преобразование строки, чтобы ведущий элемент был 1
                double leadingElement = matrix[j, j];
                for (int z = 0; z < n; z++)
                {
                    matrix[j, z] /= leadingElement;
                    L[j, z] /= leadingElement;
                }

                //произошло обнуление всех остальных элементов в столбце
                for (int i = 0; i < n; i++)
                {
                    if (i != j)
                    {
                        double factor = matrix[i, j];
                        for (int z = 0; z < n; z++)
                        {
                            matrix[i, z] -= factor * matrix[j, z];
                            L[i, z] -= factor * L[j, z];
                        }
                    }
                }
            }
            return L;
        }

        private void sum_button_Click(object sender, EventArgs e)
        {
            //получение размерности матриц
            int rows1 = dataGridView1.RowCount;
            int cols1 = dataGridView1.ColumnCount;
            int rows2 = dataGridView2.RowCount;
            int cols2 = dataGridView2.ColumnCount;

            //проверка что размерность совпадает
            if (rows1 != rows2 || cols1 != cols2)
            {
                MessageBox.Show("Размерность матриц доолжна совпадать.");
                return;
            }

            //матрица результат
            int resultRows = rows1;
            int resultCols = cols1;
            double[,] resultMatrix = new double[resultRows, resultCols];

            //сложене
            for (int i = 0; i < resultRows; i++)
            {
                for (int j = 0; j < resultCols; j++)
                {
                    double value1 = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value);
                    double value2 = Convert.ToDouble(dataGridView2.Rows[i].Cells[j].Value);
                    resultMatrix[i, j] = value1 + value2;
                }
            }

            //вывод
            dataGridView3.Rows.Clear();
            dataGridView3.Columns.Clear();
            dataGridView3.ColumnCount = resultCols;
            dataGridView3.RowCount = resultRows;

            for (int i = 0; i < resultRows; i++)
            {
                for (int j = 0; j < resultCols; j++)
                {
                    dataGridView3.Rows[i].Cells[j].Value = resultMatrix[i, j];
                }
            }
        }

        private void subtract_button_Click(object sender, EventArgs e)
        {
            //получение размерности матриц
            int rows1 = dataGridView1.RowCount;
            int cols1 = dataGridView1.ColumnCount;
            int rows2 = dataGridView2.RowCount;
            int cols2 = dataGridView2.ColumnCount;

            //проверка что размерность совпадает
            if (rows1 != rows2 || cols1 != cols2)
            {
                MessageBox.Show("Размерность матриц доолжна совпадать.");
                return;
            }

            //матрица результат
            int resultRows = rows1;
            int resultCols = cols1;
            double[,] resultMatrix = new double[resultRows, resultCols];

            //вычитане
            for (int i = 0; i < resultRows; i++)
            {
                for (int j = 0; j < resultCols; j++)
                {
                    double value1 = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value);
                    double value2 = Convert.ToDouble(dataGridView2.Rows[i].Cells[j].Value);
                    resultMatrix[i, j] = value1 - value2;
                }
            }

            //вывод
            dataGridView3.Rows.Clear();
            dataGridView3.Columns.Clear();
            dataGridView3.ColumnCount = resultCols;
            dataGridView3.RowCount = resultRows;

            for (int i = 0; i < resultRows; i++)
            {
                for (int j = 0; j < resultCols; j++)
                {
                    dataGridView3.Rows[i].Cells[j].Value = resultMatrix[i, j];
                }
            }
        }

        private void multiply_button_Click(object sender, EventArgs e)
        {
            int rows1 = dataGridView1.RowCount;
            int cols1 = dataGridView1.ColumnCount;
            int rows2 = dataGridView2.RowCount;
            int cols2 = dataGridView2.ColumnCount;

            //проверка на количество строк и столбцов
            if (cols1 != rows2)
            {
                MessageBox.Show("Количество столбцов первой матрицы не совпадает с количеством строк второй матрицы!");
                return;
            }

            //создаю массивы для матриц
            double[,] matrix1 = new double[rows1, cols1];
            double[,] matrix2 = new double[rows2, cols2];

            //заполнение массивов
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    matrix1[i, j] = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value);
                }
            }

            for (int i = 0; i < rows2; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    matrix2[i, j] = Convert.ToDouble(dataGridView2.Rows[i].Cells[j].Value);
                }
            }

            //умножение
            int resultRows = rows1;
            int resultCols = cols2;
            double[,] resultMatrix = new double[resultRows, resultCols];

            for (int i = 0; i < resultRows; i++)
            {
                for (int j = 0; j < resultCols; j++)
                {
                    for (int k = 0; k < cols1; k++)
                    {
                        resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            //вывод
            dataGridView3.Rows.Clear();
            dataGridView3.Columns.Clear();
            dataGridView3.ColumnCount = resultCols;
            dataGridView3.RowCount = resultRows;

            for (int i = 0; i < resultRows; i++)
            {
                for (int j = 0; j < resultCols; j++)
                {
                    dataGridView3.Rows[i].Cells[j].Value = resultMatrix[i, j];
                }
            }

        }

        private void copy_M1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = dataGridView3.ColumnCount;
            dataGridView1.RowCount = dataGridView3.RowCount;
            bool isEmpty = CheckForEmptyCells(dataGridView3);
            if (isEmpty)
            {
                MessageBox.Show("Заполните все ячейки матрицы.");
                return;
            }
            int rowsToCopy = Math.Min(dataGridView3.Rows.Count, dataGridView1.Rows.Count);
            int colsToCopy = Math.Min(dataGridView3.Columns.Count, dataGridView1.Columns.Count);

            for (int i = 0; i < rowsToCopy; i++)
            {
                for (int j = 0; j < colsToCopy; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = dataGridView3.Rows[i].Cells[j].Value;
                }
            }
        }

        private void copy_M2_Click(object sender, EventArgs e)
        {
            dataGridView2.Columns.Clear();

            dataGridView2.Rows.Clear();
            CheckForEmptyCells(dataGridView3);
            dataGridView2.ColumnCount = dataGridView3.ColumnCount;
            dataGridView2.RowCount = dataGridView3.RowCount;
            bool isEmpty = CheckForEmptyCells(dataGridView3);
            if (isEmpty)
            {
                MessageBox.Show("Заполните все ячейки матрицы.");
                return;
            }
            int rowsToCopy = Math.Min(dataGridView3.Rows.Count, dataGridView2.Rows.Count);
            int colsToCopy = Math.Min(dataGridView3.Columns.Count, dataGridView2.Columns.Count);

            for (int i = 0; i < rowsToCopy; i++)
            {
                for (int j = 0; j < colsToCopy; j++)
                {
                    dataGridView2.Rows[i].Cells[j].Value = dataGridView3.Rows[i].Cells[j].Value;
                }
            }
        }

        private void division_button_Click(object sender, EventArgs e)
        {
            bool isEmpty = CheckForEmptyCells(dataGridView2);
            if (isEmpty)
            {
                MessageBox.Show("Заполните все ячейки матрицы.");
                return;
            }
            if (dataGridView2.RowCount != dataGridView2.ColumnCount)
            {
                MessageBox.Show("Матрица B должна быть квадратной.");
                return;
            }
            //проверка что обратная матрица существует
            if (CalculateDeterminant(dataGridView2) == 0)
            {
                MessageBox.Show("Не существует обратной матрицы для B.");
                return;
            }


            int rows1 = dataGridView1.RowCount;
            int cols1 = dataGridView1.ColumnCount;
            int rows2 = dataGridView2.RowCount;
            int cols2 = dataGridView2.ColumnCount;
            int rows2Inversed = dataGridView2.ColumnCount;
            int cols2Inversed = dataGridView2.RowCount;

            //проверка на количество строк и столбцов
            if (cols1 != rows2Inversed)
            {
                MessageBox.Show("Количество столбцов первой матрицы не совпадает с количеством строк второй матрицы!");
                return;
            }

            //создаю массивы для матриц
            double[,] matrix1 = new double[rows1, cols1];
            double[,] matrix2 = new double[rows2, cols2];

            //заполнение массивов
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    matrix1[i, j] = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value);
                }
            }

            for (int i = 0; i < rows2; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    matrix2[i, j] = Convert.ToDouble(dataGridView2.Rows[i].Cells[j].Value);
                }
            }

            InverseMatrix(matrix2);

            for (int i = 0; i < rows2; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    matrix2[i, j] = Convert.ToDouble(dataGridView2.Rows[i].Cells[j].Value);
                }
            }
            //умножение
            int resultRows = rows1;
            int resultCols = cols2;
            double[,] resultMatrix = new double[resultRows, resultCols];

            for (int i = 0; i < resultRows; i++)
            {
                for (int j = 0; j < resultCols; j++)
                {
                    for (int k = 0; k < cols1; k++)
                    {
                        resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            //вывод
            dataGridView3.Rows.Clear();
            dataGridView3.Columns.Clear();
            dataGridView3.ColumnCount = resultCols;
            dataGridView3.RowCount = resultRows;

            for (int i = 0; i < resultRows; i++)
            {
                for (int j = 0; j < resultCols; j++)
                {
                    dataGridView3.Rows[i].Cells[j].Value = resultMatrix[i, j];
                }
            }

        }
        
    }
}
