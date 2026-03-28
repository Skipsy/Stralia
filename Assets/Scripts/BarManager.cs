using UnityEngine;
using UnityEngine.UI;

public class BarManager : MonoBehaviour
{
    public float barTimer;
    private bool _turnStarted = false;

    public Image bar;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       TurnTimer();
    }

    public void StartTurn()
    {
        _turnStarted = true;
        barTimer = 10f;
        // can play cards is true
    }

    public void TurnTimer() 
    {
        if (_turnStarted)
        {
            barTimer -= Time.deltaTime;
            Debug.Log(barTimer);
            bar.fillAmount = barTimer/10f;
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (_turnStarted == false)
            {
                StartTurn();
            }
        }
        if (barTimer < 0)
        {
            _turnStarted = false;
        }
    }
}
