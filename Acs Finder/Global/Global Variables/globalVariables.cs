namespace Global
{
    class AppInfo
    {
        public static readonly string acsFinderPath = @"C:\ProgramData\AcsFinder";

        // method finder
        public static readonly string dumpStuffPath = acsFinderPath + "\\" + "DumpStuff";

        public static readonly string processesDump = dumpStuffPath + "\\" + "dumps";

        public static readonly string assetsPath = dumpStuffPath + "\\" + "assets";

        public static readonly string s2Filename = assetsPath + "\\" + "dumper.exe";

        public static readonly string mfResultsPath = dumpStuffPath + "\\" + "Results";

        public static readonly string singleProcessesDump = dumpStuffPath + "\\" + "SingleProcessDump";

        // string finder
        public static readonly string stringFinderPath = acsFinderPath + "\\" + "String Finder";

        public static readonly string stringFinderResultsPath = stringFinderPath + "\\" + "Results";

    }
}
