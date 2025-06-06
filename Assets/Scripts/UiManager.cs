using TMPro;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    public TextMeshProUGUI dineroRestante;
    public DineroManager dineroManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {//
        dineroRestante.text = "Dinero Restante:" + dineroManager.playerMoney.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void UpdateMoneyDisplay()
    {
        dineroRestante.text = "Dinero Restante: " + dineroManager.playerMoney.ToString("F2");
    }
}
