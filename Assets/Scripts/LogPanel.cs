using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LogPanel : MonoBehaviour
{
    [SerializeField] private MedabotSpawnManager players;
    protected static LogPanel current;

    public Text logLabel;

    void Awake()
    {
        current = this;
    }

    public static void Write(string message)
    {
        current.logLabel.text = message;
    }
}
