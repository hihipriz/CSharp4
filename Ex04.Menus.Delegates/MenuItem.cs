﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem : MainMenu, IMenuItem
    {
        private readonly string m_MenuItemName;

        public MenuItem(string iMenuItemName)
        {
            this.m_MenuItemName = iMenuItemName;
        }

        /// <summary>
        /// Shows the menu item
        /// </summary>
        public void Run()
        {
          this.Show();
        }

        public override string ToString()
        {
            return string.Format("{0}", this.m_MenuItemName);
        }
    }
}