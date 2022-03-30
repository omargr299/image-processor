using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Math;
using AForge.Imaging.Filters;


namespace Examen
{
    public partial class frm_Imagenes : Form
    {
        Bitmap filtrando;
        Bitmap imagen_filtrada;
        public frm_Imagenes()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.DefaultExt = ".jpg";
                String nombre = System.DateTime.Now.ToShortDateString() + " " + System.DateTime.Now.ToLongTimeString();
                nombre = nombre.Replace("/", "-");
                nombre = nombre.Replace(":", "_");
                saveFileDialog1.FileName = nombre;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pbx_Procesada.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
            catch
            {
                MessageBox.Show("¡NO SE PUDO GUARDAR!");
            }
        }

        private void btn_Cargar_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image miImagen = Image.FromFile(openFileDialog1.FileName);
                pbx_Original.Image = miImagen;
                pbx_Procesada.Image = miImagen;
                imagen_filtrada = (Bitmap)miImagen;
                filtrando = (Bitmap)miImagen;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbt_Expandido_CheckedChanged(object sender, EventArgs e)
        {
            pbx_Original.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx_Procesada.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void rbt_Normal_CheckedChanged(object sender, EventArgs e)
        {
            pbx_Original.SizeMode = PictureBoxSizeMode.Normal;
            pbx_Procesada.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void rbt_Centrado_CheckedChanged(object sender, EventArgs e)
        {
            pbx_Original.SizeMode = PictureBoxSizeMode.CenterImage;
            pbx_Procesada.SizeMode = PictureBoxSizeMode.CenterImage;
        }
        
        private void rbt_Zoom_CheckedChanged(object sender, EventArgs e)
        {
            pbx_Original.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_Procesada.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btn_Reiniciar_Click(object sender, EventArgs e)
        {
            nvl_Brillo.Text = "0";
            nvl_Contraste.Text = "0";
            nvl_Saturacion.Text = "0";
            nvl_Zoom.Text = "0";

            tkb_Brillo.Value = 0;
            tkb_Contraste.Value = 0;
            tkb_Saturacion.Value = 0;
            tkb_Zoom.Value = 0;

            rbt_Expandido.Checked = true;

            imagen_filtrada = (Bitmap)pbx_Original.Image;
            filtrando = (Bitmap)pbx_Original.Image;

            pbx_Procesada.Image = pbx_Original.Image;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void tkb_Brillo_Scroll(object sender, EventArgs e)
        {
            nvl_Brillo.Text = tkb_Brillo.Value.ToString();
            IFilter filtro = new BrightnessCorrection(tkb_Brillo.Value);
            filtrando = filtro.Apply(imagen_filtrada);
            pbx_Procesada.Image = filtrando;
        }

        private void tkb_Brillo_MouseUP(object sender, EventArgs e)
        {
            
        }

        private void tkb_Contraste_Scroll(object sender, EventArgs e)
        {
            nvl_Contraste.Text = tkb_Contraste.Value.ToString();
            IFilter filtro = new BrightnessCorrection(tkb_Contraste.Value);
            filtrando = filtro.Apply(imagen_filtrada);
            pbx_Procesada.Image = filtrando;
        }

        private void tkb_Saturacion_Scroll(object sender, EventArgs e)
        {
            nvl_Saturacion.Text = tkb_Saturacion.Value.ToString();
            IFilter filtro = new SaturationCorrection(tkb_Saturacion.Value);
            filtrando = filtro.Apply(imagen_filtrada);
            pbx_Procesada.Image = filtrando;
        }

        private void tkb_Zoom_Scroll(object sender, EventArgs e)
        {
            nvl_Zoom.Text = tkb_Zoom.Value.ToString() + "%";
            if (tkb_Zoom.Value >= 0)
            {
                Bitmap BM = new Bitmap(filtrando);
                Bitmap BM2 = new Bitmap((int)(BM.Width * (1 + (tkb_Zoom.Value/100))), (int)(BM.Height * (1 + (tkb_Zoom.Value / 100))));
                Graphics reduccion = Graphics.FromImage(BM2);
                reduccion.DrawImage(BM,0,0,BM2.Width,BM2.Height);
                pbx_Procesada.Image = BM2;
            }
            else if (tkb_Zoom.Value < 0 && tkb_Zoom.Value > tkb_Zoom.Minimum)
            {
                Bitmap BM = new Bitmap(filtrando);
                Bitmap BM2 = new Bitmap((int)(BM.Width * (1 + (tkb_Zoom.Value / 100))), (int)(BM.Height * (1 + (tkb_Zoom.Value / 100))));
                Graphics reduccion = Graphics.FromImage(BM2);
                reduccion.DrawImage(BM, 0, 0, BM2.Width, BM2.Height);
                pbx_Procesada.Image = BM2;
            }
        }

        private void nvl_Zoom_Click(object sender, EventArgs e)
        {

        }
        
    }
}
