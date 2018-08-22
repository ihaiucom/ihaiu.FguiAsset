using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EditorFguiAssets
{
    public class FguiSetting
    {

        private static FguiSetting _Instance;
        public static FguiSetting Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new FguiSetting();
                }
                return _Instance;
            }
        }


        public string fguiProject = "../../";
        public string layaProject = "../../../../Gidea-PF-Client/GamePF/";
    }

}