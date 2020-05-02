using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerState
{
    walk,
    attack,
    interact,
    stagger,
    idle
}

public class PlayerMovement : MonoBehaviour
{
    public PlayerState currentState;
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;
    Vector3 change;
    public FloatValue currentHealth;
    public Signals playerHealthSignal;
    public AudioSource walkSound;
    public GameObject restartButton, gameOverText;

    void Start(){
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        walkSound = GetComponent<AudioSource>();
        restartButton.SetActive(false);
        gameOverText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        // animator.SetFloat("Horizontal", change.x);
        // animator.SetFloat("Vertical", change.y);
        // animator.SetFloat("Speed", change.sqrMagnitude);

        if(Input.GetButtonDown("attack") && currentState != PlayerState.attack){
            StartCoroutine(AttackCo());
        }
        else if(currentState == PlayerState.walk){
            UpdateAnimationAndMove();
        }
       

    }

    private IEnumerator AttackCo(){
        animator.SetBool("Attacking", true);
        currentState = PlayerState.attack;
        yield return null;
        animator.SetBool("Attacking", false);
        yield return new WaitForSeconds(.1f);
        currentState = PlayerState.walk;
    }

    void UpdateAnimationAndMove(){
         if(change != Vector3.zero){
            MoveCharacter();
            PlayWalkSound();
            animator.SetFloat("Horizontal", change.x);
            animator.SetFloat("Vertical", change.y);
            animator.SetBool("moving", true);
        }
        else{
            animator.SetBool("moving", false);
        }

    }

    void MoveCharacter(){

        rb.MovePosition(transform.position + change * moveSpeed * Time.fixedDeltaTime);
        
    }

    void PlayWalkSound()
    {
        if (!walkSound.isPlaying)
            walkSound.Play();        
    }

    public void Knock(float knockTime, float damage)
	{
        currentHealth.RunTimeValue -=damage;
        playerHealthSignal.Raise(); //add audio in raise
        if(currentHealth.RunTimeValue > 0){

          StartCoroutine(KnockCo(knockTime));
        }else{
            gameOverText.SetActive(true);
            restartButton.SetActive(true);
            this.gameObject.SetActive(false);
        }
	}

    private IEnumerator KnockCo(float knockTime)
    {
        if (rb != null)
        {
            yield return new WaitForSeconds(knockTime);
           rb.velocity = Vector3.zero;
           currentState = PlayerState.idle;
           rb.velocity = Vector3.zero;
        }
    }
}
