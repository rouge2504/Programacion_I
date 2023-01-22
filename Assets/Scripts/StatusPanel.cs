using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StatusPanel : MonoBehaviour
{
    [SerializeField] private MedabotSpawnManager player;

    public TextMeshPro NameLabel;
    public TextMeshPro LevelLabel;

    public Slider HealthSlider;
    public Image HealthSliderBar;
    public TextMeshPro HealthLabel;

    public void SetMedabotSpawnManager(string name, MedabotSpawnManager MedabotSpawnManager)
    {
        this.NameLabel.text = name;

        this.LevelLabel.text = $"N. {MedabotSpawnManager.level}";
        this.SetHealth(MedabotSpawnManager.health, MedabotSpawnManager.maxhealth);
    }

    public void SetHealth(float health, float maxHealth)
    {
        this.HealthLabel.text = $"{Mathf.RoundToInt(health)} / {Mathf.RoundToInt(maxHealth)}";
        float percentage = health / maxHealth;

        this.HealthSlider.value = percentage;

        if (percentage < 0.33f)
        {
            this.HealthSliderBar.color = Color.red;
        }
    }
}
