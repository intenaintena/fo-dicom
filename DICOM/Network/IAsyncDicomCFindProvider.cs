﻿// Copyright (c) 2012-2020 fo-dicom contributors.
// Licensed under the Microsoft Public License (MS-PL).

using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dicom.Network
{
    /// <summary>
    /// Interface representing asynchronous event handlers for DIMSE services applicable to C-FIND SOP instances.
    /// </summary>
    public interface IAsyncDicomCFindProvider
    {
        /// <summary>
        /// Handler of C-FIND request.
        /// </summary>
        /// <param name="request">C-FIND request subject to handling.</param>
        /// <returns>Collection of C-FIND responses based on <paramref name="request"/>.</returns>
#if NETSTANDARD2_1 || NETCOREAPP3_0 || NETCOREAPP3_1
        IAsyncEnumerable<DicomCFindResponse> OnCFindRequestAsync(DicomCFindRequest request);
#else
        Task<IEnumerable<Task<DicomCFindResponse>>> OnCFindRequestAsync(DicomCFindRequest request);
#endif
    }
}
