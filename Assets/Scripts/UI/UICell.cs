using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICell : MonoBehaviour, IListCell {

	public Text text;


	//private int number;


	public void Init(object data) {
		//number = (int)(long)data;
		text.text = ((long)data).ToString();
	}

	//void Update() {
		//text.text = number.ToString();
	//}
}
