using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class scorescript : MonoBehaviour
{
    public int Score = 0;
    public TMP_Text scoreHud;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore()
    {
        Score++;
        Debug.Log($"the score is {Score}");
        scoreHud.text = $"bolders hit: {Score}";
    }
}
