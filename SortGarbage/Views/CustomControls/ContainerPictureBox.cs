using SortGarbage.Models.Enums;
using SortGarbage.Models.GameModels;
using System.Drawing;
using System.Windows.Forms;

namespace SortGarbage.Views.CustomControls
{
    public class ContainerPictureBox : PictureBox
    {
        public GarbageType GarbageType { get; set; }
        private readonly PictureBox _pictureBox;

        public ContainerPictureBox(PictureBox pictureBox, GarbageType garbageType)
        {
            GarbageType = garbageType;
            _pictureBox = pictureBox;
            _pictureBox.AllowDrop = true;
        }

        public bool IsValidContainer(Garbage garbage)
        {
            return GarbageType == garbage.GarbageType;
        }

        public bool ElementTouchedContainer(Point p)
        {
            
            if(p.X > _pictureBox.Location.X && p.X < (_pictureBox.Location.X + _pictureBox.Size.Width)
                && p.Y > _pictureBox.Location.Y && p.Y < (_pictureBox.Location.Y + _pictureBox.Size.Height))
            {
                return true;
            }
            return false;
        }

        protected override void OnDragEnter(DragEventArgs drgevent)
        {
            base.OnDragEnter(drgevent);

        }

    }
}
