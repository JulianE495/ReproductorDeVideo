using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextPaint
{
    public partial class Form1 : Form
    {
        string doc;
        public Form1()
        {
            InitializeComponent();
            ocultarPN();
            obtenerPropiedadesTexto();
            cargarFuentes();
        }

        private void cargarFuentes()
        {
            cbFont.Items.Clear();
            foreach(FontFamily font in FontFamily.Families)
            {
                string fontName = font.Name;
                cbFont.Items.Add(fontName);
            }
        }
        private void ocultarPN()
        {
            pnMain.Visible = true;
            pnTextTools.Visible = false;
            pnPaintTools.Visible = false;
            pnTextEdit.Visible = false;
            pnTools.Visible = false;
            pnColorEdit.Visible = false;
        }
        private void obtenerPropiedadesTexto()
        {
            string font = txtTextEdit.Font.Name.ToString();
            int fontSize = ((int)txtTextEdit.Font.Size);
            cbFont.Text = font;
            cbFontSize.Text = Convert.ToString(fontSize);
        }

        private void habilitarTextTools()
        {
            if (pnTextTools.Visible == false)
            {
                pnTextTools.Visible = true;
                pnTextEdit.Visible = true;
                pnColorEdit.Visible = false;
                pnMain.Visible = false;
            }
            else
            {
                pnTextTools.Visible = false;
                pnColorEdit.Visible = false;
                pnTextEdit.Visible = true;
                pnMain.Visible = false;
            }
            
        }
        private void habilitarPaintTools()
        {
            if (pnPaintTools.Visible == false)
            {
                pnPaintTools.Visible = true;
                pnTextEdit.Visible = false;
                pnColorEdit.Visible = true;
                pnMain.Visible = false;
            }
            else
            {
                pnPaintTools.Visible = false;
                pnTextEdit.Visible = false;
                pnColorEdit.Visible = true;
                pnMain.Visible = false;
            }
            
        }

        private void btnTextMenu_Click(object sender, EventArgs e)
        {
            habilitarTextTools();

        }

        private void btnPaintMenu_Click(object sender, EventArgs e)
        {
            habilitarPaintTools();
        }

        private void btnNewDoc_Click(object sender, EventArgs e)
        {
            pnTextEdit.Visible = true;
            pnTools.Visible = false;
            txtTextEdit.Clear();
            doc = null;
            Form1.ActiveForm.Text = doc + "TextPaint";

        }

        private void btnTextTools_Click(object sender, EventArgs e)
        {
            if (pnTools.Visible == true)
            {
                pnTools.Visible = false;
            }
            else if (pnTools.Visible == false)
            {
                pnTools.Visible = true;
            }
        }

        private void cbFont_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            string text = cbFont.Items[e.Index].ToString();
            Font font = new Font(text, e.Font.Size);

            e.Graphics.DrawString(text, font, new SolidBrush(e.ForeColor), e.Bounds.Left + 2 , e.Bounds.Top + 2);
            e.DrawFocusRectangle();
        }

        private void cbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            int fontSize = Convert.ToInt32(cbFontSize.Text);
            txtTextEdit.Font = new Font(cbFont.Text, fontSize);
        }

        private void cbFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            int fontSize = Convert.ToInt32(cbFontSize.Text);
            txtTextEdit.Font = new Font(cbFont.Text, fontSize);
        }

        private void btnOpenDoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Texto|*.txt";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                doc = openFile.FileName;
                
                using (StreamReader sr = new StreamReader(doc))
                {
                    txtTextEdit.Text = sr.ReadToEnd();
                }
                Form1.ActiveForm.Text = doc + " | TextPaint";
            }
        }

        private void btnSaveDoc_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Texto|*.txt";
            
            if (doc != null)
            {
                using (StreamWriter sw = new StreamWriter(doc))
                {
                    sw.Write(txtTextEdit.Text);
                }
            }
            else
            {
                if(saveFile.ShowDialog() == DialogResult.OK)
                {
                    doc = saveFile.FileName;
                    using (StreamWriter sw = new StreamWriter(saveFile.FileName))
                    {
                        sw.Write(txtTextEdit.Text);
                    }

                }
            }
            Form1.ActiveForm.Text = doc + " | TextPaint";
        }
        private void btnColors_Click(object sender, EventArgs e)
        {
            Color c = Color.Black;
            ColorDialog clrDialog = new ColorDialog();

            if (clrDialog.ShowDialog() == DialogResult.OK)
            { 
                c = clrDialog.Color;
                pnColorEdit.BackColor = c;
                txtColorEdit.BackColor = c;
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            if (fontDlg.ShowDialog() == DialogResult.OK)
            {
                fontDlg.ShowColor = true;
                fontDlg.ShowApply = true;
                fontDlg.ShowEffects = true;
                fontDlg.ShowHelp = true;
                fontDlg.MaxSize = 36;
                fontDlg.MinSize = 10;
                txtColorEdit.Font = fontDlg.Font;
            }
        }
    }
}
