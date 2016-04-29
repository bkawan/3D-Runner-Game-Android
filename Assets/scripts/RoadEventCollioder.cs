using UnityEngine;
using System.Collections;

public class RoadEventCollioder : MonoBehaviour {


	void OnTriggerEnter(Collider other){
		if (other.tag != "Player")
			return;
		RoadManager.instance.AddRoad (1);
		RoadManager.instance.RemoveRoad ();
	}

}
