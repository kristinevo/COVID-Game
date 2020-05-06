using UnityEngine;

public class GameHandler : MonoBehaviour
{
    [SerializeField] private Happiness_Bar happyBar;
    float happiness = 1f;
    private float nextActionTime = 0.0f;
    public float period = .01f;


    void Start()
    {
        happyBar.SetSize(happiness);
    }

    private void Update()
    {
        //place holder but we can make a function for happiness based on other variables
        print(Time.time);
        if (Time.time > nextActionTime)
        {
            nextActionTime = Time.time + period;
            if (happiness > 0)
            {
                happiness -= .1f;
                happyBar.SetSize(happiness);
            }
        }        
    }
}
