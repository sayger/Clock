using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class Language : MonoBehaviour
{
    // main panel
    public Text timeButton;
    public Text stopwatchButton;
    public Text timerButton;
    public Text russianButton;
    public Text englishButton;
    public Text language;


    // time panel
    CultureInfo culture;

    // switch panel
    public Text startButtonSwitch;
    public Text stopButtonSwitch;
    public Text resetButtonSwitch;

    // timer panel
    public Text startButtonTimer;
    public Text stopButtonTimer;
    public Text resetButtonTimer;

    // panel is done
    public Text timeIsDone;
    public Text ok;

    private bool open = false;
    public GameObject settings;

    public static string lang = "rus";

    public void RussianLang()
    {
        timeButton.text = "�����";
        stopwatchButton.text = "����������";
        timerButton.text = "������";
        russianButton.text = "���";
        englishButton.text = "���";
        language.text = "����";

        startButtonSwitch.text = "�����";
        stopButtonSwitch.text = "����";
        resetButtonSwitch.text = "��������";

        startButtonTimer.text = "�����";
        stopButtonTimer.text = "����";
        resetButtonTimer.text = "��������";

        ok.text = "�������";
        timeIsDone.text = "����� �����!";

        lang = "rus";
    }

    public void EnglishLang()
    {
        timeButton.text = "Time now";
        stopwatchButton.text = "Stopwatch";
        timerButton.text = "Timer";
        russianButton.text = "RUS";
        englishButton.text = "ENG";
        language.text = "Language";

        startButtonSwitch.text = "Start";
        stopButtonSwitch.text = "Pause";
        resetButtonSwitch.text = "Reset";

        startButtonTimer.text = "Start";
        stopButtonTimer.text = "Pause";
        resetButtonTimer.text = "Reset";

        ok.text = "Close";
        timeIsDone.text = "Time is over!";

        lang = "eng";
    }

    public void settingsButton()
    {
        if (open == false)
        {
            settings.SetActive(true);
            open = true;
        }
        else
        {
            settings.SetActive(false);
            open = false;
        }
    }
}
