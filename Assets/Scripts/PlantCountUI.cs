using UnityEngine;
using TMPro;
using System.Numerics;

public class PlantCountUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _plantedText;
    [SerializeField] private TMP_Text _remainingText;

    public void UpdateSeeds (int seedsLeft, int seedsPlanted)
    {
        
        _remainingText.text = "Seeds Remaining:  "+ seedsLeft;
        _plantedText.text = "Seeds Planted:  " + seedsPlanted;
    }
}