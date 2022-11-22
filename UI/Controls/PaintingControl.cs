using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace UI.Controls
{
    public partial class PaintingControl : UserControl
    {
        private bool isPainting = false;
        private Pen pen;
        private readonly List<List<PointF>> paths = new List<List<PointF>>();

        public PaintingControl()
        {
            pen = new Pen(Color.Black, 7);

            InitializeComponent();
        }

        public void Clear()
        {
            paths.Clear();
            pictureBox.Image = null;
            pictureBox.Invalidate();
        }

        public Bitmap GetData()
        {
            var size = pictureBox.ClientSize;

            var bitmap = (Bitmap)pictureBox.Image ?? new Bitmap(size.Width, size.Height);

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                Draw(graphics);
            }

            return bitmap;
        }

        public void SetData(Bitmap newBitmap)
        {
            var bitmap = new Bitmap(newBitmap, pictureBox.Size);
            Clear();

            pictureBox.Image = bitmap;
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.Graphics);
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPainting)
            {
                var points = paths.Last();
                points.Add(e.Location);
                pictureBox.Invalidate();
            }
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            isPainting = true;
            paths.Add(new List<PointF>(10));
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isPainting = false;
        }

        private void Draw(Graphics graphics)
        {
            if (pictureBox.Image == null)
            {
                graphics.Clear(Color.White);
            }

            foreach (var points in paths)
            {
                if (points.Any())
                {
                    var path = new GraphicsPath(points.ToArray(), points.Select(_ => (byte)1).ToArray());
                    graphics.DrawPath(pen, path);
                }
            }
        }
    }
}
