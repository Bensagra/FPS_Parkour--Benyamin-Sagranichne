using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
     public float playerHealth;
    public UiManager uiManager;

    public bool UpdateHealth(float amount)
    {

        if ((playerHealth + amount) <= 0)
        {
            Debug.Log("Respawn");
            SceneManager.LoadScene("FPS Parkour");
            return false;
        }
        else
        {
            playerHealth += amount;
            uiManager.UpdateHealthDisplay();
            return true;

        }
    }
}
