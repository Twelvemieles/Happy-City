﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour {

    public GameObject player;

	void Update () {
        transform.position = new Vector3(transform.position.x, player.transform.position.y, player.transform.position.z);
		
	}
}
