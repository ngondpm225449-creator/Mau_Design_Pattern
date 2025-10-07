namespace MyRealBuilder
{
    public class ComputerDirector
    {
        private readonly ComputerBuilder builder;

        public ComputerDirector(ComputerBuilder builder)
        {
            this.builder = builder;
        }

        public void BuildComputer()
        {
            builder.BuildCPU();
            builder.BuildRAM();
            builder.BuildStorage();
            builder.BuildGPU();
        }
    }
}