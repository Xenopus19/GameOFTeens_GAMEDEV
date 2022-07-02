using UnityEngine;
using UnityEngine.UI;

public class MoneyUI : MonoBehaviour
{
    void Start()
    {
        GetComponent<Text>().text = $"+{Score.Instance.score}";
    }
}
