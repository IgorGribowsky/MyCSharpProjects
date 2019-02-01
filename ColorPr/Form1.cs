using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPr
{
    public partial class Form1 : Form
    {
        UInt32 oldColor, newColor;
        int R, G, B, Rt, Gt, Bt, nR, nG, nB, nRt, nGt, nBt;
        int Chs;
        int AChs;
        int n;
        Bitmap Input;
        Bitmap Output;

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            n = hScrollBar1.Value;
            label2.Text = n.ToString("n");
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (pbinput.Image != null && oldColor != 0 && newColor != 0)
            {
                transbitmap();
            }
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            if (Chs == 0)
            {
                Chs = 1;
                label3.Text = "Выберите цвет, кликнув по изображению в нужном месте";
            }
            else
            {
                Chs = 0;
                label3.Text = "";
            }
        }

        private void pbinput_MouseClick(object sender, MouseEventArgs e)
        {
            if (pbinput.Image != null && Chs == 1)
            {
                int X = Cursor.Position.X - pbinput.Location.X - this.DesktopLocation.X - 10;
                int Y = Cursor.Position.Y - pbinput.Location.Y - this.DesktopLocation.Y - 32;
                int w, h;
                w = 0;
                h = 0;
                if (Input.Width > Input.Height) 
                {
                     w = pbinput.Width;
                     h = pbinput.Width * Input.Height / Input.Width;
                }
                if (Input.Height > Input.Width)
                {
                     w = pbinput.Height * Input.Width / Input.Height;
                     h = pbinput.Height;
                }
                Y -= (pbinput.Height - h) / 2;
                X -= (pbinput.Width - w) / 2;
                if (X >= 0 && X <= w && Y >- 0 && Y <= h)
                {
                    label3.Text = "";
                    Chs = 0;
                    int BX = X * Input.Width / w;
                    int BY = Y * Input.Height / h;
                    UInt32 pixel = (UInt32)(Input.GetPixel(BX, BY).ToArgb());
                    oldColor = pixel;
                    pboldcolor.Refresh();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pboutput.Image != null)
            {
                Input = Output;
                pbinput.Image = pboutput.Image;
            }
        }

        private void buttonAreaChoose_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonBW_Click(object sender, EventArgs e)
        {
            Output = new Bitmap(Input.Width, Input.Height);
            for (int j = 0; j < Input.Height; j++)
                for (int i = 0; i < Input.Width; i++)
                {
                    UInt32 pixel = (UInt32)(Input.GetPixel(i, j).ToArgb());
                    R = (int)((pixel & 0x00FF0000) >> 16);
                    G = (int)((pixel & 0x0000FF00) >> 8);
                    B = (int)(pixel & 0x000000FF);
                    nR = nG = nB = (int)Math.Abs((R + G + B) / 3.0f);
                    UInt32 newpixel = 0xFF000000 | ((UInt32)nR << 16) | ((UInt32)nG << 8) | ((UInt32)nB);
                    Output.SetPixel(i, j, Color.FromArgb((int)newpixel));
                }
            pboutput.Image = Output;
        }
        void transbitmap()
        {
            Output = new Bitmap(Input.Width, Input.Height);
            for (int j = 0; j < Input.Height; j++)
                for (int i = 0; i < Input.Width; i++)
                {
                    UInt32 pixel = (UInt32)(Input.GetPixel(i, j).ToArgb());
                    R = (int)((pixel & 0x00FF0000) >> 16);
                    G = (int)((pixel & 0x0000FF00) >> 8);
                    B = (int)(pixel & 0x000000FF);

                    Rt = (int)((oldColor & 0x00FF0000) >> 16);
                    Gt = (int)((oldColor & 0x0000FF00) >> 8);
                    Bt = (int)(oldColor & 0x000000FF);

                    nRt = (int)((newColor & 0x00FF0000) >> 16);
                    nGt = (int)((newColor & 0x0000FF00) >> 8);
                    nBt = (int)(newColor & 0x000000FF);

                            if (Math.Abs(R - Rt) + Math.Abs(G - Gt) + Math.Abs(B - Bt) <= n)
                       //     if (Math.Abs(R - Rt)<=n && Math.Abs(G - Gt) <= n && Math.Abs(B - Rt) <= n)
                            {
                                if (R >= G && R >= B && G >= B)
                                {
                                    if (nRt >= nGt && nRt >= nBt && nGt >= nBt)
                                    {
                                        nR = (int)Math.Abs((R + nRt) / 2.0f);
                                        nG = (int)Math.Abs((G + nGt) / 2.0f);
                                        nB = (int)Math.Abs((B + nBt) / 2.0f);
                                    }

                                    else if (nRt >= nGt && nRt >= nBt && nBt >= nGt)
                                    {
                                        nR = (int)Math.Abs((R + nRt) / 2.0f);
                                        nG = (int)Math.Abs((B + nGt) / 2.0f);
                                        nB = (int)Math.Abs((G + nBt) / 2.0f);
                                    }

                                    else if (nGt >= nRt && nGt >= nBt && nRt >= nBt)
                                    {
                                        nR = (int)Math.Abs((G + nRt) / 2.0f);
                                        nG = (int)Math.Abs((R + nGt) / 2.0f);
                                        nB = (int)Math.Abs((B + nBt) / 2.0f);
                                    }
                                    else if (nGt >= nRt && nGt >= nBt && nBt >= nRt)
                                    {
                                        nR = (int)Math.Abs((B + nRt) / 2.0f);
                                        nG = (int)Math.Abs((R + nGt) / 2.0f);
                                        nB = (int)Math.Abs((G + nBt) / 2.0f);
                                    }
                                    else if (nBt >= nRt && nBt >= nGt && nRt >= nGt)
                                    {
                                        nR = (int)Math.Abs((G + nRt) / 2.0f);
                                        nG = (int)Math.Abs((B + nGt) / 2.0f);
                                        nB = (int)Math.Abs((R + nBt) / 2.0f);
                                    }
                                    else if (nBt >= nRt && nBt >= nGt && nGt >= nRt)
                                    {
                                        nR = (int)Math.Abs((B + nRt) / 2.0f);
                                        nG = (int)Math.Abs((G + nGt) / 2.0f);
                                        nB = (int)Math.Abs((R + nBt) / 2.0f);
                                    }
                                }
                                else if (R >= G && R >= B && B >= G)
                                {
                                    if (nRt >= nGt && nRt >= nBt && nGt >= nBt)
                                    {
                                        nR = (int)Math.Abs((R + nRt) / 2.0f);
                                        nG = (int)Math.Abs((B + nGt) / 2.0f);
                                        nB = (int)Math.Abs((G + nBt) / 2.0f);
                                    }

                                    else if (nRt >= nGt && nRt >= nBt && nBt >= nGt)
                                    {
                                        nR = (int)Math.Abs((R + nRt) / 2.0f);
                                        nG = (int)Math.Abs((G + nGt) / 2.0f);
                                        nB = (int)Math.Abs((B + nBt) / 2.0f);
                                    }

                                    else if (nGt >= nRt && nGt >= nBt && nRt >= nBt)
                                    {
                                        nR = (int)Math.Abs((B + nRt) / 2.0f);
                                        nG = (int)Math.Abs((R + nGt) / 2.0f);
                                        nB = (int)Math.Abs((G + nBt) / 2.0f);
                                    }
                                    else if (nGt >= nRt && nGt >= nBt && nBt >= nRt)
                                    {
                                        nR = (int)Math.Abs((G + nRt) / 2.0f);
                                        nG = (int)Math.Abs((R + nGt) / 2.0f);
                                        nB = (int)Math.Abs((B + nBt) / 2.0f);
                                    }
                                    else if (nBt >= nRt && nBt >= nGt && nRt >= nGt)
                                    {
                                        nR = (int)Math.Abs((B + nRt) / 2.0f);
                                        nG = (int)Math.Abs((G + nGt) / 2.0f);
                                        nB = (int)Math.Abs((R + nBt) / 2.0f);
                                    }
                                    else if (nBt >= nRt && nBt >= nGt && nGt >= nRt)
                                    {
                                        nR = (int)Math.Abs((G + nRt) / 2.0f);
                                        nG = (int)Math.Abs((B + nGt) / 2.0f);
                                        nB = (int)Math.Abs((R + nBt) / 2.0f);
                                    }
                                }
                                else if (G >= R && G >= B && R >= B)
                                {
                                    if (nRt >= nGt && nRt >= nBt && nGt >= nBt)
                                    {
                                        nR = (int)Math.Abs((G + nRt) / 2.0f);
                                        nG = (int)Math.Abs((R + nGt) / 2.0f);
                                        nB = (int)Math.Abs((B + nBt) / 2.0f);
                                    }

                                    else if (nRt >= nGt && nRt >= nBt && nBt >= nGt)
                                    {
                                        nR = (int)Math.Abs((G + nRt) / 2.0f);
                                        nG = (int)Math.Abs((B + nGt) / 2.0f);
                                        nB = (int)Math.Abs((R + nBt) / 2.0f);
                                    }

                                    else if (nGt >= nRt && nGt >= nBt && nRt >= nBt)
                                    {
                                        nR = (int)Math.Abs((R + nRt) / 2.0f);
                                        nG = (int)Math.Abs((G + nGt) / 2.0f);
                                        nB = (int)Math.Abs((B + nBt) / 2.0f);
                                    }
                                    else if (nGt >= nRt && nGt >= nBt && nBt >= nRt)
                                    {
                                        nR = (int)Math.Abs((B + nRt) / 2.0f);
                                        nG = (int)Math.Abs((G + nGt) / 2.0f);
                                        nB = (int)Math.Abs((R + nBt) / 2.0f);
                                    }
                                    else if (nBt >= nRt && nBt >= nGt && nRt >= nGt)
                                    {
                                        nR = (int)Math.Abs((R + nRt) / 2.0f);
                                        nG = (int)Math.Abs((B + nGt) / 2.0f);
                                        nB = (int)Math.Abs((G + nBt) / 2.0f);
                                    }
                                    else if (nBt >= nRt && nBt >= nGt && nGt >= nRt)
                                    {
                                        nR = (int)Math.Abs((B + nRt) / 2.0f);
                                        nG = (int)Math.Abs((R + nGt) / 2.0f);
                                        nB = (int)Math.Abs((G + nBt) / 2.0f);
                                    }
                                }
                                else if (G >= R && G >= B && B >= R)
                                {
                                    if (nRt >= nGt && nRt >= nBt && nGt >= nBt)
                                    {
                                        nR = (int)Math.Abs((G + nRt) / 2.0f);
                                        nG = (int)Math.Abs((B + nGt) / 2.0f);
                                        nB = (int)Math.Abs((R + nBt) / 2.0f);
                                    }

                                    else if (nRt >= nGt && nRt >= nBt && nBt >= nGt)
                                    {
                                        nR = (int)Math.Abs((G + nRt) / 2.0f);
                                        nG = (int)Math.Abs((R + nGt) / 2.0f);
                                        nB = (int)Math.Abs((B + nBt) / 2.0f);
                                    }

                                    else if (nGt >= nRt && nGt >= nBt && nRt >= nBt)
                                    {
                                        nR = (int)Math.Abs((B + nRt) / 2.0f);
                                        nG = (int)Math.Abs((G + nGt) / 2.0f);
                                        nB = (int)Math.Abs((R + nBt) / 2.0f);
                                    }
                                    else if (nGt >= nRt && nGt >= nBt && nBt >= nRt)
                                    {
                                        nR = (int)Math.Abs((R + nRt) / 2.0f);
                                        nG = (int)Math.Abs((G + nGt) / 2.0f);
                                        nB = (int)Math.Abs((B + nBt) / 2.0f);
                                    }
                                    else if (nBt >= nRt && nBt >= nGt && nRt >= nGt)
                                    {
                                        nR = (int)Math.Abs((B + nRt) / 2.0f);
                                        nG = (int)Math.Abs((R + nGt) / 2.0f);
                                        nB = (int)Math.Abs((G + nBt) / 2.0f);
                                    }
                                    else if (nBt >= nRt && nBt >= nGt && nGt >= nRt)
                                    {
                                        nR = (int)Math.Abs((R + nRt) / 2.0f);
                                        nG = (int)Math.Abs((B + nGt) / 2.0f);
                                        nB = (int)Math.Abs((G + nBt) / 2.0f);
                                    }
                                }
                                else if (B >= R && B >= G && R >= G)
                                {
                                    if (nRt >= nGt && nRt >= nBt && nGt >= nBt)
                                    {
                                        nR = (int)Math.Abs((B + nRt) / 2.0f);
                                        nG = (int)Math.Abs((R + nGt) / 2.0f);
                                        nB = (int)Math.Abs((G + nBt) / 2.0f);
                                    }

                                    else if (nRt >= nGt && nRt >= nBt && nBt >= nGt)
                                    {
                                        nR = (int)Math.Abs((B + nRt) / 2.0f);
                                        nG = (int)Math.Abs((G + nGt) / 2.0f);
                                        nB = (int)Math.Abs((R + nBt) / 2.0f);
                                    }

                                    else if (nGt >= nRt && nGt >= nBt && nRt >= nBt)
                                    {
                                        nR = (int)Math.Abs((R + nRt) / 2.0f);
                                        nG = (int)Math.Abs((B + nGt) / 2.0f);
                                        nB = (int)Math.Abs((G + nBt) / 2.0f);
                                    }
                                    else if (nGt >= nRt && nGt >= nBt && nBt >= nRt)
                                    {
                                        nR = (int)Math.Abs((G + nRt) / 2.0f);
                                        nG = (int)Math.Abs((B + nGt) / 2.0f);
                                        nB = (int)Math.Abs((R + nBt) / 2.0f);
                                    }
                                    else if (nBt >= nRt && nBt >= nGt && nRt >= nGt)
                                    {
                                        nR = (int)Math.Abs((R + nRt) / 2.0f);
                                        nG = (int)Math.Abs((G + nGt) / 2.0f);
                                        nB = (int)Math.Abs((B + nBt) / 2.0f);
                                    }
                                    else if (nBt >= nRt && nBt >= nGt && nGt >= nRt)
                                    {
                                        nR = (int)Math.Abs((G + nRt) / 2.0f);
                                        nG = (int)Math.Abs((R + nGt) / 2.0f);
                                        nB = (int)Math.Abs((B + nBt) / 2.0f);
                                    }
                                }
                                else if (B >= R && B >= G && G >= R)
                                {
                                    if (nRt >= nGt && nRt >= nBt && nGt >= nBt)
                                    {
                                        nR = (int)Math.Abs((B + nRt) / 2.0f);
                                        nG = (int)Math.Abs((G + nGt) / 2.0f);
                                        nB = (int)Math.Abs((R + nBt) / 2.0f);
                                    }

                                    else if (nRt >= nGt && nRt >= nBt && nBt >= nGt)
                                    {
                                        nR = (int)Math.Abs((B + nRt) / 2.0f);
                                        nG = (int)Math.Abs((R + nGt) / 2.0f);
                                        nB = (int)Math.Abs((G + nBt) / 2.0f);
                                    }

                                    else if (nGt >= nRt && nGt >= nBt && nRt >= nBt)
                                    {
                                        nR = (int)Math.Abs((G + nRt) / 2.0f);
                                        nG = (int)Math.Abs((B + nGt) / 2.0f);
                                        nB = (int)Math.Abs((R + nBt) / 2.0f);
                                    }
                                    else if (nGt >= nRt && nGt >= nBt && nBt >= nRt)
                                    {
                                        nR = (int)Math.Abs((R + nRt) / 2.0f);
                                        nG = (int)Math.Abs((B + nGt) / 2.0f);
                                        nB = (int)Math.Abs((G + nBt) / 2.0f);
                                    }
                                    else if (nBt >= nRt && nBt >= nGt && nRt >= nGt)
                                    {
                                        nR = (int)Math.Abs((G + nRt) / 2.0f);
                                        nG = (int)Math.Abs((R + nGt) / 2.0f);
                                        nB = (int)Math.Abs((B + nBt) / 2.0f);
                                    }
                                    else if (nBt >= nRt && nBt >= nGt && nGt >= nRt)
                                    {
                                        nR = (int)Math.Abs((R + nRt) / 2.0f);
                                        nG = (int)Math.Abs((G + nGt) / 2.0f);
                                        nB = (int)Math.Abs((B + nBt) / 2.0f);
                                    }
                                }
                            }


                    else { nR = R; nG = G; nB = B; }
                    UInt32 newpixel = 0xFF000000 | ((UInt32)nR << 16) | ((UInt32)nG << 8) | ((UInt32)nB);
                    Output.SetPixel(i, j, Color.FromArgb((int)newpixel));
                }
            pboutput.Image = Output;
        }
        private void pbnewcolor_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush br = new SolidBrush(System.Drawing.Color.FromArgb((int)newColor));

            e.Graphics.FillRectangle(br, 0, 0, pbnewcolor.Width, pbnewcolor.Height);
        }

        private void pboldcolor_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush br = new SolidBrush(System.Drawing.Color.FromArgb((int)oldColor));

            e.Graphics.FillRectangle(br, 0, 0, pboldcolor.Width, pboldcolor.Height);
        }

        public Form1()
        {
            InitializeComponent();
            oldColor = 0;
            newColor = 0;
            Chs = 0;
            AChs = 0;
            n = hScrollBar1.Value;
            label2.Text = n.ToString("n");
        }
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All Files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Input = new Bitmap(ofd.FileName);
                    pbinput.Image = Input;
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (pboutput.Image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Сохранить картинку как...";
                sfd.OverwritePrompt = true;
                sfd.CheckPathExists = true;
                sfd.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All Files(*.*)|*.*";
                sfd.ShowHelp = true;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pboutput.Image.Save(sfd.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else MessageBox.Show("Сначала откройте файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonOldColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                oldColor = (UInt32)cd.Color.ToArgb();
                pboldcolor.Refresh();
            }
        }

        private void buttonNewColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                newColor = (UInt32)cd.Color.ToArgb();
                pbnewcolor.Refresh();
            }
        }

    }
}