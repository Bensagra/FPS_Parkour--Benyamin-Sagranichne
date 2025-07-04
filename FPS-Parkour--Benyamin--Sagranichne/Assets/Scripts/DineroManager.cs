using UnityEngine;

public class DineroManager : MonoBehaviour
{
    public float playerMoney;
    public UiManager uiManager;

    public bool UpdateMoney(float amount)
    {

        if (playerMoney + amount < 0)
        {
            return false;
        }
        else
        {
            playerMoney += amount;
            uiManager.UpdateMoneyDisplay();
            return true;

        }
    }
}
