using UnityEngine;
using TMPro;

public class Inventory : MonoBehaviour
{
    public int mushroomCount = 0;
    public TextMeshProUGUI mushroomText;

    public void AddMushroom()
    {
        mushroomCount++;
        UpdateMushroomUI();
    }

    void UpdateMushroomUI()
    {
        if (mushroomText != null)
        {
            mushroomText.text = "Stars:  " + mushroomCount.ToString();
        }
    }
}