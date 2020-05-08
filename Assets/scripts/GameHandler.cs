using UnityEngine;
using UnityEngine.UI;
 

public class GameHandler : MonoBehaviour
{
    [SerializeField] private Happiness_Bar happyBar;

    private float nextActionTime = 0.0f;

    public Text day_Text;
    public Text infected_Text;
    public Text money_Text;
    public Button TV;
    public Button phone;
    public Button sleep;
    public Button bills;
    public Button fridge;
    public Image bill_notif;

    private int days = 0;
    private int infected = 4570;
    private int money = 1500;
    public float period = .01f;
    //day starts at 9
    private int hoursInADay = 24;
    private int friendOut = 0;
    private int calledFamily = 0;
    private int familyHappiness = 0;
    private int amountOfSleep = 8;
    private int breakTaken = 0;
    float happiness = 1f;
    

    void Start()
    {
        System.Random r = new System.Random();
        happyBar.SetSize(happiness);
        day_Text.text = "Days in Quarantine: " + days;
        infected_Text.text = "Infected/Healthcare Capacity: " + infected + "/738,401";
        money_Text.text = "Money: " + money;
        
        sleep.onClick.AddListener(()=>{
            hoursInADay = 24;
            if (amountOfSleep < 7 && r.NextDouble() > .5)
            {
                hoursInADay -= 8;
                //miss class add a pop up and reduce happiness by a constant
                happiness -= .2f;
                IncrementDay();
            }
        });

    }

    private void Update()
    {
        //place holder but we can make a function for happiness based on other variables
        if(days/14 == 0)
        {
            money += 1200;
        }

        if(days/30 <= 0 && days > 3)
        {
            bill_notif.enabled = true;
        }

        if (Time.time > nextActionTime)
        {
            nextActionTime = Time.time + period;
            if (happiness > 0)
            {
                happiness = (calledFamily + breakTaken) * amountOfSleep;
                happyBar.SetSize(happiness);
                







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
