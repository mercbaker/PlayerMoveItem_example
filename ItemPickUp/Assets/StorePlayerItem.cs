using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorePlayerItem : Singleton<StorePlayerItem> {

    public List<GameObject> playerStorage;

    // Use this for initialization
    void Start() {
        playerStorage = new List<GameObject>();
    }

    public void StoreItem(GameObject item) {
        playerStorage.Add(item);

    }
    public void DeclareItems() {
        Debug.Log("You stored away " + playerStorage.Count + " items.");
    }

}
