
using UnityEngine;
using System;

public class ClockAnimator : MonoBehaviour
{
  private const float
        hoursToDegrees = 360f / 12f,
        minutesToDegrees = 360f / 60f,
        secondsToDegrees = 360f / 60f;

    public Transform Hours, Minutes, Seconds;

    public bool analog;

    void Update()
    {
        if (analog)
        {
            TimeSpan timespan = DateTime.Now.TimeOfDay;
            Hours.localRotation = Quaternion.Euler(0f, 0f, (float)timespan.TotalHours * -hoursToDegrees);
            Minutes.localRotation = Quaternion.Euler(0f, 0f, (float)timespan.TotalMinutes * -minutesToDegrees);
            Seconds.localRotation = Quaternion.Euler(0f, 0f, (float)timespan.TotalSeconds * -secondsToDegrees);

        }
        else
        {

            DateTime time = DateTime.Now;
            Hours.localRotation = Quaternion.Euler(0f, 0f, time.Hour * -hoursToDegrees);
            Minutes.localRotation = Quaternion.Euler(0f, 0f, time.Minute * -minutesToDegrees);
            Seconds.localRotation = Quaternion.Euler(0f, 0f, time.Second * -secondsToDegrees);
        }
    }

   


}
