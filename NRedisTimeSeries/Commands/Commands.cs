﻿using System;
namespace NRedisTimeSeries
{
    public class TS
    {
        public static string CREATE => "TS.CREATE";
        public static string ALTER => "TS.ALTER";
        public static string ADD => "TS.ADD";
        public static string MADD => "TS.MADD";
        public static string INCRBY => "TS.INCRBY";
        public static string DECRBY => "TS.DECRBY";
        public static string CREATERULE => "TS.CREATERULE";
        public static string DELETERULE => "TS.DELETERULE";
        public static string RANGE => "TS.RANGE";
        public static string MRANGE => "TS.MRANGE";
        public static string GET => "TS.GET";
        public static string MGET => "TS.MGET";
        public static string INFO => "TS.INFO";
        public static string QUERYINDEX => "TS.QUERYINDEX";
    }

    public class CommandArgs
    {
        public static string RETENTION = "RETENTION";
        public static string LABELS = "LABELS";
        public static string UNCOMPRESSED = "UNCOMPRESSED";
    }
}
