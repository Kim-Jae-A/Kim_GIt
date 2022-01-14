using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    GameObject hpGauge;
    int playerhp = 3;
    GameObject score;
    int sco = 0;  // 점수 기록용
    int sco1 = 0; //힐팩 소환 카운트
    int sco2 = 0; //무기 업글 소환 카운트
    public GameObject hpPackPrefeb;
    public GameObject weaponPrefab;
    public AudioClip PointSE;
    public AudioClip DamageSE;
    AudioSource aud;
    GameObject timerText;
    float time = 60.0f;

    void Start()
    {
        this.aud = GetComponent<AudioSource>();
        this.hpGauge = GameObject.Find("hpGauge");
        this.score = GameObject.Find("score");
        this.timerText = GameObject.Find("Time");
    }

    // Update is called once per frame
    void Update()
    {
        this.time -= Time.deltaTime;
        if (sco1 >= 30)
        {
            int px = Random.Range(-7, 7);
            int py = Random.Range(-10, 6);
            GameObject go = Instantiate(hpPackPrefeb) as GameObject;
            go.transform.position = new Vector3(px, py, 0);
            sco1 -= 50;
        }
        
        if(sco2 >= 20)
        {
            int px = Random.Range(-7, 7);
            int py = Random.Range(-10, 6);
            GameObject go = Instantiate(weaponPrefab) as GameObject;
            go.transform.position = new Vector3(px, py, 0);
            sco2 -= 35;
        }
        this.timerText.GetComponent<Text>().text = this.time.ToString("F1");
        if(this.time <= 0)
        {
            this.time = 0;
            SceneManager.LoadScene("ClearScene");
        }
    }

    public void DecreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.34f;
        playerhp -= 1;
        this.aud.PlayOneShot(this.DamageSE);
        GameObject director = GameObject.Find("player");
        director.GetComponent<PlayerController>().WeaponDown();

        if (playerhp == 0)
        {
            SceneManager.LoadScene("GameOver");
        } 
    }

    public void HealHp()
    {
        if (playerhp < 3)
        {
            this.hpGauge.GetComponent<Image>().fillAmount += 0.34f;
            playerhp += 1;
        }
    }

    public void PlusScore()
    {
        this.aud.PlayOneShot(this.PointSE);
        sco += 1;
        sco1 += 1;
        sco2 += 1;
        this.score.GetComponent<Text>().text = sco + "점";
    }
    public void WriteScore()
    {
        this.score.GetComponent<Text>().text = sco + "점";
    }
}
