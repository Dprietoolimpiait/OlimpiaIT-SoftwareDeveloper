using OlimpiaIT.WinApplicacion.FileValidator.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlimpiaIT.WinApplicacion.FileValidator
{
    public partial class frmFileValidator : Form
    {
        public frmFileValidator()
        {
            InitializeComponent();
        }

        private string FilePath { get; set; }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdFileEntry = new OpenFileDialog();
            ofdFileEntry.Filter = "Archivos de texto (*.txt)|*.txt";
            ofdFileEntry.Title = "Open Text File";
            ofdFileEntry.InitialDirectory = @"C:\";
            FilePath = string.Empty;
            ResetControls();
            if (ofdFileEntry.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FilePath = lblFilePath.Text = ofdFileEntry.FileName;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            btnProcesar.Enabled = !string.IsNullOrEmpty(FilePath);
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {                
                using (var validateFile = new Validator(FilePath))
                {
                    lblFileName.Text = validateFile.FileName;
                    lblSize.Text = validateFile.Size;
                    validateFile.ValidateFile();
                    lblTotalLines.Text = validateFile.Lines.ToString();
                    lblCorrectLines.Text = validateFile.CorrectLines.ToString();
                    lblLineErrors.Text = validateFile.ErrorLines.ToString();
                    lblStatus.Text = "Proceso completado";
                    lnkFileOutput.Visible = lblFileOut.Visible = !string.IsNullOrEmpty(validateFile.OutFile);
                    lnkFileOutput.Text = validateFile.OutFile;
                }
            }
            catch(ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblStatus.Text = "Proceso completado con advertencia";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error en la validación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Proceso completado con errores";
            }
        }

        private void frmFileValidator_Load(object sender, EventArgs e)
        {

        }

        private void lnkFileOutput_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(lnkFileOutput.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ResetControls()
        {
            lblFileName.Text = string.Empty;
            lblSize.Text = string.Empty;
            lblTotalLines.Text = string.Empty;
            lblCorrectLines.Text = string.Empty;
            lblLineErrors.Text = string.Empty;
            lblStatus.Text = string.Empty;
            lnkFileOutput.Visible = lblFileOut.Visible = false;
            lnkFileOutput.Text = string.Empty; 
        }
    }
}
