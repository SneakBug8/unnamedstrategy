using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Questions : MonoBehaviour {

	public static Questions Global;
	public Question[] list = new Question[30];

	public void Awake() {
		Global=this;
	}
	public void Init () {
			list[1] = new Question()
{
	changes = new Relations(-15,-10,0,+15)
};

	list[2] = new Question()
{
	changes = new Relations(-10,+10,15,-15)
};

list[3] = new Question() 
{
	changes = new Relations(0,+10,-10,+15)
};

list[4] = new Question() 
{
	changes = new Relations(+15,-15,0,-10)
};

list[5] = new Question() 
{
	changes = new Relations(-15,0,-10,+15)
};

list[6] = new Question() 
{
	changes = new Relations(+10,-10,-15,+15)
};

list[7] = new Question() 
{
	changes = new Relations(-15,-10,+15,0)
};

list[8] = new Question() 
{
	changes = new Relations(+15,+10,-15,0)
};

list[9] = new Question() 
{
	changes = new Relations(+15,-15,+15,-10)
};

list[10] = new Question() 
{
	changes = new Relations(-15,+15,+10,0)
};

list[11] = new Question() 
{
	changes = new Relations(0,-15,+15,-10)
};

list[12] = new Question() 
{
	changes = new Relations(-10,+10,-15,+10)
};

list[13] = new Question() 
{
	changes = new Relations(+15,-15,0,-10)
};

list[14] = new Question() 
{
	changes = new Relations(-15,+15,-15,0)
};

list[15] = new Question() 
{
	changes = new Relations(+15,-15,0,-10)
};

list[16] = new Question() 
{
	changes = new Relations(-15,+15,+10,-10)
};

list[17] = new Question() 
{
	changes = new Relations(+15,-15,0,+10)
};

list[18] = new Question() 
{
	changes = new Relations(-15,-15,+10,-10)
};

list[19] = new Question() 
{
	changes = new Relations(-15,+15,0,+10)
};

list[20] = new Question() 
{
	changes = new Relations(-15,+15,-10,0)
};

list[21] = new Question() 
{
	changes = new Relations(-15,+15,0,0)
};

list[22] = new Question() 
{
	changes = new Relations(+15,+15,-10,-10)
};

list[23] = new Question() 
{
	changes = new Relations(+15,+10,0,-15)
};

list[24] = new Question() 
{
	changes = new Relations(-10,-15,0,+10)
};

list[25] = new Question() 
{
	changes = new Relations(0,-10,+15,-15)
};

list[26] = new Question() 
{
	changes = new Relations(-15,+15,0,-10)
};

list[27] = new Question() 
{
	changes = new Relations(+15,-15,-10,+10)
};

list[28] = new Question() 
{
	changes = new Relations(-15,+15,0,+10)
};

list[29] = new Question() 
{
	changes = new Relations(+15,-10,+10,-10)
};
	}
}
