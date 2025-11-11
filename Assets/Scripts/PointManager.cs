using TMPro;
using UnityEngine;

public class PointManager : MonoBehaviour
{
    [SerializeField] TMP_Text pointDisplay;
    [SerializeField] public int playerPoints = 0;
    PointManager points;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pointDisplay.text = $"{playerPoints}";

    }
}
