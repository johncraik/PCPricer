using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCPricer
{
    internal class Product
    {
        private string name;
        private float price;
        private Part cpu;
        private Part cpuCooler;
        private Part motherboard;
        private Part memory;
        private Part psu;
        private Part gpu;
        private Part hdd;
        private Part pcCase;


        /// <summary>
        /// Constructor to create new product object. Takes a name, price and all the components.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"</param>
        /// <param name="cpu"></param>
        /// <param name="cpuCooler"></param>
        /// <param name="motherboard"></param>
        /// <param name="memory"></param>
        /// <param name="psu"></param>
        /// <param name="gpu"></param>
        /// <param name="hdd"></param>
        /// <param name="pcCase"></param>
        public Product(string name, float price, Part cpu, Part cpuCooler, Part motherboard, Part memory, Part psu, Part gpu, Part hdd, Part pcCase)
        {
            this.name = name;
            this.price = price;
            this.cpu = cpu;
            this.cpuCooler = cpuCooler;
            this.motherboard = motherboard;
            this.memory = memory;
            this.psu = psu;
            this.gpu = gpu;
            this.hdd = hdd;
            this.pcCase = pcCase;
        }

        //GET METHODS:
        /// <summary>
        /// Returns the name of the product
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// Returns the price of the product
        /// </summary>
        /// <returns></returns>
        public float GetPrice()
        {
            return price;
        }

        /// <summary>
        /// Returns the CPU part in the product
        /// </summary>
        /// <returns></returns>
        public Part GetCPU()
        {
            return cpu;
        }

        /// <summary>
        /// Returns the CPU Cooler part in the product
        /// </summary>
        /// <returns></returns>
        public Part GetCPUCooler()
        {
            return cpuCooler;
        }

        /// <summary>
        /// Returns the Motherboard part in the product
        /// </summary>
        /// <returns></returns>
        public Part GetMotherboard()
        {
            return motherboard;
        }

        /// <summary>
        /// Returns the Memory part in the product
        /// </summary>
        /// <returns></returns>
        public Part GetMemory()
        {
            return memory;
        }

        /// <summary>
        /// Returns the PSU part in the product
        /// </summary>
        /// <returns></returns>
        public Part GetPSU()
        {
            return psu;
        }

        /// <summary>
        /// Returns the GPU part in the product
        /// </summary>
        /// <returns></returns>
        public Part GetGPU()
        {
            return gpu;
        }

        /// <summary>
        /// Returns the HDD part in the product
        /// </summary>
        /// <returns></returns>
        public Part GetHDD()
        {
            return hdd;
        }

        /// <summary>
        /// Returns the Case part in the product
        /// </summary>
        /// <returns></returns>
        public Part GetCase()
        {
            return pcCase;
        }
    }
}
