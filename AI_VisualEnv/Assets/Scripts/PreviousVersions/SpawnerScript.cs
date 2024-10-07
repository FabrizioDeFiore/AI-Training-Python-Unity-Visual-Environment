// using UnityEngine;
// using System.Collections;
// using UnityEditor;

// public class SpawnerScript : MonoBehaviour
// {
//     [SerializeField] private GameObject prefabToSpawn; // Reference the prefab to spawn
// }

// [CustomEditor(typeof(SpawnerScript))]
// public class SpawnerScriptEditor : Editor
// {
//     public override void OnInspectorGUI()
//     {
//         // Your inspector code here (drawing additional fields, etc.)

//         base.OnInspectorGUI(); // Call the base class's OnInspectorGUI (if needed)

//         if (GUILayout.Button("Spawn Object"))
//         {
//             SpawnObject(); // Call spawning function on button click
//         }
//     }


//         private void SpawnObject()
//         {
//             if (prefabToSpawn != null)
//             {
//                 // Instantiate the prefab at the spawner object's position
//                 Instantiate(prefabToSpawn, transform.position, transform.rotation);
//             }
//             else
//             {
//                 Debug.LogError("No prefab assigned to SpawnerScript!");
//             }
//         }
//     }

