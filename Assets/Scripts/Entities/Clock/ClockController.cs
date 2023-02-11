using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockController : MonoBehaviour
{
    private SystemManager systemManager;

    [Header("Clock Transforms")]
    public Transform hoursHandTransform;
    public Transform minutesHandTransform;
    public Transform secondsHandTransform;

    [Header("Clock Rotations")]
    private const float hoursToDegrees = 360f / 12f;
    private const float minutesToDegrees = 360f / 60f;
    private const float secondsToDegrees = 360f / 60f;

    [Header("Clock Booleans")]
    public bool isAnalog;

    private void Start()
    {
        systemManager = GetComponent<SystemManager>();
    }

    private void Update()
    {
        ManageClockHands();
    }

    void ManageClockHands()
    {
        if (isAnalog)
        {
            hoursHandTransform.localRotation = Quaternion.Euler(0f, 0f, (float)systemManager.systemTimeSpan.TotalHours * -hoursToDegrees);

            minutesHandTransform.localRotation = Quaternion.Euler(0f, 0f, (float)systemManager.systemTimeSpan.TotalMinutes * -minutesToDegrees);

            secondsHandTransform.localRotation = Quaternion.Euler(0f, 0f, (float)systemManager.systemTimeSpan.TotalSeconds * -secondsToDegrees);
        }
        else
        {
            hoursHandTransform.localRotation = Quaternion.Euler(0f, 0f, systemManager.systemTime.Hour * -hoursToDegrees);

            minutesHandTransform.localRotation = Quaternion.Euler(0f, 0f, systemManager.systemTime.Minute * -minutesToDegrees);

            secondsHandTransform.localRotation = Quaternion.Euler(0f, 0f, systemManager.systemTime.Second * -secondsToDegrees);
        }      
    }
}
