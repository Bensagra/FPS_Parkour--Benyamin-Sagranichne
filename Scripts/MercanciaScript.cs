using UnityEngine;

public class MercanciaScript : MonoBehaviour
{
    public int price;
   public DineroManager dineroManager;

    void Start()
    {
      dineroManager = FindFirstObjectByType<DineroManager>();    
    }
    void OnCollisionEnter(Collision collision)
    {
      
       if (collision.gameObject.CompareTag("Player"))
      {
         if (dineroManager.UpdateMoney(-price))
         {
            Destroy(gameObject);

         }
      }
       
        
            
    }
}
