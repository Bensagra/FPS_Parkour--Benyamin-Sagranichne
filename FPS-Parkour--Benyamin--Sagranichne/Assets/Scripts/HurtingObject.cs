using UnityEngine;

public class HurtingObject : MonoBehaviour
{
 public int damage;
   public HealthManager healthManager;

    void Start()
    {
      healthManager = FindFirstObjectByType<HealthManager>();    
    }
    void OnCollisionEnter(Collision collision)
    {
      
       if (collision.gameObject.CompareTag("Player"))
      {
            Debug.Log("TOcoo");
            healthManager.UpdateHealth(-damage);
      }
       
        
            
    }
}
