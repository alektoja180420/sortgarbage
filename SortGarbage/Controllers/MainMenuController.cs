﻿using SortGarbage.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortGarbage.Controllers
{
    public class MainMenuController
    {
        private IMainMenuView _mainMenuView;

        public MainMenuController(IMainMenuView view)
        {
            _mainMenuView = view;
        }
    }
}
