using UnityEngine;
using UnityEditor;
using UTJ.MeshSync;

namespace UTJ.MeshSyncEditor
{
    class MaterialWindow : EditorWindow
    {
        public static void Open(MeshSyncPlayer server)
        {
            var window = (MaterialWindow)EditorWindow.GetWindow(typeof(MaterialWindow));
            window.titleContent = new GUIContent("Material List");
            window.m_server = server;
            window.Show();
        }


        public MeshSyncPlayer m_server;
        Vector2 m_scrollPos;


        void OnGUI()
        {
            if(m_server == null)
            {
                return;
            }

            var pos = position;
            m_scrollPos = EditorGUILayout.BeginScrollView(m_scrollPos, GUILayout.Width(pos.width), GUILayout.Height(pos.height));
            MeshSyncServerEditor.DrawMaterialList(m_server, false);
            EditorGUILayout.EndScrollView();
        }
    }
}
