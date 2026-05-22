using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    public Animator transition;

    public float transitionTime = 1f;
    
    // Update is called once per frame
    void Update()
    {
        // have trigger once player makes choice on what pathway he takes after fights
        if(Input.GetMouseButtonDown(0)) // will be changed to on button pressed for reward selection or however we do it
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

        SceneManager.LoadScene(levelindex);


    }
}
