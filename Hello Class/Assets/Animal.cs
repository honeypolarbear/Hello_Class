using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{// 동물에 대한 변수
    public string name;
    public string sound;

    // 울음소리를 재생하는 메서드
    public void PlaySound()
    {
        Debug.Log(name + ":" + sound);
    }
    // Start is called before the first frame update
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
