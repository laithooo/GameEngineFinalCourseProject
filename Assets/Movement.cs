using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public interface ICommand
{
    void Execute(GameObject player);
}

public class MoveCommand : ICommand
{
    private Vector3 direction;
    private float speed;

    public MoveCommand(Vector3 direction, float speed)
    {
        this.direction = direction;
        this.speed = speed;
    }

    public void Execute (GameObject player)
    {
        player.transform.Translate(direction * speed * Time.deltaTime);
    }
}

public class RotateCommand : ICommand
{
    private float rotationCamera;
    public RotateCommand(float rotationCamera)
    {
        this.rotationCamera = rotationCamera;
    }



    public void Execute(GameObject player)
    {
        Vector3 rotate = new Vector3(0, rotationCamera, 0);
        player.transform.Rotate(0, rotationCamera,0);
    }

}

public class InputRemapper
{

    private Dictionary<string, string> inputMap = new Dictionary<string, string>()
    {
        {"MoveX", "Horizontal"},
        {"MoveZ", "Vertical" },
        {"RotateCamera", "Mouse X" }
    };

    public string GetMappedInput(string action)
    {

        if(inputMap.TryGetValue(action, out string axis))
        {
            return axis;
        }

        return action;
    }

    public void Remap(string action, string newInput)
    {
        if (inputMap.ContainsKey(action))
        {
            inputMap[action] = newInput;    
        }
    }

}




public class Movement : MonoBehaviour
{
    
    [SerializeField] float speed = 5f;
    [SerializeField] float rotationX = 5f;
    [SerializeField] private Animator animator;
    
    private InputRemapper inputRemapper;
    private ICommand moveCommand;
    private ICommand rotateCommand;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        TimeManager.Instance.SetTime(120f); 
        TimeManager.Instance.StartTimer();
        inputRemapper = new InputRemapper();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis(inputRemapper.GetMappedInput("MoveX"));
        float vertical = Input.GetAxis(inputRemapper.GetMappedInput("MoveZ"));
        float rotateX = Input.GetAxis(inputRemapper.GetMappedInput("RotateCamera")) * rotationX;

        Vector3 moving = new Vector3 (horizontal,0,vertical);
        moveCommand = new MoveCommand(moving,speed);
        moveCommand.Execute(this.gameObject);


        if (vertical != 0)
        {
            animator.SetBool("isMoving", true);

        }

     
        else
        {
            animator.SetBool("isMoving", false);
        }

        rotateCommand = new RotateCommand(rotateX);
        rotateCommand.Execute(this.gameObject);





    }
}
