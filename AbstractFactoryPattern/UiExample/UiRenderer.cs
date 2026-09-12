using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.UiExample
{
    public class UiRenderer
    {
        private IButton _button;
        private IModal _modal;
        private Iscreen _screen;

        public UiRenderer(IUiFactory factory)
        {
            _button = factory.GetButton();
            _modal = factory.GetModal();
            _screen = factory.GetScreen();

            RenderUI();
        }

        public void RenderUI()
        {
            _button.RenderButton();
            _modal.RenderModal();
            _screen.RenderScreen();
        }

        public void ToggleUI(IUiFactory uiFactory)
        {
            _button = uiFactory.GetButton();
            _modal = uiFactory.GetModal();
            _screen = uiFactory.GetScreen();

            RenderUI();
        }

        public void Toggle(IUiFactory uiFactory)
        {
           ToggleUI(uiFactory);
        }
    }
}
