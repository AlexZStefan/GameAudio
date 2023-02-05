using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class FModEvents : MonoBehaviour
{
    [field: Header("Actions SFX")]
    [field: SerializeField] public EventReference test { get; private set; }

    public static FModEvents instance;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null) instance = this;
    }   
}
