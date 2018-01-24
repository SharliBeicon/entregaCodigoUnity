using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;

public class ManageScore : MonoBehaviour {

    public linfoBVsVirus fail;
    private bool q = false, w = false, e = false,
        r = false, t = false, y = false, u = false, i = false;

    public AlergVsAntialerg pvp1;
    public HongoVsFago pvp2;
    public VirusVsCell pvp3, cura;
    public LinfoTVsParas pvp4;
    public BactVsAntibio pvp5;
    public Text textScore;
    public int score = 0;

    public Button final;

    // Update is called once per frame
    void Update() {
        if (fail.success && !q)
        {
            score -= 1;
            q = true;
        }
        if (pvp1.success && !i)
        {
            score += 1;
            i = true;
        }
        if (pvp2.success && !w) {
            score += 1;
            w = true;
        }
        if (pvp3.success1 && !e)
        {
            score += 1;
            e = true;
        }
        if (cura.cura && !r)
        {
            score += 1;
            r = true;
        }
        if (pvp4.success && !t)
        {
            score += 1;
            t = true;
        }
        if (pvp5.success && !y)
        {
            score += 1;
            y = true;
        }

        textScore.text = "Puntuacion: " + score + "/6";
	}
}
