using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(fileName = "Medabot", menuName = "ScriptableObjects/MakeMedabot", order = 1)]
public class MedabotSpawnManager : ScriptableObject
{

    public string nombre;
    public bool medal;
    public float health;
    public float maxhealth;
    public float deffense;
    public int speed;
    public float attack;
    public float spirit;
    public int level;

    public MedabotSpawnManager(int level, float maxhealth, float attack, float deffense, float spirit)
    {
        this.level = level;
        this.maxhealth = maxhealth;
        this.health = maxhealth;
        this.attack = attack;
        this.deffense = deffense;
        this.spirit = spirit;
    }
    public MedabotSpawnManager clone()
    {
        return new MedabotSpawnManager(this.level, this.maxhealth, this.attack, this.deffense, this.spirit);
    }

    

}
