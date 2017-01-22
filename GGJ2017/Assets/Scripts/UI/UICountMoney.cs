using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICountMoney : MonoBehaviour {

	private int totalMoney;
	private int countingMoney = 0;
	public bool isCounting = false;
	private Text moneyNb;

	void Start () {
		moneyNb = gameObject.GetComponent<Text>();
		moneyNb.text = "0";
	}
	
	void Update () {
		if (isCounting)
		{
			StartCoroutine("CountMoney");
			isCounting = false;
		}
	}

	IEnumerator CountMoney()
	{
		while (countingMoney < totalMoney)
		{
			yield return new WaitForSeconds(0.1f);
			countingMoney++;
			moneyNb.text = countingMoney.ToString();
		}
	}

	public void setTotalMoney()
	{
		totalMoney = PlayerPrefs.GetInt("Money");
	}
}
