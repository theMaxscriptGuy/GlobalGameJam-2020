using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statistics : MonoBehaviour
{
    public hud stats;

    public GameObject moneyGO;
    public GameObject lifelineGO;
    public GameObject socialGO;
    public GameObject stressGO;

    private Material moneyGOMat;
    private Material lifelineGOMat;
    private Material socialGOMat;
    private Material stressGOMat;

    private void Start()
    {
        stats.money = Random.Range(10, 100);
        stats.stress = 0;
        stats.social = 0;
        stats.life = Random.Range(70, 100);

        moneyGOMat = moneyGO.GetComponent<Renderer>().material;
        lifelineGOMat = lifelineGO.GetComponent<Renderer>().material;
        socialGOMat = socialGO.GetComponent<Renderer>().material;
        stressGOMat = stressGO.GetComponent<Renderer>().material;


        RaiseMoneyCollectionEvent.collectMoney += Money;
        RaiseExerciseEvent.doExercise  += Exercise;
        RaiseSocializeEvent.socialize  += Socialise;
    }

    private void UpdateIcons()
    {
        moneyGOMat.SetFloat("_FillAmount", (stats.money)/100f);
        lifelineGOMat.SetFloat("_FillAmount", (stats.life) / 100f);
        stressGOMat.SetFloat("_FillAmount", (stats.stress) / 100f);
        socialGOMat.SetFloat("_FillAmount", (stats.social) / 100f);
        
    }

    private void Update()
    {
        stats.money -= Time.deltaTime;
        stats.stress += Time.deltaTime;
        stats.life -= Time.deltaTime * .01f;

        UpdateIcons();
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