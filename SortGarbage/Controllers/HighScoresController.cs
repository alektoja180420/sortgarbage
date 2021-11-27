using SortGarbage.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortGarbage.Controllers
{
    public class HighScoresController
    {
        private IHighScoresView _highScoresView;

        public HighScoresController(IHighScoresView highScoresView)
        {
            _highScoresView = highScoresView;
        }


    }
}
