using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slicegame_text : MonoBehaviour
{
	public GameObject Carrot;

	public GameObject Carrot1;
	public GameObject Carrot2;
	public GameObject Carrot3;
	public GameObject Carrot4;
	public GameObject Carrot5;
	public GameObject Carrot6;
	public GameObject Carrot7;
	public GameObject Carrot8;

	public GameObject Banana;

	public GameObject Banana1;
	public GameObject Banana2;
	public GameObject Banana3;
	public GameObject Banana4;
/*	public GameObject Banana5;
	public GameObject Banana6;
	public GameObject Banana7;
	public GameObject Banana8;*/

	public GameObject first_text_carrot;
	public GameObject first_text_banana;
	public GameObject middle_text_carrot;
	public GameObject middle_text_banana;
	public GameObject last_text;

	public GameObject Slicegame_GamePart;
	public GameObject Slicegame_FinalPart;

	public GameObject btn;
	public GameObject bowl_in_carrot;

	bool carrot1, carrot2, carrot3, carrot4, carrot5, carrot6, carrot7, carrot8;
	bool banana1, banana2, banana3, banana4;
	// int banana5, banana6, banana7, banana8;

	// Start is called before the first frame update
	void Start()
	{
		first_text_carrot.SetActive(true);
		middle_text_carrot.SetActive(false);
		middle_text_banana.SetActive(false);
		last_text.SetActive(false);
		Carrot.SetActive(true);
		Banana.SetActive(false);
		btn.SetActive(false);
	}

	void gotoFinal()
	{
		Slicegame_GamePart.SetActive(false);
		Slicegame_FinalPart.SetActive(true);
	}

	// Update is called once per frame
	void Update()
	{
		carrot1 = Carrot1.GetComponent<istriggered_carrot1>().carrot1;
		carrot2 = Carrot2.GetComponent<istriggered_carrot2>().carrot2;
		carrot3 = Carrot3.GetComponent<istriggered_carrot3>().carrot3;
		carrot4 = Carrot4.GetComponent<istriggered_carrot4>().carrot4;
		carrot5 = Carrot5.GetComponent<istriggered_carrot5>().carrot5;
		carrot6 = Carrot6.GetComponent<istriggered_carrot6>().carrot6;
		carrot7 = Carrot7.GetComponent<istriggered_carrot7>().carrot7;
		carrot8 = Carrot8.GetComponent<istriggered_carrot8>().carrot8;

		banana1 = Banana1.GetComponent<istriggered_banana1>().banana1;
		banana2 = Banana2.GetComponent<istriggered_banana3>().banana3;
		banana3 = Banana3.GetComponent<istriggered_banana5>().banana5;
		banana4 = Banana4.GetComponent<istriggered_banana8>().banana8;
/*		banana5 = Banana5.GetComponent<istriggered_banana5>().banana5;
		banana6 = Banana6.GetComponent<istriggered_banana6>().banana6;
		banana7 = Banana7.GetComponent<istriggered_banana7>().banana7;
		banana8 = Banana8.GetComponent<istriggered_banana8>().banana8;*/

		// 당근 자르기
		if (carrot1 == true || carrot2 == true || carrot3 == true || carrot4 == true ||
			carrot5 == true || carrot6 == true || carrot7 == true || carrot8 == true)
		{
			// 다 잘랐다면(if all cut)
			if (carrot2 == true && carrot3 == true && carrot4 == true &&
			   carrot5 == true && carrot6 == true && carrot7 == true)
			{
				first_text_carrot.SetActive(false);
				middle_text_carrot.SetActive(false);
				last_text.SetActive(true);
				btn.SetActive(true);
			}
			// 아직 덜 잘랐다면(if not all cut)
			else
			{
				first_text_carrot.SetActive(false);
				middle_text_carrot.SetActive(true);
				last_text.SetActive(false);
				btn.SetActive(false);
			}
		}

		// 바나나 자르기
		if (bowl_in_carrot.activeSelf == true)
		{
			last_text.SetActive(false);
			first_text_banana.SetActive(true);

			btn.SetActive(false);
			Carrot.SetActive(false);
			Banana.SetActive(true);

/*			if (banana1 > 0)
			{
				banana_cnt++;
			}

			if (banana2 > 0)
			{
				banana_cnt++;
			}

			if (banana3 > 0)
			{
				banana_cnt++;
			}

			if (banana4 > 0)
			{
				banana_cnt++;
			}

			if (banana5 > 0)
			{
				banana_cnt++;
			}

			if (banana6 > 0)
			{
				banana_cnt++;
			}

			if (banana7 > 0)
			{
				banana_cnt++;
			}

			if (banana8 > 0)
			{
				banana_cnt++;
			}*/

			//if (banana1 > 0 || banana2 > 0 || banana3 > 0 || banana4 > 0 )  // || banana5 > 0 || banana6 > 0 || banana7 > 0 || banana8 > 0)
			if(banana1 == true || banana2 == true || banana3 == true || banana4 == true)
			{
				// 다 잘랐다면(if all cut)
				// if (banana_cnt > 3)
				if(banana4 == true && banana3 == true && banana2 == true)
				{
					first_text_banana.SetActive(false);
					middle_text_banana.SetActive(false);
					last_text.SetActive(true);
					Invoke("gotoFinal", 2);
				}
				// 아직 덜 잘랐다면(if not all cut)
				else
				{
					first_text_banana.SetActive(false);
					middle_text_banana.SetActive(true);
					last_text.SetActive(false);
				}
			}
		}
	}
}