namespace MyRealBuilder
{
    public class GamingComputerBuilder : ComputerBuilder
    {
        public override void BuildCPU()
        {
            computer.AddPart("CPU", "Intel Core i9");
        }

        public override void BuildRAM()
        {
            computer.AddPart("RAM", "32GB DDR5");
        }

        public override void BuildStorage()
        {
            computer.AddPart("Storage", "2TB NVMe SSD");
        }

        public override void BuildGPU()
        {
            computer.AddPart("GPU", "NVIDIA RTX 4090");
        }
    }
}