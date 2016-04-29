using UnityEngine;
using System.Collections;

public class RoadManager : MonoBehaviour {
	[SerializeField]
	Transform roadPool;

	[SerializeField]
	Transform roadLayer;

	[SerializeField]
	Transform roadPositioner;

	public static RoadManager instance;
	// Use this for initialization
	void Start () {
		AddRoad (2);

		instance = this;
	
	}

	public void AddRoad(int n){
		for (int i =0; i<n; i++) {
			Transform road = roadPool.GetChild (0);

			road.SetParent (roadLayer);
				road.position = roadPositioner.position;

			roadPositioner.position = road.FindChild ("positioner").position;
		}
	}

	public void RemoveRoad(){
		Transform road = roadLayer.GetChild (0);
		road.SetParent (roadPool);
		road.position = roadPositioner.position;
	}
	// Update is called once per frame
	void Update () {
	
	}
}
