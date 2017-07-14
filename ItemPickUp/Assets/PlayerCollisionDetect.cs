using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionDetect : MonoBehaviour {


    private void OnTriggerEnter(Collider col) {
        //Add loot to PlayerInventory
        if (col.gameObject.tag == "item") {
            GetComponent<PlayerInventory>().AddPlayerLoot(col.gameObject);
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "chest") {
            GetComponent<PlayerInventory>().StoreTheItem();
        }
    }

}
