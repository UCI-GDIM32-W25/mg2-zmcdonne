using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameController : MonoBehaviour
{
    private void Update()
    {
   // Range(float minInclusive, float maxInclusive);

    }
    // public Coin prefab; instantiate and destry when collide with newcollider

}
public void Coin prefab()
{
    var position = new Vector3(Random.Range(-10.0f, 1-.0f), 0, Random.Range(-10.0f, 10.0f));
    Instantiate(prefab, position, Quaternion.identity);
//[SerializeField] private TMP_Text ()
//{
//Points ++ 
//if coin collides with Death_collider;
//Destroy 
//}
}
