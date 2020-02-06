using UnityEngine;
using System.Collections;

public class CubeRaining : MonoBehaviour {
	public float MakeCubespeed=5f,RainTime=5f , RestTime=5f;
	public GameObject Rainobj;
	float Timer1=0f, Timer2=0f , Timer3=0f;
    public string Type;
	public float zRange=10f ,xRange=10f;
	float zRand , xRand;
	Vector3 vec1 , vec2;
	/*یک کلمه می گیرد که جهت بارش ابجکت مورد نظر را مشخص می کند
	*برای تعیین محل ابجکت که تولید می شود یکی از مولفه های ان ثابت است
	*و دو تای دیگر رندم هستند که رنج انها قابل تنظیم است*/
	void Update () 
	{
		if (Type == "Above")
		{
			vec1 = Vector3.right;
			vec2 = Vector3.forward;
		}

		if (Type == "Right")
		{
			vec1 = Vector3.up;
			vec2 = Vector3.forward;

		}

		if (Type == "Forward")
		{
			vec1 = Vector3.right;
			vec2 = Vector3.up;
		}

		Timer2 += Time.deltaTime;
		Timer1 += Time.deltaTime;
		if (Timer1 >= MakeCubespeed && Timer2 <=RainTime) 
		{
			//متخصات ابجکتی که کد به ان نسبت داده شده شده با دو عدد رندم جمع می شود 
			xRand = Random.Range (-xRange, xRange);
			zRand = Random.Range (-zRange, zRange);
			Instantiate (Rainobj, transform.position + (vec1 * xRand) + (Vector3.forward * zRand), transform.rotation);
			Timer1 = 0f;

		}
		if(Timer2 >=RainTime)
		{   
			Timer3+=Time.deltaTime;
			if (Timer3 >= RestTime) 
			{
				Timer2 = 0f;
				Timer3 = 0f;
			}

		}

	}

			


}
