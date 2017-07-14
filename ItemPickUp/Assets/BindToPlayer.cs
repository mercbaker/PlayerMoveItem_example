using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BindToPlayer : MonoBehaviour {
    [SerializeField]
    GameObject player;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        Vector3 bindPos = new Vector3(player.transform.position.x, player.transform.position.y + 30, player.transform.position.z - 60);
        transform.position = bindPos;

    }
}
