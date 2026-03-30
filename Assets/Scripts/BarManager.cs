using UnityEngine;
using UnityEngine.UI;


public class BarManager : MonoBehaviour
{
    public float turnLength;
    private float _barTimer;
    private bool _turnStarted = false;
    public Image barImage;
    public RectTransform barRectTransform;
    public RectTransform barCritTransform;
    public Image barCritImage;

    public float CritLength;
    private bool _CritIsActive = false;
    private float _CritTime;
    
    void Update()
    {
       TurnTimer();
       statusUpdate();
       
       if(Input.GetKeyDown(KeyCode.Space))
       {
           if (_turnStarted == false)
           {
               StartTurn();
           }
       }
       if (Input.GetKeyDown(KeyCode.Space)) 
       {
            CritBarSetup(Random.Range(2f, turnLength -1f));
       }
    }
    public void StartTurn()
    {
        _turnStarted = true;
        _barTimer = turnLength;
        // can play cards is true
    }
    public void TurnTimer() // Called on update
    {
        if (_turnStarted)
        {
            _barTimer -= Time.deltaTime;
            barImage.fillAmount = BarPercentCalc(_barTimer, turnLength);
        }
        
        if (_barTimer < 0)
        {
            _turnStarted = false;
        }
    }
    public float BarPercentCalc(float current, float maxBar)
    {
        return current / maxBar;
    }

    public void CritBarSetup(float critplacement)
    {
        _CritIsActive = true;
        _CritTime = critplacement;
        barCritTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, SecondsToBarPercent(CritLength));
        //barCritTransform.rect.width = SecondsToBarPercent(CritLength);
        
        Debug.Log(critplacement);
        barCritTransform.position = barFinderX(barRectTransform,barCritTransform.rect.width) + FindBarPercent(barRectTransform,critplacement);
        
    }
    public Vector3 barFinderX(RectTransform rectTransform, float statusBarLength)
    {
        return rectTransform.position + new Vector3(-rectTransform.rect.width / 2, 0, 0) -
               new Vector3(statusBarLength/2, 0, 0);
    }
    public Vector3 FindBarPercent(RectTransform rectTransform, float critplacement)
    {
        return new Vector3(critplacement / turnLength * barRectTransform.rect.width, 0f, 0f);
    }

    public float SecondsToBarPercent(float seconds )
    {
        float percent = seconds / turnLength *100f;
        return (percent/100f)*barRectTransform.rect.width;
    }
    public void statusUpdate()
    {
        if (_CritIsActive == true)
        {
            if (_CritTime >= _barTimer)
            {
               // barCritImage.fillAmount = BarPercentCalc()
            }
        }
        
    }
}
