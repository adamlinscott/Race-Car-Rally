using UnityEngine;
using System.Collections;

public class DoNotDestroyScript : MonoBehaviour
{
	public static DoNotDestroyScript Instance;

	void Awake()
       {
             if(Instance)
                 DestroyImmediate(gameObject);
             else
             {
                 DontDestroyOnLoad(gameObject);
                 Instance = this;
             }
       }
}
