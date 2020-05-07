using UnityEngine;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour
{
    [SerializeField] private Happiness_Bar happyBar;

    float happiness = 1f;
    private float nextActionTime = 0.0f;

    public Text day_Text;
    public Text infected_Text;
    public Text money_Text;

    private int days = 0;
    private int infected = 4570;
    private int money = 1500;
    public float period = .01f;


    void Start()
    {
        happyBar.SetSize(happiness);
        day_Text.text = "Days in Quarantine: " + days;
        infected_Text.text = "Infected/Healthcare Capacity: " + infected + "/738,401";
        money_Text.text = "Money: " + money;
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
                IncrementDay();
                day_Text.text = "Days in Quarantine: " + days;
                infected_Text.text = "Infected/Healthcare Capacity: " + infected + "/738,401";
                money_Text.text = "Money: " + money;
                day_Text.text = "Days in Quarantine: " + days;

            }
        }        
    }

    public void IncrementDay()
    {
        days++;
    }
}
