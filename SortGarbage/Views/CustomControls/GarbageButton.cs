using SortGarbage.Models.GameModels;
using SortGarbage.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
        
        /* private Garbage _garbage;
        private GarbageRepository garbageRepository;*/

        public GarbageButton() : base()
        {
            //FitImageSize();
            FlatStyle = FlatStyle.Flat;
            TabStop = false;
            FlatAppearance.BorderSize = 0;
            Text = "";
            //AssignBackgroundImage();
            //_garbage = new Garbage() { GarbageType = GarbageTy}
        }

        private void FitImageSize()
        {
            if(this.BackgroundImage == null) { return; }
            var picture = new Bitmap(this.BackgroundImage, new Size(this.Width, this.Height));
            this.BackgroundImage = picture;
        }

        private void AssignBackgroundImage()
        {
            var garbageRepository = new GarbageRepository();
            var _garbage = garbageRepository.GetRandomGarbage();
            /*var bitmap = Bitmap.FromFile(_garbage.Path);
            BackgroundImage = (Image)bitmap; */
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
