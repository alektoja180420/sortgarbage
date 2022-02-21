using SortGarbage.Models.Enums;
using SortGarbage.Models.GameModels;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SortGarbage.Views.CustomControls
{
    /// <summary>
    /// Klasa okreslajaca kontenery na smieci
    /// </summary>
    public class ContainerPictureBox : PictureBox
    {
        /// <summary>
        /// Typ smiecia
        /// </summary>
        public GarbageType GarbageType { get; set; }
        private readonly PictureBox _pictureBox;
        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="pictureBox">Obrazek</param>
        /// <param name="garbageType">Typ smiecia</param>
        public ContainerPictureBox(PictureBox pictureBox, GarbageType garbageType)
        {
            GarbageType = garbageType;
            _pictureBox = pictureBox;
            _pictureBox.AllowDrop = true;
        }
        /// <summary>
        /// Metoda okreslajaca polozenie kontenerow wzgledem smiecia
        /// </summary>
        /// <param name="p">Punkt dotykowy</param>
        /// <returns>Prawda jezeli element dotknal kontener</returns>
        public bool ElementTouchedContainer(Point p)
        {

            if(Math.Abs(p.X) >= _pictureBox.Location.X && Math.Abs(p.X) <= (_pictureBox.Location.X + _pictureBox.Size.Width)
                && Math.Abs(p.Y) >= _pictureBox.Location.Y && Math.Abs(p.Y) <= (_pictureBox.Location.Y + _pictureBox.Size.Height))
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
