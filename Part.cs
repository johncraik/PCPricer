using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCPricer
{
    internal class Part
    {
        private string brand;
        private string model;
        private float price;

        /// <summary>
        /// Construct new Parts object
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="model"></param>
        /// <param name="price"></param>
        public Part(string brand, string model, float price)
        {
            this.brand = brand;
            this.model = model;
            this.price = price;
        }

        /// <summary>
        /// Get the brand name for Part
        /// </summary>
        /// <returns></returns>
        public string GetBrand()
        {
            return brand;
        }

        /// <summary>
        /// Get the model name for Part
        /// </summary>
        /// <returns></returns>
        public string GetModel()
        {
            return model;
        }

        /// <summary>
        /// Get the price of Part
        /// </summary>
        /// <returns></returns>
        public float GetPrice()
        {
            return price;
        }

        /// <summary>
        /// Set the brand name for Part
        /// </summary>
        /// <param name="brand"></param>
        public void SetBrand(string brand)
        {
            this.brand = brand;
        }

        /// <summary>
        /// Set the model name for Part
        /// </summary>
        /// <param name="model"></param>
        public void SetModel(string model)
        {
            this.model = model;
        }

        /// <summary>
        /// Set the price for update
        /// </summary>
        /// <param name="price"></param>
        public void SetPrice(float price)
        {
            this.price = price;
        }


        /// <summary>
        /// Return part object as a string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ("Brand: " + this.brand 
                + ". Model: " + this.model
                + ". Price (GBP): " + this.price);
        }
    }
}
