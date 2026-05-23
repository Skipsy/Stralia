using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    // public Animator transition;



    // Update is called once per frame
    public void ChangeScene(string  sceneName)
    {
        SceneManager.LoadScene( sceneName);  
    }
    


        /*   // have trigger once player makes choice on what pathway he takes after fights
           if(Input.GetButtonDown // will be changed to on button pressed for reward selection or however we do it
           {
               LoadNextLevel();
           }

       }
       public void LoadNextLevel()
       {
           StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
       }

       IEnumerator LoadLevel(int levelindex)
       {
           transition.SetTrigger("Start");   //play black screen animation

           yield return new WaitForSeconds(transitionTime);

           SceneManager.LoadScene(sceneName);


       }*/
    }

