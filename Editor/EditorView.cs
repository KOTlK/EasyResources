using UnityEditor;
using UnityEngine;

namespace EasyResources.Editor
{
    public class EditorView : EditorWindow
    {
        private DataAccess _data = new DataAccess();
        private string _path;

        [MenuItem("EasySpawning/Window")]
        private static void Init()
        {
            var window = GetWindow<EditorView>("EasySpawning");
            window.Show();
        }

        private void OnGUI()
        {
            _path = EditorGUILayout.TextField("Path to resources", $"{Application.dataPath}/Resources");

            if (GUILayout.Button("Save"))
            {
                _data.SaveData(_path);
                var window = GetWindow<EditorView>("EasySpawning");
                window.Close();
            }
        }
    }
}

