using UnityEngine;

public class FaceManager : MonoBehaviour
{
    [SerializeField] private PlayerProgress _playerProgress;
    [SerializeField] private GameObject fumes;
    [SerializeField] private GameObject faceAngerLevel4;
    [SerializeField] private GameObject faceAngerLevel3;
    [SerializeField] private GameObject faceAngerLevel2;
    [SerializeField] private GameObject faceAngerLevel1;

    private void Start()
    {
        if (_playerProgress.rage >= 150)
        {
            fumes.SetActive(true);
            faceAngerLevel4.SetActive(true);
            
            faceAngerLevel3.SetActive(false);
            faceAngerLevel2.SetActive(false);
            faceAngerLevel1.SetActive(false);

        }

        if (_playerProgress.rage < 150 && _playerProgress.rage >= 120)
        {
            fumes.SetActive(true);
            faceAngerLevel3.SetActive(true);
            
            faceAngerLevel4.SetActive(false);
            faceAngerLevel2.SetActive(false);
            faceAngerLevel1.SetActive(false);
        }
        
        if (_playerProgress.rage < 120 && _playerProgress.rage >= 80)
        {
            fumes.SetActive(false);
            faceAngerLevel2.SetActive(true);
            
            faceAngerLevel4.SetActive(false);
            faceAngerLevel3.SetActive(false);
            faceAngerLevel1.SetActive(false);
        }

        if (_playerProgress.rage >= 80) return;
        
        fumes.SetActive(false);
        faceAngerLevel1.SetActive(true);
            
        faceAngerLevel4.SetActive(false);
        faceAngerLevel3.SetActive(false);
        faceAngerLevel2.SetActive(false);

    }
}
