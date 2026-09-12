using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.UiExample
{
    //Windows UI Products

    public class WindowsButton : IButton
    {
        public void RenderButton()
        {
            Console.WriteLine("Rendering Windows Button");
        }
    }

    public class WindowsModal : IModal
    {
        public void RenderModal()
        {
            Console.WriteLine("Rendering Windows Modal");
        }
    }

    public class WindowsScreen : Iscreen
    {
        public void RenderScreen()
        {
            Console.WriteLine("Rendering Windows Screen");
        }
    }

    //Mac UI Products

    public class MacButton : IButton
    {
        public void RenderButton()
        {
            Console.WriteLine("Rendering Mac Button");
        }
    }

    public class MacModal : IModal
    {
        public void RenderModal()
        {
            Console.WriteLine("Rendering Mac Modal");
        }
    }

    public class MacScreen : Iscreen
    {
        public void RenderScreen()
        {
            Console.WriteLine("Rendering Mac Screen");
        }
    }

    // Linux UI Products

    public class LinuxButton : IButton
    {
        public void RenderButton()
        {
            Console.WriteLine("Rendering Linux Button");
        }
    }       

    public class LinuxModal : IModal
    {
        public void RenderModal()
        {
            Console.WriteLine("Rendering Linux Modal");
        }
    }

    public class LinuxScreen : Iscreen
    {
        public void RenderScreen()
        {
            Console.WriteLine("Rendering Linux Screen");
        }
    }
}
