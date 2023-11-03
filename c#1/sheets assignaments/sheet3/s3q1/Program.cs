using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s3q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
            {
              
                Asset asset1 = new Asset("Asset1", 10000.0m, 0.1m);
                Asset asset2 = new Asset("Asset2", 5000.0m, 0.05m);

                
                Console.WriteLine("Initial Asset Information:");
                Console.WriteLine($"Asset Name: {asset1.AssetName}, Asset Value: {asset1.AssetValue}, Depreciation Rate: {asset1.DepreciationRate}");
                Console.WriteLine($"Asset Name: {asset2.AssetName}, Asset Value: {asset2.AssetValue}, Depreciation Rate: {asset2.DepreciationRate}");

                
                asset1.AssetValue *= 1.05m;
                asset2.AssetValue *= 1.05m;

                
                Console.WriteLine("\nAsset Information After 5% Increase:");
                Console.WriteLine($"Asset Name: {asset1.AssetName}, Asset Value: {asset1.AssetValue}, Depreciation Rate: {asset1.DepreciationRate}");
                Console.WriteLine($"Asset Name: {asset2.AssetName}, Asset Value: {asset2.AssetValue}, Depreciation Rate: {asset2.DepreciationRate}");
            }
        }

    }
}

