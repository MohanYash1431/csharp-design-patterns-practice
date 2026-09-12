using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.UiExample
{
    public class WindowsUiFactory : IUiFactory
    {
        public IButton GetButton()
        {
            return new WindowsButton();
        }
        public IModal GetModal()
        {
            return new WindowsModal();
        }
        public Iscreen GetScreen()
        {
            return new WindowsScreen();
        }
    }

    public class MacUiFactory : IUiFactory
    {
        public IButton GetButton()
        {
            return new MacButton();
        }
        public IModal GetModal()
        {
            return new MacModal();
        }
        public Iscreen GetScreen()
        {
            return new MacScreen();
        }
    }

    public class LinuxUiFactory : IUiFactory
    {
        public IButton GetButton()
        {
            return new LinuxButton();
        }
        public IModal GetModal()
        {
            return new LinuxModal();
        }
        public Iscreen GetScreen()
        {
            return new LinuxScreen();
        }
    }
}
