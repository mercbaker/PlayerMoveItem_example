using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour {

    private static T instance;

    public static T Instance {
        get {
            T obj = FindObjectOfType<T>();

            if (instance == null) {
                instance = obj;
            } else if (instance != obj) {
                Destroy(obj);
            }
            obj.transform.SetParent(null);
            DontDestroyOnLoad(obj);
            return instance;
        }
    }
}
