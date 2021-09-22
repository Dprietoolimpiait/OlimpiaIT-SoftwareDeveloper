namespace OlimpiaIT.WinApplicacion.FileValidator.Utils
{
    using System;
    using System.IO;
    using System.Text;

    /// <summary>
    /// Clase interna para realizar la validación del archivo
    /// </summary>
    internal class Validator : IDisposable
    {
        #region Private properties
        private string _filePath { get; set; }
        #endregion

        #region Public properties
        public string FileName { get; set; }
        public string Size { get; set; }
        public int Lines { get; set; }
        public int CorrectLines { get; set; }
        public int ErrorLines { get; set; }
        public string OutFile { get; set; }
        #endregion

        public Validator(string filePath) => GetFileInfo(filePath);

        private void GetFileInfo(string filePath)
        {
            _filePath = filePath;
            FileInfo fi = new FileInfo(_filePath);
            if (fi.Exists)
            {
                FileName = fi.Name;
                Size = FileSize(fi.Length);
            }
            else
            {
                throw new ApplicationException("Debe especificar una ruta valida para el archivo");
            }
        }

        /// <summary>
        /// Metodo para realizar la validación linea por linea del archivo
        /// </summary>
        public void ValidateFile()
        {
            try
            {
                string[] fileWithLines = File.ReadAllLines(_filePath);
                StringBuilder sbResult = new StringBuilder();
                if (fileWithLines != null && fileWithLines.Length > 0)
                {
                    Lines = fileWithLines.Length;
                    foreach (string lineNum in fileWithLines)
                    {
                        if (lineNum.IsValidLineCount())
                        {
                            if (lineNum.IsNumber())
                            {
                                sbResult.AppendLine(lineNum.IsMultiplotOf(3));
                                CorrectLines++;
                            }
                            else
                            {
                                sbResult.AppendLine("El valor en esta linea no corresponde a un numero entero");
                                ErrorLines++;
                            }
                        }
                        else
                        {
                            sbResult.AppendLine("La longitud de la cadena debe estar entre 50 y 1000 caracteres");
                            ErrorLines++;
                        }
                    }

                    if (sbResult.Length > 0)
                        CreateFile(sbResult);
                }
                else
                {
                    throw new ApplicationException("No es posible validar un archivo vacío");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Metodo que crea un archivo en el directorio de la aplicación
        /// </summary>
        /// <param name="sbContent"></param>
        private void CreateFile(StringBuilder sbContent)
        {
            try
            {
                string fileNameResult = string.Concat(AppDomain.CurrentDomain.BaseDirectory, DateTime.Now.ToString("ddMMyyyy_HHmmss"), ".txt");
                OutFile = fileNameResult;
                using (StreamWriter fileResult = new StreamWriter(fileNameResult))
                {
                    fileResult.WriteLine(sbContent.ToString());
                }
            }
            catch (Exception ex)
            {
                OutFile = string.Empty;
                throw new Exception("Ocurrió un error creando el archivo, error: " + ex.Message);
            }
        }

        private string FileSize(long size)
        {
            string sizeFile = string.Empty;
            if (size < 1024)
            {
                sizeFile = string.Concat(size, " KB");
            } else
            {
                sizeFile = string.Concat(size / 1024, " MB");
            }

            return sizeFile;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

    }
}
