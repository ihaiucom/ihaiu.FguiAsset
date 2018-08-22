using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EditorFguiAssets
{
    public class PackageData
    {
        public List<AssetData> list = new List<AssetData>();

        public void Add(AssetData assetData)
        {
            assetData.package = this;
            list.Add(assetData);
        }
    }
}
