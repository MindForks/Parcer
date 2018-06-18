
namespace Parser.Core.Habra
{
    class GorodSettings : IParserSettings
    {
        public GorodSettings(int start, int end)
        {
            StartPoint = start;
            EndPoint = end;
        }

        public string BaseUrl { get; set; } = "https://gorod.dp.ua/afisha/search?searchtext=&searchdate=0&searchtype=0&x=12&y=14&";

        public string Prefix { get; set; } = "page={CurrentId}";

        public int StartPoint { get; set; }

        public int EndPoint { get; set; }
    }
}
