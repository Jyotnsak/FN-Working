using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Click : MonoBehaviour
{
    private int level;
    public ParticleSystem Explode;
    public ParticleSystem ParticleSystem;
    
    void Start()
    {
        Explode.Stop();
        ParticleSystem.Stop();
        level = SceneManager.GetActiveScene().buildIndex - 1;
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                if (hit.collider.tag == "normal")
                {
                    Score.add_score(level-1, 1);
                    Destroy(hit.transform.gameObject);
                }
                else if (hit.collider.tag == "special")
                {
                    switch (level)
                    {
                        case 1:
                            Score.add_score(0, 10);
                            break;
                        case 2:
                            Score.add_score(1, 20);
                            break;
                        case 3:
                            Score.add_score(2, 30);
                            break;
                    }


                    //if (level == 1)
                    //{
                    //    Score.add_score(10);
                    //}
                    //if (level == 2)
                    //{
                    //    Score.add_score(15);
                    //}
                    //if (level == 3)
                    //{
                    //    Score.add_score(20);
                    //}
                    ParticleSystem.transform.position = hit.transform.position;
                    print("EXPLOSYiUN!!!" + ParticleSystem.transform.position);
                    ParticleSystem.Play();
                    Destroy(hit.transform.gameObject);
                }else if(hit.collider.tag == "evil")
                {
                    switch (level)
                    {
                        case 1:
                            Score.add_score(0, -1);
                            break;
                        case 2:
                            Score.add_score(1, -5);
                            break;
                        case 3:
                            SceneManager.LoadScene("End Scene");
                            break;
                    }
                    Explode.transform.position = hit.transform.position;
                    Explode.Play();
                    Destroy(hit.transform.gameObject);
                   

                }
                
            }
        }
    }
}
