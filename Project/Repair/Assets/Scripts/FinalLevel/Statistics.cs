using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statistics : MonoBehaviour
{
    public hud stats;

    private void Start()
    {
        stats.money = Random.Range(10, 100);
        stats.stress = 0;
        stats.social = 0;
        stats.life = Random.Range(70, 100);


        RaiseMoneyCollectionEvent.collectMoney += Money;
        RaiseExerciseEvent.doExercise  += Exercise;
        RaiseSocializeEvent.socialize  += Socialise;
    }

    private void Update()
    {
        stats.money -= Time.deltaTime * .01f;
        stats.stress += Time.deltaTime * .01f;
        stats.life -= Time.deltaTime * .01f;
    }

    public void Money()
    {
        stats.money+=Time.deltaTime;
        stats.stress+=Time.deltaTime;
        stats.social -= Time.deltaTime;
    }

    public void Exercise()
    {
        stats.money -= Time.deltaTime;
        stats.stress -= Time.deltaTime;
        stats.life += Time.deltaTime;
    }

    public void Socialise()
    {
        stats.money -= Time.deltaTime;
        stats.social += Time.deltaTime;
        stats.stress -= Time.deltaTime;
    }
}

[System.Serializable]
public struct hud
{
    public float money;
    public float stress;
    public float life;
    public float social;
}