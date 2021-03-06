﻿namespace Captura.Models
{
    // ReSharper disable once ClassNeverInstantiated.Global
    class FullScreenItem : NotifyPropertyChanged, IVideoItem
    {
        readonly IPlatformServices _platformServices;

        public FullScreenItem(IPlatformServices PlatformServices)
        {
            _platformServices = PlatformServices;
        }

        public override string ToString() => Name;

        public string Name => null;

        public IImageProvider GetImageProvider(bool IncludeCursor)
        {
			var region = _platformServices.DesktopRectangle;

            return _platformServices.GetRegionProvider(region, IncludeCursor);
		}
    }
}