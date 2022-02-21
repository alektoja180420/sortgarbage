using SortGarbage.Models.GameModels;
using SortGarbage.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortGarbage.Views.CustomControls
{
    /// <summary>
    /// Klasa opisujaca pojawiajace sie smieci na ekranie
    /// </summary>
    public class GarbageButton : Button
    {
        #nullable enable
        /// <summary>
        /// Parametr smiecia przypisanego do elementu
        /// </summary>
        public Garbage? AssignedGarbage { get; set; } = null;
        /// <summary>
        /// Parametr domyslnej lokalizacji elementu
        /// </summary>
        public Point DefaultLocation { get; set; }
        private bool isSomethingDragged = false;
        private Point ptOffset;
        /// <summary>
        /// Konstruktor
        /// </summary>
        public GarbageButton() : base()
        {
            FlatStyle = FlatStyle.Flat;
            TabStop = false;
            FlatAppearance.BorderSize = 0;
            Text = "";
        }
        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="assignedGarbage">przypisywany smiec</param>
        public GarbageButton(Garbage? assignedGarbage = null) : base()
        {
            //FitImageSize();
            FlatStyle = FlatStyle.Flat;
            TabStop = false;
            FlatAppearance.BorderSize = 0;
            Text = "";
            AssignedGarbage = assignedGarbage;
            AssignBackgroundImage();
        }
        /// <summary>
        /// Metoda ktora przypisuje smiec po wrzuceniu go do kosza
        /// </summary>
        public void OnGarbageReassigned()
        {
            AssignBackgroundImage();
        }
      
        private void AssignBackgroundImage()
        {
            if(AssignedGarbage is null)
            {
                return;
            }

            BackgroundImage = Image.FromFile(AssignedGarbage.Path);
            Invalidate();
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
        }

    }
}
