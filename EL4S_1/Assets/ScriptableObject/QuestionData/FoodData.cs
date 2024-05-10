using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "FoodData")]
public class FoodData : ScriptableObject
{
    public string foodName;
    public string foodExplanation;
    public Sprite foodImage;
    public Sprite foodCountryImage;
}
