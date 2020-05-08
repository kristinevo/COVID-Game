using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
 

public class GameHandler : MonoBehaviour
{
	//[SerializeField] private Happiness_Bar happyBar;
	public Text day_Text;
	public Text infected_Text;
	public Text money_Text;
	public Button TV;
	public Button phone;
	public Button sleep;
	public Button bills;
	public Button fridge;
	public Image bill_notif;
	public Camera cam;

	private static int days = 0;
	private static int infected = 738400;
	private static int money = 1500;
	private static int hoursInADay = 24;
	private int friendOut = 2;
	private int calledFamily = 1;
	private int familyHappiness = 0;
	private static int amountOfSleep = 8;
	private static int breakTaken = 2;
	private float time;
	float happiness = 1f;
	

	void Start()
	{
		Clicked();	
	}

	private void Update()
	{
			//happiness = (calledFamily * .2f + breakTaken * .3f) * (amountOfSleep * .5f);
			//happyBar.SetSize(happiness);
			day_Text.text = "Days in Quarantine: " + days.ToString();
			infected_Text.text = "Infected/Healthcare Capacity: " + (infected - 2) + "/738,401";
			money_Text.text = "Money: " + money;
		
	}

	public void Clicked()
	{
		sleep.onClick.AddListener(() => {

			hoursInADay -= 8;
			Infected(8);
			check();

		});

		phone.onClick.AddListener(() => {
			hoursInADay -= 2;
			calledFamily++;
			Infected(2);
			check();
		});

		TV.onClick.AddListener(() => {
			hoursInADay -= 2;
			breakTaken++;
			Infected(2);
			check();
		});

		bills.onClick.AddListener(() => {
			money -= 1000;
			check();
		});
	}

	public void check()
	{
		if (days % 14 == 0 && days != 0)
		{
			money += 1200;
		}
		if (hoursInADay == 0)
		{
			hoursInADay = 24;
			IncrementDay();
		}

		if (infected > 738401)
		{
			SceneManager.LoadScene("GAMEOVER");
		}
	}

	public void Infected(int hours)
	{
		infected += (hours * 10);
		infected += friendOut * 10;
	}

	public void IncrementDay()
	{
		days++;
	}
}
