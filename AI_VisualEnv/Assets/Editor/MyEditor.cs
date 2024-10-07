using UnityEngine;
using UnityEditor;

//public class MyEditor : using UnityEngine;
//using UnityEditor;

[CustomEditor(typeof(MyListenerRealTimeComunicationsV4))]
public class MyEditor : Editor {

    public override void OnInspectorGUI() {

        // Do all the defoult GUI stuff too 
        base.OnInspectorGUI();

        if (GUILayout.Button("Generate Object")){
            Debug.Log("I pressed the generate object button");
        }
        
    }


}
