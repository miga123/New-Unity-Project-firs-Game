using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour {

    public int score = 0;
    public string coinTagString;
    public string badCoinTagString;
	public GameObject menu;
	public playermover myMover;
	public Rigidbody myBody;

	public Text scoreText;
	public Text resultText;
	public string winText;
	public string loseText;

	int targetScore;

	void Start()
	{
		targetScore = GameObject.FindGameObjectsWithTag(coinTagString).Length;
		menu.SetActive (false);
	}

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Colision " + col.gameObject.name);
    }

    void OnTriggerEnter(Collider other)
    {
		if (other.tag == coinTagString)
        {
            score = score + 1;
        }
		else if(other.tag == badCoinTagString)
        {
			GameOver(false);    
        }  

        Debug.Log("Triggered" + score + " " + other.gameObject.name);

		if (targetScore == score) 
		{
			GameOver (true);
		}

        scoreText.text = "Score:" + score;
        Destroy(other.gameObject);
    }

	void GameOver(bool didwin)
	{
		menu.SetActive (true);
		myMover.enabled = false;
		myBody.isKinematic = true;

		if (didwin) 
		{
			resultText.text = winText;
		}
		else 
		{
			resultText.text = loseText;
		}

	}
}
