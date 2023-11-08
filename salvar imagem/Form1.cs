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

namespace salvar_imagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string arquivo,arquivo2,arquivo3,arquivo4, caminhoarquivo, caminhoarquivo2, caminhoarquivo3, caminhoarquivo4;

        imagem i = new imagem();
        private void btnAddImagem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
             
            
            }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            if (picturebox.Visible == true)
            {

                i._caminho = caminhoarquivo.Replace(@"\", @"\\"); ;
                i.inserir();//Jogar na tabela
                picturebox.Image.Save("D:\\fotos\\" + arquivo + ".png", System.Drawing.Imaging.ImageFormat.Png);
                string dbfile = carregarfoto.FileName; //Jogar na pasta

            }
            if (pictureBox2.Visible == true)
            {

                i._caminho = caminhoarquivo2.Replace(@"\", @"\\"); ;
                i.inserir();
                pictureBox2.Image.Save("D:\\fotos\\" + arquivo2 + ".png", System.Drawing.Imaging.ImageFormat.Png);
                string dbfile = carregarfoto.FileName;
            }
            if (pictureBox3.Visible == true)
            {

                i._caminho = caminhoarquivo3.Replace(@"\", @"\\"); ;
                i.inserir();
                pictureBox3.Image.Save("D:\\fotos\\" + arquivo3 + ".png", System.Drawing.Imaging.ImageFormat.Png);
                string dbfile = carregarfoto.FileName;

            }
            if (pictureBox4.Visible == true)
            {

                i._caminho = caminhoarquivo4.Replace(@"\", @"\\"); ;
                i.inserir();
                pictureBox4.Image.Save("D:\\fotos\\" + arquivo4 + ".png", System.Drawing.Imaging.ImageFormat.Png);
                string dbfile = carregarfoto.FileName;

            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                carregarfoto.ShowDialog();
                Bitmap bmp = new Bitmap(carregarfoto.FileName);

                Bitmap bmp2 = new Bitmap(bmp);
                pictureBox2.Image = bmp2;
                string nomeArquivo = Path.GetFileNameWithoutExtension(carregarfoto.FileName);

                arquivo2 = nomeArquivo;
                caminhoarquivo2 = ("D:\\fotos\\" + arquivo2 + ".png");


              
                if (MessageBox.Show("Deseja adicionar mais fotos?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    pictureBox3.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar.");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                carregarfoto.ShowDialog();
                Bitmap bmp = new Bitmap(carregarfoto.FileName);

                Bitmap bmp2 = new Bitmap(bmp);
                pictureBox3.Image = bmp2;
                string nomeArquivo = Path.GetFileNameWithoutExtension(carregarfoto.FileName);

                arquivo3 = nomeArquivo;
                caminhoarquivo3 = ("D:\\fotos\\" + arquivo + ".png");

  
                

                if (MessageBox.Show("Deseja adicionar mais fotos?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    pictureBox4.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar.");
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                carregarfoto.ShowDialog();
                Bitmap bmp = new Bitmap(carregarfoto.FileName);

                Bitmap bmp2 = new Bitmap(bmp);
                pictureBox4.Image = bmp2;
                string nomeArquivo = Path.GetFileNameWithoutExtension(carregarfoto.FileName);

                arquivo4 = nomeArquivo;
                caminhoarquivo4 = ("D:\\fotos\\" + arquivo + ".png");

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar.");
            }

        }

        private void ptBImagem_Click(object sender, EventArgs e)
        {
            try
            {
                carregarfoto.ShowDialog();
                Bitmap bmp = new Bitmap(carregarfoto.FileName);

                Bitmap bmp2 = new Bitmap(bmp);
                picturebox.Image = bmp2;
                string nomeArquivo = Path.GetFileNameWithoutExtension(carregarfoto.FileName);

                arquivo = nomeArquivo;
                caminhoarquivo = ("D:\\fotos\\" + arquivo + ".png");


               

                if (MessageBox.Show("Deseja adicionar mais fotos?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    pictureBox2.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar.");
            }

        }
    }
    }




