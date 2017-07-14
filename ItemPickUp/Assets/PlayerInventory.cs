using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : Singleton<PlayerInventory> {

    public List<GameObject> playerLoot;

    // Use this for initialization
    void Start() {
        playerLoot = new List<GameObject>();
    }

    public void AddPlayerLoot(GameObject item) {
        //Show to log what item the player got
        string theItemName = item.GetComponent<Loot>().theloot;
        Debug.Log("I got a " + theItemName + " item.");
        playerLoot.Add(item);
    }

    public void StoreTheItem() {
        foreach (GameObject theItem in playerLoot) {
            StorePlayerItem.Instance.StoreItem(theItem);
        }
        playerLoot.Clear();
        StorePlayerItem.Instance.DeclareItems();
    }

}
