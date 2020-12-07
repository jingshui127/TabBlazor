﻿namespace TabBlazor
{
    public class ModalOptions
    {
        public bool ShowHeader { get; set; } = true;
        public ModalSize Size { get; set; } = ModalSize.Medium;
        public ModalFullscreen Fullscreen { get; set; } = ModalFullscreen.Never;
    }
}