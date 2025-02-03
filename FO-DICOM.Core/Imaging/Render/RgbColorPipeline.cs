﻿// Copyright (c) 2012-2025 fo-dicom contributors.
// Licensed under the Microsoft Public License (MS-PL).
#nullable disable

using FellowOakDicom.Imaging.LUT;

namespace FellowOakDicom.Imaging.Render
{

    /// <summary>
    /// RGB color pipeline implementation of <see cref="IPipeline"/> interface
    /// </summary>
    public class RgbColorPipeline : IPipeline
    {
        /// <inheritdoc />
        public ILUT LUT => null;

        /// <inheritdoc />
        public void ClearCache()
        { /* nothing to do here because this class has no cached data */ }
    }
}
