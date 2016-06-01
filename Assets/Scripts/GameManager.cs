using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    public GameObject mailBox;
    public Text scoreText;
    public int currentScore = 0;
    public int spawnSpeed = 1; //Seconds
    public GameObject[] mailsToPickup = { null, null, null, null };

    private float[] spawnPoints = { 2.17f, 0.74f, -0.69f, -2.12f};
    private float spawnY;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        //Not to destroy when reloading scene
        //DontDestroyOnLoad(gameObject);
    }

	void Start ()
    {
        StartCoroutine(SpawnMail());
	}
	
	void Update ()
    {
	
	}

    IEnumerator SpawnMail()
    {
        yield return new WaitForSeconds(spawnSpeed);

        spawnY = spawnPoints[Random.Range(0,4)];
        Vector2 spawnPosition = new Vector2(-6.82f, spawnY);
        Instantiate(mailBox, spawnPosition, Quaternion.identity);
        StartCoroutine(SpawnMail());
    }

    public void ChangeScore(int scoreChange)
    {
        currentScore += scoreChange;
        scoreText.text = "Score: " + currentScore;
    }
}
