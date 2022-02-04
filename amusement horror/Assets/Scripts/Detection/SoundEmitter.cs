using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEmitter : MonoBehaviour
{
    [SerializeField] private HearingManager _hearingManager;
    [SerializeField] private Transform _root;
    public void EmitSound (float intensity)
    {
        _hearingManager.EmitSound(_root.position, intensity);
    }
}
