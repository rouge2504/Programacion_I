using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Medabot", menuName = "ScriptableObjects/MakeMedabot", order = 1)]

public class MedabotSpawnManager : ScriptableObject
{
    public string nombre;
    public bool medalla;
    public int vida;
    public int def;
    public int vel;
    public int ataque;
    public int ataque_especial;


}
