using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "New Enemy", menuName = "EnemieData")]
public class EnemieData : ScriptableObject
{
    public string Name;
    public string CurrentStatus;
    //ie poisoned or bleeding etc
    public string NextMove;
    // attack or self buff

    public string damageText;
    public GameObject enemyPrefab;

    //function
    public int damage;
    public int MaxHealth;
    public int CurrentHealth;
    public int enemyamount;


}
