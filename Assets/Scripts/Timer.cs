using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private Text textField;
    private float desiredTime;
    
    private void Update()
    {
        float timeLeft = TimeLeft();
        textField.text = Mathf.Round(timeLeft).ToString();
    }

    public void Restart(float duration)
    {
        desiredTime = Time.time + duration;
    }

    public bool IsTimeOver()
    {
        return TimeLeft() == 0;
    }

    private float TimeLeft() 
    { 
        float timeLeft = desiredTime - Time.time; 
        if(timeLeft >0)
        {
            return timeLeft;
        }
        return 0;
    }
}