using UnityEngine;


[CreateAssetMenu(fileName = "Arriba la capiza", menuName = "ScriptableObjects/EstaBasura", order = 1)]

public class SpawnManagerScriptableObject : ScriptableObject
{
    public string prefabName;

    public int numberOfPrefabsToCreate;

    public Vector3[] spawnPoints;

    public int soyHacker = 10000; //esto lo hizo el crack de Abel xD e.e

}
