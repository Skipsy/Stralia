using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class RandomEnemy : MonoBehaviour
{
   

    public Transform spawnPoint;
    public EnemieData enemyData;


    public List<EnemieData> enemyspawn = new List<EnemieData>();

   
    public void SpawnEnemy()
    {
        if (enemyData != null && enemyData.enemyPrefab!= null)
        {
        Instantiate(enemyData.enemyPrefab, spawnPoint.position, spawnPoint.rotation);
            EnemieData enemy = enemyspawn[Random.Range(0, enemyspawn.Count)];
        }


    }
    
    public void ButtonPressed()
    {
       
        EnemieData enemy = enemyspawn[Random.Range(0, enemyspawn.Count)];
        //spawn a random enemy from Enemies script/ scriptable objects

        //add code here that also changes the scene and spawns certain amount of enemies depending on which path is chosen,
        //all enemies that spawn in the same scene no matter how many should be the same enemy
    }


}
