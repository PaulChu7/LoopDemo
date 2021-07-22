using UnityEngine;
using UnityEngine.UI;

public class ToolsScript : MonoBehaviour
{
    [SerializeField] private DoorLockScript doorLock;
    //[SerializeField] private Text effectInfo;
    [Header("Lockpick")]
    [SerializeField, Range(-10, 10)] private int pin1;
    [SerializeField, Range(-10, 10)] private int pin2;
    [SerializeField, Range(-10, 10)] private int pin3;
    [Header("Hammer")]
    [SerializeField, Range(-10, 10)] private int pin01;
    [SerializeField, Range(-10, 10)] private int pin02;
    [SerializeField, Range(-10, 10)] private int pin03;
    [Header("Drill")]
    [SerializeField, Range(-10, 10)] private int pin001;
    [SerializeField, Range(-10, 10)] private int pin002;
    [SerializeField, Range(-10, 10)] private int pin003;

    /*private void Awake()
    {
        effectInfo.text = $"Эффект: (pin1) (pin2) (pin3)";
    }*/
    //
    public void OnClickLockPickButton()
    {
        doorLock.ChangeState(pin1, pin2, pin3);
    }

    public void OnClickHammerButton()
    {
        doorLock.ChangeState(pin01, pin02, pin03);
    }

    public void OnClickDrillButton()
    {
        doorLock.ChangeState(pin001, pin002, pin003);
    }
}
