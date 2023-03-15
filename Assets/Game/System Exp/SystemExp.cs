using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SystemExp : MonoBehaviour
{

    [Header("System Exp Variable")]
    [SerializeField] private int level;
    private int pointExp;
    [SerializeField] private float currentExp;
    [SerializeField] private int LevelUp;

    [Header("System Exp UI")]
    [SerializeField] private TMP_Text levelText;
    [SerializeField] private Slider expSlider;

    private void Start()
    {
        LevelUp = level * (2 * 5 * (1 + level));

        levelText.text = "Level : " + level.ToString();
        expSlider.maxValue = LevelUp;
        expSlider.value = currentExp;
    }

    private void Update()
    {
        ExpCalculate();
    }

    public void GetExpPoint(int getPointExp)
    {
        pointExp = getPointExp;
    }

    public void GetExpPoinRandom()
    {
        pointExp = Random.Range(0, 1000);
    }

    private void ExpCalculate()
    {

        currentExp += pointExp;
        pointExp = 0;
        expSlider.value = currentExp;

        LevelUp = level * (2 * 5 * (1 + level));
        expSlider.maxValue = LevelUp;

        if (currentExp >= LevelUp)
        {
            currentExp -= LevelUp;
            level += 1;
            levelText.text = "Level : " + level.ToString();
        }
    }

}
