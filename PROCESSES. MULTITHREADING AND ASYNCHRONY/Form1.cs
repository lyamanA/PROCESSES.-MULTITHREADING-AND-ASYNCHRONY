namespace PROCESSES._MULTITHREADING_AND_ASYNCHRONY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            string sourceFile = textBoxFrom.Text;
            string destinationFile = textBoxTo.Text;

            if (File.Exists(sourceFile))
            {
                // Запуск копирования в отдельном потоке
                Thread copyThread = new Thread(() => CopyFileByCharacter(sourceFile, destinationFile));
                copyThread.Start();
            }
            else
            {
                MessageBox.Show("Исходный файл не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFileFrom_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxFrom.Text = openFileDialog.FileName;
                }
            }
        }

        private void buttonFileTo_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "All files (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //путь к файлу назначения в текстовое поле "To"
                    textBoxTo.Text = saveFileDialog.FileName;
                }
            }
        }

        // для работы с большими файлами лучше использовать StreamReader
        //BaseStream — это поток данных, который используется для чтения или записи данных на более низком уровне.
        //StreamReader и StreamWriter предоставляют методы для работы с текстовыми данными
        //(например, чтение строк, символов),
        //но эти операции выполняются на основе потока байтов, который обрабатывает данные.
        private void CopyFileByCharacter(string sourceFile, string destinationFile)
        {
            using (StreamReader reader = new StreamReader(sourceFile))
            using (StreamWriter writer = new StreamWriter(destinationFile))
            {
                char[] buffer = new char[1];
                int totalCharacters = (int)reader.BaseStream.Length;
                int charactersCopied = 0;

                Invoke(() => {
                    progressBar.Maximum = totalCharacters;
                    progressBar.Value = 0;
                });

                while (reader.Read(buffer, 0, buffer.Length) > 0)
                {
                    writer.Write(buffer, 0, buffer.Length);
                    writer.Flush();  // принудительная запись данных в файл

                    charactersCopied++;

                    // обновление прогресса в главном потоке
                    Invoke(() => {
                        progressBar.Value = charactersCopied;
                    });

                    Thread.Sleep(50); // 50 миллисекунд задержки на каждый символ
                }
            }

            // уведомление о завершении копирования
            Invoke(() => {
                MessageBox.Show("Копирование завершено!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            });
        }


    }
}
