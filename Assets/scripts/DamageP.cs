using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DamageP : MonoBehaviour
{
    
    public RectTransform HealthBar;//this is where the image of the healthbar will be placed 
    public int MaxHealth;//this is variable max health of the player 
    public int MinHealth;//this is the variable health of the player
    public Text HealthText;//this holds the text on the UI
    public Text GameOverText;//this holds the 
    public AudioClip Death;//this holds the audio clip for the players death

    public Image Visual;//this is where the heathbar will be placed so that it can chane colour 
    private int CurrentHealth; //this is variable that holds the players current health 
    private Animator animator; //this is used so that the programme knows to call the animator 

    AudioSource sound;//this is used so that the game knows that it needs to play the sound 

    private int currentHealth
    {
        get { return CurrentHealth; }//this gets the current health 
        set
        {
            CurrentHealth = value;//this says it equals a number
            HandleHealth();//this calls a function
        }
    } 


    void Start()
    {
        animator = GetComponent<Animator>();    //Get a component reference to the Player's animator component
        CurrentHealth = MaxHealth; //this sets the current health of the player to be the maxhealth 
        sound = GetComponent<AudioSource>(); // this gets the component referenced 
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("GhostBlue"))//this only happens if the condition is met 
        {
            currentHealth -= 20; // this takes 20 away from the current health 
            other.gameObject.SetActive(false); // this destroys the game object  
            animator.SetTrigger("PlayerHit");//this calls an animation

        }
        if (other.gameObject.CompareTag("GhostBlack"))//this only happens if the condition is met
        {
            currentHealth -= 30;// this takes 30 away from the current health
            other.gameObject.SetActive(false);// this destroys the game object 
            animator.SetTrigger("PlayerHit");//this calls an animation

        }
        if (other.gameObject.CompareTag("GhostRed"))//this only happens if the condition is met
        {
            currentHealth -= 10;//this takes away 10 from the current health 
            other.gameObject.SetActive(false);// this destroys the game object 
            animator.SetTrigger("PlayerHit");//this calls an animation

        }

        if (other.gameObject.CompareTag("Potion"))//this only happens if the condition is met
        {
               currentHealth = 100;//this sets the current health back to 100
            other.gameObject.SetActive(false);// this destroys the game object 
        }

        if (other.gameObject.CompareTag("Poison"))//this only happens if the condition is met
        {
            currentHealth -= 25;//this takes 25 away from the player 
            other.gameObject.SetActive(false);// this destroys the game object 
            animator.SetTrigger("PlayerHit");//this calls an animation
        }

        if (currentHealth <= 0)//this only happens if the condition is met
        {
           
            animator.SetTrigger("PlayerDeath");//this calls an animation
            GetComponent<PlayerM>().enabled = false;//this gets the component and makes it unable to run 
            GameOverText.text = "Game Over!";//this changes the ameover text from blank to 'gameover'
            sound.PlayOneShot(Death, 1f);// this plays a sound 

            currentHealth = MinHealth; // this makes sure that the current health cant go below 0
         

        }
    }

    private float MapValues(float x, float inMin, float inMax, float outMin, float outMax)
    {
        return (x - inMin) * (outMax - outMin) / (inMax - inMin) + outMax;
    }


    private void HandleHealth()
    {
        HealthText.text = "Health: " + CurrentHealth;//this makes the text say what the current health is

        if (CurrentHealth > MaxHealth/2)//this only happens when current health is above 50%
        {
            Visual.color = new Color32((byte)MapValues(CurrentHealth, MaxHealth / 2, MaxHealth, 255, 0), 255, 0, 255);//this chanes the colour of the health bar 
        }
        if (CurrentHealth < MaxHealth / 2)//this only happens when the current health is below 50%
        {
            Visual.color = new Color32(255, (byte)MapValues(CurrentHealth, 0, MaxHealth / 2, 0, 255), 0, 255);//this chanes the colour of the health bar 
        }
    }
}

