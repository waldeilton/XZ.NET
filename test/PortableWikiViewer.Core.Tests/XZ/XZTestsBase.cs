﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.IO;

namespace PortableWikiViewer.Core.XZ.Tests
{
    [TestFixture]
    public abstract class XZTestsBase
    {
        [SetUp]
        public void RewindStream()
        {
            CompressedStream.Position = 0;
        }

        protected Stream CompressedStream { get; } = new MemoryStream(Compressed);  

        protected static byte[] Compressed { get; } = new byte[] {
            0xfd, 0x37, 0x7a, 0x58, 0x5a, 0x00, 0x00, 0x04, 0xe6, 0xd6, 0xb4, 0x46, 0x02, 0x00, 0x21, 0x01,
            0x16, 0x00, 0x00, 0x00, 0x74, 0x2f, 0xe5, 0xa3, 0xe0, 0x01, 0xe4, 0x01, 0x3c, 0x5d, 0x00, 0x26,
            0x98, 0x4a, 0x47, 0xc6, 0x6a, 0x27, 0xd7, 0x36, 0x7a, 0x05, 0xb9, 0x4f, 0xd7, 0xde, 0x52, 0x4c,
            0xca, 0x26, 0x4f, 0x23, 0x60, 0x4d, 0xf3, 0x1f, 0xa3, 0x67, 0x49, 0x53, 0xd0, 0xf5, 0xc7, 0xa9,
            0x3e, 0xd6, 0xb5, 0x3d, 0x2b, 0x02, 0xbe, 0x83, 0x27, 0xe2, 0xa6, 0xc3, 0x13, 0x4a, 0x31, 0x14,
            0x33, 0xed, 0x9a, 0x85, 0x1d, 0x05, 0x6e, 0x7e, 0xa4, 0x91, 0xbf, 0x46, 0x71, 0x7d, 0xa7, 0xfb,
            0x12, 0x10, 0xdf, 0x21, 0x73, 0x75, 0xd8, 0xd9, 0xab, 0x8f, 0x1f, 0x8b, 0xb0, 0xb9, 0x3f, 0x9a,
            0xa5, 0x1e, 0xd4, 0x2f, 0xdf, 0x09, 0xb3, 0xfe, 0x45, 0xef, 0x16, 0xec, 0x95, 0x68, 0x64, 0xbb,
            0x42, 0x0c, 0x8b, 0x96, 0x27, 0x30, 0x62, 0x42, 0x91, 0x7c, 0xf3, 0x6e, 0x4d, 0x03, 0xc5, 0x00,
            0x04, 0x73, 0xdd, 0xee, 0xb0, 0xaa, 0xd6, 0x0b, 0x11, 0x90, 0x81, 0xd4, 0xaa, 0x69, 0x63, 0xfa,
            0x2f, 0xb4, 0x25, 0x0a, 0x7f, 0xf9, 0x47, 0x77, 0xb1, 0x1f, 0xc3, 0xb4, 0x4d, 0x51, 0xf8, 0x23,
            0x3a, 0x7c, 0x44, 0xc8, 0xcc, 0xca, 0x72, 0x09, 0xae, 0xc9, 0x7b, 0x7e, 0x91, 0x5d, 0xff, 0xc4,
            0xeb, 0xfd, 0xa1, 0x9b, 0xd4, 0x8d, 0xd7, 0xd3, 0x57, 0xac, 0x7e, 0x3b, 0x97, 0x2e, 0xe4, 0xc2,
            0x2e, 0x93, 0x3d, 0xb0, 0x16, 0x64, 0x78, 0x45, 0xb1, 0xc9, 0x40, 0x96, 0xcf, 0x5b, 0xc2, 0x2f,
            0xaa, 0xba, 0xcf, 0x98, 0x38, 0x21, 0x3d, 0x1a, 0x13, 0xe8, 0xa6, 0xa6, 0xdf, 0xf4, 0x3d, 0x01,
            0xa1, 0x9d, 0xc1, 0x3e, 0x37, 0xac, 0x20, 0xc4, 0xef, 0x18, 0xb1, 0xeb, 0x35, 0xf4, 0x66, 0x9a,
            0x47, 0x3c, 0xce, 0x7c, 0xad, 0xdb, 0x2e, 0x39, 0xf5, 0x8d, 0x4a, 0x1d, 0x65, 0xc2, 0x0f, 0xa4,
            0x40, 0x7e, 0xe6, 0xa7, 0x17, 0xce, 0x75, 0x7f, 0xd9, 0xa3, 0xf9, 0x27, 0x42, 0xd7, 0x98, 0x54,
            0x17, 0xa7, 0x7a, 0x7c, 0x82, 0xdf, 0xeb, 0x08, 0x28, 0x86, 0xdd, 0x57, 0x77, 0x92, 0x80, 0x5f,
            0x7b, 0x3b, 0xce, 0x77, 0x72, 0xff, 0xa3, 0x85, 0xd8, 0x5c, 0x8a, 0xb7, 0x83, 0x58, 0xfa, 0xbd,
            0x72, 0xe3, 0x66, 0x9d, 0x3b, 0xff, 0x13, 0x5b, 0x0b, 0xf1, 0x6c, 0xa6, 0xb1, 0x3b, 0x85, 0x3b,
            0x47, 0x91, 0xc8, 0x7c, 0x38, 0xe2, 0xe5, 0x54, 0xf8, 0x27, 0xee, 0x00, 0xff, 0xd3, 0x68, 0xf1,
            0xc6, 0xc7, 0xd7, 0x24, 0x00, 0x01, 0xd8, 0x02, 0xe5, 0x03, 0x00, 0x00, 0xac, 0x16, 0x1f, 0xa4,
            0xb1, 0xc4, 0x67, 0xfb, 0x02, 0x00, 0x00, 0x00, 0x00, 0x04, 0x59, 0x5a
        };
        protected static byte[] OriginalBytes => Encoding.ASCII.GetBytes(Original);

        protected static string Original { get; } =
@"Mary had a little lamb,
His fleece was white as snow,
And everywhere that Mary went,
The lamb was sure to go.

He followed her to school one day,
Which was against the rule,
It made the children laugh and play
To see a lamb at school.

And so the teacher turned it out,
But still it lingered near,
And waited patiently about,
Till Mary did appear.

" + "\"Why does the lamb love Mary so?\"" + @"
The eager children cry.
" + "\"Why, Mary loves the lamb, you know.\"" + @"
The teacher did reply.";
    }
}
