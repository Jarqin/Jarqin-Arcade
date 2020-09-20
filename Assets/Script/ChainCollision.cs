using UnityEngine;

public class ChainCollision : MonoBehaviour
{
	public GameObject BlopSound;

    void OnTriggerEnter2D(Collider2D col)
    {
    	Chain.isFired = false;
    	if (col.tag == "Ball")
    	{
    		col.GetComponent<Ball>().Split();
    		Instantiate(BlopSound, transform.position, Quaternion.identity);
    	}
    }


}
