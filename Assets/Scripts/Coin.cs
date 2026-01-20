using UnityEngine;

public class Coin : MonoBehaviour
{
public float speed = 5f;
private GameController gameController;

    private void Start()
    {
        gameController = FindObjectOfType<GameController>();
    }

    private void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
   {
      
        if (other.tag == "Player")
        {
            gameController.AddPoints();
            Destroy(gameObject);
        }
        
        if (other.tag == "Destroyer")
        {
            Destroy(gameObject);
        }
    }
}