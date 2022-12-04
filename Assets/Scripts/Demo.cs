using UnityEngine;

public class Demo : MonoBehaviour
{

    [SerializeField] Timer timer1;
    [SerializeField] Timer timer2;

    private void Start()
    {
        timer1
        .SetDuration(6)
        .OnEnd(() => Debug.Log("Timer1 ended: "))
        .Begin();


        timer2
        .SetDuration(10)
        .OnEnd(() => Debug.Log("Timer2 ended: "))
        .Begin();







    }


}