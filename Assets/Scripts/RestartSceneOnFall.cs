using UnityEngine;

public class RestartSceneOnFall : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -18)
        {
            // Restart the scene
            UnityEngine.SceneManagement.SceneManager.LoadScene("FPS_Parkour");
        }
        {
            
        }
        
    }
}
