using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HearingSensor : MonoBehaviour
{
    public event Action<Vector3> onSoundHeard;
    [SerializeField] private float _hearingThreshold = 5f;
    [SerializeField] private HearingManager _hearingManager;
    [SerializeField] private Transform _root;

    public void OnSoundHeard (Vector3 location, float intensity)
    {
        float loudness = intensity / Vector3.Distance(location, _root.position);
        if (loudness < _hearingThreshold) onSoundHeard?.Invoke(location);
    }

    private void OnEnable()
    {
        _hearingManager.Register(this);
    }

    private void OnDisable()
    {
        _hearingManager.DeRegister(this);
    }
}
