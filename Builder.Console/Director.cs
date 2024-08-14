namespace Builder.Console
{
    class Director
    {
        public void Build(IBuilder builder)
        {
            //el director indica los pasos para hacer la cosntruccion
            //pero el constructor es quien se encarga de contruir segun esta especificacion

            //la especificacion es el orden de construccion 1 motor 2 carroceria etc.
            builder.BuildEngine();
            builder.BuildBody();
            builder.BuildTires();
        }


    }
}
