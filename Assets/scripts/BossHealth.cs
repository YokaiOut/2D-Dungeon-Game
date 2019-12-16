using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BossHealth : MonoBehaviour
{
    public float Health;//holds the health
    public float Colour;//holds the color
    public float MaxHealth;// holds the max health 
    public GameObject Boss;//this holds the gameobject
    public GameObject[] objects;// this holds the enemies
    public float spawnTime;// this holds the time they can be spawned in
    public Text WinText;// this holds the win text


    private SpriteRenderer Sprite;//this holds the sprite thats etting changed
    private Vector2 spawnPosition;//this holds the position for the spawnposition

    void Start()
    {
        spawnTime = 5f;// this sets the spawn time
        Health = MaxHealth;// this sets the health
        Sprite = GetComponent<SpriteRenderer>();//this gets the sprite renderer
        InvokeRepeating("attackPlayer", spawnTime, spawnTime);//this repeats the spawner
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Arrow"))// if it matches this tag do something
            {
                Health = Health - 50;//this takes 50 health away from the object
                other.gameObject.SetActive(false);//destroy other gameobject
                Boss.transform.position = Random.insideUnitCircle * 50;//this moves the object in a circle thats 50 pixels big
                Sprite.color = new Color(1, 0, 0, 1);//this changes the colour of the sprite
                attackPlayer();//this calls the function
            }

            if (other.gameObject.CompareTag("Arrow2"))// if it matches this tag do something
        {
                Health = Health - 50;//this takes 50 health away from the object
                other.gameObject.SetActive(false);//destroy other gameobject
                Boss.transform.position = Random.insideUnitCircle * 50;//this moves the object in a circle thats 50 pixels big
                Sprite.color = new Color(1, 0, 0, 1);//this changes the colour of the sprite
                attackPlayer();//this calls the function
            }
        
            if (Health == 0)// if it matches this tag do something
        {
                Destroy(gameObject);//destroy this gameobject
        }

    }

    void attackPlayer()
    {
     

        if (Health == 500)//if health = 500 do something
        {
            spawnTime = 5f;//this sets the spawn time 
            spawnPosition.x = Random.Range(-10, 10);//gets a random number between 10 and -10
            spawnPosition.y = Random.Range(-10, 10);//gets a random number between 10 and -10
            Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], spawnPosition, Quaternion.identity);//this spawns the object, in the correct position
            Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], spawnPosition, Quaternion.identity);//this spawns the object, in the correct position
        }

        else
        {
            if (Health == 450)//if health = 450 do something
            {
                spawnTime = 5f;//this sets the spawn time 
                spawnPosition.x = Random.Range(-10, 10);//gets a random number between 10 and -10
                spawnPosition.y = Random.Range(-10, 10);//gets a random number between 10 and -10
                Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], spawnPosition, Quaternion.identity);//this spawns the object, in the correct position
                Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], spawnPosition, Quaternion.identity);//this spawns the object, in the correct position
                Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], spawnPosition, Quaternion.identity);
            }
            else
            {
                if (Health == 400)//if health = 400 do something
                {
                    spawnTime = 5f;//this sets the spawn time 
                    spawnPosition.x = Random.Range(-10, 10);//gets a random number between 10 and -10
                    spawnPosition.y = Random.Range(-10, 10);//gets a random number between 10 and -10
                    Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], spawnPosition, Quaternion.identity);//this spawns the object, in the correct position
                    Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], spawnPosition, Quaternion.identity);//this spawns the object, in the correct position
                    Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], spawnPosition, Quaternion.identity);
                    Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], spawnPosition, Quaternion.identity);
                }
                else
                {
                    if (Health == 350)//if health = 350 do something
                    {
                        spawnTime = 5f;//this sets the spawn time 
                        spawnPosition.x = Random.Range(-10, 10);//gets a random number between 10 and -10
                        spawnPosition.y = Random.Range(-10, 10);//gets a random number between 10 and -10
                        Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], spawnPosition, Quaternion.identity);//this spawns the object, in the correct position
                        Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], spawnPosition, Quaternion.identity);//this spawns the object, in the correct position
                        Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], spawnPosition, Quaternion.identity);
                        Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], spawnPosition, Quaternion.identity);
                        Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], spawnPosition, Quaternion.identity);
                    }
                    else
                    {
                        if (Health == 300)//if health = 300 do something
                        {
                            spawnTime = 5f;//this sets the spawn time 
                            spawnPosition.x = Random.Range(-10, 10);//gets a random number between 10 and -10
                            spawnPosition.y = Random.Range(-10, 10);//gets a random number between 10 and -10
                            Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], spawnPosition, Quaternion.identity);//this spawns the object, in the correct position
                            Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], spawnPosition, Quaternion.identity);//this spawns the object, in the correct position
                            Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], spawnPosition, Quaternion.identity);
                        }
                        else
                        {
                            if (Health == 250)//if health = 250 do something
                            {
                                spawnTime = 5f;//this sets the spawn time 
                                spawnPosition.x = Random.Range(-10, 10);//gets a random number between 10 and -10
                                spawnPosition.y = Random.Range(-10, 10);//gets a random number between 10 and -10
                                Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], spawnPosition, Quaternion.identity);//this spawns the object, in the correct position
                                Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], spawnPosition, Quaternion.identity);//this spawns the object, in the correct position
                                Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], spawnPosition, Quaternion.identity);//this spawns the object, in the correct position
                            }
                            else
                            {
                                if (Health == 200)//if health = 200 do something
                                {
                                    spawnTime = 5f;//this sets the spawn time 
                                    spawnPosition.x = Random.Range(-10, 10);//gets a random number between 10 and -10
                                    spawnPosition.y = Random.Range(-10, 10);//gets a random number between 10 and -10
                                    Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], spawnPosition, Quaternion.identity);//this spawns the object, in the correct position
                                    Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], spawnPosition, Quaternion.identity);//this spawns the object, in the correct position
                                    Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], spawnPosition, Quaternion.identity);//this spawns the object, in the correct position

                                }
                                else
                                {
                                    if (Health == 150)//if health = 150 do something
                                    {
                                        spawnTime = 5f;//this sets the spawn time 
                                        spawnPosition.x = Random.Range(-10, 10);//gets a random number between 10 and -10
                                        spawnPosition.y = Random.Range(-10, 10);//gets a random number between 10 and -10
                                        Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], spawnPosition, Quaternion.identity);//this spawns the object, in the correct position
                                        Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], spawnPosition, Quaternion.identity);//this spawns the object, in the correct position
                                        Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], spawnPosition, Quaternion.identity);//this spawns the object, in the correct position

                                    }
                                    else
                                    {
                                        if (Health == 100)//if health = 100 do something
                                        {

                                            spawnTime = 4f;//this sets the spawn time 
                                            spawnPosition.x = Random.Range(-10, 10);//gets a random number between 10 and -10
                                            spawnPosition.y = Random.Range(-10, 10);//gets a random number between 10 and -10
                                            Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], spawnPosition, Quaternion.identity);//this spawns the object, in the correct position
                                            Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], spawnPosition, Quaternion.identity);//this spawns the object, in the correct position
                                            Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], spawnPosition, Quaternion.identity);//this spawns the object, in the correct position
                                        }
                                        else
                                        {
                                            if (Health == 50)//if health = 50 do something
                                            {
                                                spawnTime = 2f;//this sets the spawn time 
                                                spawnPosition.x = Random.Range(-10, 10);//gets a random number between 10 and -10
                                                spawnPosition.y = Random.Range(-10, 10);//gets a random number between 10 and -10
                                                Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], spawnPosition, Quaternion.identity);//this spawns the object, in the correct position
                                                Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], spawnPosition, Quaternion.identity);//this spawns the object, in the correct position
                                                Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], spawnPosition, Quaternion.identity);//this spawns the object, in the correct position

                                            }
                                            else
                                            {
                                                if (Health == 0)//if health equals 0 do something
                                                {
                                                    Destroy(Boss);//destroy the object in Boss

                                                    GameObject[] Red = GameObject.FindGameObjectsWithTag("GhostRed");//gets any object with Ghost red and puts them in an array
                                                    foreach (GameObject GhostRed in Red)//destroy anything with the tag GhostRed in the array 
                                                    GameObject.Destroy(GhostRed);//destroy object

                                                    GameObject[] Blue = GameObject.FindGameObjectsWithTag("GhostBlue");//gets any object with Ghost blue and puts them in an array
                                                    foreach (GameObject GhostBlue in Blue)//destroy anything with the tag Ghostblue in the array 
                                                    GameObject.Destroy(GhostBlue);//destroy object

                                                    GameObject[] Black = GameObject.FindGameObjectsWithTag("GhostBlack");//gets any object with Ghost black and puts them in an array
                                                    foreach (GameObject GhostBlack in Black)//destroy anything with the tag Ghostblack in the array 
                                                    GameObject.Destroy(GhostBlack);//destroy object

                                                    WinText.text = "You Win!";//changes the win text to 'You win!'
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
 }



