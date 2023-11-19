using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLoseIcons : MonoBehaviour
{
    [SerializeField] private Timer _timer;
    [SerializeField] private GameObject winIcon;
    [SerializeField] private GameObject loseIcon;

    public void ActivateIcon()
    {
        if(!_timer.successful)
        {
            loseIcon.SetActive(true);
            return;
        }    
        
        winIcon.SetActive(true);
    }
}
