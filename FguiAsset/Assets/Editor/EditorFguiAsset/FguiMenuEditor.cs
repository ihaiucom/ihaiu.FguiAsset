using UnityEngine;
using System.Collections;
using UnityEditor;
using System.IO;


namespace EditorFguiAssets
{
    public class GameMenuEditor
	{
		[MenuItem("Fgui资源/测试设置")]
		public static void TestSetting()
		{
            Debug.Log( Path.GetFullPath(FguiSetting.Instance.fguiProject) );
            Debug.Log( Path.GetFullPath(FguiSetting.Instance.layaProject) );
        }


        [MenuItem("Fgui资源/查找相同文件")]
        public static void OpenFindSimpleFile()
        {
            FguiSimpleFileEditorWindow.Open();
        }


    }

}