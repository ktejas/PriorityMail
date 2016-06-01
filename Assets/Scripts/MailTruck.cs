using UnityEngine;
using System.Collections;

public class MailTruck : MonoBehaviour
{
    public GameManager gameManager;
    public enum Color { R, G, B, Y };
    public Color truckColor;

	void Start ()
    {
	    
	}
	
	void Update ()
    {
	
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Mail")
        {
            if ( (int)(other.gameObject.GetComponent<MailBox>().mailColor)==(int)(truckColor))
            {
                gameManager.ChangeScore(1);
            }
            else
            {
                Debug.Log("Wrong Mail");
            }
            Destroy(other.gameObject);
        }
    }
}
