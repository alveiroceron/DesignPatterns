namespace Builder.Console
{
    interface IBody
    {
        string Characteristics();
    }

    class BasicBody : IBody
    {
        public string Characteristics() => "metal body";
    }
    class SpecialBody : IBody
    {
        public string Characteristics() => "arbon fiber body";
    }
}
