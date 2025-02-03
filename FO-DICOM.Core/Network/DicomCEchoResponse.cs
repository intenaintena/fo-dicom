﻿// Copyright (c) 2012-2025 fo-dicom contributors.
// Licensed under the Microsoft Public License (MS-PL).
#nullable disable

namespace FellowOakDicom.Network
{
    public sealed class DicomCEchoResponse : DicomResponse
    {
        public DicomCEchoResponse(DicomDataset command)
            : base(command)
        {
        }

        public DicomCEchoResponse(DicomCEchoRequest request, DicomStatus status)
            : base(request, status)
        {
        }
    }
}
