using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace IT_praktika_9
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    private void Form1_Paint(object sender, PaintEventArgs e)
    {
      Graphics g = e.Graphics; // Объявляетсяобъект Graphics
                               // Далее вставляется код рисования
      Rectangle rect = new Rectangle(330, 200, 210, 30);
      Pen BlackPen = new Pen(Color.Red, 60);
      Pen blackPen = new Pen(Color.Red, 5);
      SolidBrush BLACKPen = new SolidBrush(Color.Black);
      SolidBrush grayBrush = new SolidBrush(Color.Gray);
      SolidBrush blueBrush = new SolidBrush(Color.SkyBlue);
      SolidBrush graybBrush = new SolidBrush(Color.LightGray);
      e.Graphics.FillRectangle(blueBrush, 0, 0, 2000, 200);
      e.Graphics.FillRectangle(graybBrush, 0, 200, 2000, 800);
      e.Graphics.DrawRectangle(BlackPen, rect);
      e.Graphics.DrawRectangle(blackPen, 370, 120, 150, 50 );
      e.Graphics.FillEllipse(grayBrush, 330, 230, 60, 60);
      e.Graphics.FillEllipse(grayBrush, 480, 230, 60, 60);
      e.Graphics.FillRectangle(BLACKPen, 350, 240, 20, 40);

      while(true)
      {
        _pause(10);
        e.Graphics.FillEllipse(grayBrush, 330, 230, 60, 60);
        e.Graphics.FillRectangle(BLACKPen, 340, 250, 40, 20);
        _pause(10);
        e.Graphics.FillEllipse(grayBrush, 330, 230, 60, 60);
        e.Graphics.FillRectangle(BLACKPen, 350, 240, 20, 40);
      }

    }  
    private void _pause(int value)
    { 
      Stopwatch sw = new Stopwatch();
      sw.Start();
      while (sw.ElapsedMilliseconds < value)
        Application.DoEvents();
    }

    private void button1_Click(object sender, EventArgs e)
    {
       
    }
  }
}
 