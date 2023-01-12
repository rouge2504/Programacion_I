using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/EstaBasura", order = 1)]
public class SpawnManagerScriptableObject : ScriptableObject
{
    public string prefabName;

    public int numberOfPrefabsToCreate;
<<<<<<< HEAD
    public Vector4[] spawnPoints;
=======
    public Vector3[] spawnPoints;
    public int soyHacker = 10000; //esto lo hizo el crack de Abel xD e.e
    
>>>>>>> 40094a78dc0c857f8e598a192160058871f1067f
}
