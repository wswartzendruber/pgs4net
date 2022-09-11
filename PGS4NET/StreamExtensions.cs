﻿/*
 * Copyright 2022 William Swartzendruber
 *
 * This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a
 * copy of the MPL was not distributed with this file, You can obtain one at
 * https://mozilla.org/MPL/2.0/.
 *
 * SPDX-License-Identifier: MPL-2.0
 */

namespace PGS4NET;

using System.IO;

public static class StreamExtensions
{
    public static Segment ReadSegment(this Stream stream)
    {
        if (!stream.CanRead)
            throw new IOException("Stream does not support reading.");

        return null;
    }
}
