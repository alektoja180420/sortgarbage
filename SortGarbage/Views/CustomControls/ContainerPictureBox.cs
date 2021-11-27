using SortGarbage.Models.Enums;
using SortGarbage.Models.GameModels;
using System.Windows.Forms;

namespace SortGarbage.Views.CustomControls
{
    public class ContainerPictureBox
    {
        public GarbageType GarbageType { get; set; }
        private readonly PictureBox _pictureBox;

        public ContainerPictureBox(PictureBox pictureBox, GarbageType garbageType)
        {
            GarbageType = garbageType;
            _pictureBox = pictureBox;
        }

        public bool IsValidContainer(Garbage garbage)
        {
            return GarbageType == garbage.GarbageType;
        }
    }
}
