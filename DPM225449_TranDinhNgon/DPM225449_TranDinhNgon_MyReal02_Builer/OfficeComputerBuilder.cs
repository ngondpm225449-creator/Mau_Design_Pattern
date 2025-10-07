namespace MyRealBuilder
{
    public class OfficeComputerBuilder : ComputerBuilder
    {
        public override void BuildCPU()
        {
            computer.AddPart("CPU", "Intel Core i5");
        }

        public override void BuildRAM()
        {
            computer.AddPart("RAM", "8GB DDR4");
        }

        public override void BuildStorage()
        {
            computer.AddPart("Storage", "256GB SSD");
        }

        public override void BuildGPU()
        {
            computer.AddPart("GPU", "Integrated Graphics");
        }
    }
}