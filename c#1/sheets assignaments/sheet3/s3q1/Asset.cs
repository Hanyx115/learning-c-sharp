using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s3q1
{
    internal class Asset
    {
        private string assetName;
        private decimal assetValue;
        private decimal depreciationRate;

        public Asset(string assetName, decimal assetValue, decimal depreciationRate)
        {
            this.assetName = assetName;
            this.assetValue = assetValue;
            this.depreciationRate = depreciationRate;
        }
        public string AssetName
        {
            get
            {
                return AssetName;
            }
            set
            {
                AssetName = value;
            }
        }
        public decimal AssetValue
        {
            get { return assetValue; }
            set
            {
                if (value >= 0)
                {
                    assetValue = value;
                }
            }
        }

        public decimal DepreciationRate
        {
            get { return depreciationRate; }
            set
            {
                if (value >= 0)
                {
                    depreciationRate = value;
                }
            }
        }
    }
}
