using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RageManager : MonoBehaviour
{
    [SerializeField] private PlayerProgress _playerProgress;

    public void SetRage(int value)
    {
        _playerProgress.rage = value;
    }
    
    public void ModifyRage(int amount)
    {
        _playerProgress.rage += amount;
        if (_playerProgress.rage > 180)
        {
            _playerProgress.rage = 180;
        }

        if (_playerProgress.rage < 50)
        {
            _playerProgress.rage = 50;
        }
    }
}
