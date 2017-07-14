using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : Singleton<ItemSpawner> {
    [SerializeField]
    GameObject trash_item;
    [SerializeField]
    GameObject rare_item;
    [SerializeField]
    GameObject epic_item;
    [SerializeField]
    Transform playerPos;

	// Use this for initialization
	void Start () {
        for(int i = 0; i< 30; i++) {
            SpawnItems();
        }
	}
	
    private void SpawnItems() {
        //determine rarity
        int rGen = Random.Range(0, 101);

        GameObject obj;
        //Assign rarity to item
        if (rGen <= 10) {
            obj = Instantiate(epic_item);
            obj.GetComponent<Loot>().theloot = "Epic";
        }else if(rGen>10 && rGen<= 30) {
            obj = Instantiate(rare_item);
            obj.GetComponent<Loot>().theloot = "Rare";
        } else {
            obj = Instantiate(trash_item);
            obj.GetComponent<Loot>().theloot = "Trash";
        }
       //spawn in random location
        obj.transform.position = new Vector3(Random.Range(-20,20), 5, Random.Range(-20, 20));
    }

}
