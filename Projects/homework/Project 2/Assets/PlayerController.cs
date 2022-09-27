using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public enum AnimationDirection
//{
//    Front,
//    Right,
//    Left,
//    Back
//}

public class PlayerController : MonoBehaviour
{
    public float speed;

    public Animator playerAnimator;
    public string _currentState;
    //private AnimationDirection _playerDirection;

    #region Animation Clips
    public string face_front;
    public string face_left;
    public string face_right;
    public string face_back;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentpos = transform.position;

        if(Input.GetKey("right"))
        {
            currentpos.x += speed;
            ChangeAnimationState(face_right);
            playerAnimator.SetBool("movingRight", true);
            playerAnimator.SetBool("movingLeft", false);
            playerAnimator.SetBool("movingUp", false);
            playerAnimator.SetBool("movingDown", false);
        }

        else if (Input.GetKey("left"))
        {
            currentpos.x -= speed;
            ChangeAnimationState(face_left);
            playerAnimator.SetBool("movingLeft", true);
            playerAnimator.SetBool("movingRight", false);
            playerAnimator.SetBool("movingUp", false);
            playerAnimator.SetBool("movingDown", false);
        }

        else if (Input.GetKey("up"))
        {
            currentpos.y += speed;
            ChangeAnimationState(face_back);
            playerAnimator.SetBool("movingUp", true);
            playerAnimator.SetBool("movingLeft", false);
            playerAnimator.SetBool("movingRight", false);
            playerAnimator.SetBool("movingDown", false);
        }

        else if (Input.GetKey("down"))
        {
            currentpos.y -= speed;
            ChangeAnimationState(face_front);
            playerAnimator.SetBool("movingDown", true);
            playerAnimator.SetBool("movingLeft", false);
            playerAnimator.SetBool("movingUp", false);
            playerAnimator.SetBool("movingRight", false);
        }

        transform.position = currentpos;
    }

    void ChangeAnimationState(string newState)
    {
        if (_currentState == newState)
            return;

    //    playerAnimator.Play(newState);

        _currentState = newState;
    }
}
