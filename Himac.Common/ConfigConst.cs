using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Himac.Common
{
    public static class ConfigConst
    {
        public class Length
        {
            //The maximum column size allowed is 4000 characters when the national character set is UTF8 and 2000 when it is AL16UTF16.
            //The maximum length of an NVARCHAR2 column in bytes is 4000
            public const int OracleStringMaxByteLength = 4000;

            public const int OracleNVarchar2MaxStringLength = OracleStringMaxByteLength / 2;//AL16UTF16 byte per char is 2
            public const int OracleVarchar2MaxStringLength = OracleStringMaxByteLength / 4; //AL32UTF8 max byte per char is 4

            public const int ShortMaMaxLength = 32;
            public const int MaMaxLength = 64;

            public const int ShortNameMaxLength = 64;
            public const int NameMaxLength = 128;
            public const int LongNameMaxLength = 256;

            public const int ShortMessageMaxLength = 256;
            public const int MessageMaxLength = 512;
            public const int LongMessageMaxLength = OracleVarchar2MaxStringLength;

            public const int FilenameMaxLength = 256;
            public const int FilePathnameMaxLength = 256;

            public const int SoDienThoaiMaxLength = 16;
            public const int GhichuMaxLength = MessageMaxLength;
        }
    }
}
