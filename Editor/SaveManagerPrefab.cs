using UnityEngine;
using UnityEditor;

namespace Ferdi{
public class SaveManagerPrefab : MonoBehaviour{

    [MenuItem("GameObject/Save Manager", false, 15)]
    public static void CreateSaveManager(){
        GameObject SaveManagerPrefab = (GameObject)PrefabUtility.InstantiatePrefab(AssetDatabase.LoadAssetAtPath<Object>("Packages/com.ferdi.save/Runtime/SaveManager.prefab"));
    	SaveManagerPrefab.name = "SaveManager";
    }
}
}