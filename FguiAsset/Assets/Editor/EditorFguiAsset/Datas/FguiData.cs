using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EditorFguiAssets
{
    public class FguiData
    {
        public List<PackageData> packageList = new List<PackageData>();

        public void AddPackage(PackageData package)
        {
            this.packageList.Add(package);
        }

        /// <summary>
        /// 生成资源列表
        /// </summary>
        public void GenerateAsset()
        {

        }

        /// <summary>
        /// 生成资源MD5码
        /// </summary>
        public void GenerateAssetMD5()
        {

        }

        /// <summary>
        /// 生成资源依赖
        /// </summary>
        public void GenerateAssetDepend()
        {

        }
    }
}
