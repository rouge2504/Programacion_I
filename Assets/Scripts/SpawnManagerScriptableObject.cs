using UnityEngine;

[CreateAssetMenu(fileName = "NewDat", menuName = "ScriptableObjects/Nosequeesesto", order = 1)]
public class SpawnManagerScriptableObject : ScriptableObject
{
    public string prefabName;

    public int numberOfPrefabsToCreate;

    public Vector3[] spawnPoints;
    public int soyHacker = 10000; //esto lo hizo el crack de Abel xD e.e
    

}
