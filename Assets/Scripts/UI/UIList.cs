using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class UIList : MonoBehaviour {


	public GameObject cellPrototype;
	public GameObject loadingCell;
	public List<GameObject> cells = new List<GameObject>();



	public virtual void Awake() {
		Clear();
	}

	GameObject cellCopy;

	public void Populate(ArrayList info, bool extendList = false) {

		if (extendList == false) {
			Clear();
		}

		/*
		for (int i=0; i<info.Count; i++) {
			cellCopy = Instantiate(cellPrototype) as GameObject;
			cells.Add(cellCopy);
			cellCopy.transform.SetParent(this.transform);
			cellCopy.transform.localScale = Vector3.one;
			cellCopy.gameObject.SetActive(true);

			//if loading cell exist set sibling indext to just before it
			if (loadingCell != null) {
				cellCopy.transform.SetSiblingIndex(loadingCell.transform.GetSiblingIndex());
			}

			IListCell cell = cellCopy.GetComponent(typeof(IListCell)) as IListCell;
			cell.Init(info[i]);
		}
		*/
	}

	public void PopulateNext(object o){
		cellCopy = Instantiate(cellPrototype) as GameObject;
		cells.Add(cellCopy);
		cellCopy.transform.SetParent(this.transform);
		cellCopy.transform.localScale = Vector3.one;
		cellCopy.gameObject.SetActive(true);

		//if loading cell exist set sibling indext to just before it
		if (loadingCell != null) {
			cellCopy.transform.SetSiblingIndex(loadingCell.transform.GetSiblingIndex());
		}

		IListCell cell = cellCopy.GetComponent(typeof(IListCell)) as IListCell;
		cell.Init(o);
	}


	public void Clear() {
		foreach (GameObject cell in cells) Destroy(cell);
		cells = new List<GameObject>();
		cellPrototype.gameObject.SetActive(false);
	}


	public void SetLoadingCellVisibility (bool isVisible) {
		loadingCell.SetActive(isVisible);
	}


}
