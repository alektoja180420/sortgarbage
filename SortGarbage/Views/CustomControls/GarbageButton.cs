using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortGarbage.Views.CustomControls
{
    public class GarbageButton : Button
    {
        private bool isSomethingDragged = false;
        private Point ptOffset;
        public GarbageButton() : base()
        {
            //FitImageSize();
            FlatStyle = FlatStyle.Flat;
            TabStop = false;
            FlatAppearance.BorderSize = 0;
            Text = "";
        }

        private void FitImageSize()
        {
            if(this.BackgroundImage == null) { return; }
            var picture = new Bitmap(this.BackgroundImage, new Size(this.Width, this.Height));
            this.BackgroundImage = picture;
        }

        protected override void OnMouseMove(MouseEventArgs mevent)
        {
            base.OnMouseMove(mevent);
            if (isSomethingDragged)
            {
                Point newPoint = this.PointToScreen(new Point(mevent.X, mevent.Y));
                newPoint.Offset(ptOffset);
                Location = newPoint;
            }

        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (e.Button == MouseButtons.Left)
            {
                //button2.DoDragDrop(this.button2, DragDropEffects.Move);
                isSomethingDragged = true;
                Point ptStartPosition = PointToScreen(new Point(e.X, e.Y));
                ptOffset = new Point();
                ptOffset.X = Location.X - ptStartPosition.X;
                ptOffset.Y = Location.Y - ptStartPosition.Y;
            }
            else
            {
                isSomethingDragged = false;
            }
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            isSomethingDragged=false;
            //OnDraggedToBasket

        }

        private void OnDraggedToBasket(List<ContainerPictureBox> containers, Point point)
        {
            foreach (var container in containers)
            {
                if (container.ElementTouchedContainer(point))
                {
                    MessageBox.Show("dotkło");
                }
            }
        }
    }
}
