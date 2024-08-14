namespace Builder.Console
{
    interface ITires
    {
        string Information();
    }

    class BasicTires : ITires
    {
        public string Information() => "14-inch tire";
    }

    class SpecialTires : ITires
    {
        public string Information() => "18-inch tire with aluminum rims";
    }
}
