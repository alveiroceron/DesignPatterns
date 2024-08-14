namespace Builder.Console
{
    interface IEngine
    {
        string Specifications();
    }

    class BasicEngine : IEngine
    {
        public string Specifications() => "4-cylinder engine";
    }

    class BigEngine : IEngine
    {
        public string Specifications() => "8-cylinder engine";
    }
}
