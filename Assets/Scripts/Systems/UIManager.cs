using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private SystemManager systemManager;

    [Header("UI Current Time")]
    public Text currentTimeText;

    [Header("UI Current Date")]
    public Text currentDateText;

    [Header("Time of Day")]
    public Text timeOfDayText;

    [Header("Current Day of the Week")]
    public Text currentDayofTheWeekText;

	void Start ()
    {
        systemManager = GameObject.FindGameObjectWithTag("Clock").GetComponent<SystemManager>();
	}
	
	void Update ()
    {
        ManageDateText();
        ManageTimeText();
        ManageTimeOfDayText();
        ManageDayofTheWeekText();
	}

    void ManageDateText()
    {
        currentDateText.text = systemManager.currentDate;
    }

    void ManageTimeText()
    {
        currentTimeText.text = systemManager.currentTime;
    }

    void ManageTimeOfDayText()
    {
        if (systemManager.isMorning)
        {
            timeOfDayText.text = "Good Morning!";
        }
        else if (systemManager.isAfternoon)
        {
            timeOfDayText.text = "Hope you are having a wonderful Afternoon!";
        }
        else if (systemManager.isEvening)
        {
            timeOfDayText.text = "Good Evening!";
        }
        else if (systemManager.isNight)
        {
            timeOfDayText.text = "Its getting late, try and get some sleep!";
        }
    }

    void ManageDayofTheWeekText()
    {
        currentDayofTheWeekText.text = systemManager.systemTime.DayOfWeek.ToString();
    }
}
