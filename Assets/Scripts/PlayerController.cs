using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public GameManager gameManager;

    private float[] yPositions = { -2.322f, -0.886f, 0.55f, 1.986f };
    private int positionIndex = 1;
    private GameObject caughtMail = null;
    private MailBox caughtMailBoxScript;
    private bool emptyHands = true;
	
	void Start ()
    {
	
	}
	
	void Update ()
    {
        MovePlayer();

        //Pickup and Throw Mails
        if (Input.GetKeyDown(KeyCode.Space) && (gameManager.mailsToPickup[positionIndex] != null || !emptyHands))
        {

            if (emptyHands)
            {
                caughtMail = gameManager.mailsToPickup[positionIndex];
                caughtMail.transform.parent = transform;
                caughtMailBoxScript = caughtMail.GetComponent<MailBox>();
                caughtMailBoxScript.Pickup();
                emptyHands = false;
            }
            else
            {
                caughtMailBoxScript.Throw();
                emptyHands = true;
            }
        }
        
        if(caughtMail != null)
        {
            //p+0.196
        }
	}

    void MovePlayer()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (positionIndex < 3)
                positionIndex++;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (positionIndex > 0)
                positionIndex--;
        }

        transform.position = new Vector2(1.83f, yPositions[positionIndex]);
    }
}
