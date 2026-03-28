using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class Enemies : ScriptableObject
{

    public string CurrentStatus;
    //ie poisoned or bleeding etc
    public string NextMove;
    // attack or self buff

    public string damageText;

    //function
    public int damage;
    public int Health;
    public int enemyamount;


}
