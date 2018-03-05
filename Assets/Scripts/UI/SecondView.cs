using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UIToolkit.UI;
public class SecondView : UIView {
 
	public UIList list;

	List<long> data = new List<long> ();

	public override void ViewWillAppear (UIView sourceView = null) {
		base.ViewWillAppear (sourceView);

		//sv_rt.sizeDelta = new Vector3(Screen.width * 2, sv_rt.rect.height);

		//DO NOT MODIFY THE DATA
		//cell data
		for (int i = 0; i < 1000; i++)
			data.Add (i * 100000000L);

		list.Populate (new ArrayList (data));

		GameObject content_go = GameObject.Find("Content");
		content_rt = content_go.GetComponentInChildren<RectTransform>();

		StartCoroutine(Populate());
	}

	RectTransform content_rt;

	private IEnumerator Populate ()
	{

		bool workdone = false;
		int next_populate = 0;


		while (!workdone) {
			list.PopulateNext (data [next_populate]);
			next_populate++;

			content_rt.sizeDelta = new Vector3(content_rt.rect.width, (272.6f * next_populate));

			yield return null;

			if (next_populate >= data.Count) {
				workdone = true;
			}
		}




	}
		
}