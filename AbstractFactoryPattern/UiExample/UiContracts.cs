using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.UiExample
{
    //Define the products that will be created by the factories. Each product type has its own interface.

    //Define Products
    public interface IButton
    {
        void RenderButton();
    }
    public interface IModal
    {
        void RenderModal();
    }

    public interface Iscreen
    {
        void RenderScreen();
    }

    //Contract : Factory interface. Describe how to obtain products of each type. The concrete factory will implement this interface.
    public interface IUiFactory
    {
        IButton GetButton();
        IModal GetModal();
        Iscreen GetScreen();
    }
}
