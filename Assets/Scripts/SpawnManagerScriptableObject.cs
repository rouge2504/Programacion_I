using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/EstaBasura", order = 1)]
public class SpawnManagerScriptableObject : ScriptableObject
{
    public string prefabName;

    public int numberOfPrefabsToCreate;
    public Vector4[] spawnPoints;
}
