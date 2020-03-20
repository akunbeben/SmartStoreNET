﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStore.Services.Media
{
    public class PdfHandler : ImageHandlerBase
    {
        public PdfHandler(IImageCache imageCache)
            : base(imageCache)
        {
        }

        public override int Order => -80;

        protected override bool IsProcessable(MediaHandlerContext context)
        {
            // TODO: (mm) implement!
            return false;
        }

        protected override Task ProcessImageAsync(MediaHandlerContext context, CachedImage cachedImage, Stream inputStream)
        {
            // TODO: (mm) implement!
            return Task.FromResult(0);
        }
    }
}
