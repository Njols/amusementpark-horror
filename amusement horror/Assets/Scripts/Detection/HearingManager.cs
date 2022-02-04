using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HearingManager : MonoBehaviour
{
    public List<HearingSensor> allHearingSensors { get; private set; } = new List<HearingSensor>();

    public void EmitSound(Vector3 location, float intensity)
    {
        foreach(HearingSensor sensor in allHearingSensors)
        {
            sensor.OnSoundHeard(location, intensity);
        }
    }
    public void Register(HearingSensor sensorToRegister)
    {
        allHearingSensors.Add(sensorToRegister);
    }
    public void DeRegister(HearingSensor sensorToDeRegister)
    {
        allHearingSensors.Remove(sensorToDeRegister);
    }
}
